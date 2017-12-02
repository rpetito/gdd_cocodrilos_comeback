using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                onDataProcessed = () => { }

            });
        }
    }
}
