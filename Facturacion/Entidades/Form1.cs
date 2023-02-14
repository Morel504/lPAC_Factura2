using System;
using System.Windows.Forms;

namespace Entidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Ingrese Usuario");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Ingrese una Contraseña");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            errorProvider1.Clear();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
