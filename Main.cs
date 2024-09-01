// Hecho por Eduardo López  https://github.com/eduardoezequieel

using System;
using System.Windows.Forms;

namespace Guia1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejemplo1 ejemplo1 = new Ejemplo1();
            ejemplo1.StartPosition = FormStartPosition.CenterScreen;
            ejemplo1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejemplo2 ejemplo2 = new Ejemplo2();
            ejemplo2.StartPosition = FormStartPosition.CenterScreen;
            ejemplo2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejemplo3 ejemplo3 = new Ejemplo3();
            ejemplo3.StartPosition = FormStartPosition.CenterScreen;
            ejemplo3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
