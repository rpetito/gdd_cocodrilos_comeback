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

        public void insertNewClient(SQLResponse<Int32> listener, decimal dni, string nombre, string apellido, DateTime fecha_nac, string mail, string direccion, string telefono,  int piso, string dpto, string localidad, string cod_postal)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeScalarRequest(new SQLExecutorHelper<Int32>()
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

  

                onReadData = (Int32 result) => {
                
                     listener.onSuccess(result);  
                   
                },

                onError = (Error error) => {

                },

                onDataProcessed = () => { }

            });
        }

        public void filterClient(SQLResponse<SqlDataReader> listener, String nombre, String apellido, Decimal dni, DataGridView dgv)
        {

            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeDataGridViewRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "BUSCAR_CLIENTE"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@nombre"].Value = nombre;
                    sqlCommand.Parameters.Add("@apellido", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@apellido"].Value = apellido;
                    sqlCommand.Parameters.Add("@dni", SqlDbType.Decimal);
                    sqlCommand.Parameters["@dni"].Value = dni;
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
    }
}
