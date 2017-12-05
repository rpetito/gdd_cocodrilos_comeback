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
    public partial class ModificarFactura : Form
    {

		FacturaController facturaController;

        public ModificarFactura()
        {
            InitializeComponent();
			facturaController = new FacturaController();
			Util.Util.addButtonColumnToGridView(ModificarFacturaGV,
				"Seleccionar",
				new DataGridViewCellEventHandler(this.ModificarFactura_CellEventHandler));
        }


        private void LimpiarButton_Click(object sender, EventArgs e)
        {
			ModificarFacturaEmpresaCB.clear();
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
			ModificarFacturaEmpresaCB.getSelectedItemID(),
			ModificarFacturaGV,
			0,
			0,
			1);
		}


		private void ModificarFactura_CellEventHandler(object sender, DataGridViewCellEventArgs e) {
			if(e.ColumnIndex == 0) {
				Factura factura = new Factura();
				factura.numero = Int32.Parse(ModificarFacturaGV.Rows[e.RowIndex].Cells[1].Value.ToString());
				factura.cliente = Int32.Parse(ModificarFacturaGV.Rows[e.RowIndex].Cells[2].Value.ToString());
				factura.empresa = ModificarFacturaGV.Rows[e.RowIndex].Cells[3].Value.ToString();
				factura.fechaEmision = DateTime.Parse(ModificarFacturaGV.Rows[e.RowIndex].Cells[4].Value.ToString());
				factura.fechaVto = DateTime.Parse(ModificarFacturaGV.Rows[e.RowIndex].Cells[5].Value.ToString());
				factura.total = Decimal.Parse(ModificarFacturaGV.Rows[e.RowIndex].Cells[6].Value.ToString());
				factura.pagada = ((bool)ModificarFacturaGV.Rows[e.RowIndex].Cells[7].Value) ? 1 : 0;
				factura.rendida = ((bool)ModificarFacturaGV.Rows[e.RowIndex].Cells[8].Value) ? 1 : 0;
				factura.habilitada = ((bool)ModificarFacturaGV.Rows[e.RowIndex].Cells[9].Value) ? 1 : 0;
				
				DatosFactura datosFactura = new DatosFactura(factura);
				datosFactura.FormClosed += new FormClosedEventHandler(this.ModificarFactura_ModificarScreenClosedHandler);
				datosFactura.Show();
			}
		}

		private void ModificarFactura_ModificarScreenClosedHandler(object sender, FormClosedEventArgs e) {
			FiltrarButton.PerformClick();
		}


    }



}
