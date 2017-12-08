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

namespace PagoAgilFrba.AbmFactura
{
    public partial class BajaFactura : Form
    {

		FacturaController facturaController;

        public BajaFactura()
        {
            InitializeComponent();
			this.facturaController = new FacturaController();
			Util.Util.addButtonColumnToGridView(
				BajaFacturaGV, 
				"Eliminar",
				new DataGridViewCellEventHandler(this.BajaFactura_GridViewCellEventHandler));
			EmpresaController empresaController = new EmpresaController();
			empresaController.getEmpresas(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {
					bajaFacturaEmpresaCB.addItem(result.GetString(0), result.GetString(1));
				},

				onError = (Error error) => {

				}

			});
        }



        private void LimpiarButton_Click(object sender, EventArgs e)
        {
			bajaFacturaEmpresaCB.clear();
            FacturaTB.Clear();
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		private void FiltrarButton_Click(object sender, EventArgs e) {
			facturaController.obtenerFacturas(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {

				},

				onError = (Error error) => { 
				
				}

			},
			FacturaTB.Text.ToString(),
			bajaFacturaEmpresaCB.getSelectedItemID(),
			BajaFacturaGV,
			0,
			0,
			1);
		}


		private void BajaFactura_GridViewCellEventHandler(object sender, DataGridViewCellEventArgs e) {

			if(e.ColumnIndex == 0) {
				facturaController.bajaFactura(new SQLResponse<SqlDataReader>() {

					onSuccess = (SqlDataReader result) => {
						
					},

					onError = (Error error) => { 
					
					},

					onFinish = (Boolean withError) => {
						if(!withError) {
							Util.Util.showSuccessDialog();
							this.FiltrarButton.PerformClick();
						}
					}

				},
				BajaFacturaGV.Rows[e.RowIndex].Cells[1].Value.ToString(),
				BajaFacturaGV.Rows[e.RowIndex].Cells[3].Value.ToString());
			}

		}



    }
}