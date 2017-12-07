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
    public partial class AgregarFacturas : Form
    {

		public String numeroFactura;
		public DateTime fechaVto;
		public DateTime fechaCobro;
		public String cliente;
		public String empresa;
		public String importe;


		EmpresaController empresaController = new EmpresaController();
		FacturaController facturaController = new FacturaController();

        public AgregarFacturas()
        {
            InitializeComponent();
			fillEmpresas();

        }


		private void fillEmpresas() {
			empresaController.getEmpresas(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {
					agregarFacturaEmpresaTB.addItem(result.GetString(0), result.GetString(1));
				},

				onError = (Error error) => {

				}

			}, 1);
		}


		




        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NumFacturaTB.Clear();
            FecCobroDP.ResetText();
            ClienteTB.Clear();
			agregarFacturaEmpresaTB.clearAll();
            FecVencimientoDP.ResetText();
            ImporteTB.Clear();
        }



        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		private void AgregarButton_Click(object sender, EventArgs e) {

			cliente = ClienteTB.Text.ToString();
			fechaVto = FecVencimientoDP.Value.Date;
			fechaCobro = FecCobroDP.Value.Date;
			numeroFactura = NumFacturaTB.Text.ToString();
			empresa = agregarFacturaEmpresaTB.getSelectedItemID();
			importe = ImporteTB.Text.ToString();
			DialogResult = DialogResult.OK;
			Close();
		}

		


		

    
    

    }


}
