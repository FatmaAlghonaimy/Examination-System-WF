﻿namespace ExaminationSystem
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            button6 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox3 = new CheckedListBox();
            Title = new Label();
            label3 = new Label();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 243);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MaximumSize = new Size(1416, 292);
            dataGridView1.MinimumSize = new Size(1416, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1416, 292);
            dataGridView1.TabIndex = 13;
            // 
            // button6
            // 
            button6.Location = new Point(675, 541);
            button6.Name = "button6";
            button6.Size = new Size(116, 32);
            button6.TabIndex = 12;
            button6.Text = "back";
            button6.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 131);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(152, 172);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 15;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(34, 128);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 16;
            label1.Text = "start date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(43, 166);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 17;
            label2.Text = "end date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1093, 84);
            label5.Name = "label5";
            label5.Size = new Size(234, 25);
            label5.TabIndex = 22;
            label5.Text = "coures which have exams";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(816, 84);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 23;
            label6.Text = "Type of Exams ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(514, 84);
            label7.Name = "label7";
            label7.Size = new Size(159, 25);
            label7.TabIndex = 24;
            label7.Text = "Status Of Exams ";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pending", "Started", "Finished" });
            checkedListBox1.Location = new Point(545, 131);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(79, 40);
            checkedListBox1.TabIndex = 25;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Practice", "Final" });
            checkedListBox2.Location = new Point(849, 131);
            checkedListBox2.Margin = new Padding(3, 2, 3, 2);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(84, 22);
            checkedListBox2.TabIndex = 26;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Location = new Point(1135, 131);
            checkedListBox3.Margin = new Padding(3, 2, 3, 2);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(158, 76);
            checkedListBox3.TabIndex = 27;
            checkedListBox3.SelectedIndexChanged += checkedListBox3_SelectedIndexChanged;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Goudy Stout", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(382, 20);
            Title.Name = "Title";
            Title.Size = new Size(605, 30);
            Title.TabIndex = 28;
            Title.Text = "Hello Teacher Number ...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 84);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 29;
            label3.Text = "Date Of Exams ";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(47, 33);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 30;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 526);
            Controls.Add(btn_back);
            Controls.Add(label3);
            Controls.Add(Title);
            Controls.Add(checkedListBox3);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private Label Title;
        private Label label3;
        private Button btn_back;
    }
}
