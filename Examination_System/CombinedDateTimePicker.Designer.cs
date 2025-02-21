namespace ExaminationSystem
{
    partial class CombinedDateTimePicker
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
            dateTimePickerDate = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(21, 17);
            dateTimePickerDate.MinDate = new DateTime(2025, 2, 18, 0, 0, 0, 0);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(250, 27);
            dateTimePickerDate.TabIndex = 0;
            dateTimePickerDate.Value = new DateTime(2025, 2, 18, 0, 39, 36, 0);
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(21, 61);
            dateTimePickerTime.MinDate = new DateTime(2025, 2, 18, 0, 39, 57, 0);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.Size = new Size(250, 27);
            dateTimePickerTime.TabIndex = 1;
            dateTimePickerTime.Value = new DateTime(2025, 2, 18, 0, 39, 57, 0);
            // 
            // CombinedDateTimePicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePickerTime);
            Controls.Add(dateTimePickerDate);
            Name = "CombinedDateTimePicker";
            Size = new Size(294, 120);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePickerDate;
        private DateTimePicker dateTimePickerTime;
    }
}
