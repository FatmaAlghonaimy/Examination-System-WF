using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Examination_System.CustomControls
{
    public class CustomButton : Button
    {
        private int _borderRadius = 40;
        private Color _borderColor = Color.Black;
        private int _borderSize = 0;

        public CustomButton()
        {

            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.MediumSlateBlue;
            this.Size = new Size(150, 40);


        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border radius of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                Invalidate(); // Refresh control
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border size of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = value;
                Invalidate(); // Refresh control
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border color of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate(); // Refresh control
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the background color of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the text color of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Create rounded path
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1f);
            if(_borderRadius > 2)
            {
                using(GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
                using(GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - 1f))
                using(Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using(Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if(_borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);

                }
            } else
            {
                this.Region = new Region(rectSurface);
                using(Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
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
    }
}
