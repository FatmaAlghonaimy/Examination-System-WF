
namespace Examination_System.Presentation.AdminForms
{
    partial class CreateNewTheacher
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
            BTNCreateBack = new Button();
            lbl_ID = new Label();
            tbx_ID = new TextBox();
            lbl_UserName = new Label();
            txb_name = new TextBox();
            lbl_Email = new Label();
            txb_email = new TextBox();
            lbl_pass = new Label();
            txb_pass = new TextBox();
            lbl_role = new Label();
            lbl_fname = new Label();
            lbl_ssn = new Label();
            txb_ssn = new TextBox();
            txb_Fname = new TextBox();
            lbl_Lname = new Label();
            txb_Lname = new TextBox();
            pictureBox1 = new PictureBox();
            btn_Add = new Button();
            pnl_header = new Panel();
            lbl_header = new Label();
            cmb_role = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_header.SuspendLayout();
            SuspendLayout();
            // 
            // BTNCreateBack
            // 
            BTNCreateBack.BackColor = Color.White;
            BTNCreateBack.Cursor = Cursors.Hand;
            BTNCreateBack.FlatStyle = FlatStyle.Popup;
            BTNCreateBack.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNCreateBack.ForeColor = Color.Brown;
            BTNCreateBack.Location = new Point(517, 332);
            BTNCreateBack.Margin = new Padding(2, 2, 2, 2);
            BTNCreateBack.Name = "BTNCreateBack";
            BTNCreateBack.Size = new Size(196, 31);
            BTNCreateBack.TabIndex = 0;
            BTNCreateBack.Text = "Back";
            BTNCreateBack.UseVisualStyleBackColor = false;
            BTNCreateBack.Click += button1_Click;
            // 
            // lbl_ID
            // 
            lbl_ID.BackColor = Color.White;
            lbl_ID.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID.ForeColor = Color.Brown;
            lbl_ID.Location = new Point(31, 63);
            lbl_ID.Margin = new Padding(2, 0, 2, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(151, 28);
            lbl_ID.TabIndex = 1;
            lbl_ID.Text = "ID";
            lbl_ID.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ID.Click += lbl_ID_Click;
            // 
            // tbx_ID
            // 
            tbx_ID.Location = new Point(206, 63);
            tbx_ID.Margin = new Padding(2, 2, 2, 2);
            tbx_ID.Multiline = true;
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(220, 29);
            tbx_ID.TabIndex = 2;
            tbx_ID.Click += tbx_ID_Click;
            tbx_ID.TextChanged += tbx_ID_TextChanged;
            // 
            // lbl_UserName
            // 
            lbl_UserName.BackColor = Color.White;
            lbl_UserName.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UserName.ForeColor = Color.Brown;
            lbl_UserName.Location = new Point(31, 111);
            lbl_UserName.Margin = new Padding(2, 0, 2, 0);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(151, 28);
            lbl_UserName.TabIndex = 3;
            lbl_UserName.Text = "User Name";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(206, 111);
            txb_name.Margin = new Padding(2, 2, 2, 2);
            txb_name.Multiline = true;
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(220, 29);
            txb_name.TabIndex = 4;
            txb_name.TextChanged += textBox1_TextChanged;
            // 
            // lbl_Email
            // 
            lbl_Email.BackColor = Color.White;
            lbl_Email.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Email.ForeColor = Color.Brown;
            lbl_Email.Location = new Point(31, 158);
            lbl_Email.Margin = new Padding(2, 0, 2, 0);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(151, 28);
            lbl_Email.TabIndex = 5;
            lbl_Email.Text = "Email";
            lbl_Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(206, 158);
            txb_email.Margin = new Padding(2, 2, 2, 2);
            txb_email.Multiline = true;
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(220, 29);
            txb_email.TabIndex = 6;
            txb_email.TextChanged += txb_email_TextChanged;
            // 
            // lbl_pass
            // 
            lbl_pass.BackColor = Color.White;
            lbl_pass.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pass.ForeColor = Color.Brown;
            lbl_pass.Location = new Point(31, 200);
            lbl_pass.Margin = new Padding(2, 0, 2, 0);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(151, 28);
            lbl_pass.TabIndex = 7;
            lbl_pass.Text = "Password";
            lbl_pass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_pass
            // 
            txb_pass.ImeMode = ImeMode.NoControl;
            txb_pass.Location = new Point(206, 200);
            txb_pass.Margin = new Padding(2, 2, 2, 2);
            txb_pass.Multiline = true;
            txb_pass.Name = "txb_pass";
            txb_pass.Size = new Size(220, 29);
            txb_pass.TabIndex = 8;
            txb_pass.TextChanged += txb_pass_TextChanged;
            // 
            // lbl_role
            // 
            lbl_role.BackColor = Color.White;
            lbl_role.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_role.ForeColor = Color.Brown;
            lbl_role.Location = new Point(31, 241);
            lbl_role.Margin = new Padding(2, 0, 2, 0);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(151, 28);
            lbl_role.TabIndex = 9;
            lbl_role.Text = "Role";
            lbl_role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_fname
            // 
            lbl_fname.BackColor = Color.White;
            lbl_fname.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fname.ForeColor = Color.Brown;
            lbl_fname.Location = new Point(31, 326);
            lbl_fname.Margin = new Padding(2, 0, 2, 0);
            lbl_fname.Name = "lbl_fname";
            lbl_fname.Size = new Size(151, 28);
            lbl_fname.TabIndex = 11;
            lbl_fname.Text = "Frist Name";
            lbl_fname.TextAlign = ContentAlignment.MiddleCenter;
            lbl_fname.Click += lbl_fname_Click;
            // 
            // lbl_ssn
            // 
            lbl_ssn.BackColor = Color.White;
            lbl_ssn.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ssn.ForeColor = Color.Brown;
            lbl_ssn.Location = new Point(31, 283);
            lbl_ssn.Margin = new Padding(2, 0, 2, 0);
            lbl_ssn.Name = "lbl_ssn";
            lbl_ssn.Size = new Size(151, 28);
            lbl_ssn.TabIndex = 12;
            lbl_ssn.Text = "SSN";
            lbl_ssn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_ssn
            // 
            txb_ssn.ImeMode = ImeMode.NoControl;
            txb_ssn.Location = new Point(206, 283);
            txb_ssn.Margin = new Padding(2, 2, 2, 2);
            txb_ssn.Multiline = true;
            txb_ssn.Name = "txb_ssn";
            txb_ssn.Size = new Size(220, 29);
            txb_ssn.TabIndex = 13;
            txb_ssn.TextChanged += txb_ssn_TextChanged;
            // 
            // txb_Fname
            // 
            txb_Fname.ImeMode = ImeMode.NoControl;
            txb_Fname.Location = new Point(206, 326);
            txb_Fname.Margin = new Padding(2, 2, 2, 2);
            txb_Fname.Multiline = true;
            txb_Fname.Name = "txb_Fname";
            txb_Fname.Size = new Size(220, 29);
            txb_Fname.TabIndex = 14;
            txb_Fname.TextChanged += txb_Fname_TextChanged;
            // 
            // lbl_Lname
            // 
            lbl_Lname.BackColor = Color.White;
            lbl_Lname.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Lname.ForeColor = Color.Brown;
            lbl_Lname.Location = new Point(31, 368);
            lbl_Lname.Margin = new Padding(2, 0, 2, 0);
            lbl_Lname.Name = "lbl_Lname";
            lbl_Lname.Size = new Size(151, 28);
            lbl_Lname.TabIndex = 16;
            lbl_Lname.Text = "Last Name";
            lbl_Lname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_Lname
            // 
            txb_Lname.ImeMode = ImeMode.NoControl;
            txb_Lname.Location = new Point(206, 368);
            txb_Lname.Margin = new Padding(2, 2, 2, 2);
            txb_Lname.Multiline = true;
            txb_Lname.Name = "txb_Lname";
            txb_Lname.Size = new Size(220, 29);
            txb_Lname.TabIndex = 18;
            txb_Lname.TextChanged += txb_Lname_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(517, 63);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.Brown;
            btn_Add.Location = new Point(517, 289);
            btn_Add.Margin = new Padding(2, 2, 2, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(196, 31);
            btn_Add.TabIndex = 20;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            // 
            // pnl_header
            // 
            pnl_header.BackColor = Color.White;
            pnl_header.Controls.Add(lbl_header);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Font = new Font("Segoe Print", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            pnl_header.ForeColor = Color.DarkRed;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Margin = new Padding(2, 2, 2, 2);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(800, 40);
            pnl_header.TabIndex = 21;
            // 
            // lbl_header
            // 
            lbl_header.AutoSize = true;
            lbl_header.Font = new Font("Cooper Black", 14F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_header.Location = new Point(327, 11);
            lbl_header.Margin = new Padding(2, 0, 2, 0);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(137, 21);
            lbl_header.TabIndex = 0;
            lbl_header.Text = "New Teacher";
            // 
            // cmb_role
            // 
            cmb_role.Enabled = false;
            cmb_role.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_role.ForeColor = Color.Brown;
            cmb_role.FormattingEnabled = true;
            cmb_role.Location = new Point(206, 238);
            cmb_role.Margin = new Padding(2, 2, 2, 2);
            cmb_role.Name = "cmb_role";
            cmb_role.Size = new Size(220, 36);
            cmb_role.TabIndex = 22;
            cmb_role.Text = "Teacher";
            cmb_role.SelectedIndexChanged += cmb_role_SelectedIndexChanged;
            // 
            // CreateNewTheacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 415);
            Controls.Add(cmb_role);
            Controls.Add(pnl_header);
            Controls.Add(btn_Add);
            Controls.Add(pictureBox1);
            Controls.Add(txb_Lname);
            Controls.Add(lbl_Lname);
            Controls.Add(txb_Fname);
            Controls.Add(txb_ssn);
            Controls.Add(lbl_ssn);
            Controls.Add(lbl_fname);
            Controls.Add(lbl_role);
            Controls.Add(txb_pass);
            Controls.Add(lbl_pass);
            Controls.Add(txb_email);
            Controls.Add(lbl_Email);
            Controls.Add(txb_name);
            Controls.Add(lbl_UserName);
            Controls.Add(tbx_ID);
            Controls.Add(lbl_ID);
            Controls.Add(BTNCreateBack);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MaximumSize = new Size(816, 464);
            MinimumSize = new Size(816, 422);
            Name = "CreateNewTheacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewTheacher";
            TransparencyKey = Color.FromArgb(0, 0, 64);
            Load += CreateNewTheacher_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lbl_fname_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button BTNCreateBack;
        private Label lbl_ID;
        private TextBox tbx_ID;
        private Label lbl_UserName;
        private TextBox txb_name;
        private Label lbl_Email;
        private TextBox txb_email;
        private Label lbl_pass;
        private TextBox txb_pass;
        private Label lbl_role;
        private Label lbl_fname;
        private Label lbl_ssn;
        private TextBox txb_ssn;
        private TextBox txb_Fname;
        private Label lbl_Lname;
        private TextBox txb_Lname;
        private PictureBox pictureBox1;
        private Button btn_Add;
        private Panel pnl_header;
        private Label lbl_header;
        private ComboBox cmb_role;
    }
}