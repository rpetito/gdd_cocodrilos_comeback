using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
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
    public partial class DatosSucursal : Form
    {
        Int32 habilitado;
        private SucursalController sucursalController = new SucursalController();
        public DatosSucursal()
        {
            
            InitializeComponent();
            NombreTB.Text = Model.Sucursal.getInstance().getNombre();
            DireccionTB.Text = Model.Sucursal.getInstance().getDireccion();
            CodigoPostalTB.Text = Convert.ToString(Model.Sucursal.getInstance().getCodPostal());
            EstadoCB.Checked = Model.Sucursal.getInstance().getHabilitado();
           

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            DireccionTB.Clear();
            CodigoPostalTB.Clear();
            EstadoCB.Checked = false;
            ModificarButton.Enabled = false;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            habilitar();
            sucursalController.modifySucursal(new Util.SQLResponse<Int32>
            {
                onSuccess = (Int32 result) =>
                {
                    Util.Util.showSuccessDialog();
                    this.Close();
                },
                onError = (Error fail) =>
                {

                }

            },
            Model.Sucursal.getInstance().getId(),
            NombreTB.Text,
            DireccionTB.Text,
            Convert.ToDecimal(CodigoPostalTB.Text),
            habilitado);
        }

        private void habilitar()
        {
            if (EstadoCB.Checked == true)
                habilitado = 1;
            else habilitado = 0;
        }
    }

}
