using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1
{
    public partial class Ejemplo2 : Form
    {
        private struct CursorPosition
        {
            public int X { get; set; }
            public int Y { get; set; }

            public CursorPosition(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        CursorPosition[] cursorPositions = new CursorPosition[2];
        bool firstPositionCanBeSet = true;
        Graphics area;

        public Ejemplo2()
        {
            InitializeComponent();
            area = areaDibujo.CreateGraphics();
        }

        private void areaDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            Point pointer = new Point(e.X, e.Y);
            int x = pointer.X;
            int y = pointer.Y;

            if (firstPositionCanBeSet)
            {
                CursorPosition firstCursorPosition = new CursorPosition(x, y);
                cursorPositions[0] = firstCursorPosition;
                firstPositionCanBeSet = false;
            }
            else
            {
                CursorPosition secondCursorPosition = new CursorPosition(x, y);
                cursorPositions[1] = secondCursorPosition;
                firstPositionCanBeSet = true;
            }

            area.Clear(Color.White);

            if (cursorPositions[0].X != 0 && cursorPositions[0].Y != 0)
            {
                int xPosition = cursorPositions[0].X;
                int yPosition = cursorPositions[0].Y;

                area.DrawEllipse(Pens.Black, xPosition, yPosition, 10, 10);
                area.FillEllipse(Brushes.Red, xPosition, yPosition, 10, 10);
            }

            if (cursorPositions[1].X != 0 && cursorPositions[1].Y != 0)
            {
                int xPosition = cursorPositions[1].X;
                int yPosition = cursorPositions[1].Y;

                area.DrawEllipse(Pens.Black, xPosition, yPosition, 10, 10);
                area.FillEllipse(Brushes.BlueViolet, xPosition, yPosition, 10, 10);
            }
        }

        private void btnDibujar_Click(object sender, System.EventArgs e)
        {
            if (cursorPositions[0].X == 0 && cursorPositions[0].Y == 0 ||
                cursorPositions[1].X == 0 && cursorPositions[1].Y == 0)
            {
                MessageBox.Show("Debe de seleccionar dos puntos antes de comenzar", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pen pen = new Pen(Color.Black);

            Console.WriteLine("test");

            switch (cmbColor.SelectedIndex)
            {
                case 0: pen = new Pen(Color.Yellow); break;
                case 1: pen = new Pen(Color.Red); break;
                case 2: pen = new Pen(Color.Blue); break;
                case 3: pen = new Pen(Color.Black); break;
            }

            int iterations = int.Parse(txtCantidad.Text);
            int space = int.Parse(txtEspaciado.Text);

            area.Clear(Color.White);

            int x1 = cursorPositions[0].X;
            int y1 = cursorPositions[0].Y;
            int x2 = cursorPositions[1].X;
            int y2 = cursorPositions[1].Y;

            for (int i = 0; i < iterations; i++)
            {
                int offsetX = (x2 - x1) * i / (iterations - space);
                int offsetY = (y2 - y1) * i / (iterations - space);

                Console.WriteLine(offsetX + " " + offsetY);
                area.DrawLine(pen, x1 + offsetX, y1 + offsetY, x2 + offsetX, y2 + offsetY);
            }
        }
    }
}