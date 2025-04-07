namespace Examination_System.Presentation.Common
{
    partial class ToastForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastForm));
            toast_timer = new System.Windows.Forms.Timer(components);
            toast_hide_timer = new System.Windows.Forms.Timer(components);
            pic_toasticon = new PictureBox();
            pl_toastcolor = new Panel();
            lb_typr = new Label();
            lb_toastMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_toasticon).BeginInit();
            SuspendLayout();
            // 
            // toast_timer
            // 
            toast_timer.Enabled = true;
            toast_timer.Interval = 10;
            toast_timer.Tick += toast_timer_Tick;
            // 
            // toast_hide_timer
            // 
            toast_hide_timer.Enabled = true;
            toast_hide_timer.Interval = 10;
            toast_hide_timer.Tick += toast_hide_timer_Tick;
            // 
            // pic_toasticon
            // 
            pic_toasticon.Image = Properties.Resources.check;
            pic_toasticon.Location = new Point(24, 23);
            pic_toasticon.Name = "pic_toasticon";
            pic_toasticon.Size = new Size(32, 34);
            pic_toasticon.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_toasticon.TabIndex = 0;
            pic_toasticon.TabStop = false;
            // 
            // pl_toastcolor
            // 
            pl_toastcolor.BackColor = Color.FromArgb(57, 155, 53);
            pl_toastcolor.Location = new Point(0, 0);
            pl_toastcolor.Name = "pl_toastcolor";
            pl_toastcolor.Size = new Size(10, 80);
            pl_toastcolor.TabIndex = 1;
            // 
            // lb_typr
            // 
            lb_typr.AutoSize = true;
            lb_typr.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_typr.Location = new Point(62, 9);
            lb_typr.Name = "lb_typr";
            lb_typr.Size = new Size(57, 21);
            lb_typr.TabIndex = 2;
            lb_typr.Text = "label1";
            // 
            // lb_toastMessage
            // 
            lb_toastMessage.Location = new Point(69, 34);
            lb_toastMessage.Name = "lb_toastMessage";
            lb_toastMessage.Size = new Size(215, 39);
            lb_toastMessage.TabIndex = 3;
            lb_toastMessage.Text = "label2";
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 80);
            Controls.Add(lb_toastMessage);
            Controls.Add(lb_typr);
            Controls.Add(pl_toastcolor);
            Controls.Add(pic_toasticon);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(300, 80);
            MinimumSize = new Size(300, 80);
            Name = "ToastForm";
            Text = "ToastForm";
            TopMost = true;
            Load += ToastForm_Load;
            ((System.ComponentModel.ISupportInitialize)pic_toasticon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer toast_timer;
        private System.Windows.Forms.Timer toast_hide_timer;
        private PictureBox pic_toasticon;
        private Panel pl_toastcolor;
        private Label lb_typr;
        private Label lb_toastMessage;
    }
}