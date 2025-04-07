using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.CustomControls
{
    public class CustomPanel : Panel
    {
        #region Fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;
        private int borderSize = 2; // New field for border size
        private Color borderColor = Color.Black; // New field for border color
        #endregion

        #region Constructor
        public CustomPanel()
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.Black;
            this.Size = new Size(150, 150);
        }
        #endregion

        #region Properties
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the border radius of the control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate(); // Refresh control
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the angle of the gradient.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float GrediantAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the top gradient color.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set
            {
                gradientTopColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the bottom gradient color.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set
            {
                gradientBottomColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the size of the border.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Sets the color of the border.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }
        #endregion

        #region Methods
        private GraphicsPath GetPath(RectangleF rec, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rec.Width - radius, rec.Height - radius, radius, radius, 0, 90);
            path.AddArc(rec.X, rec.Height - radius, radius, radius, 90, 90);
            path.AddArc(rec.X, rec.Y, radius, radius, 180, 90);
            path.AddArc(rec.Width - radius, rec.Y, radius, radius, 270, 90);
            path.CloseFigure();

            return path;
        }
        #endregion

        #region Override Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, this.ClientRectangle);

            // Borders
            RectangleF rec = new RectangleF(0, 0, this.Width, this.Height);
            if (this.borderRadius > 2)
            {
                using (GraphicsPath path = GetPath(rec, this.borderRadius))
                using (Pen pen = new Pen(this.borderColor, this.borderSize)) // Use the new borderColor and borderSize
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                this.Region = new Region(rec);
            }
        }
        #endregion
    }
}