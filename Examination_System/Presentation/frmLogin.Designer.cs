namespace Examination_System
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_login = new CustomControls.CustomButton();
            tx_pass = new CustomControls.CustomTextBox();
            tx_username = new CustomControls.CustomTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 68, 68);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-10, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 478);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic Fixed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(64, 323);
            label1.MaximumSize = new Size(250, 100);
            label1.Name = "label1";
            label1.Size = new Size(204, 50);
            label1.TabIndex = 1;
            label1.Text = "Login to manage your account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(450, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(54, 41);
            panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(450, 270);
            panel3.Name = "panel3";
            panel3.Size = new Size(54, 41);
            panel3.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(544, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.BackgroundColor = Color.Transparent;
            btn_login.BorderColor = Color.FromArgb(219, 68, 68);
            btn_login.BorderRadius = 40;
            btn_login.BorderSize = 3;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.FromArgb(219, 68, 68);
            btn_login.Location = new Point(522, 350);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(161, 49);
            btn_login.TabIndex = 10;
            btn_login.Text = "Login";
            btn_login.TextColor = Color.FromArgb(219, 68, 68);
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_click;
            btn_login.MouseEnter += btn_login_MouseEnter;
            btn_login.MouseLeave += btn_login_MouseLeave;
            // 
            // tx_pass
            // 
            tx_pass.BackColor = Color.White;
            tx_pass.BorderColor = Color.FromArgb(219, 68, 68);
            tx_pass.BorderFocusColor = Color.HotPink;
            tx_pass.BorderRadius = 35;
            tx_pass.BorderSize = 2;
            tx_pass.Font = new Font("Segoe UI", 9.5F);
            tx_pass.ForeColor = Color.Black;
            tx_pass.IsFocus = false;
            tx_pass.IsPlaceHolder = true;
            tx_pass.Location = new Point(510, 270);
            tx_pass.Multiline = true;
            tx_pass.Name = "tx_pass";
            tx_pass.Padding = new Padding(20, 10, 12, 10);
            tx_pass.PasswordChar = true;
            tx_pass.PlaceHolderColor = Color.Black;
            tx_pass.PlaceHolderText = "Password";
            tx_pass.Size = new Size(218, 41);
            tx_pass.TabIndex = 63;
            tx_pass.UnderLine = false;
            // 
            // tx_username
            // 
            tx_username.BackColor = Color.White;
            tx_username.BorderColor = Color.FromArgb(219, 68, 68);
            tx_username.BorderFocusColor = Color.HotPink;
            tx_username.BorderRadius = 35;
            tx_username.BorderSize = 2;
            tx_username.Font = new Font("Segoe UI", 9.5F);
            tx_username.ForeColor = Color.Black;
            tx_username.IsFocus = true;
            tx_username.IsPlaceHolder = true;
            tx_username.Location = new Point(510, 196);
            tx_username.Multiline = true;
            tx_username.Name = "tx_username";
            tx_username.Padding = new Padding(20, 10, 12, 7);
            tx_username.PasswordChar = true;
            tx_username.PlaceHolderColor = Color.Black;
            tx_username.PlaceHolderText = "Username Or Email";
            tx_username.Size = new Size(218, 41);
            tx_username.TabIndex = 65;
            tx_username.UnderLine = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tx_username);
            Controls.Add(tx_pass);
            Controls.Add(btn_login);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 450);
            MinimumSize = new Size(800, 450);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        public System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private CustomControls.CustomButton btn_login;
        private CustomControls.CustomTextBox tx_pass;
        private CustomControls.CustomTextBox tx_username;
    }
}
