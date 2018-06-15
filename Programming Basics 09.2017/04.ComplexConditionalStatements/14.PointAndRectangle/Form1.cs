using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14.PointAndRectangle
{
    public partial class FormPointAndRectangle : Form
    {
        public FormPointAndRectangle()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownX1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownX2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void FormPointAndRectangle_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void FormPointAndRectangle_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            // Get the rectangle and point coordinates from the form
            var x1 = this.numericUpDownX1.Value;
            var y1 = this.numericUpDownY1.Value;
            var x2 = this.numericUpDownX2.Value;
            var y2 = this.numericUpDownY2.Value;
            var x = this.numericUpDownX.Value;
            var y = this.numericUpDownY.Value;

            // Display the location of the point: Inside / Border / Outside
            DisplayPointLocation(x1, y1, x2, y2, x, y);

            // Calculate the scale factor (ratio) for the diagram holding the
            // rectangle and point in order to fit them well in the picture box
            decimal minX = (decimal)Min(x1, x2, x);
            decimal maxX = (decimal)Max(x1, x2, x);
            decimal minY = (decimal)Min(y1, y2, y);
            decimal maxY = (decimal)Max(y1, y2, y);
            var diagramWidth = maxX - minX;
            var diagramHeight = maxY - minY;
            var ratio = 1.0m;
            var offset = 10;
            if (diagramWidth != 0 && diagramHeight != 0)
            {
                var ratioX = (pictureBox.Width - 2 * offset - 1) / diagramWidth;
                var ratioY = (pictureBox.Height - 2 * offset - 1) / diagramHeight;
                ratio = Math.Min(ratioX, ratioY);
            }

            // Calculate the scaled rectangle coordinates
            var rectLeft = offset + (int)Math.Round((Math.Min(x1, x2) - minX) * ratio);
            var rectTop = offset + (int)Math.Round((Math.Min(y1, y2) - minY) * ratio);
            var rectWidth = offset + (int)Math.Round(Math.Abs(x1 - x2) * ratio);
            var rectHeight = offset + (int)Math.Round(Math.Abs(y1 - y2) * ratio);
            var rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

            // Calculate the scalled point coordinates
            var pointX = (int)Math.Round(offset + (x - minX) * ratio);
            var pointY = (int)Math.Round(offset + (y - minY) * ratio);
            var pointRect = new Rectangle(pointX - 2, pointY - 2, 5, 5);

            //Draw the rectangle and point
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.Clear(Color.White);
                var pen = new Pen(Color.Blue, 3);
                g.DrawRectangle(pen, rect);
                pen = new Pen(Color.DarkBlue, 5);
                g.DrawEllipse(pen, pointRect);
            }
        }

        private object Max(decimal val1, decimal val2, decimal val3)
        {
            return Math.Max(val1, Math.Max(val2, val3));
        }

        private object Min(decimal val1, decimal val2, decimal val3)
        {
            return Math.Min(val1, Math.Min(val2, val3));
        }

        private void DisplayPointLocation(decimal x1, decimal y1, decimal x2, decimal y2, decimal x, decimal y)
        {
            var left = Math.Min(x1, x2);
            var right = Math.Max(x1, x2);
            var top = Math.Min(y1, y2);
            var bottom = Math.Max(y1, y2);
            if (x > left && x < right && y > top && y < bottom)
            {
                this.labelLocation.Text = "Inside";
                this.labelLocation.BackColor = Color.LightGreen;
            }
            else if (x < left || x > right || y < top || y > bottom)
            {
                this.labelLocation.Text = "Outside";
                this.labelLocation.BackColor = Color.LightSalmon;
            }
            else
            {
                this.labelLocation.Text = "Border";
                this.labelLocation.BackColor = Color.Gold;
            }
        }
    }
}
