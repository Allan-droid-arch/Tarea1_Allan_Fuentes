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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Formularios.FrmSuma Suma = new Formularios.FrmSuma();
            Suma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Formularios.FrmPromedio Promedio = new Formularios.FrmPromedio();
            Promedio.ShowDialog();
        }

        private void BtnCmillas_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvensor Conversor = new Formularios.FrmConvensor();
            Conversor.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmConversordemoneda Conversorm = new Formularios.FrmConversordemoneda();
            Conversorm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmComprallanta llanta = new Formularios.FrmComprallanta();
            llanta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FrmSueldos Sueldo = new Formularios.FrmSueldos();
            Sueldo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmGalon Galon = new Formularios.FrmGalon();
            Galon.ShowDialog();
        }
    }
}
