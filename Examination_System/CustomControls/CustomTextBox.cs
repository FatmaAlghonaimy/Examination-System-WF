using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {
        // fields 
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLine = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocus = false;
        private int borderRadius = 0;
        private Color placeHolderColor = Color.DarkGray;
        private string placeHolderText = "";
        private bool isPlaceHolder = false;
        private bool isPasswordChar = false;



        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border radius of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    Invalidate(); // Refresh control
                }
            }
        }
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border color of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate(); // Refresh control
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the placeholder color of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Color PlaceHolderColor
        {
            get => placeHolderColor;
            set
            {
                placeHolderColor = value;
                if (isPasswordChar)
                    textBox1.ForeColor = value;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the placeholder text of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string PlaceHolderText
        {
            get => placeHolderText;
            set
            {
                placeHolderText = value;
                textBox1.Text = "";
                SetPlaceHolder();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border focus color of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set
            {
                borderFocusColor = value;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border size of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Invalidate(); // Refresh control
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox style of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public bool UnderLine
        {
            get => underLine;
            set
            {
                underLine = value;
                Invalidate(); // Refresh control
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox password char of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public bool PasswordChar
        {
            get => isPasswordChar;
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox focus of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public bool IsFocus
        {
            get => isFocus;
            set
            {
                isFocus = value;
                //textBox1.UseSystemPasswordChar = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox placeholder  of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public bool IsPlaceHolder
        {
            get => isPlaceHolder;
            set
            {
                isPlaceHolder = value;
                Invalidate();
            }
        }



        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox Multiline of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public bool Multiline
        {
            get => textBox1.Multiline;
            set
            {
                textBox1.Multiline = value;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox BackColor of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                textBox1.BackColor = value;
                base.BackColor = value;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox ForeColor of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                textBox1.ForeColor = value;
                base.ForeColor = value;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox Font of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the textbox Text of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Text
        {
            get
            {
                if (isPlaceHolder) return "";
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceHolder();
            }
        }

        private void SetPlaceHolder()
        {
            if (string.IsNullOrEmpty(textBox1.Text) && placeHolderText != "")
            {
                isPlaceHolder = true;
                textBox1.Text = placeHolderText;
                textBox1.ForeColor = PlaceHolderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceHolder()
        {
            if (isPlaceHolder && placeHolderText != "")
            {
                isPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetRoundedFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetRoundedFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = PenAlignment.Center;
                    if (isFocus) penBorder.Color = borderFocusColor;

                    if (underLine)
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.SmoothingMode = SmoothingMode.None;

                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.DrawPath(penBorder, pathBorder);
                    }

                }

            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (!isFocus)
                    {
                        if (underLine)
                        {
                            graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            graphics.DrawRectangle(penBorder, 0, 0, this.Height - 0.5f, this.Width - 0.5f);
                        }
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underLine)
                        {
                            graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            graphics.DrawRectangle(penBorder, 0, 0, this.Height - 0.5f, this.Width - 0.5f);
                        }
                    }
                }
            }


        }
        public void Clear()
        {
            textBox1.Clear();
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath graphicsPath;
            if (Multiline)
            {
                graphicsPath = GetRoundedFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(graphicsPath);
            }
            else
            {
                graphicsPath = GetRoundedFigurePath(textBox1.ClientRectangle, 2 * borderSize);
                textBox1.Region = new Region(graphicsPath);
            }
        }

        public event EventHandler _TextChanged;
        public event EventHandler _KeyUp;
        public event EventHandler _KeyPress;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        //private GraphicsPath GetRoundedFigurePath(RectangleF rect, float radius)
        //{
        //    float curveSize = 2f * radius;
        //    GraphicsPath path = new GraphicsPath();
        //    // Define the rounded corners
        //    path.StartFigure();
        //    path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90); // Top-left
        //    path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90); // Top-right
        //    path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90); // Bottom-right
        //    path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90); // Bottom-left
        //    path.CloseFigure();

        //    return path;
        //}

        private GraphicsPath GetRoundedFigurePath(RectangleF rect, float radius)
        {

            GraphicsPath path = new GraphicsPath();
            // Define the rounded corners
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90); // Bottom-left
            path.CloseFigure();

            return path;
        }


        public CustomTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            this.OnMouseHover(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.OnMouseMove(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _KeyPress?.Invoke(sender, e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocus = true;
            Invalidate();
            RemovePlaceHolder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocus = false;
            Invalidate();
            SetPlaceHolder();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            _KeyUp?.Invoke(sender, e);
        }
    }
}
