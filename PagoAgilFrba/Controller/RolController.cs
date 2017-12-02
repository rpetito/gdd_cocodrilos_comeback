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


	class RolController {

		public void getAvailableFunctionalities(SQLResponse<SqlDataReader> listener, int rolID)  {
			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => { return "FUNCIONALIDADES_ROL"; },

				addParams = (SqlCommand sqlCommand) => {
					sqlCommand.Parameters.Add("@rol", SqlDbType.Int);
					sqlCommand.Parameters["@rol"].Value = rolID;
				},

				onReadData = (SqlDataReader result) => {
					if(result.VisibleFieldCount == 2) {
						listener.onSuccess(result);
					} else {
						listener.onError(Error.errorWithMessage("Algo ha ocurrido. Por favor vuelva a intentar."));
					}
				},

				onError = (Error error) => {
				},

				onDataProcessed = () => {}

			});
		}



		public void createRol(SQLResponse<Int32> listener, RolRequest rol) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>() {

				getProcedureName = () => { return "ALTA_ROL"; },

				addParams = (SqlCommand sqlCommand) => {
					sqlCommand.Parameters.Add("@descripcion", SqlDbType.NVarChar);
					sqlCommand.Parameters["@descripcion"].Value = rol.descripcion;
					sqlCommand.Parameters.Add("@funcionalities", SqlDbType.NVarChar);
					sqlCommand.Parameters["@funcionalities"].Value = rol.funcionalidades;
				},

				onReadData = (Int32 result) => {
					listener.onSuccess(result);
				},

				onError = (Error error) => {
				},

				onDataProcessed = () => {
					
				}

			});

		}


	}




}
