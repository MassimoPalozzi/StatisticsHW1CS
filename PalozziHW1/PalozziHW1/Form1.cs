using System;
using System.Drawing;
using System.Windows.Forms;

namespace PalozziHW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Size = new Size(500, 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Dot
            Pen pen = new Pen(Color.Brown, 2);
            g.DrawEllipse(pen, 250, 250, 2, 2);

            // Line
            pen = new Pen(Color.Blue, 2);
            g.DrawLine(pen, 25, 25, 100, 50);

            // Cirle
            pen = new Pen(Color.Red, 2);
            g.DrawEllipse(pen, 350, 350, 80, 80);

            // Rectangle
            pen = new Pen(Color.Orange, 2);
            g.DrawRectangle(pen, 25, 300, 120, 60);
        }

    }
}