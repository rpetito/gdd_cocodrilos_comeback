using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmRol
{
    public partial class AltaRol : Form
    {

		FuncionalidadController funcionaliadController;
		List<Int32> funcionalidadesSeleccionadas = new List<Int32>();

        public AltaRol()
        {
            InitializeComponent();
            CrearButton.Enabled = false;

			DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
			checkbox.HeaderText = "Agregar";
			checkbox.Name = "agregarCheckbox";
			FuncionalidadesGV.Columns.Add(checkbox);

			funcionaliadController = new FuncionalidadController();
			funcionaliadController.getAllFunctionalities(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {

				},

				onError = (Error error) => { 
				
				}

			}, FuncionalidadesGV);
		
        }


        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            FuncionalidadesGV.ClearSelection();
            foreach (DataGridViewRow row in FuncionalidadesGV.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
               
                chk.Value = chk.FalseValue;
                

            }
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		private void CrearButton_Click(object sender, EventArgs e) {
			RolController rolController = new RolController();
			
			RolRequest rolRequest = new RolRequest();
			rolRequest.descripcion = NombreTB.Text.ToString();
			foreach(DataGridViewRow row in this.FuncionalidadesGV.Rows) {
				Boolean selected = row.Cells[0].Value == null ? false : true;
				if(selected) {
					rolRequest.addFuncionalidad((Int32) row.Cells[1].Value);
				}
			}

			rolController.createRol(new SQLResponse<Int32>() {

				onSuccess = (Int32 result) => {
					if(result == 0) {
                        Util.Util.showSuccessDialog();
                        this.Close();
                    }
				},

				onError = (Error error) => { 
					
				}

			}, rolRequest);
		}

        private void NombreTB_TextChanged(object sender, EventArgs e)
        {
            this.CrearButton.Enabled = !string.IsNullOrWhiteSpace(this.NombreTB.Text);
        }
    }

}
