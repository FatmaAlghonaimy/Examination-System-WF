namespace Examination_System.Presentation
{
    partial class frmAdminProfile
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
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            pic_profileImg = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            l_username = new Label();
            l_email = new Label();
            l_fullname = new Label();
            btn_editprofile = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_profileImg).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 105);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 57);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "dashboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pic_profileImg
            // 
            pic_profileImg.Location = new Point(524, 23);
            pic_profileImg.Name = "pic_profileImg";
            pic_profileImg.Size = new Size(175, 148);
            pic_profileImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_profileImg.TabIndex = 6;
            pic_profileImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(524, 205);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 7;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(524, 239);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 8;
            label2.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(524, 280);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 9;
            label3.Text = "Username: ";
            // 
            // l_username
            // 
            l_username.AutoSize = true;
            l_username.Font = new Font("Segoe UI", 12F);
            l_username.Location = new Point(612, 280);
            l_username.Name = "l_username";
            l_username.Size = new Size(52, 21);
            l_username.TabIndex = 12;
            l_username.Text = "label4";
            // 
            // l_email
            // 
            l_email.AutoSize = true;
            l_email.Font = new Font("Segoe UI", 12F);
            l_email.Location = new Point(612, 239);
            l_email.Name = "l_email";
            l_email.Size = new Size(52, 21);
            l_email.TabIndex = 11;
            l_email.Text = "label5";
            // 
            // l_fullname
            // 
            l_fullname.AutoSize = true;
            l_fullname.Font = new Font("Segoe UI", 12F);
            l_fullname.Location = new Point(612, 205);
            l_fullname.Name = "l_fullname";
            l_fullname.Size = new Size(52, 21);
            l_fullname.TabIndex = 10;
            l_fullname.Text = "label6";
            // 
            // btn_editprofile
            // 
            btn_editprofile.Location = new Point(524, 333);
            btn_editprofile.Name = "btn_editprofile";
            btn_editprofile.Size = new Size(175, 23);
            btn_editprofile.TabIndex = 13;
            btn_editprofile.Text = " Edit  Profile  ";
            btn_editprofile.UseVisualStyleBackColor = true;
            btn_editprofile.Click += btn_editprofile_Click;
            // 
            // frmAdminProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_editprofile);
            Controls.Add(l_username);
            Controls.Add(l_email);
            Controls.Add(l_fullname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pic_profileImg);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmAdminProfile";
            Text = "frmAdminProfile";
            ((System.ComponentModel.ISupportInitialize)pic_profileImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button2;
        private PictureBox pic_profileImg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label l_username;
        private Label l_email;
        private Label l_fullname;
        private Button btn_editprofile;
    }
}