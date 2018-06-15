using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _13.TurtleGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;

            //Draw an equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            //Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void buttonDrawHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void buttonDrawStar_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.PenColor = Color.Green;
            for (int i = 0; i < 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void buttonDrawSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            int forward = 10;
            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(forward);
                Turtle.Rotate(60);
                forward += 10;
            }
        }

        private void buttonDrawSun_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            for (int i = 0; i < 18; i++)
            {
                Turtle.Forward(300);
                Turtle.Rotate(10);
                Turtle.Backward(300);
                Turtle.Rotate(10);
            }
        }

        private void buttonDrawTriangle_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.PenColor = Color.IndianRed;
            int forward = 10;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Turtle.Forward(forward);
                    Turtle.Rotate(120);
                    forward += 10;
                }
                forward = 10;
            }
        }
    }
}
