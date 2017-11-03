using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class DatosFactura : Form
    {
        public DatosFactura()
        {
            EstadoCB.Items.Add("Habilitado");
            EstadoCB.Items.Add("Deshabilitado");
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            ClienteTB.Clear();
            EmpresaTB.Clear();
            FacturaTB.Clear();
            AltaDP.ResetText();
            VencimientoDP.ResetText();
            ItemsFacturaGV.Rows.Clear();
            TotalTB.Clear();
        }
    }
}
