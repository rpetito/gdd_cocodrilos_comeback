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
using System.Data.SqlClient;
using PagoAgilFrba.Util;
using PagoAgilFrba.Model;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class BajaEmpresa : Form
    {

        Decimal idRubro;
        Dictionary<Decimal, String> dictRubro = new Dictionary<Decimal, String>();
        EmpresaController empresaController = new EmpresaController();

        public BajaEmpresa()
        {
            InitializeComponent();
            Util.Util.addButtonColumnToGridView(BajaEmpresaGV, "Eliminar", new DataGridViewCellEventHandler(this.BajaEmpresa_cellEventHandler));


            empresaController.fillRubros(new SQLResponse<SqlDataReader>()
            {

                onSuccess = (SqlDataReader result) => {

                },

                onError = (Error error) => {

                }

            }, dictRubro, RubroCB);
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            CuitTB.Clear();
            RubroCB.ResetText();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            idRubro = dictRubro.FirstOrDefault(x => x.Value == RubroCB.Text).Key;
            empresaController.filterEmpresaHabilitada(new Util.SQLResponse<SqlDataReader>
            {
                onSuccess = (SqlDataReader result) =>
                {

                },
                onError = (Error fail) =>
                {

                }

            }, CuitTB.Text, NombreTB.Text, idRubro, BajaEmpresaGV);
        }


        private void BajaEmpresa_cellEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                String cuit = (String)BajaEmpresaGV.Rows[e.RowIndex].Cells[1].Value;
                empresaController.removeEmpresa(new SQLResponse<Int32>()
                {

                    onSuccess = (Int32 result) => {
                        Util.Util.showSuccessDialog();
                        this.FiltrarButton.PerformClick();
                    },

                    onError = (Error error) => {

                    }

                }, cuit);
            }
        }
    }
}
