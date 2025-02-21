namespace ExaminationSystem.Presentation
{
    partial class FormExamPreview
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
            flowPanelExamInfo = new FlowLayoutPanel();
            flowPanelQuestions = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowPanelExamInfo
            // 
            flowPanelExamInfo.AutoSize = true;
            flowPanelExamInfo.Dock = DockStyle.Top;
            flowPanelExamInfo.FlowDirection = FlowDirection.TopDown;
            flowPanelExamInfo.Location = new Point(0, 0);
            flowPanelExamInfo.Name = "flowPanelExamInfo";
            flowPanelExamInfo.Padding = new Padding(10);
            flowPanelExamInfo.Size = new Size(1058, 20);
            flowPanelExamInfo.TabIndex = 4;
            // 
            // flowPanelQuestions
            // 
            flowPanelQuestions.AutoScroll = true;
            flowPanelQuestions.AutoSize = true;
            flowPanelQuestions.Dock = DockStyle.Fill;
            flowPanelQuestions.FlowDirection = FlowDirection.TopDown;
            flowPanelQuestions.Location = new Point(0, 20);
            flowPanelQuestions.Name = "flowPanelQuestions";
            flowPanelQuestions.Size = new Size(1058, 659);
            flowPanelQuestions.TabIndex = 5;
            flowPanelQuestions.WrapContents = false;
            // 
            // FormExamPreview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1058, 679);
            Controls.Add(flowPanelQuestions);
            Controls.Add(flowPanelExamInfo);
            Name = "FormExamPreview";
            Text = "FormExamPreview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowPanelExamInfo;
        private FlowLayoutPanel flowPanelQuestions;
    }
}