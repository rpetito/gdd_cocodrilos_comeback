using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Util;
using PagoAgilFrba.Model;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class AltaEmpresa : Form
    {
        
        Decimal idRubro;
        Dictionary<Decimal, String> dictRubro = new Dictionary<Decimal, String>();

        public AltaEmpresa()
        {
            InitializeComponent();
            EmpresaController diccionari = new EmpresaController();
            diccionari.fillRubros(new SQLResponse<SqlDataReader>()
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
            DireccionTB.Clear();
            CuitTB.Clear();
            RubroCB.ResetText();
            DiaRendicionTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            idRubro = dictRubro.FirstOrDefault(x => x.Value == RubroCB.Text).Key;
            EmpresaController empresa = new EmpresaController();
            empresa.insertNewEmpresa(new Util.SQLResponse<Int32>
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
            CuitTB.Text,
            NombreTB.Text,
            DireccionTB.Text,
            idRubro,
            Convert.ToInt32(DiaRendicionTB.Text));
        }
    }
}
