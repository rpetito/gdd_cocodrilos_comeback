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
        EmpresaController empresa = new EmpresaController();

        public BajaEmpresa()
        {
            InitializeComponent();

            
            empresa.fillRubros(new SQLResponse<SqlDataReader>()
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
            empresa.filterEmpresa(new Util.SQLResponse<SqlDataReader>
            {
                onSuccess = (SqlDataReader result) =>
                {

                },
                onError = (Error fail) =>
                {

                }

            }, CuitTB.Text, NombreTB.Text, idRubro, BajaEmpresaGV);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BajaEmpresaGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in BajaEmpresaGV.SelectedRows)
                {
                    String cuit = (String)row.Cells[0].Value;
                    empresa.removeEmpresa(new SQLResponse<Int32>()
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
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila completa.", "Selección vacía");
            }
        }
    }
}
