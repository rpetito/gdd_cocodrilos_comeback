using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class SeleccionSucursal : Form
    {
        public SeleccionSucursal()
        {
            InitializeComponent();

            for (Int16 i = 0; i < Usuario.getInstance().getSucursales().Count; i++)
            {
                if(!SucursalCB.Items.Contains(Usuario.getInstance().getSucursales()[i].getNombre()))
                    SucursalCB.Items.Add(Usuario.getInstance().getSucursales()[i].getNombre());
            }
        }

        private void SucursalButton_Click(object sender, EventArgs e)
        {
            SucursalLogeo sucursalSeleccionada = Usuario.getInstance().getSucursalAtIndex(SucursalCB.SelectedIndex);
            try
            {
                if (sucursalSeleccionada != null)
                {
                    Usuario.getInstance().setSucursalSeleccionada(sucursalSeleccionada);
                    Menu menues = new Menu();
                    menues.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Debe seleccionar una sucursal.");

            }
        }
    }
}
