using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class DatosEmpresa : Form
    {
        public DatosEmpresa()
        {
            EstadoCB.Items.Add("Habilitado");
            EstadoCB.Items.Add("Deshabilitado");
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            CuitTB.Clear();
            DireccionTB.Clear();
            RubroCB.ResetText();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
