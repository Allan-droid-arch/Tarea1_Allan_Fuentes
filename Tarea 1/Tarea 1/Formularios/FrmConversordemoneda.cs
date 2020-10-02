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
    public partial class FrmConversordemoneda : Form
    {
        public FrmConversordemoneda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmLempira_euro Euro = new Formularios.FrmLempira_euro();
            Euro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmLempira_Dolar Dolar = new Formularios.FrmLempira_Dolar();
            Dolar.ShowDialog();
        }
    }
}
