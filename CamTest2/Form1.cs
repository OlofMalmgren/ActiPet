using System;
using System.Drawing;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Video;
using MQTTnet;
using MQTTnet.Client;
using System.Threading.Tasks;
using MQTTnet.Client.Options;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Renci.SshNet;

namespace CamTest2
{
    
    public partial class Form1 : Form
    {
        MJPEGStream PiStream;
        IMqttClient mqttClient;
        SqlConnectionStringBuilder SQLbuilder = new SqlConnectionStringBuilder();
        int GlobalXpos = 90;
        int GlobalYpos = 90;
        int LaserVar = 0;
        string ControlTopic = "not selected";
        string selectedID = "";
        public Form1(string usr, string pass)
        {
            InitializeComponent();
            PiStream = new MJPEGStream(""); //Camserver IP
            PiStream.NewFrame += PiStream_NewFrame;
            PiStream.Login = usr;
            PiStream.Password = pass;
            string clientId = Guid.NewGuid().ToString();
            string mqttURI = ""; //CloudMQTT server
            string mqttUser = ""; //CloudMQTT user
            string mqttPassword = ""; //CloudMQTT PW
            int mqttPort = 11252; //CloudMQTT port
            var options = new MqttClientOptionsBuilder()
                .WithClientId(clientId)
                .WithCredentials(mqttUser, mqttPassword)
                .WithTcpServer(mqttURI, mqttPort)
                .WithCleanSession()
                .Build();
            mqttClient = new MqttFactory().CreateMqttClient();
            mqttClient.ConnectAsync(options);
            System.Threading.Thread.Sleep(500);

            SQLbuilder.DataSource = ""; //SQL server URL
            SQLbuilder.UserID = ""; // SQL username
            SQLbuilder.Password = ""; // SQL PW
            SQLbuilder.InitialCatalog = "L"; // SQL DB

            SqlConnection connection = new SqlConnection(SQLbuilder.ConnectionString);
            connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select ID, Time From Screenshots", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv1.DataSource = dtbl;
            connection.Close();


        }
        public class JsonPos
        {
            public int xpos { get; set; }
            public int ypos { get; set; }
            public int lazor { get; set; }
        }
        void PiStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            PiStream.Start();
        }

        private void Btnstop_Click(object sender, EventArgs e)
        {
            PiStream.Stop();
        }

        private void BtnScreenShot_Click(object sender, EventArgs e)
        {
            PiStream.Stop();
            string desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pictureBox1.Image.Save(desktop_path + "/1.jpeg");
            PiStream.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                btnUP.PerformClick();
            }
            if (keyData == Keys.Down)
            {
                btnDOWN.PerformClick();
            }
            if (keyData == Keys.Left)
            {
                btnLEFT.PerformClick();
            }
            if (keyData == Keys.Right)
            {
                btnRIGHT.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnMQTT_ClickAsync(object sender, EventArgs e)
        {
            GlobalXpos = 90;
            GlobalYpos = 90;
            SendJsonPos();
        }

        private void BtnUP_Click(object sender, EventArgs e)
        {
            GlobalYpos += 5;
            SendJsonPos();
        }

        private void BtnDOWN_Click(object sender, EventArgs e)
        {
            GlobalYpos -= 5;
            SendJsonPos();
        }

        private void BtnLEFT_Click(object sender, EventArgs e)
        {
            GlobalXpos -= 5;
            SendJsonPos();
        }

        private void BtnRIGHT_Click(object sender, EventArgs e)
        {
            GlobalXpos += 5;
            SendJsonPos();
        }

        private void BtnSQL_Click(object sender, EventArgs e)
        {
            PiStream.Stop();
            System.Threading.Thread.Sleep(500);
            string desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pictureBox1.Image.Save(desktop_path + "/2.jpeg");
            byte[] img_array = File.ReadAllBytes((desktop_path + "/2.jpeg"));
            SqlConnection connection = new SqlConnection(SQLbuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Screenshots(Image, Time)values(@a, @b)", connection);
            cmd.Parameters.AddWithValue("@a", img_array);
            cmd.Parameters.AddWithValue("@b", DateTime.Now);
            cmd.ExecuteNonQuery();
            connection.Close();
            File.Delete((desktop_path + "/2.jpeg"));
            PiStream.Start();
        }

        private void Dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv1.CurrentRow.Selected = true;
                selectedID = dgv1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                SqlConnection connection = new SqlConnection(SQLbuilder.ConnectionString);
                PiStream.Stop();
                using (SqlCommand cmd = new SqlCommand("select Image from Screenshots where ID='" + selectedID + "'", connection))
                {
                    connection.Open();
                    byte[] bytes = (byte[])cmd.ExecuteScalar();
                    connection.Close();
                    if (bytes != null)
                    {
                        pictureBox1.Image = Image.FromStream(new MemoryStream(bytes));
                    }
                }
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(SQLbuilder.ConnectionString);
            connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select ID, Time From Screenshots", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv1.DataSource = dtbl;
            connection.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(SQLbuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete From Screenshots where ID='" + selectedID + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnLaser_ClickAsync(object sender, EventArgs e)
        {
            if(LaserVar == 0)
            {
                LaserVar = 1;
            }
            else if(LaserVar == 1)
            {
                LaserVar = 0;
            }
            SendJsonPos();
        }

        private void BtnSSH_Click(object sender, EventArgs e)
        {
            string user = ""; //RBP user
            string pass = ""; //RBP PW
            string host = ""; //RBP IP
            using (var client = new SshClient(host, 22, user, pass))
            {
                client.Connect();
                client.RunCommand("sudo motion");
                client.Disconnect();
            }
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            if(cbb1.Text == "") //Device1
            {
                ControlTopic = "esp2/control";
            }
            else if(cbb1.Text == "") //Next device
            {
                ControlTopic = "esp1/control";
            }
        }

        private void PictureBox1_MouseClickAsync(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int xClick = e.X;
            int yClick = e.Y;

            if(yClick < 240)
            {
                int newY = 240 - yClick;
                newY = (newY/5);
                GlobalYpos += newY;
            }
            else if(yClick > 240)
            {
                int newY = yClick - 240;
                newY = (newY / 5);
                GlobalYpos -= newY;
            }
            if (xClick < 320)
            {
                int newX = 320 - xClick;
                newX = (newX / 6);
                GlobalXpos -= newX;
            }
            else if (xClick > 320)
            {
                int newX = xClick - 320;
                newX = (newX / 6);
                GlobalXpos += newX;
            }
            SendJsonPos();
        }

        private async void SendJsonPos()
        {
            if(GlobalXpos > 170)
            {
                GlobalXpos = 170;
            }
            else if(GlobalXpos < 10)
            {
                GlobalXpos = 10;
            }
            if(GlobalYpos > 150)
            {
                GlobalYpos = 150;
            }
            else if(GlobalYpos < 45)
            {
                GlobalYpos = 45;
            }
            JsonPos pos = new JsonPos
            {
                xpos = GlobalXpos,
                ypos = GlobalYpos,
                lazor = LaserVar
            };
            string json = JsonConvert.SerializeObject(pos, Formatting.Indented);
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(ControlTopic)
                .WithPayload(json)
                .WithExactlyOnceQoS()
                .WithRetainFlag()
                .Build();
            await mqttClient.PublishAsync(message);
        }
    }
}
