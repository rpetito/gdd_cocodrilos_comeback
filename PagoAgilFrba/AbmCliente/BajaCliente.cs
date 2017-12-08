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
using PagoAgilFrba.Model;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Util;

namespace PagoAgilFrba.AbmCliente
{
    public partial class BajaCliente : Form
    {

		private ClienteController clienteController = new ClienteController();

        public BajaCliente()
        {
            InitializeComponent();
            Util.Util.addButtonColumnToGridView(BajaClienteGV, "Eliminar", new DataGridViewCellEventHandler(this.BajaCliente_cellEventHandler));

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

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            clienteController.filterClientHabilitado(new Util.SQLResponse<SqlDataReader>
            {
                onSuccess = (SqlDataReader result) =>
                {

                },
                onError = (Error fail) =>
                {

                }

            }, NombreTB.Text, ApellidoTB.Text, DniTB.Text, BajaClienteGV);
        }



        private void BajaCliente_cellEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                Decimal clienteDNI = (Decimal)BajaClienteGV.Rows[e.RowIndex].Cells[1].Value;
                clienteController.removeClient(new SQLResponse<SqlDataReader>()
                {

                    onSuccess = (SqlDataReader result) => {

                    },



						onFinish = (Boolean withErrores) => {
							if(!withErrores) {
								Util.Util.showSuccessDialog();
								this.FiltrarButton.PerformClick();
							}
						},

                    onError = (Error error) => {

                    }

                }, clienteDNI);
            }
        }

    }
}
