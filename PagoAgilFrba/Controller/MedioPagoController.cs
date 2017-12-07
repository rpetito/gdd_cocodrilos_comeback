using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Controller {

	class MedioPagoController {

		public void obtenerMediosDePago(SQLResponse<SqlDataReader> listener) {

			SQLExecutor executor = new SQLExecutor();
			executor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => { return "OBTENER_MEDIOS_PAGO"; },

				addParams = (SqlCommand command) => {

				},

				onReadData = (SqlDataReader result) => {
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
