using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Formularios
{
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextValor3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TextValor1.Text.Trim().Length==0) {
                MessageBox.Show("Ingrese el Primer Valor");
                TextValor1.Focus();
                return;
            }
            if (TxtValor2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Segundo Valor");
                TxtValor2.Focus();
                return;
            }
            if (TextValor3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Tercer Valor");
                TextValor3.Focus();
                return;
            }
            double v1, v2 , v3, r;
            v1 = Convert.ToDouble(TextValor1.Text);
            v2 = Convert.ToDouble(TxtValor2.Text);
            v3 = Convert.ToDouble(TextValor3.Text);
            r = v1 + v2 + v3;
            TexCalcular.Text = r.ToString();

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TextValor1.Text = null;
            TxtValor2.Text = null;
            TextValor3.Text = null;
            TexCalcular.Text = null;
       
        }
    }
}
