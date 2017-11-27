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

namespace PagoAgilFrba
{
    public partial class Menu : Form
    {
        public Menu() {

			FlowLayoutPanel panel = new FlowLayoutPanel();
			panel.FlowDirection = FlowDirection.LeftToRight;
			panel.AutoScroll = true;
			panel.WrapContents = true;
			panel.Width = 500;
			panel.Height = 500;
			this.Controls.Add(panel);

			RolController rolController = new RolController();
			rolController.getAvailableFunctionalities(
				new SQLResponse<SqlDataReader>() {

					onSuccess = (SqlDataReader result) => {

						

						// HACER ESTO POR CADA FUNCIONALIDAD QUE VIENE EN result
						Button button = new Button();

						button.Tag = result.GetInt32(0);
						button.Text = result.GetString(1);
						button.Width = 250;
						button.Click += button_Click;

						panel.Controls.Add(button);

					},

					onError = (Error error) => {
						MessageBox.Show(error.getMessage(), "Error");
					}

				}, Usuario.getInstance().getRolSeleccionado().getID());

        }

        

        void button_Click(object sender, EventArgs e) {
            Form view = MenuController.getViewForFunctionality(Convert.ToInt32(((Button)sender).Tag));
            view.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e) {

        }

			  

    }

			   

}
