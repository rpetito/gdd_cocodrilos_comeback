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

namespace PagoAgilFrba.Controller
{
    class SucursalController
    {
        public void insertNewSucursal(SQLResponse<Int32> listener, String nombre, String direccion, Decimal cod_postal)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>()
            {

                getProcedureName = () => { return "ALTA_SUCURSAL"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@nombre"].Value = nombre;
                    sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@direccion"].Value = direccion;
                    sqlCommand.Parameters.Add("@cod_postal", SqlDbType.Decimal);
                    sqlCommand.Parameters["@cod_postal"].Value = cod_postal;
                },



                onReadData = (Int32 result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

                onDataProcessed = (Boolean withErrores) => { }

            });
        }

        public void removeSucursal(SQLResponse<Int32> listener, Int32 idSucursal)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>()
            {

                getProcedureName = () => { return "BAJA_SUCURSAL"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.AddWithValue("@idsucursal", idSucursal);
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
        public void filterSucursalHabilitada(SQLResponse<SqlDataReader> listener, String nombre, String direccion, String codPostal, DataGridView dgv)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "BUSCAR_SUCURSAL_HABILITADA"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@nombre"].Value = nombre;
                    }
                    if (!string.IsNullOrWhiteSpace(direccion))
                    {
                        sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@direccion"].Value = direccion;
                    }
                    if (!string.IsNullOrWhiteSpace(codPostal))
                    {
                        sqlCommand.Parameters.Add("@cod_postal", SqlDbType.Decimal);
                        sqlCommand.Parameters["@cod_postal"].Value = Convert.ToDecimal(codPostal);
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

        public void filterSucursalTotalidad(SQLResponse<SqlDataReader> listener, String nombre, String direccion, String codPostal, DataGridView dgv)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "BUSCAR_SUCURSAL_TOTALIDAD"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@nombre"].Value = nombre;
                    }
                    if (!string.IsNullOrWhiteSpace(direccion))
                    {
                        sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@direccion"].Value = direccion;
                    }
                    if (!string.IsNullOrWhiteSpace(codPostal))
                    {
                        sqlCommand.Parameters.Add("@cod_postal", SqlDbType.Decimal);
                        sqlCommand.Parameters["@cod_postal"].Value = Convert.ToDecimal(codPostal);
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

        public void modifySucursal(SQLResponse<SqlDataReader> listener, Int32 id, String nombre, String direccion, Decimal codPostal, Int32 habilitado)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
			sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "MODIFICAR_SUCURSAL"; },

                addParams = (SqlCommand sqlCommand) => {

                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@id"].Value = id;
                    sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@nombre"].Value = nombre;
                    sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@direccion"].Value = direccion;
                    sqlCommand.Parameters.Add("@cod_postal", SqlDbType.Decimal);
                    sqlCommand.Parameters["@cod_postal"].Value = codPostal;
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
    }
}
