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
    public partial class FrmHoras : Form
    {
        public FrmHoras()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnCalcular2_Click(object sender, EventArgs e)
        {
            double di, ho, predi, preho, to, to2, tot;
            di = Convert.ToDouble(textDiast.Text);
            ho = Convert.ToDouble(textHoras.Text);
            predi = Convert.ToDouble(textPdias.Text);
            preho = Convert.ToDouble(textPhoras.Text);
            to = di * predi;
            to2 = ho * preho;
            tot = to + to2;

            textTotalpagar.Text = tot.ToString();


        }

        private void BtnBorrar2_Click(object sender, EventArgs e)
        {
            textDiast.Text = null;
            textHoras.Text = null;
            textPdias.Text = null;
            textPhoras.Text = null;
            textTotalpagar.Text = null;
        }
    }
}
