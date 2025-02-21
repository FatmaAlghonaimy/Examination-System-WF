namespace Examination_System.Presentation.AdminForms
{
    partial class frmShowStudentExam
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
            flowLayoutPanelQuestions = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAsPdfToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanelQuestions.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelQuestions
            // 
            flowLayoutPanelQuestions.AutoScroll = true;
            flowLayoutPanelQuestions.Controls.Add(menuStrip1);
            flowLayoutPanelQuestions.Dock = DockStyle.Fill;
            flowLayoutPanelQuestions.Location = new Point(0, 0);
            flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            flowLayoutPanelQuestions.Padding = new Padding(20, 0, 0, 0);
            flowLayoutPanelQuestions.Size = new Size(984, 450);
            flowLayoutPanelQuestions.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(20, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(165, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsPdfToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveAsPdfToolStripMenuItem
            // 
            saveAsPdfToolStripMenuItem.Name = "saveAsPdfToolStripMenuItem";
            saveAsPdfToolStripMenuItem.Size = new Size(180, 22);
            saveAsPdfToolStripMenuItem.Text = "Save as Pdf";
            saveAsPdfToolStripMenuItem.Click += btnExportPDF_Click;
            // 
            // frmShowStudentExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(flowLayoutPanelQuestions);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 489);
            MinimumSize = new Size(1000, 489);
            Name = "frmShowStudentExam";
            Text = "frmShowStudentExam";
            flowLayoutPanelQuestions.ResumeLayout(false);
            flowLayoutPanelQuestions.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelQuestions;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsPdfToolStripMenuItem;
    }
}