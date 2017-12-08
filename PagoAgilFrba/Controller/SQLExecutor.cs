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

				bool firstTime = true;
				bool withErrores = false;
				String message = "";

				SqlConnection Conexion = BaseDeDatos.ObternerConexion();
				SqlCommand sqlCommand = new SqlCommand();
				SqlDataReader result;

				using(sqlCommand = new SqlCommand("COCODRILOS_COMEBACK." + sqlExecutorHelper.getProcedureName(), Conexion)) {
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlExecutorHelper.addParams(sqlCommand);
				}

				result = sqlCommand.ExecuteReader();

				while(result.Read()) {
					try {
						if(firstTime) {
							if(result.GetString(0).Equals("Errores")) {
								withErrores = true;
							}
							firstTime = false;
						} else if(withErrores) {
							message += result.GetString(0) + '\n';
						} else {
							sqlExecutorHelper.onReadData(result);
						}
					} catch(Exception e) {
						firstTime = false;
						sqlExecutorHelper.onReadData(result);
					}
				}
				if(withErrores) {
					MessageBox.Show(message);
				}
				sqlExecutorHelper.onDataProcessed(withErrores);
                Conexion.Close();

			} catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error");
				sqlExecutorHelper.onError(Error.errorWithMessage(ex.Message));
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
				sqlExecutorHelper.onError(Error.errorWithMessage(ex.Message));
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
                sqlExecutorHelper.onDataProcessed(true);
                Conexion.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                sqlExecutorHelper.onError(Error.errorWithMessage(ex.Message));
                return null;
            }

        }

    }

}
