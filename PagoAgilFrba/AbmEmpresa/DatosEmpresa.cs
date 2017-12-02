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
        Int32 habilitado = -1;
        public DatosEmpresa()
        {
            InitializeComponent();
            CuitTB.Text = Empresa.getInstance().getCuit();
            NombreTB.Text = Empresa.getInstance().getNombre();
            DireccionTB.Text = Empresa.getInstance().getDireccion();
            //RubroCB.Text = Empresa.getInstance().get
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
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
