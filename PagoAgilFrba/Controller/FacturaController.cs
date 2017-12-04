using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
					command.Parameters["@total"].Value = factura.total;
					command.Parameters.Add("@items", SqlDbType.NVarChar);
					command.Parameters["@items"].Value = factura.items.getItemsAsStream();
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
	
	}


}
