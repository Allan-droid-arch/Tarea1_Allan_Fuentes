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
    public partial class FrmGalon : Form
    {
        public FrmGalon()
        {
            InitializeComponent();
        }

        private void FrmGalon_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ga, litro;
            ga = Convert.ToDouble(textGalon.Text);
            litro = ga * 3.785;
            textLitro.Text = litro.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textGalon.Text = null;
            textLitro.Text = null;

        }
    }
}
