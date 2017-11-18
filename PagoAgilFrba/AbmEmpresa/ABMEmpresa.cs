using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class ABMEmpresa : Form
    {
        public ABMEmpresa()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            AltaEmpresa alta = new AltaEmpresa();
            alta.Show();
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            BajaEmpresa baja = new BajaEmpresa();
            baja.Show();
        }

        private void Modificacion_Click(object sender, EventArgs e)
        {
            ModificarEmpresa mod = new ModificarEmpresa();
            mod.Show();
        }
    }
}
