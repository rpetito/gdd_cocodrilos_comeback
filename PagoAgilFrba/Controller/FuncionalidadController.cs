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

	class FuncionalidadController {

		public void getAllFunctionalities(SQLResponse<SqlDataReader> listener, DataGridView dataGridView) {
			SQLExecutor sqlExecutor = new SQLExecutor();
			DataTable dataTable = sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => {
					return "OBTENER_FUNCIONALIDADES_TOTALIDAD";
				},

				addParams = (SqlCommand command) => {

				},

				onReadData = (SqlDataReader reader) => {

				},

				onDataProcessed = () => {

				},

				onError = (Error error) => { 
				
				}
			}, dataGridView);
		}


	
	}


}
