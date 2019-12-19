namespace CamTest2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.btnMQTT = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnDOWN = new System.Windows.Forms.Button();
            this.btnLEFT = new System.Windows.Forms.Button();
            this.btnRIGHT = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLaser = new System.Windows.Forms.Button();
            this.btnSSH = new System.Windows.Forms.Button();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClickAsync);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnstart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnstart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnstart.Location = new System.Drawing.Point(658, 101);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 68);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start Stream";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnstop.Location = new System.Drawing.Point(741, 102);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 67);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop Stream";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.Btnstop_Click);
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnScreenShot.Location = new System.Drawing.Point(822, 101);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(75, 67);
            this.btnScreenShot.TabIndex = 3;
            this.btnScreenShot.Text = "Screenshot to desktop";
            this.btnScreenShot.UseVisualStyleBackColor = false;
            this.btnScreenShot.Click += new System.EventHandler(this.BtnScreenShot_Click);
            // 
            // btnMQTT
            // 
            this.btnMQTT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMQTT.Location = new System.Drawing.Point(822, 174);
            this.btnMQTT.Name = "btnMQTT";
            this.btnMQTT.Size = new System.Drawing.Size(75, 67);
            this.btnMQTT.TabIndex = 4;
            this.btnMQTT.Text = "Cam StartPos";
            this.btnMQTT.UseVisualStyleBackColor = false;
            this.btnMQTT.Click += new System.EventHandler(this.BtnMQTT_ClickAsync);
            // 
            // btnUP
            // 
            this.btnUP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUP.BackgroundImage")));
            this.btnUP.Location = new System.Drawing.Point(750, 279);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(66, 67);
            this.btnUP.TabIndex = 5;
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.BtnUP_Click);
            this.btnUP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnDOWN
            // 
            this.btnDOWN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDOWN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDOWN.BackgroundImage")));
            this.btnDOWN.Location = new System.Drawing.Point(750, 425);
            this.btnDOWN.Name = "btnDOWN";
            this.btnDOWN.Size = new System.Drawing.Size(66, 67);
            this.btnDOWN.TabIndex = 6;
            this.btnDOWN.UseVisualStyleBackColor = false;
            this.btnDOWN.Click += new System.EventHandler(this.BtnDOWN_Click);
            // 
            // btnLEFT
            // 
            this.btnLEFT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLEFT.Image = ((System.Drawing.Image)(resources.GetObject("btnLEFT.Image")));
            this.btnLEFT.Location = new System.Drawing.Point(678, 352);
            this.btnLEFT.Name = "btnLEFT";
            this.btnLEFT.Size = new System.Drawing.Size(66, 67);
            this.btnLEFT.TabIndex = 7;
            this.btnLEFT.UseVisualStyleBackColor = false;
            this.btnLEFT.Click += new System.EventHandler(this.BtnLEFT_Click);
            // 
            // btnRIGHT
            // 
            this.btnRIGHT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRIGHT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRIGHT.BackgroundImage")));
            this.btnRIGHT.Location = new System.Drawing.Point(822, 352);
            this.btnRIGHT.Name = "btnRIGHT";
            this.btnRIGHT.Size = new System.Drawing.Size(66, 67);
            this.btnRIGHT.TabIndex = 8;
            this.btnRIGHT.UseVisualStyleBackColor = false;
            this.btnRIGHT.Click += new System.EventHandler(this.BtnRIGHT_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSQL.Location = new System.Drawing.Point(658, 175);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(75, 67);
            this.btnSQL.TabIndex = 9;
            this.btnSQL.Text = "Screenshot to SQL";
            this.btnSQL.UseVisualStyleBackColor = false;
            this.btnSQL.Click += new System.EventHandler(this.BtnSQL_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(916, 13);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(243, 317);
            this.dgv1.TabIndex = 10;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv1_CellClick);
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.Location = new System.Drawing.Point(1019, 336);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(67, 66);
            this.btnReload.TabIndex = 11;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Location = new System.Drawing.Point(1092, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 65);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnLaser
            // 
            this.btnLaser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLaser.Location = new System.Drawing.Point(741, 175);
            this.btnLaser.Name = "btnLaser";
            this.btnLaser.Size = new System.Drawing.Size(75, 67);
            this.btnLaser.TabIndex = 13;
            this.btnLaser.Text = "LAZOR";
            this.btnLaser.UseVisualStyleBackColor = false;
            this.btnLaser.Click += new System.EventHandler(this.BtnLaser_ClickAsync);
            // 
            // btnSSH
            // 
            this.btnSSH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSSH.Location = new System.Drawing.Point(12, 498);
            this.btnSSH.Name = "btnSSH";
            this.btnSSH.Size = new System.Drawing.Size(75, 67);
            this.btnSSH.TabIndex = 14;
            this.btnSSH.Text = "Reset Cam feed";
            this.btnSSH.UseVisualStyleBackColor = false;
            this.btnSSH.Click += new System.EventHandler(this.BtnSSH_Click);
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "Loffe",
            "Gurr"});
            this.cbb1.Location = new System.Drawing.Point(657, 32);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(239, 21);
            this.cbb1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select device";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(822, 59);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 17;
            this.btnUser.Text = "Select";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 568);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.btnSSH);
            this.Controls.Add(this.btnLaser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.btnRIGHT);
            this.Controls.Add(this.btnLEFT);
            this.Controls.Add(this.btnDOWN);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnMQTT);
            this.Controls.Add(this.btnScreenShot);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnstart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button btnMQTT;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDOWN;
        private System.Windows.Forms.Button btnLEFT;
        private System.Windows.Forms.Button btnRIGHT;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLaser;
        private System.Windows.Forms.Button btnSSH;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUser;
    }
}

