using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoAgilFrba.Model;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Util;

namespace PagoAgilFrba.Controller
{
    class RendicionController
    {

        public DataTable getFacturasMes(SQLResponse<SqlDataReader> listener, String empresa, Int32 mes, DataGridView dataGridView)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            DataTable dt = sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () =>
                {
                    return "OBTENER_FACTURAS_MES";
                },

                addParams = (SqlCommand command) =>
                {
                    command.Parameters.Add("@empresa", SqlDbType.NVarChar);
                    command.Parameters["@empresa"].Value = empresa;
                    command.Parameters.Add("@mes", SqlDbType.Int);
                    command.Parameters["@mes"].Value = mes;
                },

                onReadData = (SqlDataReader reader) =>
                {

                },

				onDataProcessed = (Boolean withErrores) =>
                {

                },

                onError = (Error error) =>
                {

                }
            }, dataGridView);
            return dt;
        }

        public void rendir(SQLResponse<Int32> listener, Int32 cantidadFacturas, DateTime fechaRendicion, Decimal importeBruto, Decimal importeNeto, Decimal importeComision, Decimal porcentajeComision, String empresa, Int32 mes)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>()
            {

                getProcedureName = () => { return "RENDICION"; },

                addParams = (SqlCommand sqlCommand) =>
                {
                    sqlCommand.Parameters.Add("@cant_facturas", SqlDbType.Int);
                    sqlCommand.Parameters["@cant_facturas"].Value = cantidadFacturas;
                    sqlCommand.Parameters.Add("@fecha_rendicion", SqlDbType.DateTime);
                    sqlCommand.Parameters["@fecha_rendicion"].Value = fechaRendicion;
                    sqlCommand.Parameters.Add("@importe_bruto", SqlDbType.Decimal);
                    sqlCommand.Parameters["@importe_bruto"].Value = importeBruto;
                    sqlCommand.Parameters.Add("@importe_neto", SqlDbType.Decimal);
                    sqlCommand.Parameters["@importe_neto"].Value = importeNeto;
                    sqlCommand.Parameters.Add("@importe_comision", SqlDbType.Decimal);
                    sqlCommand.Parameters["@importe_comision"].Value = importeComision;
                    sqlCommand.Parameters.Add("@porcentaje_comision", SqlDbType.Decimal);
                    sqlCommand.Parameters["@porcentaje_comision"].Value = porcentajeComision;
                    sqlCommand.Parameters.Add("@rendicion_empresa", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@rendicion_empresa"].Value = empresa;
                    sqlCommand.Parameters.Add("@mes_rendicion", SqlDbType.Int);
                    sqlCommand.Parameters["@mes_rendicion"].Value = mes;
                },

                onReadData = (Int32 result) =>
                {
                    listener.onSuccess(result);
                },

                onError = (Error error) =>
                {
                },

				onDataProcessed = (Boolean withErrores) =>
                {

                }

            });

        }
    }
}