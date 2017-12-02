using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
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
    public partial class ModificarCliente : Form
    {

		private ClienteController clienteController;


        public ModificarCliente()
        {
            InitializeComponent();
			this.clienteController = new ClienteController();

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Seleccionar";
            button.Name = "seleccionarButton";
            button.Text = "Seleccionar";
            button.UseColumnTextForButtonValue = true;
            ModificarGV.Columns.Add(button);
            button.Frozen = true;
        }


        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            ApellidoTB.Clear();
            DniTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		private void FiltrarButton_Click(object sender, EventArgs e) {
			clienteController.filterClient(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {

				},

				onError = (Error error) => {

				}

			}, NombreTB.Text, ApellidoTB.Text, DniTB.Text, ModificarGV);
		}

        private void ModificarGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

                Cliente.getInstance().setDni(Convert.ToInt32(this.ModificarGV.CurrentRow.Cells[1].Value));
                Cliente.getInstance().setNombre(this.ModificarGV.CurrentRow.Cells[2].Value.ToString());
                Cliente.getInstance().setApellido(this.ModificarGV.CurrentRow.Cells[3].Value.ToString());
                Cliente.getInstance().setFecNac(Convert.ToDateTime(this.ModificarGV.CurrentRow.Cells[4].Value));
                Cliente.getInstance().setMail(this.ModificarGV.CurrentRow.Cells[5].Value.ToString());
                Cliente.getInstance().setDireccion(this.ModificarGV.CurrentRow.Cells[6].Value.ToString());
                Cliente.getInstance().setTelefono(this.ModificarGV.CurrentRow.Cells[7].Value.ToString());
                Cliente.getInstance().setPiso(Convert.ToInt32(this.ModificarGV.CurrentRow.Cells[8].Value));
                Cliente.getInstance().setDepto(this.ModificarGV.CurrentRow.Cells[9].Value.ToString());
                Cliente.getInstance().setLocalidad(this.ModificarGV.CurrentRow.Cells[10].Value.ToString());
                Cliente.getInstance().setCodPostal(this.ModificarGV.CurrentRow.Cells[11].Value.ToString());
                Cliente.getInstance().setHabilitado(Convert.ToInt32(this.ModificarGV.CurrentRow.Cells[12].Value));

                DatosCliente datos = new PagoAgilFrba.AbmCliente.DatosCliente();
				datos.FormClosed += new FormClosedEventHandler(ModificarCliente_datosClienteClosed);
                datos.Show();
            }
        }

		void ModificarCliente_datosClienteClosed(object sender, FormClosedEventArgs e) {
			FiltrarButton.PerformClick();
		}

    }


}
