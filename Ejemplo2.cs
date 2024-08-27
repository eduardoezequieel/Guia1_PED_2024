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

        private CursorPosition[] cursorPositions = new CursorPosition[2];
        private bool firstPositionCanBeSet = true;
        private bool linesCanBeDrawed = false;

        public Ejemplo2()
        {
            InitializeComponent();
            this.btnClear.Enabled = false;
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

            areaDibujo.Invalidate();
        }

        private void btnDibujar_Click(object sender, System.EventArgs e)
        {
            this.linesCanBeDrawed = true;

            this.btnDibujar.Enabled = false;
            this.btnClear.Enabled = true;

            areaDibujo.Invalidate();
        }

        private void areaDibujo_Paint(object sender, PaintEventArgs e)
        {
            Graphics localArea = e.Graphics;

            if (cursorPositions[0].X != 0 && cursorPositions[0].Y != 0)
            {
                int xPosition = cursorPositions[0].X;
                int yPosition = cursorPositions[0].Y;

                localArea.DrawEllipse(Pens.Black, xPosition, yPosition, 10, 10);
                localArea.FillEllipse(Brushes.Red, xPosition, yPosition, 10, 10);
            }

            if (cursorPositions[1].X != 0 && cursorPositions[1].Y != 0)
            {
                int xPosition = cursorPositions[1].X;
                int yPosition = cursorPositions[1].Y;

                localArea.DrawEllipse(Pens.Black, xPosition, yPosition, 10, 10);
                localArea.FillEllipse(Brushes.BlueViolet, xPosition, yPosition, 10, 10);
            }

            if (linesCanBeDrawed)
            {
                drawLines(localArea);
            }
        }

        private void drawLines(Graphics localArea)
        {
            if (cursorPositions[0].X == 0 && cursorPositions[0].Y == 0 ||
                cursorPositions[1].X == 0 && cursorPositions[1].Y == 0)
            {
                MessageBox.Show("Debe de seleccionar dos puntos antes de comenzar", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnClear_Click(null, null);
                return;
            }

            Pen pen = new Pen(Color.Black);

            switch (cmbColor.SelectedIndex)
            {
                case 0: pen = new Pen(Color.Yellow); break;
                case 1: pen = new Pen(Color.Red); break;
                case 2: pen = new Pen(Color.Blue); break;
                case 3: pen = new Pen(Color.Black); break;
            }

            int iterations = 0;
            int space = 0;

            try
            {
                iterations = int.Parse(txtCantidad.Text);
                space = int.Parse(txtEspaciado.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe de ingresar un valor numérico", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnClear_Click(null, null);
                return; 
            }

            int x1 = cursorPositions[0].X + 5;
            int y1 = cursorPositions[0].Y + 5;
            int x2 = cursorPositions[1].X + 5;
            int y2 = cursorPositions[1].Y + 5;

            localArea.DrawLine(pen, x1, y1, x2, y2);

            //for (int i = 0; i < iterations; i++)
            //{
            //    int offsetX = (x2 - x1) * i / (iterations - space);
            //    int offsetY = (y2 - y1) * i / (iterations - space);

            //    Console.WriteLine(offsetX + " " + offsetY);
            //    area.DrawLine(pen, x1 + offsetX, y1 + offsetY, x2 + offsetX, y2 + offsetY);
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cursorPositions[0] = new CursorPosition(0, 0);
            cursorPositions[1] = new CursorPosition(0, 0);
            firstPositionCanBeSet = true;
            linesCanBeDrawed = false;
            this.btnDibujar.Enabled = true;
            this.btnClear.Enabled = false;

            areaDibujo.Invalidate();
        }
    }
}