using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class ABMCliente : Form
    {
        public ABMCliente()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmCliente.AltaCliente alta = new AltaCliente();
            alta.Show();
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmCliente.BajaCliente baja = new BajaCliente();
            baja.Show();
        }

        private void Modificacion_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmCliente.ModificarCliente mod = new ModificarCliente();
            mod.Show();
        }
    }
}
