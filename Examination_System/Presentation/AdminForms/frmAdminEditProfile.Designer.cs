namespace Examination_System.Presentation
{
    partial class frmAdminEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminEditProfile));
            pic_userImg = new PictureBox();
            tx_username = new TextBox();
            tx_email = new TextBox();
            tx_password = new TextBox();
            tx_ssn = new TextBox();
            tx_firstname = new TextBox();
            com_gender = new ComboBox();
            tx_lastname = new TextBox();
            btn_save = new Button();
            btn_browse = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_userImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pic_userImg
            // 
            pic_userImg.Location = new Point(78, 33);
            pic_userImg.Name = "pic_userImg";
            pic_userImg.Size = new Size(179, 176);
            pic_userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_userImg.TabIndex = 0;
            pic_userImg.TabStop = false;
            // 
            // tx_username
            // 
            tx_username.Location = new Point(78, 278);
            tx_username.Name = "tx_username";
            tx_username.PlaceholderText = "Username";
            tx_username.Size = new Size(179, 23);
            tx_username.TabIndex = 1;
            // 
            // tx_email
            // 
            tx_email.Location = new Point(78, 307);
            tx_email.Name = "tx_email";
            tx_email.PlaceholderText = "Email";
            tx_email.Size = new Size(179, 23);
            tx_email.TabIndex = 2;
            // 
            // tx_password
            // 
            tx_password.Location = new Point(78, 338);
            tx_password.Name = "tx_password";
            tx_password.PasswordChar = '*';
            tx_password.PlaceholderText = "Password";
            tx_password.Size = new Size(179, 23);
            tx_password.TabIndex = 3;
            // 
            // tx_ssn
            // 
            tx_ssn.Location = new Point(78, 367);
            tx_ssn.Name = "tx_ssn";
            tx_ssn.PlaceholderText = "SSN";
            tx_ssn.Size = new Size(179, 23);
            tx_ssn.TabIndex = 4;
            // 
            // tx_firstname
            // 
            tx_firstname.Location = new Point(78, 396);
            tx_firstname.Name = "tx_firstname";
            tx_firstname.PlaceholderText = "First Name";
            tx_firstname.Size = new Size(179, 23);
            tx_firstname.TabIndex = 5;
            // 
            // com_gender
            // 
            com_gender.FormattingEnabled = true;
            com_gender.Location = new Point(78, 453);
            com_gender.Name = "com_gender";
            com_gender.Size = new Size(179, 23);
            com_gender.TabIndex = 6;
            // 
            // tx_lastname
            // 
            tx_lastname.Location = new Point(78, 425);
            tx_lastname.Name = "tx_lastname";
            tx_lastname.PlaceholderText = "Last Name";
            tx_lastname.Size = new Size(179, 23);
            tx_lastname.TabIndex = 7;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(78, 482);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(179, 23);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(78, 249);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(179, 23);
            btn_browse.TabIndex = 9;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += browse_btn_click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(263, 338);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // frmAdminEditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 611);
            Controls.Add(pic_userImg);
            Controls.Add(pictureBox1);
            Controls.Add(btn_browse);
            Controls.Add(btn_save);
            Controls.Add(tx_lastname);
            Controls.Add(com_gender);
            Controls.Add(tx_firstname);
            Controls.Add(tx_ssn);
            Controls.Add(tx_password);
            Controls.Add(tx_email);
            Controls.Add(tx_username);
            MaximumSize = new Size(371, 650);
            MinimumSize = new Size(371, 650);
            Name = "frmAdminEditProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAdminEditProfile";
            ((System.ComponentModel.ISupportInitialize)pic_userImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_userImg;
        private TextBox tx_username;
        private TextBox tx_email;
        private TextBox tx_password;
        private TextBox tx_ssn;
        private TextBox tx_firstname;
        private ComboBox com_gender;
        private TextBox tx_lastname;
        private Button btn_save;
        private Button btn_browse;
        private PictureBox pictureBox1;
    }
}