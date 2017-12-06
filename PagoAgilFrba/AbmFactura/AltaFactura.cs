using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
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
using PagoAgilFrba.Util;
using PagoAgilFrba.Model;
using System.Data.SqlClient; 

namespace PagoAgilFrba.AbmFactura
{
    public partial class AltaFactura : Form
    {

		FacturaController facturaController;
		DataTable itemsFacturaDataTable;

        public AltaFactura()
        {
            InitializeComponent();
			this.facturaController = new FacturaController();
			this.itemsFacturaDataTable = new DataTable();
			this.itemsFacturaDataTable.Columns.Add("Precio");
			this.itemsFacturaDataTable.Columns.Add("Cantidad");
			this.ItemsFacturaGV.DataSource = itemsFacturaDataTable;
			Util.Util.addButtonColumnToGridView(
				ItemsFacturaGV,
				"Eliminar",
				new DataGridViewCellEventHandler(this.AltaFactura_EliminarItemHandler)
			);
			TotalTB.Text = "$ 0.00";
			EmpresaController empresaController = new EmpresaController();
			empresaController.getEmpresas(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {
					altaFacturaEmpresaCB.addItem(result.GetString(0), result.GetString(1));
				},

				onError = (Error error) => { 
					
				}

			}, 1);
			
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            ClienteTB.Clear();
            FacturaTB.Clear();
            AltaDP.ResetText();
            VencimientoDP.ResetText();
			itemsFacturaDataTable.Rows.Clear();
			TotalTB.Text = "$ 0.00";
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void CrearButton_Click(object sender, EventArgs e) {

			Factura factura = new Factura();
			factura.numero = Int32.Parse(FacturaTB.Text.ToString());
			factura.cliente = Int32.Parse(ClienteTB.Text.ToString());
			factura.empresa = altaFacturaEmpresaCB.getSelectedItemID();
			factura.fechaEmision = AltaDP.Value.Date;
			factura.fechaVto = VencimientoDP.Value.Date;
			foreach(DataGridViewRow row in ItemsFacturaGV.Rows) {
				Decimal precio = Decimal.Parse(row.Cells[1].Value.ToString());
				Int32 cantidad = Int32.Parse(row.Cells[2].Value.ToString());
				factura.addItem(precio, cantidad);
			}


			this.facturaController.altaFactura(new SQLResponse<Int32>() {

				onSuccess = (Int32 result) => {
					if(result == 0) {
						Util.Util.showSuccessDialog();
					}
				},

				onError = (Error error) => { 
				
				}

			}, factura);
		}


		private void agregarItemButton_Click(object sender, EventArgs e) {
			using(AltaItemFactura altaItemFactura = new AltaItemFactura()) {
				altaItemFactura.ShowDialog();
				String precio = altaItemFactura.precio;
				String cant = altaItemFactura.cantidad;

				if(altaItemFactura.DialogResult == DialogResult.OK) {
					itemsFacturaDataTable.Rows.Add(precio, cant);
				}
				
			}
		}


		private void AltaFactura_EliminarItemHandler(object sender, DataGridViewCellEventArgs e) {

			if(e.ColumnIndex == 0) {
				Decimal total = Decimal.Parse(Util.Util.getPlainTextFromCurrency(TotalTB.Text.ToString()));
				Decimal precio = Decimal.Parse(ItemsFacturaGV.Rows[e.RowIndex].Cells[1].Value.ToString());
				Int32 cant = Int32.Parse(ItemsFacturaGV.Rows[e.RowIndex].Cells[2].Value.ToString());
				total -= (precio * cant);
				TotalTB.Text = "$ " + total.ToString();
				itemsFacturaDataTable.Rows.Remove(itemsFacturaDataTable.Rows[e.RowIndex]);
			}

		}


		private void ClienteTB_KeyPress(object sender, KeyPressEventArgs e) {
			Util.Util.handleOnlyNumbersLengthInput(ClienteTB.Text, 8, e);
		}


		private void ItemsFacturaGV_ItemRemoved(object sender, DataGridViewRowsRemovedEventArgs e) { 
			
		}

		private void ItemsFacturaGV_ItemAdded(object sender, DataGridViewRowsAddedEventArgs e) {
			Decimal total = Decimal.Parse(Util.Util.getPlainTextFromCurrency(TotalTB.Text.ToString()));
			Decimal precio = Decimal.Parse(ItemsFacturaGV.Rows[e.RowIndex].Cells[1].Value.ToString());
			Int32 cant = Int32.Parse(ItemsFacturaGV.Rows[e.RowIndex].Cells[2].Value.ToString());
			total += (precio * cant);
			TotalTB.Text = "$ " + total.ToString();
		}
		


		

		


    }
}
