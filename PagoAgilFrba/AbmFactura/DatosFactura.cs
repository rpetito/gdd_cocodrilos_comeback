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
    public partial class DatosFactura : Form
    {

		Factura factura;
		FacturaController facturaController;

        public DatosFactura(Factura factura)
        {
            InitializeComponent();
			this.factura = factura;
			this.facturaController = new FacturaController();
			/*this.itemsFacturaDataTable = new DataTable();
			this.itemsFacturaDataTable.Columns.Add("Id");
			this.itemsFacturaDataTable.Columns.Add("Precio");
			this.itemsFacturaDataTable.Columns.Add("Cantidad");
			this.ItemsFacturaGV.DataSource = itemsFacturaDataTable;
			Util.Util.addButtonColumnToGridView(ItemsFacturaGV, "Modificar");
			 * */

			setData();
			
        }


		private void setData() {
						
			facturaController.getItemsFactura(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {
					if(ItemsFacturaGV.Columns.Count == 3) {
						Util.Util.addButtonColumnToGridView(ItemsFacturaGV, "Modificar");
					}
				},

				onError = (Error error) => { 
				
				}

			}, factura.numero, factura.empresa, ItemsFacturaGV);

			foreach(DataGridViewRow row in ItemsFacturaGV.Rows) {
				factura.addItem(
					Int32.Parse(row.Cells[0].Value.ToString()), 
					Decimal.Parse(row.Cells[1].Value.ToString()), 
					Int32.Parse(row.Cells[2].Value.ToString())
				);
			}

			FacturaTB.Text = factura.numero.ToString();
			DatosFacturaEmpresaTB.Text = factura.empresa.ToString();
			ClienteTB.Text = factura.cliente.ToString();
			AltaDP.Text = factura.fechaEmision.ToShortDateString();
			VencimientoDP.Text = factura.fechaEmision.ToShortDateString();
			DatosFacturaPagadaCheckBox.Checked = factura.pagada == 1 ? true : false;
			DatosFacturaRendidaCheckbox.Checked = factura.rendida == 1 ? true : false;
			DatosFacturaTotalLabel.Text = "$ " + factura.total.ToString();
			DatosFacturaHabilitadaCheckbox.Checked = factura.habilitada == 1 ? true : false;
		}


        private void LimpiarButton_Click(object sender, EventArgs e)
        {
			setData();
			
        }


		private void ModificarButton_Click(object sender, EventArgs e) {
			Factura nuevaFactura = new Factura();
			nuevaFactura.numero = factura.numero;
			nuevaFactura.empresa = factura.empresa;
			nuevaFactura.cliente = Int32.Parse(ClienteTB.Text.ToString());
			nuevaFactura.fechaEmision = AltaDP.Value.Date;
			nuevaFactura.fechaVto = VencimientoDP.Value.Date;
			nuevaFactura.habilitada = DatosFacturaHabilitadaCheckbox.Checked ? 1 : 0;
			nuevaFactura.pagada = DatosFacturaPagadaCheckBox.Checked ? 1 : 0;
			nuevaFactura.rendida = DatosFacturaRendidaCheckbox.Checked ? 1 : 0;
			foreach(DataGridViewRow row in ItemsFacturaGV.Rows) {
				Int32 id = Int32.Parse(row.Cells[1].Value.ToString());
				Decimal precio = Decimal.Parse(row.Cells[2].Value.ToString());
				Int32 cantidad = Int32.Parse(row.Cells[3].Value.ToString());
				nuevaFactura.addItem(id, precio, cantidad);
			}
			this.facturaController.modificarFactura(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {
					
				},

				onError = (Error erro) => { 
				
				},

				onFinish = (Boolean withError) => {
					if(!withError) {
						Util.Util.showSuccessDialog();
						Close();
					}
				}
			},
			nuevaFactura);
		}


		private void cellClickHandler(object sender, DataGridViewCellEventArgs e) {
			if(e.ColumnIndex == 0) {
				using(AltaItemFactura altaItemFactura = new AltaItemFactura()) {
					altaItemFactura.ShowDialog();
					String precio = altaItemFactura.precio;
					String cant = altaItemFactura.cantidad;

					if(altaItemFactura.DialogResult == DialogResult.OK) {
						ItemsFacturaGV.Rows[e.RowIndex].Cells[2].Value = precio;
						ItemsFacturaGV.Rows[e.RowIndex].Cells[3].Value = cant;
						Decimal total = 0;
						foreach(DataGridViewRow row in ItemsFacturaGV.Rows) {
							Decimal precioRow = Decimal.Parse(row.Cells[2].Value.ToString());
							Int32 cantRow = Int32.Parse(row.Cells[3].Value.ToString());
							total = total + (precioRow * cantRow);
							DatosFacturaTotalLabel.Text = "$ " + total.ToString();
						}
					}
				}
			}
		}

		


    }


}
