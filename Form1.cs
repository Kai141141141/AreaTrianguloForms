using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbAltura_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            try
            {
                //Obter respostas:
                double n1, n2;
                n1 = double.Parse(txb1.Text);
                n2 = double.Parse(txb2.Text);

                //Aplicar condição:

                txbRes.Text = (n1 * n2 / 2).ToString()


        }
            catch
            {
                MessageBox.Show("Dados inválidos!");
                //limpar os txbs:
                txbRes.Clear();
                txbAltura.Clear();
                txbBase.Clear();
            }

            private void txbRes_EnabledChanged(object sender, EventArgs e)
            {

            }

            private void txb1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
    }
}
