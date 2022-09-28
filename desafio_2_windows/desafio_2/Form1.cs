using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            int resultado;
            numero = int.Parse(textBox1.Text);

            for (int i = 1; i > 0; i--)
            {

                resultado = numero * (numero + i) / 2;
                label3.Text = resultado.ToString();

            }
        }
    }
}
