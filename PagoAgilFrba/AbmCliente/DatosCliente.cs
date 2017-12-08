using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Model;
using PagoAgilFrba.Controller;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoAgilFrba.AbmCliente
{
    public partial class DatosCliente : Form
    {
        private Int32 habilitado = -1;
		private String originalDNI;

        public DatosCliente()
        {
            InitializeComponent();
            NombreTB.Text = Cliente.getInstance().getNombre();
            ApellidoTB.Text = Cliente.getInstance().getApellido();
            DniTB.Text = Cliente.getInstance().getDni().ToString();
            TelefonoTB.Text = Cliente.getInstance().getTelefono();
            MailTB.Text = Cliente.getInstance().getMail();
            FecNacDP.Value = Cliente.getInstance().getFecNac();
            DireccionTB.Text = Cliente.getInstance().getDireccion();
            CodigoPostalTB.Text = Cliente.getInstance().getCodPostal();
            LocalidadTB.Text = Cliente.getInstance().getLocalidad();
            PisoTB.Text = Cliente.getInstance().getPiso().ToString();
            DepartamentoTB.Text = Cliente.getInstance().getDepto();

			originalDNI = Cliente.getInstance().getDni().ToString();

            if (Cliente.getInstance().getHabilitado() == 1)
                EstadoCB.Checked = true;
            else EstadoCB.Checked = false;

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            ApellidoTB.Clear();
            DniTB.Clear();
            TelefonoTB.Clear();
            MailTB.Clear();
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

        private void ModificarButton_Click(object sender, EventArgs e)
        {

            habilitar();

            ClienteController clienteController = new ClienteController();
			clienteController.modifyClient(new Util.SQLResponse<SqlDataReader> {
				onSuccess = (SqlDataReader result) => {
				
				},
				onError = (Error fail) => {

				},
				onFinish = (Boolean withErrores) => {
					if(!withErrores) {
						Util.Util.showSuccessDialog();
						this.Close();
					}
				}

			},
			Convert.ToDecimal(originalDNI),
			Convert.ToDecimal(DniTB.Text),
			NombreTB.Text,
			ApellidoTB.Text,
			FecNacDP.Value,
			MailTB.Text,
			DireccionTB.Text,
			TelefonoTB.Text,
			Convert.ToInt32(PisoTB.Text),
			DepartamentoTB.Text,
			LocalidadTB.Text,
			CodigoPostalTB.Text,
			habilitado);
        }

        private void habilitar()
        {
            if (EstadoCB.Checked == true)
                habilitado = 1;
            else habilitado = 0;
        }

		

    }




}
