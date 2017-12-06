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

		EmpresaController empresaController = new EmpresaController();
		FacturaController facturaController = new FacturaController();

        public AgregarFacturas()
        {
            InitializeComponent();
			empresaController.getEmpresas(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {
					agregarFacturaPagoEmpresaCB.addItem(result.GetString(0), result.GetString(1));
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
			agregarFacturaPagoEmpresaCB.clear();
            FecVencimientoDP.ResetText();
            ImporteTB.Clear();
        }



        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		private void AgregarButton_Click(object sender, EventArgs e) {
			
			if(!facturaVencida()) { 
			
			}

		}



		private Boolean facturaVencida() {
			return false;
		}

    
    

    }


}
