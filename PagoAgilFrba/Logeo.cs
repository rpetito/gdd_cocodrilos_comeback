using PagoAgilFrba.Controller;
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

namespace PagoAgilFrba {

    public partial class Logeo : Form {
    
		public Logeo() {
            InitializeComponent();
            ContraseniaTB.PasswordChar = '*';
        }

        private void Ingresar_Click(object sender, EventArgs e) {
            String pUsername = UsuarioTB.Text;
            String pContrasenia = ContraseniaTB.Text;

			UserController userController = new UserController();
			userController.test(new UserController.LoginResponse() {

				onMultipleRoles = () => {
					SeleccionRol rolSeleccionado = new SeleccionRol();
					rolSeleccionado.ShowDialog();
				},

				onUniqueRol = () => {
					Menu menu = new Menu();
					menu.ShowDialog();
				}

			},
			pUsername, pContrasenia);
            
        
        }



    }





}
