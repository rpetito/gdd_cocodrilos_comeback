using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class Logeo : Form
    {
        public Logeo()
        {
            InitializeComponent();
            //SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            //SqlCommand cmd = new SqlCommand();
            ContraseniaTB.PasswordChar = '*';
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            String pUsername = UsuarioTB.Text;
            String pContrasenia = ContraseniaTB.Text;

            try
            {
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                MessageBox.Show("estamos conectados");
                SqlCommand loginUsuario = new SqlCommand();
                SqlDataReader result;

                using (loginUsuario = new SqlCommand("COCODRILOS_COMEBACK.INGRESAR_USUARIO", Conexion))
                {
                    loginUsuario.CommandType = CommandType.StoredProcedure;
                    loginUsuario.Parameters.Add("@username", SqlDbType.Char);
                    loginUsuario.Parameters["@username"].Value = pUsername;
                    loginUsuario.Parameters.Add("@password", SqlDbType.Char);
                    loginUsuario.Parameters["@password"].Value = pContrasenia;
                }

                result = loginUsuario.ExecuteReader();

                Boolean success = true;

                while (result.Read())
                {
                    if (result.VisibleFieldCount == 3)
                    {
                        Usuario.getInstance().setDNI(result.GetDecimal(0));

                        Rol rol = new Rol();
                        rol.setID(result.GetInt32(1));
                        rol.setDetalle(result.GetString(2));

                        Usuario.getInstance().addRol(rol);

                    }
                    else
                    {
                        if (result.GetInt32(0) == 0)
                            MessageBox.Show("Usuario inhabilitado", "hola");
                        else
                            MessageBox.Show("Usuario o Contraseña incorrecto/s");

                        success = false;
                    }


                }

                if (success)
                {
                    if (Usuario.getInstance().getRoles().Count == 1)
                    {
                        Usuario.getInstance().setRolSeleccionado(Usuario.getInstance().getRoles()[0]);
                        Menu menu = new Menu();
                        menu.ShowDialog();
                    }
                    else if (Usuario.getInstance().getRoles().Count > 0)
                    {
                        SeleccionRol rolSeleccionado = new SeleccionRol();
                        rolSeleccionado.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no tiene roles disponibles");
                    }
                }

                Conexion.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }
        
        }
    }
}
