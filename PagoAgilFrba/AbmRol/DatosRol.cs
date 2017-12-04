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

            
            foreach(DataGridViewRow row in this.FuncionalidadesGV.Rows)
            {

                if (Rol.getInstance().getFuncionalidades().Contains(Convert.ToInt32(row.Cells[1].Value)))
                {
                    //FuncionalidadesGV.Rows[i].Cells[0].Value = true; .... checkear...
                }
                
            }

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
