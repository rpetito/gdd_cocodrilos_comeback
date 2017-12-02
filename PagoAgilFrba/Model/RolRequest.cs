using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model {



	class RolRequest {

		public String descripcion { get; set; }
		public String funcionalidades {get; set;}


		public RolRequest() {
			this.funcionalidades = "";
		}

		public void addFuncionalidad(Int32 funcionalidadID) {
 			if(this.funcionalidades.Equals("")) {
				this.funcionalidades = funcionalidadID.ToString();
			} else {
				this.funcionalidades = this.funcionalidades + "&" + funcionalidadID.ToString(); 
			}
		}

	}


}
