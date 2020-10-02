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
    public partial class FrmComprallanta : Form
    {
        public FrmComprallanta()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double com, pre, to;
            com = Convert.ToDouble(textCompra.Text);
            pre = Convert.ToDouble(textPrecio.Text);
            to = com* pre;
            textTotal.Text = to.ToString ();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textCompra.Text = null;
            textPrecio.Text = null;
            textTotal.Text = null;
        }
    }
}
