namespace ExaminationSystem
{
    partial class FormAddQuestionWithAnswers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtQuestionBody = new RichTextBox();
            cmbQuestionTypes = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AnswerPanel = new Panel();
            MarksUpDown = new NumericUpDown();
            label4 = new Label();
            cmbCourseName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)MarksUpDown).BeginInit();
            SuspendLayout();
            // 
            // txtQuestionBody
            // 
            txtQuestionBody.Location = new Point(622, 59);
            txtQuestionBody.Name = "txtQuestionBody";
            txtQuestionBody.Size = new Size(321, 61);
            txtQuestionBody.TabIndex = 1;
            txtQuestionBody.Text = "";
            // 
            // cmbQuestionTypes
            // 
            cmbQuestionTypes.FormattingEnabled = true;
            cmbQuestionTypes.Location = new Point(268, 49);
            cmbQuestionTypes.Name = "cmbQuestionTypes";
            cmbQuestionTypes.Size = new Size(151, 28);
            cmbQuestionTypes.TabIndex = 3;
            cmbQuestionTypes.SelectedIndexChanged += CmbQuestionTypes_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(417, 473);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(671, 36);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 6;
            label1.Text = "Question Body";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 26);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 7;
            label2.Text = "QuestionType";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 110);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 12;
            label3.Text = "Marks";
            // 
            // AnswerPanel
            // 
            AnswerPanel.Location = new Point(235, 100);
            AnswerPanel.Name = "AnswerPanel";
            AnswerPanel.Size = new Size(360, 245);
            AnswerPanel.TabIndex = 13;
            // 
            // MarksUpDown
            // 
            MarksUpDown.Location = new Point(44, 133);
            MarksUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MarksUpDown.Name = "MarksUpDown";
            MarksUpDown.Size = new Size(150, 27);
            MarksUpDown.TabIndex = 14;
            MarksUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 26);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 17;
            label4.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(44, 49);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(151, 28);
            cmbCourseName.TabIndex = 16;
            // 
            // FormAddQuestionWithAnswers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 579);
            Controls.Add(label4);
            Controls.Add(cmbCourseName);
            Controls.Add(MarksUpDown);
            Controls.Add(AnswerPanel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cmbQuestionTypes);
            Controls.Add(txtQuestionBody);
            Name = "FormAddQuestionWithAnswers";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)MarksUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtQuestionBody;
        private ComboBox cmbQuestionTypes;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel AnswerPanel;
        private NumericUpDown MarksUpDown;
        private Label label4;
        private ComboBox cmbCourseName;
    }
}
