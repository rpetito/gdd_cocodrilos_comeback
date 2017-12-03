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

namespace PagoAgilFrba.AbmRol
{
    public partial class BajaRol : Form
    {

		RolController rolController;
        
		public BajaRol()
        {
            InitializeComponent();
			this.rolController = new RolController();
			Util.Util.addButtonColumnToGridView(EliminarRolGV, new DataGridViewCellEventHandler(this.EliminarRolGV_CellContentClick));
        }


        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void FiltratButton_Click(object sender, EventArgs e) {
			rolController.getRolByName(new SQLResponse<SqlDataReader>() {

				onSuccess = (SqlDataReader result) => {

				},

				onError = (Error error) => { 
				
				}

			},NombreTB.Text.ToString() , EliminarRolGV);
		}


		private void EliminarRolGV_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			
			if(e.ColumnIndex == 0 && e.RowIndex >= 0) {
				rolController.bajaRol(new SQLResponse<Int32>() {
					
					onSuccess = (Int32 result) => {
						if(result > 0) {
							Util.Util.showSuccessDialog();
						}
					},

					onError = (Error error) => { 
					
					}
				}, (Int32) EliminarRolGV.Rows[e.RowIndex].Cells[1].Value);
			}

		}

    }


}
