namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminManageTeachersUc
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            customPanel1 = new CustomControls.CustomPanel();
            dgv_Teacher = new DataGridView();
            lbl_search_name = new Label();
            lbl_Search_Id = new Label();
            cmb_Cources = new CustomControls.CustomComboBox();
            btnNew = new CustomControls.CustomButton();
            btn_report = new CustomControls.CustomButton();
            txb_SearchByName = new TextBox();
            txb_search_Id = new TextBox();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dgv_Teacher);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(23, 117);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(813, 422);
            customPanel1.TabIndex = 17;
            // 
            // dgv_Teacher
            // 
            dgv_Teacher.AllowUserToAddRows = false;
            dgv_Teacher.AllowUserToDeleteRows = false;
            dgv_Teacher.AllowUserToResizeColumns = false;
            dgv_Teacher.AllowUserToResizeRows = false;
            dgv_Teacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_Teacher.BackgroundColor = Color.White;
            dgv_Teacher.BorderStyle = BorderStyle.None;
            dgv_Teacher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Teacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Teacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Teacher.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Teacher.Dock = DockStyle.Fill;
            dgv_Teacher.EnableHeadersVisualStyles = false;
            dgv_Teacher.Location = new Point(0, 0);
            dgv_Teacher.Name = "dgv_Teacher";
            dgv_Teacher.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Teacher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Teacher.RowHeadersVisible = false;
            dgv_Teacher.RowHeadersWidth = 25;
            dgv_Teacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Teacher.Size = new Size(813, 412);
            dgv_Teacher.TabIndex = 0;
            dgv_Teacher.CellClick += HandleEDD_Buttons_Click;
            // 
            // lbl_search_name
            // 
            lbl_search_name.BackColor = SystemColors.Control;
            lbl_search_name.Font = new Font("Segoe UI", 12F);
            lbl_search_name.ForeColor = Color.Black;
            lbl_search_name.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_search_name.Location = new Point(24, 20);
            lbl_search_name.Margin = new Padding(2, 0, 2, 0);
            lbl_search_name.Name = "lbl_search_name";
            lbl_search_name.Size = new Size(203, 32);
            lbl_search_name.TabIndex = 44;
            lbl_search_name.Text = "Search By Name";
            lbl_search_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Search_Id
            // 
            lbl_Search_Id.BackColor = SystemColors.Control;
            lbl_Search_Id.Font = new Font("Segoe UI", 12F);
            lbl_Search_Id.ForeColor = Color.Black;
            lbl_Search_Id.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_Search_Id.Location = new Point(24, 65);
            lbl_Search_Id.Margin = new Padding(2, 0, 2, 0);
            lbl_Search_Id.Name = "lbl_Search_Id";
            lbl_Search_Id.Size = new Size(203, 32);
            lbl_Search_Id.TabIndex = 42;
            lbl_Search_Id.Text = "Search By ID";
            lbl_Search_Id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_Cources
            // 
            cmb_Cources.BackColor = Color.WhiteSmoke;
            cmb_Cources.BorderColor = Color.MediumSlateBlue;
            cmb_Cources.BorderRadius = 0;
            cmb_Cources.BorderSize = 2;
            cmb_Cources.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Cources.Font = new Font("Segoe UI", 10F);
            cmb_Cources.ForeColor = Color.DimGray;
            cmb_Cources.IconColor = Color.MediumSlateBlue;
            cmb_Cources.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Cources.ListTextColor = Color.DimGray;
            cmb_Cources.Location = new Point(402, 69);
            cmb_Cources.MinimumSize = new Size(200, 30);
            cmb_Cources.Name = "cmb_Cources";
            cmb_Cources.Padding = new Padding(2);
            cmb_Cources.SelectedValue = null;
            cmb_Cources.Size = new Size(200, 30);
            cmb_Cources.TabIndex = 49;
            cmb_Cources.Texts = "";
            cmb_Cources.OnSelectedIndexChanged += cmb_Cources_SelectedIndexChanged;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.MediumSlateBlue;
            btnNew.BackgroundColor = Color.MediumSlateBlue;
            btnNew.BorderColor = Color.Black;
            btnNew.BorderRadius = 30;
            btnNew.BorderSize = 0;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(402, 22);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(200, 32);
            btnNew.TabIndex = 51;
            btnNew.Text = "Create New Teacher";
            btnNew.TextColor = Color.White;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btn_new_teacher_Click;
            // 
            // btn_report
            // 
            btn_report.BackColor = Color.MediumSlateBlue;
            btn_report.BackgroundColor = Color.MediumSlateBlue;
            btn_report.BorderColor = Color.Black;
            btn_report.BorderRadius = 30;
            btn_report.BorderSize = 0;
            btn_report.FlatAppearance.BorderSize = 0;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.ForeColor = Color.White;
            btn_report.Location = new Point(608, 22);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(200, 32);
            btn_report.TabIndex = 52;
            btn_report.Text = "Report";
            btn_report.TextColor = Color.White;
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
            // 
            // txb_SearchByName
            // 
            txb_SearchByName.Location = new Point(208, 22);
            txb_SearchByName.Multiline = true;
            txb_SearchByName.Name = "txb_SearchByName";
            txb_SearchByName.Size = new Size(188, 29);
            txb_SearchByName.TabIndex = 53;
            txb_SearchByName.TextChanged += txb_SearchByName_TextChanged;
            txb_SearchByName.KeyPress += txb_SearchByName_KeyPress;
            txb_SearchByName.KeyUp += SearchByName;
            // 
            // txb_search_Id
            // 
            txb_search_Id.Location = new Point(208, 70);
            txb_search_Id.Multiline = true;
            txb_search_Id.Name = "txb_search_Id";
            txb_search_Id.Size = new Size(188, 29);
            txb_search_Id.TabIndex = 54;
            txb_search_Id.TextChanged += txb_search_Id_TextChanged;
            txb_search_Id.KeyPress += txb_search_Id_KeyPress;
            txb_search_Id.KeyUp += SearchById;
            // 
            // frmAdminManageTeachersUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(txb_search_Id);
            Controls.Add(txb_SearchByName);
            Controls.Add(btn_report);
            Controls.Add(btnNew);
            Controls.Add(cmb_Cources);
            Controls.Add(lbl_search_name);
            Controls.Add(customPanel1);
            Controls.Add(lbl_Search_Id);
            ForeColor = Color.Black;
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminManageTeachersUc";
            Size = new Size(863, 562);
            Load += frmAdminManageTeachers_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Teacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private DataGridView dgv_Teacher;
        private Label lbl_search_name;
        private Label lbl_Search_Id;
        private CustomControls.CustomComboBox cmb_Cources;
        private Label label2;
        private CustomControls.CustomButton btnNew;
        private CustomControls.CustomButton btn_report;
        private TextBox txb_SearchByName;
        private TextBox txb_search_Id;
    }
}
