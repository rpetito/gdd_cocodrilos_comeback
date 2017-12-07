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

        public void ejecutarEstadistica(SQLResponse<SqlDataReader> listener, Int32 año, Int32 trimestre, DataGridView dgv, String procedureName)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return procedureName; },

                addParams = (SqlCommand sqlCommand) =>
                {
                    if (!string.IsNullOrWhiteSpace(año.ToString()))
                    {
                        sqlCommand.Parameters.Add("@año", SqlDbType.Int);
                        sqlCommand.Parameters["@año"].Value = año;
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