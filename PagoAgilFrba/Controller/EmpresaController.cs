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

        public void insertNewEmpresa(SQLResponse<Int32> listener, String cuit, String nombre, String direccion, Decimal rubro)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>()
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
                },



                onReadData = (Int32 result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

                onDataProcessed = () => { }

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

                },

                onError = (Error error) => {

                },

                onDataProcessed = () => {

                    foreach (KeyValuePair<Decimal, String> item in dict)
                    {
                        comboBox.Items.Add(item.Value);
                    }

                }

            });
        }

        public void filterEmpresa(SQLResponse<SqlDataReader> listener, String cuit, String nombre, Decimal rubro, DataGridView dgv)
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
                    
                },



                onReadData = (SqlDataReader result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

                onDataProcessed = () => {

                }

            }, dgv);

        }


        public void removeEmpresa(SQLResponse<Int32> listener, String cuit)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>()
            {

                getProcedureName = () => { return "BAJA_EMPRESA"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.AddWithValue("@cuit", cuit);
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
