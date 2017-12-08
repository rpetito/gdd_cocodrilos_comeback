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

				onDataProcessed = (Boolean withErrores) => { }

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

				onDataProcessed = (Boolean withErrores) => {
					
				}

			});

		}


		public void bajaRol(SQLResponse<Int32> listener, Int32 rol) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>() {

				getProcedureName = () => { return "BAJA_ROL"; },

				addParams = (SqlCommand sqlCommand) => {
					sqlCommand.Parameters.Add("@rolID", SqlDbType.Int);
					sqlCommand.Parameters["@rolID"].Value = rol;
				},

				onReadData = (Int32 result) => {
					listener.onSuccess(result);
				},

				onError = (Error error) => {
				},

				onDataProcessed = (Boolean withErrores) => {

				}

			});

		}


		public void getAllRoles(SQLResponse<SqlDataReader> listener, DataGridView gridView) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => { return "OBTENER_ROLES"; },

				addParams = (SqlCommand sqlCommand) => {
					sqlCommand.Parameters.Add("@habilitado", SqlDbType.Bit);
					sqlCommand.Parameters["@habilitado"].Value = 0;
				},

				onReadData = (SqlDataReader result) => {
					listener.onSuccess(result);
				},

				onError = (Error error) => {
				},

				onDataProcessed = (Boolean withErrores) => {

				}

			}, gridView);

		}


		public void getAvailableRoles(SQLResponse<SqlDataReader> listener, DataGridView gridView) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => { return "OBTENER_ROLES"; },

				addParams = (SqlCommand sqlCommand) => {

				},

				onReadData = (SqlDataReader result) => {
					listener.onSuccess(result);
				},

				onError = (Error error) => {
				},

				onDataProcessed = (Boolean withErrores) => {

				}

			}, gridView);

		}


		public void getAvailableRolByName(SQLResponse<SqlDataReader> listener, String name, DataGridView gridView) {

			SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>() {

				getProcedureName = () => { return "OBTENER_ROLES"; },

				addParams = (SqlCommand sqlCommand) => {
					if(!string.IsNullOrWhiteSpace(name)) {
						sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
						sqlCommand.Parameters["@nombre"].Value = name;
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

			}, gridView);

		}

        public void getAllRolByName(SQLResponse<SqlDataReader> listener, String name, DataGridView gridView)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "OBTENER_ROLES"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!name.Equals(""))
                    {
                        sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@nombre"].Value = name;
                    }
                },

                onReadData = (SqlDataReader result) => {
                    listener.onSuccess(result);
                },

                onError = (Error error) => {
                },

				onDataProcessed = (Boolean withErrores) => {

                }

            }, gridView);

        }

        public void obtenerFuncionalidades(SQLResponse<SqlDataReader> listener, Int32 idRol, RolRequest rolRequest)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {
                getProcedureName = () => { return "OBTENER_FUNCIONALIDADES_ROL"; },

                addParams = (SqlCommand sqlCommand) =>
                {
                    sqlCommand.Parameters.Add("@idRol", SqlDbType.Int);
                    sqlCommand.Parameters["@idRol"].Value = idRol;
                },

                onReadData = (SqlDataReader result) =>
                {
                    //rolRequest.addFuncionalidad(Convert.ToInt32(result[0]));
                    Rol.getInstance().addFuncionalidad(Convert.ToInt32(result[0]));
                },

                onError = (Error error) =>
                {
                },

				onDataProcessed = (Boolean withErrores) =>
                {

                }

            });
        }

        public void modifyRol(SQLResponse<Int32> listener, Int32 idRol, String descripcion, String funcionalities, Int32 habilitado)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>()
            {

                getProcedureName = () => { return "MODIFICAR_ROL"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!idRol.Equals(""))
                    {
                        sqlCommand.Parameters.Add("@idRol", SqlDbType.Int);
                        sqlCommand.Parameters["@idRol"].Value = idRol;
                    }
                    if (!descripcion.Equals(""))
                    {
                        sqlCommand.Parameters.Add("@descripcion", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@descripcion"].Value = descripcion;
                    }
                    if (!funcionalities.Equals(""))
                    {
                        sqlCommand.Parameters.Add("@funcionalities", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@funcionalities"].Value = funcionalities;
                    }
                    if (!habilitado.Equals(""))
                    {
                        sqlCommand.Parameters.Add("@habilitado", SqlDbType.Bit);
                        sqlCommand.Parameters["@habilitado"].Value = habilitado;
                    }
                },

                onReadData = (Int32 result) => {
                    listener.onSuccess(result);
                },

                onError = (Error error) => {
                },

				onDataProcessed = (Boolean withErrores) => {

                }

            });

        }


    }


}
