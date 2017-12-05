using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Controller {


	class FacturaController {

		public void altaFactura(SQLResponse<Int32> listener, Factura factura) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>() {

				getProcedureName = () => { return "ALTA_FACTURA"; },

				addParams = (SqlCommand command) => {
					command.Parameters.Add("@numero", SqlDbType.Decimal);
					command.Parameters["@numero"].Value = factura.numero;
					command.Parameters.Add("@cliente", SqlDbType.Decimal);
					command.Parameters["@cliente"].Value = factura.cliente;
					command.Parameters.Add("@empresa", SqlDbType.NVarChar);
					command.Parameters["@empresa"].Value = factura.empresa;
					command.Parameters.Add("@fechaEmision", SqlDbType.DateTime);
					command.Parameters["@fechaEmision"].Value = factura.fechaEmision;
					command.Parameters.Add("@fechaVto", SqlDbType.DateTime);
					command.Parameters["@fechaVto"].Value = factura.fechaVto;
					command.Parameters.Add("@total", SqlDbType.Decimal);
					command.Parameters["@total"].Value = factura.getTotal();
					command.Parameters.Add("@items", SqlDbType.NVarChar);
					command.Parameters["@items"].Value = factura.getItemsAsStream();
				},

				onReadData = (Int32 result) => {
					listener.onSuccess(result);
				},

				onDataProcessed = () => {

				},

				onError = (Error error) => { 
				
				}

			});

		}



		public void modificarFactura() { 
		
		}



		public void bajaFactura(SQLResponse<Int32> listener, String numeroFactura, String empresa) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>() {

				getProcedureName = () => { return "BAJA_FACTURA"; },

				addParams = (SqlCommand command) => {
					command.Parameters.Add("@numero", SqlDbType.Decimal);
					command.Parameters["@numero"].Value = numeroFactura;
					command.Parameters.Add("@empresa", SqlDbType.NVarChar);
					command.Parameters["@empresa"].Value = empresa;
				},

				onReadData = (Int32 result) => {
					listener.onSuccess(result);
				},

				onDataProcessed = () => {

				},

				onError = (Error error) => { 
				
				}

			});

		}



		public void obtenerFacturas(SQLResponse<SqlDataReader> listener, 
									String factura, String empresa, DataGridView gridView, 
									int pagada = -1, int rendida = -1, int habilitada = -1) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => { return "OBTENER_FACTURAS"; },

				addParams = (SqlCommand command) => {
					if(!string.IsNullOrEmpty(factura)) {
						command.Parameters.Add("@numero", SqlDbType.Decimal);
						command.Parameters["@numero"].Value = Decimal.Parse(factura);
					}
					if(!string.IsNullOrEmpty(empresa)) {
						command.Parameters.Add("@empresa", SqlDbType.NVarChar);
						command.Parameters["@empresa"].Value = empresa;
					}
					if(pagada != -1) {
						command.Parameters.Add("@pagada", SqlDbType.Bit);
						command.Parameters["@pagada"].Value = pagada;
					}
					if(rendida != -1) {
						command.Parameters.Add("@rendida", SqlDbType.Bit);
						command.Parameters["@rendida"].Value = rendida;
					}
					if(habilitada != -1) {
						command.Parameters.Add("@habilitada", SqlDbType.Bit);
						command.Parameters["@habilitada"].Value = habilitada;
					}
				},

				onReadData = (SqlDataReader result) => {

				},

				onDataProcessed = () => {
					listener.onSuccess(null);
				},

				onError = (Error error) => { 
				
				}

			}, gridView);

			
		}


	
	}


}
