namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminCreateEditCourseUc
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
            lb_title = new Label();
            customPanel2 = new CustomControls.CustomPanel();
            pictureBox1 = new PictureBox();
            lb_coursegrade = new Label();
            lb_courseduration = new Label();
            lb_coursename = new Label();
            com_courseteacher = new CustomControls.CustomComboBox();
            btn_save = new CustomControls.CustomButton();
            label5 = new Label();
            label7 = new Label();
            btn_back = new CustomControls.CustomButton();
            n_coursegrade = new CustomControls.CustomTextBox();
            tx_coursename = new CustomControls.CustomTextBox();
            label9 = new Label();
            n_courseduration = new CustomControls.CustomTextBox();
            label11 = new Label();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_title
            // 
            lb_title.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_title.Location = new Point(124, 35);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(644, 40);
            lb_title.TabIndex = 1;
            lb_title.Text = "Create a new Course";
            lb_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.Transparent;
            customPanel2.BorderColor = Color.Transparent;
            customPanel2.BorderRadius = 60;
            customPanel2.BorderSize = 0;
            customPanel2.Controls.Add(pictureBox1);
            customPanel2.Controls.Add(lb_coursegrade);
            customPanel2.Controls.Add(lb_courseduration);
            customPanel2.Controls.Add(lb_coursename);
            customPanel2.Controls.Add(com_courseteacher);
            customPanel2.Controls.Add(btn_save);
            customPanel2.Controls.Add(label5);
            customPanel2.Controls.Add(label7);
            customPanel2.Controls.Add(btn_back);
            customPanel2.Controls.Add(n_coursegrade);
            customPanel2.Controls.Add(tx_coursename);
            customPanel2.Controls.Add(label9);
            customPanel2.Controls.Add(n_courseduration);
            customPanel2.Controls.Add(label11);
            customPanel2.ForeColor = Color.White;
            customPanel2.GradientBottomColor = Color.FromArgb(238, 238, 238);
            customPanel2.GradientTopColor = Color.FromArgb(238, 238, 238);
            customPanel2.GrediantAngle = 90F;
            customPanel2.Location = new Point(124, 96);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(629, 385);
            customPanel2.TabIndex = 63;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.online_education;
            pictureBox1.Location = new Point(345, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // lb_coursegrade
            // 
            lb_coursegrade.AutoSize = true;
            lb_coursegrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_coursegrade.ForeColor = Color.Red;
            lb_coursegrade.Location = new Point(30, 70);
            lb_coursegrade.Name = "lb_coursegrade";
            lb_coursegrade.Size = new Size(10, 15);
            lb_coursegrade.TabIndex = 65;
            lb_coursegrade.Text = " ";
            // 
            // lb_courseduration
            // 
            lb_courseduration.AutoSize = true;
            lb_courseduration.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_courseduration.ForeColor = Color.Red;
            lb_courseduration.Location = new Point(30, 44);
            lb_courseduration.Name = "lb_courseduration";
            lb_courseduration.Size = new Size(10, 15);
            lb_courseduration.TabIndex = 64;
            lb_courseduration.Text = " ";
            // 
            // lb_coursename
            // 
            lb_coursename.AutoSize = true;
            lb_coursename.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_coursename.ForeColor = Color.Red;
            lb_coursename.Location = new Point(30, 17);
            lb_coursename.Name = "lb_coursename";
            lb_coursename.Size = new Size(10, 15);
            lb_coursename.TabIndex = 63;
            lb_coursename.Text = " ";
            // 
            // com_courseteacher
            // 
            com_courseteacher.BackColor = Color.FromArgb(238, 238, 238);
            com_courseteacher.BorderColor = Color.DarkOrchid;
            com_courseteacher.BorderRadius = 0;
            com_courseteacher.BorderSize = 2;
            com_courseteacher.DropDownStyle = ComboBoxStyle.DropDown;
            com_courseteacher.Font = new Font("Segoe UI", 10F);
            com_courseteacher.ForeColor = Color.Black;
            com_courseteacher.IconColor = Color.DarkOrchid;
            com_courseteacher.ListBackColor = Color.FromArgb(230, 228, 245);
            com_courseteacher.ListTextColor = Color.DimGray;
            com_courseteacher.Location = new Point(117, 224);
            com_courseteacher.MinimumSize = new Size(179, 32);
            com_courseteacher.Name = "com_courseteacher";
            com_courseteacher.Padding = new Padding(2);
            com_courseteacher.SelectedValue = null;
            com_courseteacher.Size = new Size(179, 32);
            com_courseteacher.TabIndex = 59;
            com_courseteacher.Texts = "";
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
            btn_save.Location = new Point(380, 298);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(179, 29);
            btn_save.TabIndex = 60;
            btn_save.Text = "Save";
            btn_save.TextColor = Color.White;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 190);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 45;
            label5.Text = "Course Grade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(23, 234);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 47;
            label7.Text = "Course Teacher";
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
            btn_back.Location = new Point(117, 298);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(179, 29);
            btn_back.TabIndex = 61;
            btn_back.Text = "Back";
            btn_back.TextColor = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // n_coursegrade
            // 
            n_coursegrade.BackColor = Color.FromArgb(238, 238, 238);
            n_coursegrade.BorderColor = Color.DarkOrchid;
            n_coursegrade.BorderFocusColor = Color.HotPink;
            n_coursegrade.BorderRadius = 25;
            n_coursegrade.BorderSize = 2;
            n_coursegrade.Font = new Font("Segoe UI", 9.5F);
            n_coursegrade.ForeColor = Color.Black;
            n_coursegrade.IsFocus = false;
            n_coursegrade.IsPlaceHolder = true;
            n_coursegrade.Location = new Point(117, 180);
            n_coursegrade.Multiline = false;
            n_coursegrade.Name = "n_coursegrade";
            n_coursegrade.Padding = new Padding(12, 7, 12, 7);
            n_coursegrade.PasswordChar = false;
            n_coursegrade.PlaceHolderColor = Color.Black;
            n_coursegrade.PlaceHolderText = "Course Grade";
            n_coursegrade.Size = new Size(179, 32);
            n_coursegrade.TabIndex = 56;
            n_coursegrade.UnderLine = false;
            n_coursegrade._TextChanged += OnTextChanged;
            // 
            // tx_coursename
            // 
            tx_coursename.BackColor = Color.FromArgb(238, 238, 238);
            tx_coursename.BorderColor = Color.DarkOrchid;
            tx_coursename.BorderFocusColor = Color.HotPink;
            tx_coursename.BorderRadius = 25;
            tx_coursename.BorderSize = 2;
            tx_coursename.Font = new Font("Segoe UI", 9.5F);
            tx_coursename.ForeColor = Color.Black;
            tx_coursename.IsFocus = false;
            tx_coursename.IsPlaceHolder = true;
            tx_coursename.Location = new Point(117, 97);
            tx_coursename.Multiline = false;
            tx_coursename.Name = "tx_coursename";
            tx_coursename.Padding = new Padding(12, 7, 12, 7);
            tx_coursename.PasswordChar = false;
            tx_coursename.PlaceHolderColor = Color.Black;
            tx_coursename.PlaceHolderText = "Course Name";
            tx_coursename.Size = new Size(179, 32);
            tx_coursename.TabIndex = 52;
            tx_coursename.UnderLine = false;
            tx_coursename._TextChanged += OnTextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(30, 107);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 41;
            label9.Text = "Course Name";
            // 
            // n_courseduration
            // 
            n_courseduration.BackColor = Color.FromArgb(238, 238, 238);
            n_courseduration.BorderColor = Color.DarkOrchid;
            n_courseduration.BorderFocusColor = Color.HotPink;
            n_courseduration.BorderRadius = 25;
            n_courseduration.BorderSize = 2;
            n_courseduration.Font = new Font("Segoe UI", 9.5F);
            n_courseduration.ForeColor = Color.Black;
            n_courseduration.IsFocus = false;
            n_courseduration.IsPlaceHolder = true;
            n_courseduration.Location = new Point(117, 138);
            n_courseduration.Multiline = false;
            n_courseduration.Name = "n_courseduration";
            n_courseduration.Padding = new Padding(12, 7, 12, 7);
            n_courseduration.PasswordChar = false;
            n_courseduration.PlaceHolderColor = Color.Black;
            n_courseduration.PlaceHolderText = "Course Duration";
            n_courseduration.Size = new Size(179, 32);
            n_courseduration.TabIndex = 54;
            n_courseduration.UnderLine = false;
            n_courseduration._TextChanged += OnTextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(26, 144);
            label11.Name = "label11";
            label11.Size = new Size(93, 21);
            label11.TabIndex = 43;
            label11.Text = "Course Duration";
            label11.UseCompatibleTextRendering = true;
            // 
            // frmAdminCreateEditCourseUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customPanel2);
            Controls.Add(lb_title);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminCreateEditCourseUc";
            Size = new Size(863, 562);
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lb_title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CustomControls.CustomPanel customPanel1;
        private CustomControls.CustomPanel customPanel2;
        private Label lb_coursename;
        private Label lb_courseduration;
        private Label lb_coursegrade;
  
        private PictureBox pic_userImg;
        private CustomControls.CustomComboBox com_courseteacher;
        private CheckedListBox clb_courses;
        private Label label8;
        private CustomControls.CustomButton btn_save;
        private CustomControls.CustomTextBox tx_lastname;
        private Label label5;
        private Label label6;
        private Label label7;
        private CustomControls.CustomButton btn_back;
        private CustomControls.CustomTextBox n_coursegrade;
        private CustomControls.CustomTextBox tx_coursename;
        private CustomControls.CustomTextBox tx_ssn;
        private Label label9;
        private CustomControls.CustomTextBox n_courseduration;
        private CustomControls.CustomTextBox tx_email;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private Label label12;
    }
}
