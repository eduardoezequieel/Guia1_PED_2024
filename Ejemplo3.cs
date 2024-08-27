using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1
{
    public partial class Ejemplo3 : Form
    {
        enum Position
        {
            IZQUIERDA, DERECHA, ARRIBA, ABAJO
        }

        private int x;
        private int y;
        private Position objPosition;

        public Ejemplo3()
        {
            InitializeComponent();
            x = 50;
            y = 50;
            objPosition = Position.ABAJO;
        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            if (objPosition == Position.DERECHA)
            {
                x += 10;
            } else if (objPosition == Position.IZQUIERDA)
            {
                x -= 10;
            } else if (objPosition == Position.ARRIBA)
            {
                y -= 10;
            } else if (objPosition == Position.ABAJO)
            {
                y += 10;
            }

            Invalidate();
        }

        private void Ejemplo3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("imagen.png"), x, y, 65, 65);
        }

        private void Ejemplo3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                objPosition = Position.IZQUIERDA;
            } 
            else if (e.KeyCode == Keys.Right)
            {
                objPosition = Position.DERECHA;
            } 
            else if (e.KeyCode == Keys.Up)
            {
                objPosition = Position.ARRIBA;
            } 
            else if (e.KeyCode == Keys.Down)
            {
                objPosition = Position.ABAJO;
            }
        }
    }
}
