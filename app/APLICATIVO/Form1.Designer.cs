namespace APLICATIVO
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
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic_Box_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Bnt_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-64, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Txt_User
            // 
            this.Txt_User.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_User.Location = new System.Drawing.Point(60, 322);
            this.Txt_User.Multiline = true;
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(223, 23);
            this.Txt_User.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Password
            // 
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password.Location = new System.Drawing.Point(60, 368);
            this.Txt_Password.Multiline = true;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(223, 23);
            this.Txt_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Pic_Box_Minimize);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 271);
            this.panel1.TabIndex = 9;
            // 
            // Pic_Box_Minimize
            // 
            this.Pic_Box_Minimize.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pic_Box_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Box_Minimize.Image")));
            this.Pic_Box_Minimize.Location = new System.Drawing.Point(288, 0);
            this.Pic_Box_Minimize.Name = "Pic_Box_Minimize";
            this.Pic_Box_Minimize.Size = new System.Drawing.Size(25, 24);
            this.Pic_Box_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Box_Minimize.TabIndex = 1;
            this.Pic_Box_Minimize.TabStop = false;
            this.Pic_Box_Minimize.Click += new System.EventHandler(this.Pic_Box_Minimize_Click);
            this.Pic_Box_Minimize.MouseLeave += new System.EventHandler(this.Pic_Box_Minimize_MouseLeave);
            this.Pic_Box_Minimize.MouseHover += new System.EventHandler(this.Pic_Box_Minimize_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(310, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // Bnt_Login
            // 
            this.Bnt_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bnt_Login.FlatAppearance.BorderSize = 0;
            this.Bnt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Login.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Bnt_Login.Location = new System.Drawing.Point(118, 434);
            this.Bnt_Login.Name = "Bnt_Login";
            this.Bnt_Login.Size = new System.Drawing.Size(97, 45);
            this.Bnt_Login.TabIndex = 10;
            this.Bnt_Login.Text = "Log In";
            this.Bnt_Login.UseVisualStyleBackColor = true;
            this.Bnt_Login.Click += new System.EventHandler(this.Bnt_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID:";
            // 
            // Txt_ID
            // 
            this.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ID.Location = new System.Drawing.Point(60, 415);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(70, 13);
            this.Txt_ID.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(335, 487);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bnt_Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic_Box_Minimize;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Bnt_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_ID;
    }
}

