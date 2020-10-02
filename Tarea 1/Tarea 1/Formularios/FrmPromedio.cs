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
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
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

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNota1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Primer Valor");
                TxtNota1.Focus();
                return;
            }
            if (TxtNota2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Segundo Valor");
                TxtNota2.Focus();
                return;
            }
            if (TxtNota3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Tercer Valor");
                TxtNota3.Focus();
                return;
            }
            if (TxtNota4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Cuarto Valor");
                TxtNota4.Focus();
                return;
            }
            double n1, n2, n3, n4, r;
            n1 = Convert.ToDouble(TxtNota1.Text);
            n2 = Convert.ToDouble(TxtNota2.Text);
            n3 = Convert.ToDouble(TxtNota3.Text);
            n4 = Convert.ToDouble(TxtNota4.Text);
            r = (n1+ n2+ n3 + n4)/4 ;
            TxtPromedio.Text = r.ToString();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtNota1.Text = null;
            TxtNota2.Text = null;
            TxtNota3.Text = null;
            TxtNota4.Text = null;
            TxtPromedio.Text = null;

        }
    }
}
