using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PagoAgilFrba.Controller
{
    class EstadisticoController
    {

        public void porcentajeFacturasCobradas(SQLResponse<SqlDataReader> listener, Int32 anio, Int32 trimestre, DataGridView dgv)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "PORCENTAJE_FACTURAS_COBRADAS"; },

                addParams = (SqlCommand sqlCommand) =>
                {
                    if (!string.IsNullOrWhiteSpace(anio.ToString()))
                    {
                        sqlCommand.Parameters.Add("@anio", SqlDbType.Int);
                        sqlCommand.Parameters["@anio"].Value = anio;
                    }
                    if (!string.IsNullOrWhiteSpace(trimestre.ToString()))
                    {
                        sqlCommand.Parameters.Add("@trimestre", SqlDbType.Int);
                        sqlCommand.Parameters["@trimestre"].Value = trimestre;
                    }
                },



                onReadData = (SqlDataReader result) =>
                {

                    listener.onSuccess(result);

                },

                onError = (Error error) =>
                {

                },

                onDataProcessed = () =>
                {

                }

            }, dgv);

        }

        public void empresasMayorMontoRend(SQLResponse<SqlDataReader> listener, Int32 anio, Int32 trimestre, DataGridView dgv)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "EMPRESAS_MAYOR_MONTO_RENDIDO"; },

                addParams = (SqlCommand sqlCommand) =>
                {
                    if (!string.IsNullOrWhiteSpace(anio.ToString()))
                    {
                        sqlCommand.Parameters.Add("@anio", SqlDbType.Int);
                        sqlCommand.Parameters["@anio"].Value = anio;
                    }
                    if (!string.IsNullOrWhiteSpace(trimestre.ToString()))
                    {
                        sqlCommand.Parameters.Add("@trimestre", SqlDbType.Int);
                        sqlCommand.Parameters["@trimestre"].Value = trimestre;
                    }
                },



                onReadData = (SqlDataReader result) =>
                {

                    listener.onSuccess(result);

                },

                onError = (Error error) =>
                {

                },

                onDataProcessed = () =>
                {

                }

            }, dgv);

        }

        public void clienteMasPagos(SQLResponse<SqlDataReader> listener, Int32 anio, Int32 trimestre, DataGridView dgv)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "CLIENTE_MAS_PAGOS"; },

                addParams = (SqlCommand sqlCommand) =>
                {
                    if (!string.IsNullOrWhiteSpace(anio.ToString()))
                    {
                        sqlCommand.Parameters.Add("@anio", SqlDbType.Int);
                        sqlCommand.Parameters["@anio"].Value = anio;
                    }
                    if (!string.IsNullOrWhiteSpace(trimestre.ToString()))
                    {
                        sqlCommand.Parameters.Add("@trimestre", SqlDbType.Int);
                        sqlCommand.Parameters["@trimestre"].Value = trimestre;
                    }
                },



                onReadData = (SqlDataReader result) =>
                {

                    listener.onSuccess(result);

                },

                onError = (Error error) =>
                {

                },

                onDataProcessed = () =>
                {

                }

            }, dgv);

        }

        public void clienteMayorPorcentajePagas(SQLResponse<SqlDataReader> listener, Int32 anio, Int32 trimestre, DataGridView dgv)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "CLIENTE_MAYOR_PORCENTAJE_PAGAS"; },

                addParams = (SqlCommand sqlCommand) =>
                {
                    if (!string.IsNullOrWhiteSpace(anio.ToString()))
                    {
                        sqlCommand.Parameters.Add("@anio", SqlDbType.Int);
                        sqlCommand.Parameters["@anio"].Value = anio;
                    }
                    if (!string.IsNullOrWhiteSpace(trimestre.ToString()))
                    {
                        sqlCommand.Parameters.Add("@trimestre", SqlDbType.Int);
                        sqlCommand.Parameters["@trimestre"].Value = trimestre;
                    }
                },



                onReadData = (SqlDataReader result) =>
                {

                    listener.onSuccess(result);

                },

                onError = (Error error) =>
                {

                },

                onDataProcessed = () =>
                {

                }

            }, dgv);

        }


    }
}