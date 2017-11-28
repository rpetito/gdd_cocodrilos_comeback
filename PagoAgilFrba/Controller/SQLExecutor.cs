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
				SqlCommand sqlCommand = new SqlCommand();
				SqlDataReader result;

				using(sqlCommand = new SqlCommand("COCODRILOS_COMEBACK." + sqlExecutorHelper.getProcedureName(), Conexion)) {
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlExecutorHelper.addParams(sqlCommand);
				}

				result = sqlCommand.ExecuteReader();

				while(result.Read()) {
					sqlExecutorHelper.onReadData(result);
				}
				sqlExecutorHelper.onDataProcessed();
                Conexion.Close();

			} catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error");
				sqlExecutorHelper.onError(Error.errorWithMessage("Algo salio mal. Intente nuevamente"));
			}

		}


		public void executeScalarRequest(SQLExecutorHelper<Int32> sqlExecutorHelper) {
			try {
				SqlConnection Conexion = BaseDeDatos.ObternerConexion();

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
				MessageBox.Show(ex.Message, "Error");
				sqlExecutorHelper.onError(Error.errorWithMessage("Algo salio mal. Intente nuevamente"));
			}
		}

        public DataTable executeDataGridViewRequest(SQLExecutorHelper<SqlDataReader> sqlExecutorHelper, DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataReader result;

                using (sqlCommand = new SqlCommand("COCODRILOS_COMEBACK." + sqlExecutorHelper.getProcedureName(), Conexion))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlExecutorHelper.addParams(sqlCommand);
                    da.SelectCommand = sqlCommand;
                    da.Fill(dt);
                    dataGridView.DataSource = dt;
                }

                result = sqlCommand.ExecuteReader();

                while (result.Read())
                {
                    sqlExecutorHelper.onReadData(result);
                }
                sqlExecutorHelper.onDataProcessed();
                Conexion.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                sqlExecutorHelper.onError(Error.errorWithMessage("Algo salio mal. Intente nuevamente"));
                return null;
            }

        }

    }

}
