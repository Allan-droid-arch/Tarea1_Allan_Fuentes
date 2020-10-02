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
    public partial class FrmMmetros : Form
    {
        public FrmMmetros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double m, me ;
            m = Convert.ToDouble (textMillas.Text);
            me = m * 1609;
            textMetros.Text = me.ToString();


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textMillas.Text = null;
            textMetros.Text = null;
        }
    }
}
