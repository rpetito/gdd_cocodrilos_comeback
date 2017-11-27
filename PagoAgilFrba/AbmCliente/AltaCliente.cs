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
using PagoAgilFrba.Controller;

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

            ClienteController clienteController = new ClienteController();
            clienteController.test(nombre, dni, mail, apellido, telefono, fecNac, direccion, localidad, piso, departamento, codPostal);

        }
    }
}
