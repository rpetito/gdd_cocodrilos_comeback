using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class BajaSucursal : Form
    {
        private SucursalController sucursalController = new SucursalController();

        public BajaSucursal()
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

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            sucursalController.filterSucursalHabilitada(new Util.SQLResponse<SqlDataReader>
            {
                onSuccess = (SqlDataReader result) =>
                {

                },
                onError = (Error fail) =>
                {

                }

            }, NombreTB.Text, DireccionTB.Text, CodigoPostalTB.Text, BajaSucursalGV);
        }

        private void EliminarB_Click(object sender, EventArgs e)
        {
            if (BajaSucursalGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in BajaSucursalGV.SelectedRows)
                {
                    Int32 idSucursal = (int)row.Cells[0].Value;
                    sucursalController.removeSucursal(new SQLResponse<Int32>()
                    {

                        onSuccess = (Int32 result) => {
                            Util.Util.showSuccessDialog();
                            this.FiltrarButton.PerformClick();
                        },

                        onError = (Error error) => {

                        }

                    }, idSucursal);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila completa.", "Selección vacía");
            }
        }
    }
}
