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
    public partial class DatosDevolucion : Form
    {
        DevolucionController devolucionController = new DevolucionController();
        public DatosDevolucion()
        {
            InitializeComponent();
            FacturaTB.Text = Convert.ToString(Model.Devoluciones.getInstance().getFactura());
            ClienteTB.Text = Convert.ToString(Model.Devoluciones.getInstance().getUsuario());
            EmpresaTB.Text = Model.Devoluciones.getInstance().getEmpresa();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            devolucionController.hacerDevolucion(new Util.SQLResponse<SqlDataReader>
            {
                onSuccess = (SqlDataReader result) =>
                {

                },
                onError = (Error fail) =>
                {

                }

            }, FacturaTB.Text, ClienteTB.Text, EmpresaTB.Text, MotivoTB.Text);
        }
    }
}
