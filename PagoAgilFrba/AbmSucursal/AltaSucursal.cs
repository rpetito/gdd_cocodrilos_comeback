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
    public partial class AltaSucursal : Form
    {
        public AltaSucursal()
        {
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            DireccionTB.Clear();
            CodigoPostalTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            String nombre = NombreTB.Text;
            String direccion = DireccionTB.Text;
            Decimal codPostal = Convert.ToDecimal(CodigoPostalTB.Text);

            SucursalController sucursalController = new SucursalController();
            sucursalController.insertNewSucursal(new Util.SQLResponse<Int32>
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
            nombre,
            direccion,
            codPostal);
        }
    }
}
