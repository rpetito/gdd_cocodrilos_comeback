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

	 class SQLExecutor {


		public void executeReaderRequest(SQLExecutorHelper<SqlDataReader> sqlExecutorHelper) {

			try {
				SqlConnection Conexion = BaseDeDatos.ObternerConexion();
				SqlCommand loginUsuario = new SqlCommand();
				SqlDataReader result;

				using(loginUsuario = new SqlCommand("COCODRILOS_COMEBACK." + sqlExecutorHelper.getProcedureName(), Conexion)) {
					loginUsuario.CommandType = CommandType.StoredProcedure;
					sqlExecutorHelper.addParams(loginUsuario);
				}

				result = loginUsuario.ExecuteReader();

				while(result.Read()) {
					sqlExecutorHelper.onReadData(result);
				}
				sqlExecutorHelper.onDataProcessed();
				Conexion.Close();

			} catch(Exception ex) {
				sqlExecutorHelper.onError(Error.errorWithMessage("Algo salio mal. Intente nuevamente"));
			}

		}


		public void executeScalarRequest(SQLExecutorHelper<Int32> sqlExecutorHelper) {
			try {
				SqlConnection Conexion = BaseDeDatos.ObternerConexion();
				MessageBox.Show("estamos conectados");
				SqlCommand sqlCommand = new SqlCommand();
				Int32 result;

				using(sqlCommand = new SqlCommand("COCODRILOS_COMEBACK." + sqlExecutorHelper.getProcedureName(), Conexion)) {
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlExecutorHelper.addParams(sqlCommand);
				}

				result = (Int32) sqlCommand.ExecuteScalar();
				sqlExecutorHelper.onReadData(result);
				Conexion.Close();

			} catch(Exception ex) {
				sqlExecutorHelper.onError(Error.errorWithMessage("Algo salio mal. Intente nuevamente"));
				MessageBox.Show(ex.ToString(), "Algo salio mal. Intente nuevamente.");
			}
		}



	 }


	




}
