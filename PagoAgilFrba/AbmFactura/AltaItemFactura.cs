using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura {


	public partial class AltaItemFactura : Form {

		public String precio { get; set; }
		public String cantidad { get; set; }

		public AltaItemFactura() {
			InitializeComponent();
		}


		private void itemFacturaCancelarButton_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void itemFacturaAñadirButton_Click(object sender, EventArgs e) {
			precio = itemFacturaPrecioTB.Text.ToString();
			cantidad = itemFacturaCantTB.Text.ToString();
			if(Util.Util.onlyNumbersText(precio) && Util.Util.onlyNumbersText(cantidad)) {
				DialogResult = DialogResult.OK;
				Close();
			} else {
				MessageBox.Show("Solo se deben ingresar datos numericos con hasta dos decimales.");
			}
		}


	}



}
