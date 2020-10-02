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
    public partial class FrmLempira_euro : Form
    {
        public FrmLempira_euro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double lem, eur;
            lem = Convert.ToDouble(textLempira.Text);
            eur = lem * 28.71;
            textEuro.Text = eur.ToString();

        }

        private void BtnConvertir2_Click(object sender, EventArgs e)
        {
            double l1, e1;
            l1 = Convert.ToDouble(textLempira2.Text);
            e1 = l1 * 29.86;
            textEuro2.Text = e1.ToString();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            textEuro.Text = null;
            textLempira.Text = null;
        }

        private void btnBorrar2_Click(object sender, EventArgs e)
        {
            textLempira2.Text = null;
            textEuro2.Text = null;
        }
    }
}
