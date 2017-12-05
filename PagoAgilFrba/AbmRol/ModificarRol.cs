using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System.Data.SqlClient;
using PagoAgilFrba.Controller;

namespace PagoAgilFrba.AbmRol
{
    public partial class ModificarRol : Form
    {

        RolController rolController;

        public ModificarRol()
        {
            InitializeComponent();
            this.rolController = new RolController();
            Util.Util.addButtonSeleccionarColumnToGridView(ModificarRolGV, new DataGridViewCellEventHandler(this.ModificarRolGV_CellContentClick));
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltratButton_Click(object sender, EventArgs e)
        {
            rolController.getAllRolByName(new SQLResponse<SqlDataReader>()
            {

                onSuccess = (SqlDataReader result) => {

                },

                onError = (Error error) => {

                }

            }, NombreTB.Text.ToString(), ModificarRolGV);
        }

        private void ModificarRolGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                RolRequest rolRequest = new RolRequest();
                Rol.getInstance().setID(Convert.ToInt32(this.ModificarRolGV.CurrentRow.Cells[1].Value));
                Rol.getInstance().setDetalle(this.ModificarRolGV.CurrentRow.Cells[2].Value.ToString());
                Rol.getInstance().setHabilitado(Convert.ToBoolean(this.ModificarRolGV.CurrentRow.Cells[3].Value));

                rolController.obtenerFuncionalidades(new SQLResponse<SqlDataReader>()
                {

                    onSuccess = (SqlDataReader result) => {

                    },

                    onError = (Error error) => {

                    }

                }, Convert.ToInt32(this.ModificarRolGV.CurrentRow.Cells[1].Value), rolRequest);

                DatosRol datos = new DatosRol();
                datos.FormClosed += new FormClosedEventHandler(ModificarRolGV_datosRolClosed);
                datos.Show();
            }
        }

        void ModificarRolGV_datosRolClosed(object sender, FormClosedEventArgs e)
        {
            FiltratButton.PerformClick();
        }

    }
}
