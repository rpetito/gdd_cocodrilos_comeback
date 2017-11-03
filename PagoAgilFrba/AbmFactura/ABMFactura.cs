using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class ABMFactura : Form
    {
        public ABMFactura()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            AltaFactura alta = new AltaFactura();
            alta.Show();
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            BajaFactura baja = new BajaFactura();
            baja.Show();
        }

        private void Modificacion_Click(object sender, EventArgs e)
        {
            ModificarFactura mod = new ModificarFactura();
            mod.Show();
        }
    }
}
