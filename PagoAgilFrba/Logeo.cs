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
            Menu menu = new PagoAgilFrba.Menu();
            menu.Show();
        }
    }
}
