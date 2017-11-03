using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ClienteButton_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmCliente.ABMCliente cliente = new AbmCliente.ABMCliente();
            cliente.Show();
        }

        private void EmpresaButton_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmEmpresa.ABMEmpresa empresa = new AbmEmpresa.ABMEmpresa();
            empresa.Show();
        }

        private void FacturaButton_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmFactura.ABMFactura factura = new AbmFactura.ABMFactura();
            factura.Show();
        }

        private void RolButton_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmRol.ABMRol rol = new AbmRol.ABMRol();
            rol.Show();
        }

        private void SucursalButton_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmSucursal.ABMSucursal sucursal = new AbmSucursal.ABMSucursal();
            sucursal.Show();
        }
    }
}
