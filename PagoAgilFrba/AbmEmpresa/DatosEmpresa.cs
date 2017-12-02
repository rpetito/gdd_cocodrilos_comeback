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
using PagoAgilFrba.Util;
using System.Data.SqlClient;
using PagoAgilFrba.Model;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class DatosEmpresa : Form
    {
        Int32 habilitado = -1;
        Decimal idRubro;
        String rubroNombre;
        String oldCuit;
        Decimal newRubro;
        Dictionary<Decimal, String> dictRubro = new Dictionary<Decimal, String>();
        EmpresaController empresaController = new EmpresaController();

        public DatosEmpresa()
        {
            InitializeComponent();

            empresaController.fillRubros(new SQLResponse<SqlDataReader>()
            {
                onSuccess = (SqlDataReader result) => {

                },

                onError = (Error error) => {

                }

            }, dictRubro, RubroCB);

            idRubro = Empresa.getInstance().getRubro();
            rubroNombre = dictRubro.FirstOrDefault(x => x.Key == idRubro).Value;
            newRubro = dictRubro.FirstOrDefault(x => x.Value == RubroCB.SelectedText).Key;

            oldCuit = Empresa.getInstance().getCuit();

            CuitTB.Text = Empresa.getInstance().getCuit();
            NombreTB.Text = Empresa.getInstance().getNombre();
            DireccionTB.Text = Empresa.getInstance().getDireccion();
            FecRendicionTB.Text = Empresa.getInstance().getDiaRendicion().ToString();
            RubroCB.Text = rubroNombre;
            if (Empresa.getInstance().getHabilitado() == 1)
                EstadoCB.Checked = true;
            else EstadoCB.Checked = false;
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            CuitTB.Clear();
            DireccionTB.Clear();
            RubroCB.ResetText();
            FecRendicionTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            habilitar();

            empresaController.modifyEmpresa(new Util.SQLResponse<Int32>
            {
                onSuccess = (Int32 result) =>
                {
                    Util.Util.showSuccessDialog();
                    this.Close();
                },
                onError = (Error fail) =>
                {

                }

            },
            oldCuit,
            CuitTB.Text,
            NombreTB.Text,
            DireccionTB.Text,
            Convert.ToInt32(FecRendicionTB.Text),
            newRubro,
            habilitado);
        }

        private void habilitar()
        {
            if (EstadoCB.Checked == true)
                habilitado = 1;
            else habilitado = 0;
        }

    }
}
