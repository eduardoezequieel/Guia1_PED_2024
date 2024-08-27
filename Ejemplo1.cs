using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1
{
    public partial class Ejemplo1 : Form
    {
        int x, y;
        List<Color> colors;
        List<int> sizes;

        public Ejemplo1()
        {
            InitializeComponent();

            colors = new List<Color>{
                Color.Black,
                Color.Red,
                Color.Green,
                Color.Blue,
                Color.Magenta,
                Color.Yellow,
                Color.Cyan,
                Color.Gray,
                Color.Pink,
                Color.Orange
            };

            sizes = new List<int> { 60, 80, 100, 120, 140 };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Random random = new Random();

            Color newColor = colors[random.Next(colors.Count)];
            int newSize = sizes[random.Next(sizes.Count)];

            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush solidBrush = new SolidBrush(newColor);
                graphics.DrawEllipse(pen, x - 50, y - 50, newSize, newSize);
                graphics.FillEllipse(solidBrush, x - 50, y - 50, newSize, newSize);
            }
            else if (listBox1.SelectedIndex == 1)
            {
                SolidBrush solidBrush = new SolidBrush(newColor);
                graphics.DrawRectangle(pen, x - 50, y - 50, newSize, newSize);
                graphics.FillRectangle(solidBrush, x - 50, y - 50, newSize, newSize);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            x = point.X;
            y = point.Y;

            panel1.Invalidate();
        }
    }
}
