namespace CamTest2
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnsub = new System.Windows.Forms.Button();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsub
            // 
            this.btnsub.AutoSize = true;
            this.btnsub.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnsub.Location = new System.Drawing.Point(145, 151);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 3;
            this.btnsub.Text = "Submit";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.Btnsub_Click);
            // 
            // tbpass
            // 
            this.tbpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbpass.Location = new System.Drawing.Point(132, 113);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 1;
            this.tbpass.UseSystemPasswordChar = true;
            this.tbpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbpass_KeyDown);
            // 
            // tbuser
            // 
            this.tbuser.BackColor = System.Drawing.SystemColors.Window;
            this.tbuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbuser.Location = new System.Drawing.Point(132, 73);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(100, 20);
            this.tbuser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.btnsub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}