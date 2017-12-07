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

namespace PagoAgilFrba.Devolucion
{
    public partial class Devolucion : Form
    {
        private DevolucionController devolucionController = new DevolucionController();

        public Devolucion()
        {
            InitializeComponent();
            Util.Util.addButtonColumnToGridView(DevolucionesGV, "Devolucion", new DataGridViewCellEventHandler(this.Devolucion_cellEventHandler));

        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            devolucionController.filterFacturasPagas(new Util.SQLResponse<SqlDataReader>
            {
                onSuccess = (SqlDataReader result) =>
                {

                },
                onError = (Error fail) =>
                {

                }

            }, FacturaTB.Text, ClienteTB.Text, EmpresaTB.Text, DevolucionesGV);
        }

        private void Devolucion_cellEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                Devoluciones.getInstance().setFactura(Convert.ToDecimal(this.DevolucionesGV.CurrentRow.Cells[1].Value.ToString()));
                Devoluciones.getInstance().setUsuario(Convert.ToDecimal(this.DevolucionesGV.CurrentRow.Cells[2].Value.ToString()));
                Devoluciones.getInstance().setEmpresa(this.DevolucionesGV.CurrentRow.Cells[3].Value.ToString());


                DatosDevolucion datos = new PagoAgilFrba.Devolucion.DatosDevolucion();
                datos.FormClosed += new FormClosedEventHandler(DatosDevolucionClosed);
                datos.Show();
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DatosDevolucionClosed(object sender, FormClosedEventArgs e)
        {
            FiltrarButton.PerformClick();
        }
    }
}
