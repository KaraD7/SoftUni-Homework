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

namespace TurtleGraphics
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
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

        private void buttonHexagon_Click(object sender, EventArgs e)
        {

            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw a Hexagon
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(100);

        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Green;

            Turtle.Delay = 200;

            Turtle.Forward(200);
            Turtle.Rotate(144);
            Turtle.Forward(200);
            Turtle.Rotate(144);
            Turtle.Forward(200);
            Turtle.Rotate(144);
            Turtle.Forward(200);
            Turtle.Rotate(144);
            Turtle.Forward(200);
            Turtle.Rotate(144);

        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;

            Turtle.Forward(10);
            Turtle.Rotate(60);
            Turtle.Forward(20);
            Turtle.Rotate(60);
            Turtle.Forward(30);
            Turtle.Rotate(60);
            Turtle.Forward(50);
            Turtle.Rotate(60);
            Turtle.Forward(60);
            Turtle.Rotate(60);
            Turtle.Forward(70);
            Turtle.Rotate(60);
            Turtle.Forward(80);
            Turtle.Rotate(60);
            Turtle.Forward(90);
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.Rotate(60);
            Turtle.Forward(110);
            Turtle.Rotate(60);
            Turtle.Forward(120);
            Turtle.Rotate(60);
            Turtle.Forward(130);
            Turtle.Rotate(60);
            Turtle.Forward(140);
            Turtle.Rotate(60);
            Turtle.Forward(150);
            Turtle.Rotate(60);
            Turtle.Forward(160);
            Turtle.Rotate(60);
            Turtle.Forward(170);
            Turtle.Rotate(60);
            Turtle.Forward(180);
            Turtle.Rotate(60);
            Turtle.Forward(190);
            Turtle.Rotate(60);
            Turtle.Forward(200);
            Turtle.Rotate(60);
            Turtle.Forward(210);
            Turtle.Rotate(60);
        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;

        
            Turtle.Forward(100);
            Turtle.Rotate(170);
            Turtle.Forward(100);
            Turtle.Rotate(170);
            Turtle.Forward(100);
            


        }
    }
}


