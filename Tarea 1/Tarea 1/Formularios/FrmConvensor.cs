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
    public partial class FrmConvensor : Form
    {
        public FrmConvensor()
        {
            InitializeComponent();
        }

        private void FrmConvensor_Load(object sender, EventArgs e)
        {

        }

        private void BtnMMetros_Click(object sender, EventArgs e)
        {
            Formularios.FrmMmetros Metros = new Formularios.FrmMmetros();
            Metros.ShowDialog();
        }

        private void BtnMkilometros_Click(object sender, EventArgs e)
        {
            Formularios.FrmMkilometros kilometros = new Formularios.FrmMkilometros();
            kilometros.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
