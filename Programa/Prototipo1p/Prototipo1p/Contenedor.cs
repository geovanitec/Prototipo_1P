using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1p
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void vENTASENCABEZADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaEncabezado abrir = new frmVentaEncabezado();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void vENTASDETALLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaDetalle abrir = new frmVentaDetalle();
            abrir.MdiParent = this;
            abrir.Show();
        }
    }
}
