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
    class DevolucionController
    {
        public void filterFacturasPagas(SQLResponse<SqlDataReader> listener, String factura, String cliente, String empresa, DataGridView dgv)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "OBTENER_FACTURAS_PAGAS"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!string.IsNullOrWhiteSpace(factura))
                    {
                        sqlCommand.Parameters.Add("@factura", SqlDbType.Decimal);
                        sqlCommand.Parameters["@factura"].Value = Convert.ToDecimal(factura);
                    }
                    if (!string.IsNullOrWhiteSpace(cliente))
                    {
                        sqlCommand.Parameters.Add("@cliete", SqlDbType.Decimal);
                        sqlCommand.Parameters["@cliente"].Value = Convert.ToDecimal(cliente);
                    }
                    if (!string.IsNullOrWhiteSpace(empresa))
                    {
                        sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@empresa"].Value = empresa;
                    }
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

        public void hacerDevolucion(SQLResponse<Int32> listener, String factura, String cliente, String empresa, String motivo)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>()
            {
                /*
                 * TODO: hacer el insert en la tabla devolucion y ver como afecta a Facturas
                 */
                getProcedureName = () => { return "HACER_DEVOLUCION"; },

                addParams = (SqlCommand sqlCommand) => {
                    if (!string.IsNullOrWhiteSpace(factura))
                    {
                        sqlCommand.Parameters.Add("@factura", SqlDbType.Decimal);
                        sqlCommand.Parameters["@factura"].Value = Convert.ToDecimal(factura);
                    }
                    if (!string.IsNullOrWhiteSpace(cliente))
                    {
                        sqlCommand.Parameters.Add("@cliete", SqlDbType.Decimal);
                        sqlCommand.Parameters["@cliente"].Value = Convert.ToDecimal(cliente);
                    }
                    if (!string.IsNullOrWhiteSpace(empresa))
                    {
                        sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@empresa"].Value = empresa;
                    }
                    if (!string.IsNullOrWhiteSpace(motivo))
                    {
                        sqlCommand.Parameters.Add("@motivo", SqlDbType.NVarChar);
                        sqlCommand.Parameters["@motivo"].Value = empresa;
                    }
                },



                onReadData = (Int32 result) => {

                    listener.onSuccess(result);

                },

                onError = (Error error) => {

                },

                onDataProcessed = () => { }

            });
        }
    }
}
