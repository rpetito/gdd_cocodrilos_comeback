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

namespace PagoAgilFrba.AbmCliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            DniTB.Clear();
            MailTB.Clear();
            ApellidoTB.Clear();
            TelefonoTB.Clear();
            FecNacDP.ResetText();
            DireccionTB.Clear();
            LocalidadTB.Clear();
            PisoTB.Clear();
            DepartamentoTB.Clear();
            CodigoPostalTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            String nombre = NombreTB.Text;
            String dni = DniTB.Text;
            String mail = MailTB.Text;
            String apellido = ApellidoTB.Text;
            String telefono = TelefonoTB.Text;
            String fecNac = FecNacDP.Text;
            String direccion = DireccionTB.Text;
            String localidad = LocalidadTB.Text;
            String piso = PisoTB.Text;
            String departamento = DepartamentoTB.Text;
            String codPostal = CodigoPostalTB.Text;


            try
            {
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                SqlCommand crearCliente = new SqlCommand();
                SqlDataReader result;

                using (crearCliente = new SqlCommand("COCODRILOS_COMEBACK.", Conexion))
                {
                    crearCliente.CommandType = CommandType.StoredProcedure;
                    crearCliente.Parameters.Add("@nombre", SqlDbType.Char);
                    crearCliente.Parameters["@nombre"].Value = nombre;
                    crearCliente.Parameters.Add("@apellido", SqlDbType.Char);
                    crearCliente.Parameters["@apellido"].Value = apellido;
                    crearCliente.Parameters.Add("@dni", SqlDbType.Int);
                    crearCliente.Parameters["@dni"].Value = dni;
                    crearCliente.Parameters.Add("@mail", SqlDbType.Char);
                    crearCliente.Parameters["@mail"].Value = mail;
                   /* crearCliente.Parameters.Add("@telefono", SqlDbType.Char);
                    crearCliente.Parameters["@username"].Value = pUsername;
                    crearCliente.Parameters.Add("@password", SqlDbType.Char);
                    crearCliente.Parameters["@password"].Value = pContrasenia;
                    crearCliente.Parameters.Add("@username", SqlDbType.Char);
                    crearCliente.Parameters["@username"].Value = pUsername;
                    crearCliente.Parameters.Add("@password", SqlDbType.Char);
                    crearCliente.Parameters["@password"].Value = pContrasenia;
                    crearCliente.Parameters.Add("@username", SqlDbType.Char);
                    crearCliente.Parameters["@username"].Value = pUsername;
                    crearCliente.Parameters.Add("@password", SqlDbType.Char);
                    crearCliente.Parameters["@password"].Value = pContrasenia;
                    crearCliente.Parameters.Add("@username", SqlDbType.Char);
                    crearCliente.Parameters["@username"].Value = pUsername;*/

                }

               // result = loginUsuario.ExecuteReader();/* al ingresar el username y password bien, no devuelve nada el reader y catchea excepcion*/

                Boolean success = true;

               /* while (result.Read())
                {
                    

                }

                if (success)
                {
                    
                }
                */
                Conexion.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }

        }
    }
}
