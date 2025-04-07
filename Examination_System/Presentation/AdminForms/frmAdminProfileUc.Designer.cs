namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminProfileUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminProfileUc));
            customPanel1 = new CustomControls.CustomPanel();
            lb_password = new Label();
            lb_email = new Label();
            lb_lastname = new Label();
            lb_firstname = new Label();
            lb_username = new Label();
            pic_eye = new PictureBox();
            pic_userImg = new PictureBox();
            com_gender = new CustomControls.CustomComboBox();
            btn_save = new CustomControls.CustomButton();
            tx_lastname = new CustomControls.CustomTextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btn_back = new CustomControls.CustomButton();
            tx_firstname = new CustomControls.CustomTextBox();
            tx_username = new CustomControls.CustomTextBox();
            tx_ssn = new CustomControls.CustomTextBox();
            label12 = new Label();
            tx_password = new CustomControls.CustomTextBox();
            tx_email = new CustomControls.CustomTextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_eye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_userImg).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Transparent;
            customPanel1.BorderColor = Color.Transparent;
            customPanel1.BorderRadius = 60;
            customPanel1.BorderSize = 0;
            customPanel1.Controls.Add(lb_password);
            customPanel1.Controls.Add(lb_email);
            customPanel1.Controls.Add(lb_lastname);
            customPanel1.Controls.Add(lb_firstname);
            customPanel1.Controls.Add(lb_username);
            customPanel1.Controls.Add(pic_eye);
            customPanel1.Controls.Add(pic_userImg);
            customPanel1.Controls.Add(com_gender);
            customPanel1.Controls.Add(btn_save);
            customPanel1.Controls.Add(tx_lastname);
            customPanel1.Controls.Add(label9);
            customPanel1.Controls.Add(label10);
            customPanel1.Controls.Add(label11);
            customPanel1.Controls.Add(btn_back);
            customPanel1.Controls.Add(tx_firstname);
            customPanel1.Controls.Add(tx_username);
            customPanel1.Controls.Add(tx_ssn);
            customPanel1.Controls.Add(label12);
            customPanel1.Controls.Add(tx_password);
            customPanel1.Controls.Add(tx_email);
            customPanel1.Controls.Add(label13);
            customPanel1.Controls.Add(label14);
            customPanel1.Controls.Add(label15);
            customPanel1.ForeColor = Color.White;
            customPanel1.GradientBottomColor = Color.FromArgb(238, 238, 238);
            customPanel1.GradientTopColor = Color.FromArgb(238, 238, 238);
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(141, 59);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(629, 468);
            customPanel1.TabIndex = 63;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_password.ForeColor = Color.Red;
            lb_password.Location = new Point(445, 157);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(10, 15);
            lb_password.TabIndex = 67;
            lb_password.Text = " ";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_email.ForeColor = Color.Red;
            lb_email.Location = new Point(445, 131);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(10, 15);
            lb_email.TabIndex = 66;
            lb_email.Text = " ";
            // 
            // lb_lastname
            // 
            lb_lastname.AutoSize = true;
            lb_lastname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_lastname.ForeColor = Color.Red;
            lb_lastname.Location = new Point(445, 101);
            lb_lastname.Name = "lb_lastname";
            lb_lastname.Size = new Size(10, 15);
            lb_lastname.TabIndex = 65;
            lb_lastname.Text = " ";
            // 
            // lb_firstname
            // 
            lb_firstname.AutoSize = true;
            lb_firstname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_firstname.ForeColor = Color.Red;
            lb_firstname.Location = new Point(445, 72);
            lb_firstname.Name = "lb_firstname";
            lb_firstname.Size = new Size(10, 15);
            lb_firstname.TabIndex = 64;
            lb_firstname.Text = " ";
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_username.ForeColor = Color.Red;
            lb_username.Location = new Point(445, 42);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(10, 15);
            lb_username.TabIndex = 63;
            lb_username.Text = " ";
            // 
            // pic_eye
            // 
            pic_eye.Cursor = Cursors.Hand;
            pic_eye.Image = Properties.Resources.show;
            pic_eye.Location = new Point(271, 257);
            pic_eye.Name = "pic_eye";
            pic_eye.Size = new Size(28, 21);
            pic_eye.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_eye.TabIndex = 62;
            pic_eye.TabStop = false;
            pic_eye.Click += pictureBox1_Click;
            // 
            // pic_userImg
            // 
            pic_userImg.BackColor = Color.Transparent;
            pic_userImg.Cursor = Cursors.Hand;
            pic_userImg.Image = (Image)resources.GetObject("pic_userImg.Image");
            pic_userImg.Location = new Point(244, 16);
            pic_userImg.Name = "pic_userImg";
            pic_userImg.Size = new Size(179, 176);
            pic_userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_userImg.TabIndex = 31;
            pic_userImg.TabStop = false;
            pic_userImg.Click += btn_browse_Click;
            // 
            // com_gender
            // 
            com_gender.BackColor = Color.FromArgb(238, 238, 238);
            com_gender.BorderColor = Color.DarkOrchid;
            com_gender.BorderRadius = 0;
            com_gender.BorderSize = 2;
            com_gender.DropDownStyle = ComboBoxStyle.DropDown;
            com_gender.Font = new Font("Segoe UI", 10F);
            com_gender.ForeColor = Color.Black;
            com_gender.IconColor = Color.DarkOrchid;
            com_gender.ListBackColor = Color.FromArgb(230, 228, 245);
            com_gender.ListTextColor = Color.DimGray;
            com_gender.Location = new Point(130, 339);
            com_gender.MinimumSize = new Size(179, 32);
            com_gender.Name = "com_gender";
            com_gender.Padding = new Padding(2);
            com_gender.Size = new Size(179, 32);
            com_gender.TabIndex = 59;
            com_gender.Texts = "";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.MediumSlateBlue;
            btn_save.BackgroundColor = Color.MediumSlateBlue;
            btn_save.BorderColor = Color.Black;
            btn_save.BorderRadius = 30;
            btn_save.BorderSize = 0;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(393, 413);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(179, 29);
            btn_save.TabIndex = 60;
            btn_save.Text = "Save";
            btn_save.TextColor = Color.White;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // tx_lastname
            // 
            tx_lastname.BackColor = Color.FromArgb(238, 238, 238);
            tx_lastname.BorderColor = Color.DarkOrchid;
            tx_lastname.BorderFocusColor = Color.HotPink;
            tx_lastname.BorderRadius = 25;
            tx_lastname.BorderSize = 2;
            tx_lastname.Font = new Font("Segoe UI", 9.5F);
            tx_lastname.ForeColor = Color.Black;
            tx_lastname.IsFocus = false;
            tx_lastname.IsPlaceHolder = true;
            tx_lastname.Location = new Point(393, 298);
            tx_lastname.Multiline = false;
            tx_lastname.Name = "tx_lastname";
            tx_lastname.Padding = new Padding(12, 7, 12, 7);
            tx_lastname.PasswordChar = false;
            tx_lastname.PlaceHolderColor = Color.Black;
            tx_lastname.PlaceHolderText = "Lastname";
            tx_lastname.Size = new Size(179, 32);
            tx_lastname.TabIndex = 57;
            tx_lastname.UnderLine = false;
            tx_lastname._TextChanged += OnTextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(64, 305);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 45;
            label9.Text = "Firstname";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(322, 309);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 46;
            label10.Text = "Lastname";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(64, 349);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 47;
            label11.Text = "Gender";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.MediumSlateBlue;
            btn_back.BackgroundColor = Color.MediumSlateBlue;
            btn_back.BorderColor = Color.Black;
            btn_back.BorderRadius = 30;
            btn_back.BorderSize = 0;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(130, 413);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(179, 29);
            btn_back.TabIndex = 61;
            btn_back.Text = "Back";
            btn_back.TextColor = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // tx_firstname
            // 
            tx_firstname.BackColor = Color.FromArgb(238, 238, 238);
            tx_firstname.BorderColor = Color.DarkOrchid;
            tx_firstname.BorderFocusColor = Color.HotPink;
            tx_firstname.BorderRadius = 25;
            tx_firstname.BorderSize = 2;
            tx_firstname.Font = new Font("Segoe UI", 9.5F);
            tx_firstname.ForeColor = Color.Black;
            tx_firstname.IsFocus = false;
            tx_firstname.IsPlaceHolder = true;
            tx_firstname.Location = new Point(130, 295);
            tx_firstname.Multiline = false;
            tx_firstname.Name = "tx_firstname";
            tx_firstname.Padding = new Padding(12, 7, 12, 7);
            tx_firstname.PasswordChar = false;
            tx_firstname.PlaceHolderColor = Color.Black;
            tx_firstname.PlaceHolderText = "Firstname";
            tx_firstname.Size = new Size(179, 32);
            tx_firstname.TabIndex = 56;
            tx_firstname.UnderLine = false;
            tx_firstname._TextChanged += OnTextChanged;
            // 
            // tx_username
            // 
            tx_username.BackColor = Color.FromArgb(238, 238, 238);
            tx_username.BorderColor = Color.DarkOrchid;
            tx_username.BorderFocusColor = Color.HotPink;
            tx_username.BorderRadius = 25;
            tx_username.BorderSize = 2;
            tx_username.Font = new Font("Segoe UI", 9.5F);
            tx_username.ForeColor = Color.Black;
            tx_username.IsFocus = false;
            tx_username.IsPlaceHolder = true;
            tx_username.Location = new Point(130, 212);
            tx_username.Multiline = false;
            tx_username.Name = "tx_username";
            tx_username.Padding = new Padding(12, 7, 12, 7);
            tx_username.PasswordChar = false;
            tx_username.PlaceHolderColor = Color.Black;
            tx_username.PlaceHolderText = "Username";
            tx_username.Size = new Size(179, 32);
            tx_username.TabIndex = 52;
            tx_username.UnderLine = false;
            tx_username._TextChanged += OnTextChanged;
            // 
            // tx_ssn
            // 
            tx_ssn.BackColor = Color.FromArgb(238, 238, 238);
            tx_ssn.BorderColor = Color.DarkOrchid;
            tx_ssn.BorderFocusColor = Color.HotPink;
            tx_ssn.BorderRadius = 25;
            tx_ssn.BorderSize = 2;
            tx_ssn.Font = new Font("Segoe UI", 9.5F);
            tx_ssn.ForeColor = Color.Black;
            tx_ssn.IsFocus = false;
            tx_ssn.IsPlaceHolder = true;
            tx_ssn.Location = new Point(393, 253);
            tx_ssn.Multiline = false;
            tx_ssn.Name = "tx_ssn";
            tx_ssn.Padding = new Padding(12, 7, 12, 7);
            tx_ssn.PasswordChar = false;
            tx_ssn.PlaceHolderColor = Color.Black;
            tx_ssn.PlaceHolderText = "SSN";
            tx_ssn.Size = new Size(179, 32);
            tx_ssn.TabIndex = 55;
            tx_ssn.UnderLine = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(55, 222);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 41;
            label12.Text = "Username";
            // 
            // tx_password
            // 
            tx_password.BackColor = Color.FromArgb(238, 238, 238);
            tx_password.BorderColor = Color.DarkOrchid;
            tx_password.BorderFocusColor = Color.HotPink;
            tx_password.BorderRadius = 25;
            tx_password.BorderSize = 2;
            tx_password.Font = new Font("Segoe UI", 9.5F);
            tx_password.ForeColor = Color.Black;
            tx_password.IsFocus = true;
            tx_password.IsPlaceHolder = true;
            tx_password.Location = new Point(130, 253);
            tx_password.Multiline = false;
            tx_password.Name = "tx_password";
            tx_password.Padding = new Padding(12, 7, 12, 7);
            tx_password.PasswordChar = true;
            tx_password.PlaceHolderColor = Color.Black;
            tx_password.PlaceHolderText = "Password";
            tx_password.Size = new Size(179, 32);
            tx_password.TabIndex = 54;
            tx_password.UnderLine = false;
            tx_password._TextChanged += OnTextChanged;
            // 
            // tx_email
            // 
            tx_email.BackColor = Color.FromArgb(238, 238, 238);
            tx_email.BorderColor = Color.DarkOrchid;
            tx_email.BorderFocusColor = Color.HotPink;
            tx_email.BorderRadius = 25;
            tx_email.BorderSize = 2;
            tx_email.Font = new Font("Segoe UI", 9.5F);
            tx_email.ForeColor = Color.Black;
            tx_email.IsFocus = false;
            tx_email.IsPlaceHolder = true;
            tx_email.Location = new Point(393, 212);
            tx_email.Multiline = false;
            tx_email.Name = "tx_email";
            tx_email.Padding = new Padding(12, 7, 12, 7);
            tx_email.PasswordChar = false;
            tx_email.PlaceHolderColor = Color.Black;
            tx_email.PlaceHolderText = "Email";
            tx_email.Size = new Size(179, 32);
            tx_email.TabIndex = 53;
            tx_email.UnderLine = false;
            tx_email._TextChanged += OnTextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(339, 221);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 42;
            label13.Text = "Email";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(59, 259);
            label14.Name = "label14";
            label14.Size = new Size(56, 21);
            label14.TabIndex = 43;
            label14.Text = "Password";
            label14.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(344, 263);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 44;
            label15.Text = "SSN";
            // 
            // frmAdminProfileUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customPanel1);
            Name = "frmAdminProfileUc";
            Size = new Size(863, 562);
            Load += frmAdminProfileUc_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_eye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_userImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private Label lb_password;
        private Label lb_email;
        private Label lb_lastname;
        private Label lb_firstname;
        private Label lb_username;
        private PictureBox pic_eye;
        private PictureBox pic_userImg;
        private CustomControls.CustomComboBox com_gender;
        private CustomControls.CustomButton btn_save;
        private CustomControls.CustomTextBox tx_lastname;
        private Label label9;
        private Label label10;
        private Label label11;
        private CustomControls.CustomButton btn_back;
        private CustomControls.CustomTextBox tx_firstname;
        private CustomControls.CustomTextBox tx_username;
        private CustomControls.CustomTextBox tx_ssn;
        private Label label12;
        private CustomControls.CustomTextBox tx_password;
        private CustomControls.CustomTextBox tx_email;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}
