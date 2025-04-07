﻿namespace Examination_System.Presentation.AdminForms
{
    partial class frmAdminStudentCoursesUc
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
            dgv_student_courses = new DataGridView();
            btn_back = new CustomControls.CustomButton();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_student_courses).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.AutoSize = true;
            customPanel1.BackColor = Color.Black;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 30;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(dgv_student_courses);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.GrediantAngle = 90F;
            customPanel1.Location = new Point(31, 75);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(0, 0, 0, 10);
            customPanel1.Size = new Size(811, 462);
            customPanel1.TabIndex = 17;
            // 
            // dgv_student_courses
            // 
            dgv_student_courses.AllowUserToAddRows = false;
            dgv_student_courses.AllowUserToDeleteRows = false;
            dgv_student_courses.AllowUserToResizeColumns = false;
            dgv_student_courses.AllowUserToResizeRows = false;
            dgv_student_courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_student_courses.BackgroundColor = Color.White;
            dgv_student_courses.BorderStyle = BorderStyle.None;
            dgv_student_courses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.Padding = new Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_student_courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_student_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_student_courses.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_student_courses.Dock = DockStyle.Fill;
            dgv_student_courses.EnableHeadersVisualStyles = false;
            dgv_student_courses.Location = new Point(0, 0);
            dgv_student_courses.Name = "dgv_student_courses";
            dgv_student_courses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_student_courses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_student_courses.RowHeadersVisible = false;
            dgv_student_courses.RowHeadersWidth = 25;
            dgv_student_courses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_student_courses.Size = new Size(811, 452);
            dgv_student_courses.TabIndex = 0;
            dgv_student_courses.CellClick += HandleShowExams;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.DarkOrchid;
            btn_back.BackgroundColor = Color.DarkOrchid;
            btn_back.BorderColor = Color.Black;
            btn_back.BorderRadius = 30;
            btn_back.BorderSize = 0;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(31, 25);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(150, 32);
            btn_back.TabIndex = 24;
            btn_back.Text = "Back";
            btn_back.TextColor = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // frmAdminStudentCoursesUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_back);
            Controls.Add(customPanel1);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmAdminStudentCoursesUc";
            Size = new Size(863, 562);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_student_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private DataGridView dgv_student_courses;
        private CustomControls.CustomButton btn_back;
    }
}
