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
    public partial class FrmSueldonormal : Form
    {
        public FrmSueldonormal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double su, pre, to;
            su = Convert.ToDouble(textDias.Text);
            pre = Convert.ToDouble(textPrecios.Text);
            to = su * pre;
            textPagar.Text = to.ToString();


        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            textDias.Text = null;
            textPrecios.Text = null;
            textPagar.Text = null;

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
