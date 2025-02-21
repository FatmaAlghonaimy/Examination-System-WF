namespace Examination_System.Presentation.AdminForms
{
    partial class Teacher_Info_Report
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
            ComboBox cmb_role;
            ComboBox cmb_gender;
            txb_Lname = new TextBox();
            lbl_Lname = new Label();
            textBox2 = new TextBox();
            txb_ssn = new TextBox();
            lbl_ssn = new Label();
            lbl_fname = new Label();
            txb_pass = new TextBox();
            lbl_pass = new Label();
            txb_email = new TextBox();
            lbl_Email = new Label();
            textBox1 = new TextBox();
            lbl_UserName = new Label();
            tbx_ID = new TextBox();
            lbl_ID = new Label();
            BTNCreateBack = new Button();
            pictureBox1 = new PictureBox();
            btn_Update = new Button();
            btn_Delete = new Button();
            panel1 = new Panel();
            label1 = new Label();
            cmb_role = new ComboBox();
            cmb_gender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmb_role
            // 
            cmb_role.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_role.ForeColor = Color.Brown;
            cmb_role.FormattingEnabled = true;
            cmb_role.Location = new Point(41, 823);
            cmb_role.Name = "cmb_role";
            cmb_role.Size = new Size(563, 58);
            cmb_role.Sorted = true;
            cmb_role.TabIndex = 39;
            cmb_role.Text = "Thearer";
            // 
            // txb_Lname
            // 
            txb_Lname.ImeMode = ImeMode.NoControl;
            txb_Lname.Location = new Point(291, 741);
            txb_Lname.Multiline = true;
            txb_Lname.Name = "txb_Lname";
            txb_Lname.Size = new Size(313, 46);
            txb_Lname.TabIndex = 35;
            txb_Lname.UseWaitCursor = true;
            // 
            // lbl_Lname
            // 
            lbl_Lname.BackColor = Color.White;
            lbl_Lname.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Lname.ForeColor = Color.Brown;
            lbl_Lname.Location = new Point(41, 741);
            lbl_Lname.Name = "lbl_Lname";
            lbl_Lname.Size = new Size(216, 46);
            lbl_Lname.TabIndex = 34;
            lbl_Lname.Text = "Last Name";
            lbl_Lname.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Lname.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(291, 635);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 46);
            textBox2.TabIndex = 33;
            textBox2.UseWaitCursor = true;
            // 
            // txb_ssn
            // 
            txb_ssn.ImeMode = ImeMode.NoControl;
            txb_ssn.Location = new Point(291, 338);
            txb_ssn.Multiline = true;
            txb_ssn.Name = "txb_ssn";
            txb_ssn.Size = new Size(313, 46);
            txb_ssn.TabIndex = 32;
            txb_ssn.UseWaitCursor = true;
            // 
            // lbl_ssn
            // 
            lbl_ssn.BackColor = Color.White;
            lbl_ssn.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ssn.ForeColor = Color.Brown;
            lbl_ssn.Location = new Point(41, 338);
            lbl_ssn.Name = "lbl_ssn";
            lbl_ssn.Size = new Size(216, 46);
            lbl_ssn.TabIndex = 31;
            lbl_ssn.Text = "SSN";
            lbl_ssn.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ssn.UseWaitCursor = true;
            // 
            // lbl_fname
            // 
            lbl_fname.BackColor = Color.White;
            lbl_fname.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fname.ForeColor = Color.Brown;
            lbl_fname.Location = new Point(41, 635);
            lbl_fname.Name = "lbl_fname";
            lbl_fname.Size = new Size(216, 46);
            lbl_fname.TabIndex = 30;
            lbl_fname.Text = "Frist Name";
            lbl_fname.TextAlign = ContentAlignment.MiddleCenter;
            lbl_fname.UseWaitCursor = true;
            // 
            // txb_pass
            // 
            txb_pass.ImeMode = ImeMode.NoControl;
            txb_pass.Location = new Point(291, 537);
            txb_pass.Multiline = true;
            txb_pass.Name = "txb_pass";
            txb_pass.Size = new Size(313, 46);
            txb_pass.TabIndex = 27;
            txb_pass.UseWaitCursor = true;
            // 
            // lbl_pass
            // 
            lbl_pass.BackColor = Color.White;
            lbl_pass.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pass.ForeColor = Color.Brown;
            lbl_pass.Location = new Point(41, 537);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(216, 46);
            lbl_pass.TabIndex = 26;
            lbl_pass.Text = "Password";
            lbl_pass.TextAlign = ContentAlignment.MiddleCenter;
            lbl_pass.UseWaitCursor = true;
            lbl_pass.Click += lbl_pass_Click;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(291, 237);
            txb_email.Multiline = true;
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(313, 46);
            txb_email.TabIndex = 25;
            txb_email.UseWaitCursor = true;
            // 
            // lbl_Email
            // 
            lbl_Email.BackColor = Color.White;
            lbl_Email.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Email.ForeColor = Color.Brown;
            lbl_Email.Location = new Point(41, 237);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(216, 46);
            lbl_Email.TabIndex = 24;
            lbl_Email.Text = "Email";
            lbl_Email.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Email.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 435);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 46);
            textBox1.TabIndex = 23;
            textBox1.UseWaitCursor = true;
            // 
            // lbl_UserName
            // 
            lbl_UserName.BackColor = Color.White;
            lbl_UserName.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UserName.ForeColor = Color.Brown;
            lbl_UserName.Location = new Point(41, 435);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(216, 46);
            lbl_UserName.TabIndex = 22;
            lbl_UserName.Text = "User Name";
            lbl_UserName.UseWaitCursor = true;
            // 
            // tbx_ID
            // 
            tbx_ID.Location = new Point(291, 127);
            tbx_ID.Multiline = true;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(313, 46);
            tbx_ID.TabIndex = 21;
            tbx_ID.UseWaitCursor = true;
            // 
            // lbl_ID
            // 
            lbl_ID.BackColor = Color.White;
            lbl_ID.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID.ForeColor = Color.Brown;
            lbl_ID.Location = new Point(41, 127);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(216, 46);
            lbl_ID.TabIndex = 20;
            lbl_ID.Text = "ID";
            lbl_ID.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ID.UseWaitCursor = true;
            // 
            // BTNCreateBack
            // 
            BTNCreateBack.BackColor = Color.White;
            BTNCreateBack.Cursor = Cursors.Hand;
            BTNCreateBack.FlatStyle = FlatStyle.Popup;
            BTNCreateBack.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNCreateBack.ForeColor = Color.Brown;
            BTNCreateBack.Location = new Point(795, 914);
            BTNCreateBack.Name = "BTNCreateBack";
            BTNCreateBack.Size = new Size(333, 58);
            BTNCreateBack.TabIndex = 19;
            BTNCreateBack.Text = "Back";
            BTNCreateBack.UseVisualStyleBackColor = false;
            // 
            // cmb_gender
            // 
            cmb_gender.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_gender.ForeColor = Color.Brown;
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Location = new Point(41, 915);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(563, 58);
            cmb_gender.Sorted = true;
            cmb_gender.TabIndex = 40;
            cmb_gender.Text = "Gender";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(785, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 391);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.FlatStyle = FlatStyle.Popup;
            btn_Update.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = Color.Brown;
            btn_Update.Location = new Point(785, 635);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(333, 58);
            btn_Update.TabIndex = 42;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.White;
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.FlatStyle = FlatStyle.Popup;
            btn_Delete.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.ForeColor = Color.Brown;
            btn_Delete.Location = new Point(795, 778);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(333, 58);
            btn_Delete.TabIndex = 43;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 75);
            panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(556, 12);
            label1.Name = "label1";
            label1.Size = new Size(132, 50);
            label1.TabIndex = 0;
            label1.Text = "Teacher";
            // 
            // Teacher_Info_Report
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1250, 996);
            Controls.Add(panel1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(pictureBox1);
            Controls.Add(cmb_gender);
            Controls.Add(cmb_role);
            Controls.Add(txb_Lname);
            Controls.Add(lbl_Lname);
            Controls.Add(textBox2);
            Controls.Add(txb_ssn);
            Controls.Add(lbl_ssn);
            Controls.Add(lbl_fname);
            Controls.Add(txb_pass);
            Controls.Add(lbl_pass);
            Controls.Add(txb_email);
            Controls.Add(lbl_Email);
            Controls.Add(textBox1);
            Controls.Add(lbl_UserName);
            Controls.Add(tbx_ID);
            Controls.Add(lbl_ID);
            Controls.Add(BTNCreateBack);
            MaximizeBox = false;
            Name = "Teacher_Info_Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher_Info_Report";
            Load += Teacher_Info_Report_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_Lname;
        private Label lbl_Lname;
        private TextBox textBox2;
        private TextBox txb_ssn;
        private Label lbl_ssn;
        private Label lbl_fname;
        private TextBox txb_pass;
        private Label lbl_pass;
        private TextBox txb_email;
        private Label lbl_Email;
        private TextBox textBox1;
        private Label lbl_UserName;
        private TextBox tbx_ID;
        private Label lbl_ID;
        private Button BTNCreateBack;
        private PictureBox pictureBox1;
        private Button btn_Update;
        private Button btn_Delete;
        private Panel panel1;
        private Label label1;
    }
}