﻿namespace Examination_System.Presentation.StudentForms
{
    partial class frmStudentHomeUc
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
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(3, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Padding = new Padding(10, 0, 0, 0);
            lblWelcome.Size = new Size(197, 69);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmStudentHomeUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_02_28_at_19_07_12_0f20639f;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(lblWelcome);
            MaximumSize = new Size(863, 562);
            MinimumSize = new Size(863, 562);
            Name = "frmStudentHomeUc";
            Size = new Size(863, 562);
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
    }
}
