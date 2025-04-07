namespace Examination_System.CustomControls
{
    partial class CustomComboBox1
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
            pl_title = new CustomPanel();
            pl_items = new CustomPanel();
            flp_items = new FlowLayoutPanel();
            pic_comboboxicon = new PictureBox();
            pic_combobox = new PictureBox();
            lb_options = new Label();
            lb_selectedValue = new Label();
            pl_title.SuspendLayout();
            pl_items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_comboboxicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_combobox).BeginInit();
            SuspendLayout();
            // 
            // pl_title
            // 
            pl_title.BackColor = Color.Transparent;
            pl_title.BorderColor = Color.Transparent;
            pl_title.BorderRadius = 50;
            pl_title.BorderSize = 0;
            pl_title.Controls.Add(lb_selectedValue);
            pl_title.Controls.Add(lb_options);
            pl_title.Controls.Add(pic_combobox);
            pl_title.Controls.Add(pic_comboboxicon);
            pl_title.Dock = DockStyle.Top;
            pl_title.ForeColor = Color.White;
            pl_title.GradientBottomColor = Color.FromArgb(30, 32, 34);
            pl_title.GradientTopColor = Color.FromArgb(30, 32, 34);
            pl_title.GrediantAngle = 90F;
            pl_title.Location = new Point(0, 0);
            pl_title.Margin = new Padding(0);
            pl_title.Name = "pl_title";
            pl_title.Size = new Size(300, 60);
            pl_title.TabIndex = 0;
            // 
            // pl_items
            // 
            pl_items.BackColor = Color.Transparent;
            pl_items.BorderColor = Color.Transparent;
            pl_items.BorderRadius = 30;
            pl_items.BorderSize = 0;
            pl_items.Controls.Add(flp_items);
            pl_items.Dock = DockStyle.Fill;
            pl_items.ForeColor = Color.White;
            pl_items.GradientBottomColor = Color.FromArgb(30, 32, 34);
            pl_items.GradientTopColor = Color.FromArgb(30, 32, 34);
            pl_items.GrediantAngle = 90F;
            pl_items.Location = new Point(0, 60);
            pl_items.Margin = new Padding(0);
            pl_items.Name = "pl_items";
            pl_items.Padding = new Padding(5);
            pl_items.Size = new Size(300, 130);
            pl_items.TabIndex = 1;
            // 
            // flp_items
            // 
            flp_items.Dock = DockStyle.Fill;
            flp_items.Location = new Point(5, 5);
            flp_items.Name = "flp_items";
            flp_items.Size = new Size(290, 120);
            flp_items.TabIndex = 0;
            // 
            // pic_comboboxicon
            // 
            pic_comboboxicon.Image = Properties.Resources.icons8_options_80;
            pic_comboboxicon.Location = new Point(13, 13);
            pic_comboboxicon.Name = "pic_comboboxicon";
            pic_comboboxicon.Size = new Size(30, 30);
            pic_comboboxicon.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_comboboxicon.TabIndex = 0;
            pic_comboboxicon.TabStop = false;
            // 
            // pic_combobox
            // 
            pic_combobox.Image = Properties.Resources.icons8_down_button_1001;
            pic_combobox.Location = new Point(258, 16);
            pic_combobox.Name = "pic_combobox";
            pic_combobox.Size = new Size(25, 25);
            pic_combobox.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_combobox.TabIndex = 1;
            pic_combobox.TabStop = false;
            // 
            // lb_options
            // 
            lb_options.AutoSize = true;
            lb_options.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_options.ForeColor = Color.FromArgb(42, 245, 245);
            lb_options.Location = new Point(37, -4);
            lb_options.Margin = new Padding(0);
            lb_options.Name = "lb_options";
            lb_options.Size = new Size(70, 21);
            lb_options.TabIndex = 2;
            lb_options.Text = "Options";
            // 
            // lb_selectedValue
            // 
            lb_selectedValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_selectedValue.ForeColor = Color.FromArgb(42, 245, 245);
            lb_selectedValue.Location = new Point(57, 22);
            lb_selectedValue.Margin = new Padding(0);
            lb_selectedValue.Name = "lb_selectedValue";
            lb_selectedValue.Size = new Size(198, 21);
            lb_selectedValue.TabIndex = 3;
            lb_selectedValue.Text = "Options";
            // 
            // CustomComboBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(pl_items);
            Controls.Add(pl_title);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(0);
            Name = "CustomComboBox";
            Size = new Size(300, 190);
            pl_title.ResumeLayout(false);
            pl_title.PerformLayout();
            pl_items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_comboboxicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_combobox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel pl_title;
        private CustomPanel pl_items;
        private FlowLayoutPanel flp_items;
        private PictureBox pic_comboboxicon;
        private PictureBox pic_combobox;
        private Label lb_options;
        private Label lb_selectedValue;
    }
}
