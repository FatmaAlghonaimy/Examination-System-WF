namespace Examination_System.Presentation.StudentForms
{
    partial class frmStudentExamsHistoryUc
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            buttonBack = new CustomControls.CustomButton();
            customPanel1 = new CustomControls.CustomPanel();
            dgvExamsHistory = new DataGridView();
            buttonRefresh = new CustomControls.CustomButton();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExamsHistory).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.DarkOrchid;
            buttonBack.BackgroundColor = Color.DarkOrchid;
            buttonBack.BorderColor = Color.Black;
            buttonBack.BorderRadius = 30;
            buttonBack.BorderSize = 0;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(26, 25);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(150, 32);
            buttonBack.TabIndex = 26;
            buttonBack.Text = "Back";
            buttonBack.TextColor = Color.White;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += button1_Click;
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dgvExamsHistory);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(26, 75);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(811, 462);
            customPanel1.TabIndex = 25;
            // 
            // dgvExamsHistory
            // 
            dgvExamsHistory.AllowUserToAddRows = false;
            dgvExamsHistory.AllowUserToDeleteRows = false;
            dgvExamsHistory.AllowUserToResizeColumns = false;
            dgvExamsHistory.AllowUserToResizeRows = false;
            dgvExamsHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvExamsHistory.BackgroundColor = Color.White;
            dgvExamsHistory.BorderStyle = BorderStyle.None;
            dgvExamsHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle7.Padding = new Padding(15);
            dataGridViewCellStyle7.SelectionBackColor = Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvExamsHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvExamsHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvExamsHistory.DefaultCellStyle = dataGridViewCellStyle8;
            dgvExamsHistory.Dock = DockStyle.Fill;
            dgvExamsHistory.EnableHeadersVisualStyles = false;
            dgvExamsHistory.Location = new Point(0, 0);
            dgvExamsHistory.Name = "dgvExamsHistory";
            dgvExamsHistory.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvExamsHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvExamsHistory.RowHeadersVisible = false;
            dgvExamsHistory.RowHeadersWidth = 25;
            dgvExamsHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExamsHistory.Size = new Size(811, 452);
            dgvExamsHistory.TabIndex = 0;
            dgvExamsHistory.CellClick += dgvExamsHistory_CellClick;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.DarkOrchid;
            buttonRefresh.BackgroundColor = Color.DarkOrchid;
            buttonRefresh.BorderColor = Color.Black;
            buttonRefresh.BorderRadius = 30;
            buttonRefresh.BorderSize = 0;
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(226, 25);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(150, 32);
            buttonRefresh.TabIndex = 27;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.TextColor = Color.White;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += frmStudentExamsHistory_Load_1;
            // 
            // frmStudentExamsHistoryUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRefresh);
            Controls.Add(buttonBack);
            Controls.Add(customPanel1);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmStudentExamsHistoryUc";
            Size = new Size(863, 562);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExamsHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomButton buttonBack;
        private CustomControls.CustomPanel customPanel1;
        private DataGridView dgvExamsHistory;
        private CustomControls.CustomButton buttonRefresh;
    }
}
