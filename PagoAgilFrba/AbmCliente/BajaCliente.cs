using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Controller;

namespace PagoAgilFrba.AbmCliente
{
    public partial class BajaCliente : Form
    {
        public BajaCliente()
        {
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            ApellidoTB.Clear();
            DniTB.Clear();
            BajaClienteGV.Rows.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            String nombre = NombreTB.Text;
            String apellido = ApellidoTB.Text;
            Decimal dni = Convert.ToDecimal(DniTB.Text);

            ClienteController filtroCliente = new ClienteController();
            
        }
    }
}
