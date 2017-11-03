using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class DatosCliente : Form
    {
        public DatosCliente()
        {
            EstadoCB.Items.Add("Habilitado");
            EstadoCB.Items.Add("Deshabilitado");
            InitializeComponent();
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
    }
}
