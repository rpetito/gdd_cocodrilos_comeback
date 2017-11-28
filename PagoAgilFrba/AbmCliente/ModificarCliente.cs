using PagoAgilFrba.Controller;
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
    public partial class ModificarCliente : Form
    {

		private ClienteController clienteController;


        public ModificarCliente()
        {
            InitializeComponent();
			this.clienteController = new ClienteController();
        }


		private void ModificarButton_Click(object sender, EventArgs e) { 
		
		}

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            ApellidoTB.Clear();
            DniTB.Clear();
            ModificarGV.Rows.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }


}
