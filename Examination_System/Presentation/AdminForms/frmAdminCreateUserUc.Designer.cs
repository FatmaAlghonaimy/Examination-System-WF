namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminCreateUserUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCreateUserUc));
            label8 = new Label();
            clb_courses = new CheckedListBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pic_userImg = new PictureBox();
            lb_title = new Label();
            tx_username = new CustomControls.CustomTextBox();
            tx_email = new CustomControls.CustomTextBox();
            tx_password = new CustomControls.CustomTextBox();
            tx_ssn = new CustomControls.CustomTextBox();
            tx_firstname = new CustomControls.CustomTextBox();
            tx_lastname = new CustomControls.CustomTextBox();
            com_gender = new CustomControls.CustomComboBox();
            btn_save = new CustomControls.CustomButton();
            btn_back = new CustomControls.CustomButton();
            customPanel1 = new CustomControls.CustomPanel();
            lb_password = new Label();
            lb_email = new Label();
            lb_lastname = new Label();
            lb_firstname = new Label();
            lb_username = new Label();
            pic_eye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_userImg).BeginInit();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_eye).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(337, 349);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 49;
            label8.Text = "Courses";
            // 
            // clb_courses
            // 
            clb_courses.BackColor = Color.FromArgb(238, 238, 238);
            clb_courses.FormattingEnabled = true;
            clb_courses.Location = new Point(393, 339);
            clb_courses.Name = "clb_courses";
            clb_courses.Size = new Size(179, 58);
            clb_courses.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(64, 349);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 47;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(322, 309);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 46;
            label6.Text = "Lastname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(64, 305);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 45;
            label5.Text = "Firstname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(344, 263);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 44;
            label4.Text = "SSN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(59, 259);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 43;
            label3.Text = "Password";
            label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(339, 221);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 42;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 222);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 41;
            label1.Text = "Username";
            // 
            // pic_userImg
            // 
            pic_userImg.BackColor = Color.Transparent;
            pic_userImg.Image = (Image)resources.GetObject("pic_userImg.Image");
            pic_userImg.Location = new Point(244, 16);
            pic_userImg.Name = "pic_userImg";
            pic_userImg.Size = new Size(179, 176);
            pic_userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_userImg.TabIndex = 31;
            pic_userImg.TabStop = false;
            pic_userImg.Click += btn_browse_Click;
            // 
            // lb_title
            // 
            lb_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_title.Location = new Point(123, 7);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(629, 35);
            lb_title.TabIndex = 51;
            lb_title.Text = "label9";
            lb_title.TextAlign = ContentAlignment.MiddleCenter;
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
            // tx_password
            // 
            tx_password.BackColor = Color.FromArgb(238, 238, 238);
            tx_password.BorderColor = Color.DarkOrchid;
            tx_password.BorderFocusColor = Color.HotPink;
            tx_password.BorderRadius = 25;
            tx_password.BorderSize = 2;
            tx_password.Font = new Font("Segoe UI", 9.5F);
            tx_password.ForeColor = Color.Black;
            tx_password.IsFocus = false;
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
            com_gender.SelectedValue = null;
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
            customPanel1.Controls.Add(clb_courses);
            customPanel1.Controls.Add(label8);
            customPanel1.Controls.Add(btn_save);
            customPanel1.Controls.Add(tx_lastname);
            customPanel1.Controls.Add(label5);
            customPanel1.Controls.Add(label6);
            customPanel1.Controls.Add(label7);
            customPanel1.Controls.Add(btn_back);
            customPanel1.Controls.Add(tx_firstname);
            customPanel1.Controls.Add(tx_username);
            customPanel1.Controls.Add(tx_ssn);
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(tx_password);
            customPanel1.Controls.Add(tx_email);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(label4);
            customPanel1.ForeColor = Color.White;
            customPanel1.GradientBottomColor = Color.FromArgb(238, 238, 238);
            customPanel1.GradientTopColor = Color.FromArgb(238, 238, 238);
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(123, 56);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(629, 468);
            customPanel1.TabIndex = 62;
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
            // frmAdminCreateUserUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customPanel1);
            Controls.Add(lb_title);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminCreateUserUc";
            Size = new Size(863, 562);
            Load += frmAdminCreateUserUc_Load;
            ((System.ComponentModel.ISupportInitialize)pic_userImg).EndInit();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_eye).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private CheckedListBox clb_courses;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pic_userImg;
        private Label lb_title;
        private CustomControls.CustomTextBox tx_username;
        private CustomControls.CustomTextBox tx_email;
        private CustomControls.CustomTextBox tx_password;
        private CustomControls.CustomTextBox tx_ssn;
        private CustomControls.CustomTextBox tx_firstname;
        private CustomControls.CustomTextBox tx_lastname;
        private CustomControls.CustomComboBox com_gender;
        private CustomControls.CustomButton btn_save;
        private CustomControls.CustomButton btn_back;
        private CustomControls.CustomPanel customPanel1;
        private PictureBox pic_eye;
        private Label lb_firstname;
        private Label lb_username;
        private Label lb_password;
        private Label lb_email;
        private Label lb_lastname;
    }
}
