using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
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
using PagoAgilFrba.Model; 

namespace PagoAgilFrba.AbmFactura
{
    public partial class AltaFactura : Form
    {

		FacturaController facturaController;

        public AltaFactura()
        {
            InitializeComponent();
			this.facturaController = new FacturaController();
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

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void CrearButton_Click(object sender, EventArgs e) {

			Factura factura = new Factura();
			factura.numero = Int32.Parse(FacturaTB.Text.ToString());
			factura.cliente = Int32.Parse(ClienteTB.Text.ToString());
			factura.empresa = EmpresaTB.Text.ToString();
			factura.fechaEmision = DateTime.Parse(FecAlta.Text.ToString());
			factura.fechaVto = DateTime.Parse(FecVenc.Text.ToString());
			foreach(DataGridViewRow row in ItemsFacturaGV.Rows) {
				Decimal precio = (Decimal)row.Cells[0].Value;
				Int32 cantidad = (Int32)row.Cells[1].Value;
				factura.addItem(new ItemFactura(precio, cantidad));
			}
			
			
			this.facturaController.altaFactura(new SQLResponse<Int32>() { 
			
			}, factura);
		}


		private void agregarItemButton_Click(object sender, EventArgs e) {

		}

		


    }
}
