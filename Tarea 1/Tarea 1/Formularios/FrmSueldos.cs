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
    public partial class FrmSueldos : Form
    {
        public FrmSueldos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmSueldonormal Sueldo1 = new Formularios.FrmSueldonormal();
            Sueldo1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmHoras Horas = new Formularios.FrmHoras();
            Horas.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
