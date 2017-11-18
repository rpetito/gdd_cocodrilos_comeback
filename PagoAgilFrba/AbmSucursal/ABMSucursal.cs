using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class ABMSucursal : Form
    {
        public ABMSucursal()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            AltaSucursal alta = new AltaSucursal();
            alta.Show();
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            BajaSucursal baja = new BajaSucursal();
            baja.Show();
        }

        private void Modificacion_Click(object sender, EventArgs e)
        {
            ModificarSucursal mod = new ModificarSucursal();
            mod.Show();
        }
    }
}
