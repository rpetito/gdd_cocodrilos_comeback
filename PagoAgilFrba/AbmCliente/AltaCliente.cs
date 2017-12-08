using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
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
            CrearButton.Enabled = false;
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
            Decimal dni = Convert.ToDecimal(DniTB.Text);
            String mail = MailTB.Text;
            String apellido = ApellidoTB.Text;
            String telefono = TelefonoTB.Text;
            DateTime fecNac = FecNacDP.Value;
            String direccion = DireccionTB.Text;
            String localidad = LocalidadTB.Text;
            int piso = Convert.ToInt32(PisoTB.Text);
            String departamento = DepartamentoTB.Text;
            String codPostal = CodigoPostalTB.Text;

            ClienteController clienteController = new ClienteController();
            clienteController.insertNewClient(new Util.SQLResponse<SqlDataReader>
            {
				onSuccess = (SqlDataReader result) =>
                {
                    
                },
                onError = (Error fail) =>
                {

                },

				onFinish = (Boolean withError) => {
					if(!withError) {
						Util.Util.showSuccessDialog();
						this.Close();
					}
				}

            },
            dni,
            nombre,
            apellido,
            fecNac,
            mail,
            direccion,
            telefono,
            piso,
            departamento,
            localidad,
            codPostal);
        }

        private void NombreTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();
        }

        private Boolean TBCompletos() {
            return (!string.IsNullOrWhiteSpace(this.NombreTB.Text) && !string.IsNullOrWhiteSpace(this.ApellidoTB.Text) && !string.IsNullOrWhiteSpace(this.DniTB.Text) && !string.IsNullOrWhiteSpace(this.MailTB.Text) && !string.IsNullOrWhiteSpace(this.TelefonoTB.Text) && !string.IsNullOrWhiteSpace(this.DireccionTB.Text) && !string.IsNullOrWhiteSpace(this.LocalidadTB.Text) && !string.IsNullOrWhiteSpace(this.PisoTB.Text) && !string.IsNullOrWhiteSpace(this.DepartamentoTB.Text) && !string.IsNullOrWhiteSpace(this.CodigoPostalTB.Text));
        }

        private void ApellidoTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }

        private void DniTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }

        private void TelefonoTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }

        private void MailTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }

        private void DireccionTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }

        private void LocalidadTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }

        private void PisoTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }

        private void DepartamentoTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }

        private void CodigoPostalTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = TBCompletos();

        }
    }
}
