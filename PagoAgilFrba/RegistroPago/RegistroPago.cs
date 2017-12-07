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

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistroPago : Form
    {

		DataTable dataTable;
		FacturaController facturaController;
   
		public RegistroPago()
        {
			InitializeComponent();
			fillMediosPago();
			this.facturaController = new FacturaController();
			this.registroPagoTotalLabel.Text = "$ 0.00";
			this.dataTable = new DataTable();
			dataTable.Columns.Add("Numero Factura");
			dataTable.Columns.Add("Fecha Cobro");
			dataTable.Columns.Add("Fecha Vencimiento");
			dataTable.Columns.Add("Cliente");
			dataTable.Columns.Add("Empresa");
			dataTable.Columns.Add("Importe");
			dataTable.Columns.Add("Sucursal");
			dataTable.Columns.Add("Medio de Pago");
			FacturasGV.DataSource = dataTable;
        }


		private void fillMediosPago() {
			MedioPagoController controller = new MedioPagoController();
			controller.obtenerMediosDePago(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {
					medioDePagoCB.addItem(result.GetInt32(0), result.GetString(1));
				},

				onError = (Error error) => {

				}

			});
		}


        private void LimpiarButton_Click(object sender, EventArgs e)
        {
			this.Total.Text = "$ 0.00";
			this.dataTable.Rows.Clear();
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
		private void AgregarButton_Click(object sender, EventArgs e)
        {
			using(PagoAgilFrba.RegistroPago.AgregarFacturas facturas = new PagoAgilFrba.RegistroPago.AgregarFacturas()) {

				facturas.ShowDialog();

				String numeroFactura = facturas.numeroFactura;
				DateTime fechaCobro = facturas.fechaCobro;
				DateTime fechaVto = facturas.fechaVto;
				Decimal cliente = Decimal.Parse(facturas.cliente);
				String empresa = facturas.empresa;
				String importe = facturas.importe;

				//TODO cargar list de request

				if(facturas.DialogResult == DialogResult.OK) {
					dataTable.Rows.Add(numeroFactura, fechaCobro, fechaVto, cliente, empresa, importe, 1, 1);

					Decimal total = Decimal.Parse(Util.Util.getPlainTextFromCurrency(registroPagoTotalLabel.Text.ToString()));
					Decimal importeNuevo = Decimal.Parse(importe.Replace(".", ","));
					registroPagoTotalLabel.Text = "$ " + (total + importeNuevo).ToString(); 
				}

			}
        }


		private void RendirButton_Click(object sender, EventArgs e) {

			//DataTable requestTable = new DataTable();
			//Util.Util.CopyDataTable(requestTable, dataTable);
			//Util.Util.AddColumnWithValue(requestTable, "Sucursal", 1);
			//Util.Util.AddColumnWithValue(requestTable, "Medio de pago", 1);

			facturaController.registrarPago(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {
				
						Util.Util.showSuccessDialog();
						Close();
					
				},

				onError = (Error error) => { 
				
				}

			}, dataTable);
		}


    }


}
