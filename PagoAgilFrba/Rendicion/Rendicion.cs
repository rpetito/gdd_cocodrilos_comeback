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
        Int32 mes = 0;

        public Rendicion()
        {
            InitializeComponent();
            FechaCB.addItem(1, "Enero");
            FechaCB.addItem(2, "Febrero");
            FechaCB.addItem(3, "Marzo");
            FechaCB.addItem(4, "Abril");
            FechaCB.addItem(5, "Mayo");
            FechaCB.addItem(6, "Junio");
            FechaCB.addItem(7, "Julio");
            FechaCB.addItem(8, "Agosto");
            FechaCB.addItem(9, "Septiembre");
            FechaCB.addItem(10, "Octubre");
            FechaCB.addItem(11, "Noviembre");
            FechaCB.addItem(12, "Diciembre");

        }

        private void Rendicion_Load(object sender, EventArgs e)
        {

        }

        private void FacturasButton_Click(object sender, EventArgs e)
        {

            DataTable dt = rendicionController.getFacturasMes(new SQLResponse<SqlDataReader>()
            {

                onSuccess = (SqlDataReader result) =>
                {
                
                },

                onError = (Error error) =>
                {

                }

            }, EmpresaTB.Text, 2/*mescombobox*/, FacturasGV);

            CantidadLabel.Text = dt.Rows.Count.ToString();

            for (int i = 0; i < FacturasGV.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(FacturasGV.Rows[i].Cells[3].Value);
            }
            TotalLabel.Text = "$ " + sum.ToString();

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            FechaCB.ResetText();
            EmpresaTB.Clear();
            ComisionPorcentajeTB.Clear();
        }

        private void RendirButton_Click(object sender, EventArgs e)
        {
            mes = FechaCB.getSelectedItemID();
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

            }, Convert.ToInt32(CantidadLabel.Text), DateTime.Now, sum, rendicion, monto, Convert.ToDecimal(ComisionPorcentajeTB.Text), EmpresaTB.Text, mes);
        }

        private void ComisionPorcentajeTB_TextChanged(object sender, EventArgs e)
        {
            if ((ComisionPorcentajeTB.Text) != "")
            {
                porcentaje = Convert.ToDecimal(ComisionPorcentajeTB.Text);
                monto = ((porcentaje) * (sum)) / 100;
                ComisionLabel.Text = "$ " + monto.ToString();

                rendicion = sum - monto;
                RendicionLabel.Text = "$ " + rendicion;
            }
            else
            {
                ComisionLabel.Text = "$ 0.00";
                RendicionLabel.Text = "$ " + sum;
            }
        }
    }
}
