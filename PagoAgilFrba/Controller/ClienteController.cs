using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Util;

namespace PagoAgilFrba.Controller
{
    class ClienteController
    {

        public void test(String nombre, String dni, String mail, String apellido, String telefono, String fecNac, String direccion, String localidad, String piso, String departamento, String codPostal)
        {

            SQLExecutor executor = new SQLExecutor();
            executor.executeReaderRequest(
                new SQLExecutorHelper<SqlDataReader>()
                {

                    getProcedureName = () => { return "ALTA_CLIENTE"; },

                    addParams = (SqlCommand sqlCommand) => {
                        sqlCommand.Parameters.Add("@nombre", SqlDbType.Char);
                        sqlCommand.Parameters["@nombre"].Value = nombre;
                        sqlCommand.Parameters.Add("@dni", SqlDbType.Int);
                        sqlCommand.Parameters["@dni"].Value = dni;
                        sqlCommand.Parameters.Add("@mail", SqlDbType.Char);
                        sqlCommand.Parameters["@mail"].Value = mail;
                        sqlCommand.Parameters.Add("@apellido", SqlDbType.Char);
                        sqlCommand.Parameters["@apellido"].Value = apellido;
                        sqlCommand.Parameters.Add("@telefono", SqlDbType.Char);
                        sqlCommand.Parameters["@telefono"].Value = telefono;
                        sqlCommand.Parameters.Add("@fecNac", SqlDbType.DateTime);
                        sqlCommand.Parameters["@fecNac"].Value = fecNac;
                        sqlCommand.Parameters.Add("@direccion", SqlDbType.Char);
                        sqlCommand.Parameters["@direccion"].Value = direccion;
                        sqlCommand.Parameters.Add("@localidad", SqlDbType.Char);
                        sqlCommand.Parameters["@localidad"].Value = localidad;
                        sqlCommand.Parameters.Add("@piso", SqlDbType.Int);
                        sqlCommand.Parameters["@piso"].Value = piso;
                        sqlCommand.Parameters.Add("@departamento", SqlDbType.Char);
                        sqlCommand.Parameters["@departamento"].Value = departamento;
                        sqlCommand.Parameters.Add("@codPostal", SqlDbType.Char);
                        sqlCommand.Parameters["@codPostal"].Value = codPostal;
                    },

                    onReadData = (SqlDataReader result) => {

                        if (result.GetInt32(0) == 0)
                            MessageBox.Show("Usuario creado.", "Creacion Completa.");
                        else if (result.GetInt32(0) == 2627)
                            MessageBox.Show("Usuario existente.");
                            else MessageBox.Show("Ha ocurrido un error.");
                        
                    }

                });

        }

    }
}
