using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.RegistroPago
{
    public partial class AgregarFacturas : Form
    {
        public AgregarFacturas()
        {
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NumFacturaTB.Clear();
            FecCobroDP.ResetText();
            ClienteTB.Clear();
            EmpresaTB.Clear();
            FecVencimientoDP.ResetText();
            ImporteTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmpresaButton_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmEmpresa.BuscadorEmpresa buscador = new AbmEmpresa.BuscadorEmpresa();
            buscador.Show();
        }

        private void ClienteButton_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmCliente.BuscadorCliente buscador = new AbmCliente.BuscadorCliente();
            buscador.Show();
        }
    }
}
