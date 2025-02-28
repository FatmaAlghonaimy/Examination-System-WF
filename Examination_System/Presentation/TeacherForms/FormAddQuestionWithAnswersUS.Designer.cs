namespace Examination_System.Presentation.TeacherForms
{
    partial class FormAddQuestionWithAnswersUS
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
            button2 = new Button();
            label4 = new Label();
            cmbCourseName = new ComboBox();
            MarksUpDown = new NumericUpDown();
            AnswerPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            cmbQuestionTypes = new ComboBox();
            txtQuestionBody = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)MarksUpDown).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(152, 638);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 29;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 101);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 28;
            label4.Text = "Course Name";
            // 
            // cmbCourseName
            // 
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(95, 134);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(151, 28);
            cmbCourseName.TabIndex = 27;
            cmbCourseName.SelectedIndexChanged += cmbCourseName_SelectedIndexChanged;
            // 
            // MarksUpDown
            // 
            MarksUpDown.Location = new Point(342, 272);
            MarksUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MarksUpDown.Name = "MarksUpDown";
            MarksUpDown.Size = new Size(150, 27);
            MarksUpDown.TabIndex = 26;
            MarksUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AnswerPanel
            // 
            AnswerPanel.AutoScroll = true;
            AnswerPanel.AutoSize = true;
            AnswerPanel.Location = new Point(33, 339);
            AnswerPanel.Name = "AnswerPanel";
            AnswerPanel.Size = new Size(885, 245);
            AnswerPanel.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 237);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 24;
            label3.Text = "Marks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 102);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 23;
            label2.Text = "QuestionType";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(688, 81);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 22;
            label1.Text = "Question Body";
            // 
            // button1
            // 
            button1.Location = new Point(666, 648);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnSave_Click;
            // 
            // cmbQuestionTypes
            // 
            cmbQuestionTypes.FormattingEnabled = true;
            cmbQuestionTypes.Location = new Point(341, 135);
            cmbQuestionTypes.Name = "cmbQuestionTypes";
            cmbQuestionTypes.Size = new Size(151, 28);
            cmbQuestionTypes.TabIndex = 20;
            cmbQuestionTypes.SelectedIndexChanged += CmbQuestionTypes_SelectedIndexChanged;
            // 
            // txtQuestionBody
            // 
            txtQuestionBody.Location = new Point(621, 114);
            txtQuestionBody.Name = "txtQuestionBody";
            txtQuestionBody.Size = new Size(321, 61);
            txtQuestionBody.TabIndex = 19;
            txtQuestionBody.Text = "";
            // 
            // FormAddQuestionWithAnswersUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
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
            MaximumSize = new Size(986, 749);
            MinimumSize = new Size(986, 749);
            Name = "FormAddQuestionWithAnswersUS";
            Size = new Size(986, 749);
            ((System.ComponentModel.ISupportInitialize)MarksUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label4;
        private ComboBox cmbCourseName;
        private NumericUpDown MarksUpDown;
        private Panel AnswerPanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox cmbQuestionTypes;
        private RichTextBox txtQuestionBody;
    }
}
