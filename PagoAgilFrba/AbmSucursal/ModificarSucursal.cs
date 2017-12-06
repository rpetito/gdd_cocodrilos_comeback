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

namespace PagoAgilFrba.AbmSucursal
{
    public partial class ModificarSucursal : Form
    {
        private SucursalController sucursalController = new SucursalController();

        public ModificarSucursal()
        {
            InitializeComponent();
            Util.Util.addButtonColumnToGridView(ModificarSucursalGV, new DataGridViewCellEventHandler(this.ModificarSucursal_cellEventHandler), "Seleccionar");
        
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            DireccionTB.Clear();
            CodigoPostalTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            sucursalController.filterSucursalTotalidad(new Util.SQLResponse<SqlDataReader>
            {
                onSuccess = (SqlDataReader result) =>
                {

                },
                onError = (Error fail) =>
                {

                }

            }, NombreTB.Text, DireccionTB.Text, CodigoPostalTB.Text, ModificarSucursalGV);
        }

        private void ModificarSucursal_cellEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                Sucursal.getInstance().setId(Convert.ToInt32(this.ModificarSucursalGV.CurrentRow.Cells[1].Value.ToString()));
                Sucursal.getInstance().setNombre(this.ModificarSucursalGV.CurrentRow.Cells[2].Value.ToString());
                Sucursal.getInstance().setDireccion(this.ModificarSucursalGV.CurrentRow.Cells[3].Value.ToString());
                Sucursal.getInstance().setCodPostal(Convert.ToInt32(this.ModificarSucursalGV.CurrentRow.Cells[4].Value.ToString()));
                Sucursal.getInstance().setHabilitado(Convert.ToInt32(this.ModificarSucursalGV.CurrentRow.Cells[5].Value == null ? 0 : 1));

                DatosSucursal datos = new PagoAgilFrba.AbmSucursal.DatosSucursal();
                datos.FormClosed += new FormClosedEventHandler(ModificarSucursal_datosSucursalClosed);
                datos.Show();
            }
        }

        void ModificarSucursal_datosSucursalClosed(object sender, FormClosedEventArgs e)
        {
            FiltrarButton.PerformClick();
        }

    }
}
