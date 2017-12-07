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
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System.Data.SqlClient;

namespace PagoAgilFrba.AbmRol
{
    public partial class DatosRol : Form
    {

        FuncionalidadController funcionalidadController = new FuncionalidadController();

        public DatosRol()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Agregar";
            checkbox.Name = "agregarCheckbox";
            checkbox.FalseValue = false;
            checkbox.TrueValue = true;
            FuncionalidadesGV.Columns.Add(checkbox);
            NombreTB.Text = Rol.getInstance().getDetalle();
            if (Rol.getInstance().getHabilitado() == true)
                HabilitadoCB.Checked = true;
            else HabilitadoCB.Checked = false;

            funcionalidadController.getAllFunctionalities(new SQLResponse<SqlDataReader>()
            {

                onSuccess = (SqlDataReader result) =>
                {
                   
                },

                onError = (Error error) =>
                {

                }

            }, FuncionalidadesGV);

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            RolController rolController = new RolController();
            RolRequest rolRequest = new RolRequest();
            rolRequest.descripcion = NombreTB.Text.ToString();
            Int32 habilitado = -1;
            if (HabilitadoCB.Checked == true)
                habilitado = 1;
            else habilitado = 0;

            foreach (DataGridViewRow row in this.FuncionalidadesGV.Rows)
            {
                Boolean selected = row.Cells[0].Value == null ? false : true;
                if (selected)
                {
                    rolRequest.addFuncionalidad((Int32)row.Cells[1].Value);
                }
            }

            rolController.modifyRol(new SQLResponse<Int32>()
            {

                onSuccess = (Int32 result) =>
                {

                },

                onError = (Error error) =>
                {

                }

            }, Rol.getInstance().getID(), Rol.getInstance().getDetalle(), rolRequest.funcionalidades, habilitado);

            Util.Util.showSuccessDialog();
            this.Close();
        }
    }
}
