using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApps.Controls
{
    internal class CircularPictureBox : PictureBox
    {
        public CircularPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetCircularRegion();
        }

        private void SetCircularRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                this.Region = new Region(path);
            }
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(rect);
                pe.Graphics.SetClip(gp);
            }

            base.OnPaint(pe);

            using (Pen pen = new Pen(Color.Gray, 2))
            {
                pe.Graphics.ResetClip();
                pe.Graphics.DrawEllipse(pen, rect);
            }
        }
    }
}