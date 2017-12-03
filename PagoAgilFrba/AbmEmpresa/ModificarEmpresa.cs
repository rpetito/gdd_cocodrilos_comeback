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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class ModificarEmpresa : Form
    {
        private EmpresaController empresaController;
        Decimal idRubro;
        Dictionary<Decimal, String> dictRubro = new Dictionary<Decimal, String>();

        public ModificarEmpresa()
        {
            InitializeComponent();

            this.empresaController = new EmpresaController();

            empresaController.fillRubros(new SQLResponse<SqlDataReader>()
            {

                onSuccess = (SqlDataReader result) => {

                },

                onError = (Error error) => {

                }

            }, dictRubro, RubroCB);

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Seleccionar";
            button.Name = "seleccionarButton";
            button.Text = "Seleccionar";
            button.UseColumnTextForButtonValue = true;
            ModificarEmpresaGV.Columns.Add(button);
            button.Frozen = true;
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            RubroCB.ResetText();
            CuitTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
			
            idRubro = dictRubro.FirstOrDefault(x => x.Value == RubroCB.Text).Key;
            empresaController.filterEmpresaTotalidad(new SQLResponse<SqlDataReader>()
            {

                onSuccess = (SqlDataReader result) => {

                },

                onError = (Error error) => {

                }

            }, CuitTB.Text, NombreTB.Text, idRubro, ModificarEmpresaGV);
        }

        private void ModificarEmpresaGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

                Empresa.getInstance().setCuit(this.ModificarEmpresaGV.CurrentRow.Cells[1].Value.ToString());
                Empresa.getInstance().setNombre(this.ModificarEmpresaGV.CurrentRow.Cells[2].Value.ToString());
                Empresa.getInstance().setDireccion(this.ModificarEmpresaGV.CurrentRow.Cells[3].Value.ToString());
                Empresa.getInstance().setDiaRendicion(Convert.ToInt32(this.ModificarEmpresaGV.CurrentRow.Cells[4].Value));
                Empresa.getInstance().setRubro(Convert.ToDecimal(this.ModificarEmpresaGV.CurrentRow.Cells[5].Value));
                Empresa.getInstance().setHabilitado(Convert.ToInt32(this.ModificarEmpresaGV.CurrentRow.Cells[6].Value));

                DatosEmpresa datos = new PagoAgilFrba.AbmEmpresa.DatosEmpresa();
                datos.FormClosed += new FormClosedEventHandler(ModificarEmpresaGV_datosEmpresaClosed);
                datos.Show();
            }
        }

        void ModificarEmpresaGV_datosEmpresaClosed(object sender, FormClosedEventArgs e)
        {
            FiltrarButton.PerformClick();
        }

    }
}
