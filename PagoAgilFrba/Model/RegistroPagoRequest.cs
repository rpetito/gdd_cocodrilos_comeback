using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model {

	class RegistroPagoRequest {

		public Decimal factura { get; set; }
		public DateTime fechaPago { get; set; }
		public DateTime fechaVto { get; set; }
		public String empresa { get; set; }
		public Int32 cliente { get; set; }
		public Decimal importe { get; set; }
		public Int32 medioPago { get; set; }
		public Int32 sucursal { get; set; }
	

	}


}
