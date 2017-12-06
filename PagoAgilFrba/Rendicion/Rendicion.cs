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
using PagoAgilFrba.Controller;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;

namespace PagoAgilFrba.Rendicion
{
    public partial class Rendicion : Form
    {
        RendicionController rendicionController = new RendicionController();
        Decimal sum = 0;
        Decimal porcentaje = 0;
        Decimal monto = 0;
        Decimal rendicion = 0;
        Int32 dia = 0;

        public Rendicion()
        {
            InitializeComponent();
            

        }

        private void Rendicion_Load(object sender, EventArgs e)
        {

        }

        private void FacturasButton_Click(object sender, EventArgs e)
        {

            Int32 mes;//definir sobre la combobox
            DataTable dt = rendicionController.getFacturasMes(new SQLResponse<SqlDataReader>()
            {

                onSuccess = (SqlDataReader result) =>
                {
                
                },

                onError = (Error error) =>
                {

                }

            }, EmpresaTB.Text, 2/*mescombobox*/, FacturasGV);

            dia = Convert.ToInt32(FacturasGV[4, 1].Value);

            CantidadLabel.Text = dt.Rows.Count.ToString();

            for (int i = 0; i < FacturasGV.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(FacturasGV.Rows[i].Cells[3].Value);
            }
            TotalLabel.Text = "$ " + sum.ToString();

            porcentaje = Convert.ToDecimal(ComisionPorcentajeTB.Text);
            monto = ((porcentaje) * (sum)) / 100;
            ComisionLabel.Text = "$ " + monto.ToString();

            rendicion = sum - monto;
            RendicionLabel.Text = "$ " + rendicion;
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            FechaCB.ResetText();
            EmpresaTB.Clear();
            ComisionPorcentajeTB.Clear();
        }

        private void RendirButton_Click(object sender, EventArgs e)
        {
            rendicionController.rendir(new SQLResponse<Int32>()
            {

                onSuccess = (Int32 result) => {
                    if (result == 0)
                    {
                        Util.Util.showSuccessDialog();
                        this.Close();
                    }
                },

                onError = (Error error) => {

                }

            }, Convert.ToInt32(CantidadLabel.Text), dia, sum, rendicion, monto, Convert.ToDecimal(ComisionPorcentajeTB.Text), 10/*poner las facturas*/ , EmpresaTB.Text );
        }
    }
}
