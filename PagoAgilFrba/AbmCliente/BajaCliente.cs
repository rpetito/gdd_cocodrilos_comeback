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
using PagoAgilFrba.Model;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Util;

namespace PagoAgilFrba.AbmCliente
{
    public partial class BajaCliente : Form
    {

		private ClienteController clienteController = new ClienteController();

        public BajaCliente()
        {
            InitializeComponent();
			
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            ApellidoTB.Clear();
            DniTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            clienteController.filterClientHabilitado(new Util.SQLResponse<SqlDataReader>
            {
                onSuccess = (SqlDataReader result) =>
                {

                },
                onError = (Error fail) =>
                {

                }

            }, NombreTB.Text, ApellidoTB.Text, DniTB.Text, BajaClienteGV);
        }


		private void eliminarCliente_Click(object sender, EventArgs e) {
			if(BajaClienteGV.SelectedRows.Count > 0) {
				foreach(DataGridViewRow row in BajaClienteGV.SelectedRows) {
					Decimal clienteDNI = (Decimal) row.Cells[0].Value;
					clienteController.removeClient(new SQLResponse<Int32>() {

						onSuccess = (Int32 result) => {
							Util.Util.showSuccessDialog();
							this.FiltrarButton.PerformClick();
						},

						onError = (Error error) => {

						}

					}, clienteDNI);
				}
			} else {
				MessageBox.Show("Debe seleccionar al menos una fila completa.", "Selección vacía");
			}
		}

		

    }
}
