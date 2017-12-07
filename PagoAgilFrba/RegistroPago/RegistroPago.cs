using PagoAgilFrba.Controller;
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

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistroPago : Form
    {

		DataTable dataTable;
		FacturaController facturaController;
   
		public RegistroPago()
        {
			InitializeComponent();
			this.facturaController = new FacturaController();
			this.registroPagoTotalLabel.Text = "$ 0.00";
			this.dataTable = new DataTable();
			dataTable.Columns.Add("Numero Factura");
			dataTable.Columns.Add("Fecha Cobro");
			dataTable.Columns.Add("Fecha Vencimiento");
			dataTable.Columns.Add("Cliente");
			dataTable.Columns.Add("Empresa");
			dataTable.Columns.Add("Importe");
			FacturasGV.DataSource = dataTable;
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
				String fechaCobro = facturas.fechaCobro;
				String fechaVto = facturas.fechaVto;
				String cliente = facturas.cliente;
				String empresa = facturas.empresa;
				String importe = facturas.importe;

				//TODO cargar list de request

				if(facturas.DialogResult == DialogResult.OK) {
					dataTable.Rows.Add(numeroFactura, fechaCobro, fechaVto, cliente, empresa, importe);

					Decimal total = Decimal.Parse(Util.Util.getPlainTextFromCurrency(registroPagoTotalLabel.Text.ToString()));
					Decimal importeNuevo = Decimal.Parse(importe);
					registroPagoTotalLabel.Text = "$ " + (total + importeNuevo).ToString(); 
				}

			}
        }


		private void RendirButton_Click(object sender, EventArgs e) {


			facturaController.registrarPago(new SQLResponse<Int32>() {

				onSuccess = (Int32) => {

				},

				onError = (Error error) => { 
				
				}

			}, pago);
		}


    }


}
