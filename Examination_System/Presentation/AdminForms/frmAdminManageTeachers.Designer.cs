namespace Examination_System.Presentation
{
    partial class frmAdminManageTeachers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmb_Cources;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //ComboBox cmb_Cources;
            dgv_Teacher = new DataGridView();
            btn_back = new Button();
            btnNew = new Button();
            btn_report = new Button();
            pnl_nav = new Panel();
            txb_SearchByName = new TextBox();
            lbl_search_name = new Label();
            txb_search_Id = new TextBox();
            lbl_Search_Id = new Label();
            cmb_Cources = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).BeginInit();
            pnl_nav.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Teacher
            // 
            dgv_Teacher.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgv_Teacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Teacher.BackgroundColor = Color.RosyBrown;
            dgv_Teacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Teacher.GridColor = Color.RosyBrown;
            dgv_Teacher.Location = new Point(-1, 234);
            dgv_Teacher.Margin = new Padding(4, 5, 4, 5);
            dgv_Teacher.Name = "dgv_Teacher";
            dgv_Teacher.RowHeadersWidth = 62;
            dgv_Teacher.Size = new Size(1328, 514);
            dgv_Teacher.TabIndex = 4;
            dgv_Teacher.CellContentClick += dgv_Teacher_CellContentClick;
            dgv_Teacher.CellDoubleClick += Teacher_Info_Report;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatStyle = FlatStyle.Popup;
            btn_back.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.Brown;
            btn_back.Location = new Point(0, 0);
            btn_back.Margin = new Padding(4, 5, 4, 5);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(663, 54);
            btn_back.TabIndex = 3;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += button1_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.ControlLightLight;
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Brown;
            btnNew.Location = new Point(660, 0);
            btnNew.Margin = new Padding(4, 5, 4, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(667, 54);
            btnNew.TabIndex = 6;
            btnNew.Text = "Create New Teacher";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btn_report
            // 
            btn_report.BackColor = Color.White;
            btn_report.Cursor = Cursors.Hand;
            btn_report.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_report.ForeColor = Color.Brown;
            btn_report.Location = new Point(878, 141);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(450, 58);
            btn_report.TabIndex = 41;
            btn_report.Text = "Report";
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
            // 
            // pnl_nav
            // 
            pnl_nav.BackColor = Color.RosyBrown;
            pnl_nav.Controls.Add(txb_SearchByName);
            pnl_nav.Controls.Add(lbl_search_name);
            pnl_nav.Controls.Add(txb_search_Id);
            pnl_nav.Controls.Add(lbl_Search_Id);
            pnl_nav.Controls.Add(btn_report);
            pnl_nav.Controls.Add(cmb_Cources);
            pnl_nav.Controls.Add(btnNew);
            pnl_nav.Controls.Add(btn_back);
            pnl_nav.ForeColor = Color.Coral;
            pnl_nav.Location = new Point(-1, 1);
            pnl_nav.Name = "pnl_nav";
            pnl_nav.Size = new Size(1328, 225);
            pnl_nav.TabIndex = 7;
            pnl_nav.Paint += pnl_nav_Paint;
            // 
            // txb_SearchByName
            // 
            txb_SearchByName.Location = new Point(442, 145);
            txb_SearchByName.Multiline = true;
            txb_SearchByName.Name = "txb_SearchByName";
            txb_SearchByName.Size = new Size(412, 54);
            txb_SearchByName.TabIndex = 45;
            txb_SearchByName.TextChanged += txb_SearchByName_TextChanged;
            txb_SearchByName.KeyPress += txb_SearchByName_KeyPress;
            txb_SearchByName.KeyUp += SearchByName;
            // 
            // lbl_search_name
            // 
            lbl_search_name.BackColor = Color.White;
            lbl_search_name.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_search_name.ForeColor = Color.Brown;
            lbl_search_name.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_search_name.Location = new Point(3, 145);
            lbl_search_name.Name = "lbl_search_name";
            lbl_search_name.Size = new Size(433, 54);
            lbl_search_name.TabIndex = 44;
            lbl_search_name.Text = "Search By Name";
            lbl_search_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_search_Id
            // 
            txb_search_Id.Location = new Point(442, 79);
            txb_search_Id.Multiline = true;
            txb_search_Id.Name = "txb_search_Id";
            txb_search_Id.Size = new Size(412, 54);
            txb_search_Id.TabIndex = 43;
            txb_search_Id.TextChanged += txb_search_Id_TextChanged;
            txb_search_Id.KeyPress += txb_search_Id_KeyPress;
            txb_search_Id.KeyUp += SearchById;
            // 
            // lbl_Search_Id
            // 
            lbl_Search_Id.BackColor = Color.White;
            lbl_Search_Id.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Search_Id.ForeColor = Color.Brown;
            lbl_Search_Id.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_Search_Id.Location = new Point(3, 79);
            lbl_Search_Id.Name = "lbl_Search_Id";
            lbl_Search_Id.Size = new Size(433, 54);
            lbl_Search_Id.TabIndex = 42;
            lbl_Search_Id.Text = "Search By ID";
            lbl_Search_Id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_Cources
            // 
            cmb_Cources.Cursor = Cursors.Hand;
            cmb_Cources.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Cources.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Cources.ForeColor = Color.Brown;
            cmb_Cources.FormattingEnabled = true;
            cmb_Cources.Location = new Point(878, 77);
            cmb_Cources.Name = "cmb_Cources";
            cmb_Cources.Size = new Size(450, 58);
            cmb_Cources.Sorted = true;
            cmb_Cources.TabIndex = 39;
            cmb_Cources.SelectedIndexChanged += cmb_Cources_SelectedIndexChanged;
            // 
            // frmAdminManageTeachers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1328, 750);
            Controls.Add(pnl_nav);
            Controls.Add(dgv_Teacher);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1350, 806);
            MinimumSize = new Size(1350, 800);
            Name = "frmAdminManageTeachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherControl";
            Load += frmAdminManageTeachers_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).EndInit();
            pnl_nav.ResumeLayout(false);
            pnl_nav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Teacher;
        private Button btn_back;
        private Button btnNew;
        private Button btn_report;
        private Panel pnl_nav;
        private TextBox txb_search_Id;
        private Label lbl_Search_Id;
        private TextBox txb_SearchByName;
        private Label lbl_search_name;
    }
}