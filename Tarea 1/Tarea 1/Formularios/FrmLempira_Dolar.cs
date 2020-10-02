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
    public partial class FrmLempira_Dolar : Form
    {
        public FrmLempira_Dolar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double lem, dol;
            lem = Convert.ToDouble(textLempira3.Text);
            dol = lem * 24.44;
            textDolar.Text = dol.ToString();
        }

        private void btnConvertir1_Click(object sender, EventArgs e)
        {
            double lem1, dol1;
            lem1 = Convert.ToDouble(textLempira4.Text);
            dol1 = lem1 * 24.61;
            textDolar2.Text = dol1.ToString();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            textLempira3.Text = null;
            textDolar.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textLempira4.Text = null;
            textDolar2.Text = null;
        }
    }
}
