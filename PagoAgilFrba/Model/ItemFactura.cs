using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model {


	class ItemFactura {

		public Decimal precio { get; set; }
		public Int32 cantidad { get; set; }


		public ItemFactura(Decimal precio, Int32 cantidad) {
			this.precio = precio;
			this.cantidad = cantidad;
		}
	
	}


}
