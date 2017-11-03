using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmRol
{
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            AltaRol alta = new AltaRol();
            alta.Show();
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            BajaRol baja = new BajaRol();
            baja.Show();
        }

        private void Modificacion_Click(object sender, EventArgs e)
        {
            ModificarRol mod = new ModificarRol();
            mod.Show();
        }
    }
}
