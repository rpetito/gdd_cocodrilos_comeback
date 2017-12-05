using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model {


	public class ItemFactura {

		public Int32 id { get; set; }
		public Decimal precio { get; set; }
		public Int32 cantidad { get; set; }

		public ItemFactura(Decimal precio, Int32 cantidad) {
			this.precio = precio;
			this.cantidad = cantidad;
		}

		public ItemFactura(Int32 id, Decimal precio, Int32 cantidad) {
			this.id = id;
			this.precio = precio;
			this.cantidad = cantidad;
		}
	
	}


}
