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
    public partial class SeleccionRol : Form
    {
        public SeleccionRol()
        {
            InitializeComponent();

            for(Int16 i = 0; i <= Usuario.getInstance().getRoles().Count; i++)
            {
                RolCB.Items.Add(Usuario.getInstance().getRoles()[i].getDetalle());
            }
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            Rol selectedRol = Usuario.getInstance().getRolAtIndex(RolCB.SelectedIndex);

            try {
                if(selectedRol != null)
                Usuario.getInstance().setRolSeleccionado(selectedRol);

                Menu menu = new Menu();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Debe seleccionar un rol.");

            }
        }
    }
}
