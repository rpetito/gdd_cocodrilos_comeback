using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System.Data.SqlClient;

namespace PagoAgilFrba
{
    public partial class SeleccionRol : Form
    {

        UserController usuarioController = new UserController();

        public SeleccionRol()
        {
            InitializeComponent();

            for(Int16 i = 0; i < Usuario.getInstance().getRoles().Count; i++)
            {
                RolCB.Items.Add(Usuario.getInstance().getRoles()[i].getDetalle());
            }
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            RolLogeo selectedRol = Usuario.getInstance().getRolAtIndex(RolCB.SelectedIndex);

            try {
                if(selectedRol != null)
                Usuario.getInstance().setRolSeleccionado(selectedRol);
                usuarioController.getSucursal(new SQLResponse<SqlDataReader>()
                {

                    onSuccess = (SqlDataReader result) => {
 
                    },

                    onError = (Error error) => {

                    }

                }, Usuario.getInstance().getDNI());
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Debe seleccionar un rol.");

            }
        }
    }
}
