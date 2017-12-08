using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
using System.Data;
using System.Data.SqlClient;
using PagoAgilFrba.Util;
using System.Windows.Forms;

namespace PagoAgilFrba.Controller
{
    class EmpresaController
    {

        public void insertNewEmpresa(SQLResponse<SqlDataReader> listener, String cuit, String nombre, String direccion, Decimal rubro, Int32 diaRendicion)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "ALTA_EMPRESA"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.Add("@cuit", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@cuit"].Value = cuit;
                    sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@nombre"].Value = nombre;
                    sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@direccion"].Value = direccion;
                    sqlCommand.Parameters.Add("@rubro", SqlDbType.Decimal);
                    sqlCommand.Parameters["@rubro"].Value = rubro;
                    sqlCommand.Parameters.Add("@diaRendicion", SqlDbType.Int);
                    sqlCommand.Parameters["@diaRendicion"].Value = diaRendicion;
                },



                onReadData = (SqlDataReader result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

				onDataProcessed = (Boolean withErrores) => {
					listener.onFinish(withErrores);
				}

            });
        }

        public void fillRubros(SQLResponse<SqlDataReader> listener, Dictionary<Decimal, String> dict, ComboBox comboBox)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "OBTENER_RUBROS"; },

                addParams = (SqlCommand sqlCommand) => { },

                onReadData = (SqlDataReader result) => {

					dict.Add(result.GetDecimal(0), (result.GetString(1)));
					comboBox.Items.Add(result.GetString(1));

                },

                onError = (Error error) => {

                },

				onDataProcessed = (Boolean withErrores) => {

                }

            });
        }

        public void filterEmpresaHabilitada(SQLResponse<SqlDataReader> listener, String cuit, String nombre, Decimal rubro, DataGridView dgv)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "BUSCAR_EMPRESA"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!string.IsNullOrWhiteSpace(cuit))
                    {
                        sqlCommand.Parameters.Add("@cuit", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@cuit"].Value = cuit;
                    }
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@nombre"].Value = nombre;
                    }
                    
                    sqlCommand.Parameters.Add("@rubro", SqlDbType.Decimal);
                    sqlCommand.Parameters["@rubro"].Value = Convert.ToDecimal(rubro);

					sqlCommand.Parameters.Add("@habilitada", SqlDbType.Bit);
					sqlCommand.Parameters["@habilitada"].Value = 1;
                    
                },



                onReadData = (SqlDataReader result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

				onDataProcessed = (Boolean withErrores) => {

                }

            }, dgv);

        }

        public void filterEmpresaTotalidad(SQLResponse<SqlDataReader> listener, String cuit, String nombre, Decimal rubro, DataGridView dgv)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "BUSCAR_EMPRESA"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!string.IsNullOrWhiteSpace(cuit))
                    {
                        sqlCommand.Parameters.Add("@cuit", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@cuit"].Value = cuit;
                    }
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@nombre"].Value = nombre;
                    }
					if(rubro != 0) {
						sqlCommand.Parameters.Add("@rubro", SqlDbType.Decimal);
						sqlCommand.Parameters["@rubro"].Value = Convert.ToDecimal(rubro);
					}

                },



                onReadData = (SqlDataReader result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

				onDataProcessed = (Boolean withErrores) => {

                }

            }, dgv);

        }

        public void removeEmpresa(SQLResponse<SqlDataReader> listener, String cuit)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "BAJA_EMPRESA"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.AddWithValue("@cuit", cuit);
                },

                onReadData = (SqlDataReader result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

				onDataProcessed = (Boolean withErrores) => {
					listener.onFinish(withErrores);
                }
            });

        }

        public void modifyEmpresa(SQLResponse<SqlDataReader> listener, String oldCuit, String newCuit, String nombre, String direccion, Int32 fecRendicion, Decimal rubro, Int32 habilitado)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "MODIFICAR_EMPRESA"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.Add("@oldCuit", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@oldCuit"].Value = oldCuit;
                    sqlCommand.Parameters.Add("@newCuit", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@newCuit"].Value = newCuit;
                    sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@nombre"].Value = nombre;
                    sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@direccion"].Value = direccion;
                    sqlCommand.Parameters.Add("@fecRendicion", SqlDbType.Int);
                    sqlCommand.Parameters["@fecRendicion"].Value = fecRendicion;
                    sqlCommand.Parameters.Add("@rubro", SqlDbType.Decimal);
                    sqlCommand.Parameters["@rubro"].Value = rubro;
                    sqlCommand.Parameters.Add("@habilitado", SqlDbType.Bit);
                    sqlCommand.Parameters["@habilitado"].Value = habilitado;
                },



                onReadData = (SqlDataReader result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

				onDataProcessed = (Boolean withErrores) => {
					listener.onFinish(withErrores);
				}

            });
        }


		public void getEmpresas(SQLResponse<SqlDataReader> listener, Int32 habilitado = -1) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => { return "OBTENER_EMPRESAS"; },

				addParams = (SqlCommand command) => {
					if(habilitado != -1) {
						command.Parameters.Add("@habilitada", SqlDbType.Bit);
						command.Parameters["@habilitada"].Value = habilitado;
					}
				},

				onReadData = (SqlDataReader result) => {
					listener.onSuccess(result);
				},

				onDataProcessed = (Boolean withErrores) => {

				},

				onError = (Error error) => { 
				
				}

			});

		}


    }
}
