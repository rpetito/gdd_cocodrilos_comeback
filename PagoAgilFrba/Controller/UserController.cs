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

						if(hasCompleteData(result)) {

							Usuario.getInstance().setDNI(result.GetDecimal(0));

							Rol rol = new Rol();
							rol.setID(result.GetInt32(1));
							rol.setDetalle(result.GetString(2));

							Usuario.getInstance().addRol(rol);

						} else {
							if(result.GetInt32(0) == 999)
								MessageBox.Show("Usuario inhabilitado", "hola");
							else
								MessageBox.Show("Usuario o Contraseña incorrecto/s");
						}
					},

					onDataProcessed = () => {
						if(Usuario.getInstance().hasOnlyOneRol()) {
							Usuario.getInstance().setRolSeleccionado(Usuario.getInstance().getRoles()[0]);
							listener.onUniqueRol();
						} else if(Usuario.getInstance().hasMultipleRoles()) {
							listener.onMultipleRoles();
						} else {
							MessageBox.Show("El usuario no tiene roles disponibles");
						}
					}

				});

		}



		private Boolean hasCompleteData(SqlDataReader result) {
			return result.VisibleFieldCount == 3;
		}







		public class LoginResponse {
			public Action onMultipleRoles;
			public Action onUniqueRol;
		}




	}


}
