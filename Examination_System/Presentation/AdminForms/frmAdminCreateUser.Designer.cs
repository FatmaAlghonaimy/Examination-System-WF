namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCreateUser));
            btn_browse = new Button();
            btn_save = new Button();
            tx_lastname = new TextBox();
            com_gender = new ComboBox();
            tx_firstname = new TextBox();
            tx_ssn = new TextBox();
            tx_password = new TextBox();
            tx_email = new TextBox();
            tx_username = new TextBox();
            pic_userImg = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            clb_courses = new CheckedListBox();
            label8 = new Label();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_userImg).BeginInit();
            SuspendLayout();
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(147, 223);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(179, 23);
            btn_browse.TabIndex = 19;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(147, 457);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(179, 23);
            btn_save.TabIndex = 18;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // tx_lastname
            // 
            tx_lastname.Location = new Point(147, 399);
            tx_lastname.Name = "tx_lastname";
            tx_lastname.Size = new Size(179, 23);
            tx_lastname.TabIndex = 17;
            // 
            // com_gender
            // 
            com_gender.FormattingEnabled = true;
            com_gender.Location = new Point(147, 428);
            com_gender.Name = "com_gender";
            com_gender.Size = new Size(179, 23);
            com_gender.TabIndex = 16;
            // 
            // tx_firstname
            // 
            tx_firstname.Location = new Point(147, 370);
            tx_firstname.Name = "tx_firstname";
            tx_firstname.Size = new Size(179, 23);
            tx_firstname.TabIndex = 15;
            // 
            // tx_ssn
            // 
            tx_ssn.Location = new Point(147, 341);
            tx_ssn.Name = "tx_ssn";
            tx_ssn.Size = new Size(179, 23);
            tx_ssn.TabIndex = 14;
            // 
            // tx_password
            // 
            tx_password.Location = new Point(147, 312);
            tx_password.Name = "tx_password";
            tx_password.PasswordChar = '*';
            tx_password.Size = new Size(179, 23);
            tx_password.TabIndex = 13;
            // 
            // tx_email
            // 
            tx_email.Location = new Point(147, 283);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(179, 23);
            tx_email.TabIndex = 12;
            // 
            // tx_username
            // 
            tx_username.Location = new Point(147, 252);
            tx_username.Name = "tx_username";
            tx_username.Size = new Size(179, 23);
            tx_username.TabIndex = 11;
            // 
            // pic_userImg
            // 
            pic_userImg.Image = (Image)resources.GetObject("pic_userImg.Image");
            pic_userImg.Location = new Point(147, 41);
            pic_userImg.Name = "pic_userImg";
            pic_userImg.Size = new Size(179, 176);
            pic_userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_userImg.TabIndex = 10;
            pic_userImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 260);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 21;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 291);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 22;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 320);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 23;
            label3.Text = "Password";
            label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 349);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 24;
            label4.Text = "SSN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 378);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 25;
            label5.Text = "Firstname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 407);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 26;
            label6.Text = "Lastname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 436);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 27;
            label7.Text = "Gender";
            // 
            // clb_courses
            // 
            clb_courses.FormattingEnabled = true;
            clb_courses.Location = new Point(21, 41);
            clb_courses.MaximumSize = new Size(120, 166);
            clb_courses.MinimumSize = new Size(120, 166);
            clb_courses.Name = "clb_courses";
            clb_courses.Size = new Size(120, 166);
            clb_courses.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 210);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 29;
            label8.Text = "Courses";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(147, 486);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(179, 23);
            btn_back.TabIndex = 30;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // frmAdminCreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 538);
            Controls.Add(btn_back);
            Controls.Add(label8);
            Controls.Add(clb_courses);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_browse);
            Controls.Add(btn_save);
            Controls.Add(tx_lastname);
            Controls.Add(com_gender);
            Controls.Add(tx_firstname);
            Controls.Add(tx_ssn);
            Controls.Add(tx_password);
            Controls.Add(tx_email);
            Controls.Add(tx_username);
            Controls.Add(pic_userImg);
            MaximizeBox = false;
            MaximumSize = new Size(354, 577);
            MinimumSize = new Size(354, 577);
            Name = "frmAdminCreateUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAdminCreateUser";
            ((System.ComponentModel.ISupportInitialize)pic_userImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_browse;
        private Button btn_save;
        private TextBox tx_lastname;
        private ComboBox com_gender;
        private TextBox tx_firstname;
        private TextBox tx_ssn;
        private TextBox tx_password;
        private TextBox tx_email;
        private TextBox tx_username;
        private PictureBox pic_userImg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckedListBox clb_courses;
        private Label label8;
        private Button btn_back;
    }
}