namespace Examination_System.Presentation.TeacherForms
{
    partial class FormGenerateRandomExamUC
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
            panel1 = new Panel();
            label1 = new Label();
            btnContinue = new Button();
            NumTFQuestions = new NumericUpDown();
            label3 = new Label();
            NumChooseOneQuestion = new NumericUpDown();
            label2 = new Label();
            NumChooseMultipleQuestion = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumTFQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseOneQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseMultipleQuestion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnContinue);
            panel1.Controls.Add(NumTFQuestions);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NumChooseOneQuestion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NumChooseMultipleQuestion);
            panel1.Location = new Point(15, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 315);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 3;
            label1.Text = "True False Questions\r\n";
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(92, 261);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(94, 29);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // NumTFQuestions
            // 
            NumTFQuestions.Location = new Point(196, 20);
            NumTFQuestions.Name = "NumTFQuestions";
            NumTFQuestions.Size = new Size(150, 27);
            NumTFQuestions.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 198);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 5;
            label3.Text = "Choose Many Questions\r\n";
            // 
            // NumChooseOneQuestion
            // 
            NumChooseOneQuestion.Location = new Point(196, 111);
            NumChooseOneQuestion.Name = "NumChooseOneQuestion";
            NumChooseOneQuestion.Size = new Size(150, 27);
            NumChooseOneQuestion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 111);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "Choose One";
            // 
            // NumChooseMultipleQuestion
            // 
            NumChooseMultipleQuestion.Location = new Point(196, 198);
            NumChooseMultipleQuestion.Name = "NumChooseMultipleQuestion";
            NumChooseMultipleQuestion.Size = new Size(150, 27);
            NumChooseMultipleQuestion.TabIndex = 2;
            // 
            // FormGenerateRandomExamUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FormGenerateRandomExamUC";
            Size = new Size(405, 382);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumTFQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseOneQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumChooseMultipleQuestion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnContinue;
        private NumericUpDown NumTFQuestions;
        private Label label3;
        private NumericUpDown NumChooseOneQuestion;
        private Label label2;
        private NumericUpDown NumChooseMultipleQuestion;
    }
}
