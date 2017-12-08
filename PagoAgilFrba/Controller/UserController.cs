using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System.Windows.Forms;

namespace PagoAgilFrba.Controller {

    class UserController {


        public void test(LoginResponse listener, String username, String password) {

            SQLExecutor executor = new SQLExecutor();
            executor.executeReaderRequest(
                new SQLExecutorHelper<SqlDataReader>() {

                    getProcedureName = () => { return "INGRESAR_USUARIO"; },

                    addParams = (SqlCommand sqlCommand) => {
                        sqlCommand.Parameters.Add("@username", SqlDbType.Char);
                        sqlCommand.Parameters["@username"].Value = username;
                        sqlCommand.Parameters.Add("@password", SqlDbType.Char);
                        sqlCommand.Parameters["@password"].Value = password;
                    },

                    onReadData = (SqlDataReader result) => {

                        if (hasCompleteData(result)) {

                            Usuario.getInstance().setDNI(result.GetDecimal(0));

                            RolLogeo rol = new RolLogeo();
                            rol.setID(result.GetInt32(1));
                            rol.setDetalle(result.GetString(2));
                            rol.setHabilitado(result.GetBoolean(3));
                            if (rol.getHabilitado() == true)
                                Usuario.getInstance().addRol(rol);

                        } else {
                            if (result.GetInt32(0) == 999)
                                MessageBox.Show("Usuario inhabilitado", "hola");
                            if (result.GetInt32(0) == 1001)
                                MessageBox.Show("Usuario o Contraseña incorrecto/s");
                        }
                    },

                    onDataProcessed = () => {
                        if (Usuario.getInstance().hasOnlyOneRol())
                        {
                            Usuario.getInstance().setRolSeleccionado(Usuario.getInstance().getRoles()[0]);
                            listener.onUniqueRol();
                        }
                        else if (Usuario.getInstance().hasMultipleRoles())
                        {
                            listener.onMultipleRoles();
                        }
                        else if (Usuario.getInstance().hasNoneRol())
                        {
                            MessageBox.Show("Usuario no tiene roles asignados.");
                        }
                        else
                            MessageBox.Show("Usuario inhabilitado");
                        
                    }

                });

        }



        private Boolean hasCompleteData(SqlDataReader result) {
            return result.VisibleFieldCount == 4;
        }



        public void getSucursal(SQLResponse<SqlDataReader> listener, Decimal dni)
        {
            SQLExecutor sqlExecutor = new SQLExecutor();
            sqlExecutor.executeReaderRequest(new SQLExecutorHelper<SqlDataReader>()
            {

                getProcedureName = () => { return "OBTENER_SUCURSAL_DNI"; },

                addParams = (SqlCommand sqlCommand) => {
                    sqlCommand.Parameters.Add("@user_dni", SqlDbType.Decimal);
                    sqlCommand.Parameters["@user_dni"].Value = dni;
                },

                onReadData = (SqlDataReader result) =>
                {
                    try
                    {
                        SucursalLogeo sucursal = new SucursalLogeo();
                        sucursal.setId(result.GetInt32(0));
                        sucursal.setNombre(result.GetString(1));
                        sucursal.setDireccion(result.GetString(2));
                        sucursal.setCodPostal(result.GetDecimal(3));
                        sucursal.setHabilitado(result.GetBoolean(4));
                        if (sucursal.getHabilitado() == true)
                            Usuario.getInstance().addSucursal(sucursal);
                    } catch (Exception ex)
                    {
                            MessageBox.Show("Algo ha ocurrido", "hola");
                    }
                },

                onError = (Error error) =>
                {

                },

                onDataProcessed = () =>
                {
                    if (Usuario.getInstance().hasOnlyOneSucursal())
                    {
                        Usuario.getInstance().setSucursalSeleccionada(Usuario.getInstance().getSucursales()[0]);
                        Menu menues = new Menu();
                        menues.Show();
                    }
                    else if (Usuario.getInstance().hasMultipleSucursales())
                    {
                        SeleccionSucursal sucursalMenu = new SeleccionSucursal();
                        sucursalMenu.Show();
                    }
                    else if (Usuario.getInstance().hasNoneSucursal())
                        MessageBox.Show("Usuario no tiene sucursales asignadas.");
                    else MessageBox.Show("Algo ha ocurrido.");
                }

            });
        }





        public class LoginResponse {
			public Action onMultipleRoles;
			public Action onUniqueRol;
		}




	}


}
