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
    public partial class FrmMkilometros : Form
    {
        public FrmMkilometros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textMilla1.Text = null;
            textkilometro.Text = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double mi, ki;
            mi = Convert.ToDouble(textMilla1.Text);
           
            ki = mi * 1.609;
            textkilometro.Text = ki.ToString();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
