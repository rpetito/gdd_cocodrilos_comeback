using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Util;
using System.Data.SqlClient;
using System.Data;
using PagoAgilFrba.Model;
using System.Windows.Forms;


namespace PagoAgilFrba.Controller
{
    class ClienteController
    {

        public void insertNewClient(SQLResponse<SqlDataReader> listener, decimal dni, string nombre, string apellido, DateTime fecha_nac, string mail, string direccion, string telefono,  int piso, string dpto, string localidad, string cod_postal)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "ALTA_CLIENTE"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.Add("@dni", SqlDbType.Decimal);
                    sqlCommand.Parameters["@dni"].Value = dni;
                    sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@nombre"].Value = nombre;
                    sqlCommand.Parameters.Add("@apellido", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@apellido"].Value = apellido;
                    sqlCommand.Parameters.Add("@fecha_nac", SqlDbType.DateTime);
                    sqlCommand.Parameters["@fecha_nac"].Value = fecha_nac;
                    sqlCommand.Parameters.Add("@mail", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@mail"].Value = mail;
                    sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@direccion"].Value = direccion;
                    sqlCommand.Parameters.Add("@telefono", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@telefono"].Value = telefono;
                    sqlCommand.Parameters.Add("@piso", SqlDbType.Int);
                    sqlCommand.Parameters["@piso"].Value = piso;
                    sqlCommand.Parameters.Add("@dpto", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@dpto"].Value = dpto;
                    sqlCommand.Parameters.Add("@localidad", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@localidad"].Value = localidad;
                    sqlCommand.Parameters.Add("@cod_postal", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@cod_postal"].Value = cod_postal;
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


		public void removeClient(SQLResponse<SqlDataReader> listener, Decimal dni) {
			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => { return "BAJA_CLIENTE"; },

				addParams = (SqlCommand sqlCommand) => {
					sqlCommand.Parameters.AddWithValue("@dni", dni);
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
		


        public void filterClientHabilitado(SQLResponse<SqlDataReader> listener, String nombre, String apellido, String dni, DataGridView dgv)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "BUSCAR_CLIENTE"; },

                addParams = (SqlCommand sqlCommand) => {
					if(!string.IsNullOrWhiteSpace(nombre)) {
						sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
						sqlCommand.Parameters["@nombre"].Value = nombre;
					}
					if(!string.IsNullOrWhiteSpace(apellido)) {
						sqlCommand.Parameters.Add("@apellido", SqlDbType.NVarChar);
						sqlCommand.Parameters["@apellido"].Value = apellido;
					}
					if(!string.IsNullOrWhiteSpace(dni)) {
						sqlCommand.Parameters.Add("@dni", SqlDbType.Decimal);
						sqlCommand.Parameters["@dni"].Value = Convert.ToDecimal(dni);
					}
					sqlCommand.Parameters.Add("@habilitado", SqlDbType.Bit);
					sqlCommand.Parameters["@habilitado"].Value = 1;
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

		public void modifyClient(SQLResponse<SqlDataReader> listener, decimal oldDNI, decimal newDNI, string nombre, string apellido, DateTime fecha_nac, string mail, string direccion, string telefono, int piso, string dpto, string localidad, string cod_postal, Int32 habilitado)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "MODIFICAR_CLIENTE"; },

				addParams = (SqlCommand sqlCommand) => {
					sqlCommand.Parameters.Add("@oldDni", SqlDbType.Decimal);
					sqlCommand.Parameters["@oldDni"].Value = oldDNI;
                    sqlCommand.Parameters.Add("@newDni", SqlDbType.Decimal);
					sqlCommand.Parameters["@newDni"].Value = newDNI;
                    sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@nombre"].Value = nombre;
                    sqlCommand.Parameters.Add("@apellido", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@apellido"].Value = apellido;
                    sqlCommand.Parameters.Add("@fecha_nac", SqlDbType.DateTime);
                    sqlCommand.Parameters["@fecha_nac"].Value = fecha_nac;
                    sqlCommand.Parameters.Add("@mail", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@mail"].Value = mail;
                    sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@direccion"].Value = direccion;
                    sqlCommand.Parameters.Add("@telefono", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@telefono"].Value = telefono;
                    sqlCommand.Parameters.Add("@piso", SqlDbType.Int);
                    sqlCommand.Parameters["@piso"].Value = piso;
                    sqlCommand.Parameters.Add("@dpto", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@dpto"].Value = dpto;
                    sqlCommand.Parameters.Add("@localidad", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@localidad"].Value = localidad;
                    sqlCommand.Parameters.Add("@cod_postal", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@cod_postal"].Value = cod_postal;
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

        public void filterClientTotalidad(SQLResponse<SqlDataReader> listener, String nombre, String apellido, String dni, DataGridView dgv)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "BUSCAR_CLIENTE"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@nombre"].Value = nombre;
                    }
                    if (!string.IsNullOrWhiteSpace(apellido))
                    {
                        sqlCommand.Parameters.Add("@apellido", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@apellido"].Value = apellido;
                    }
                    if (!string.IsNullOrWhiteSpace(dni))
                    {
                        sqlCommand.Parameters.Add("@dni", SqlDbType.Decimal);
                        sqlCommand.Parameters["@dni"].Value = Convert.ToDecimal(dni);
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

    }
}
