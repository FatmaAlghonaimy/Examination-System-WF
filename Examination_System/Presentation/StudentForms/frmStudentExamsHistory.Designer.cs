namespace Examination_System.Presentation
{
    partial class frmStudentExamsHistory
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
            dgvExamsHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvExamsHistory).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(55, 40);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 0;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvExamsHistory
            // 
            dgvExamsHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamsHistory.Location = new Point(302, 40);
            dgvExamsHistory.Margin = new Padding(5, 6, 5, 6);
            dgvExamsHistory.Name = "dgvExamsHistory";
            dgvExamsHistory.RowHeadersWidth = 72;
            dgvExamsHistory.Size = new Size(1049, 554);
            dgvExamsHistory.TabIndex = 1;
            // 
            // frmStudentExamsHistory
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(dgvExamsHistory);
            Controls.Add(button1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmStudentExamsHistory";
            Text = "frmStudentExamsHistory";
            Load += frmStudentExamsHistory_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvExamsHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvExamsHistory;
    }
}