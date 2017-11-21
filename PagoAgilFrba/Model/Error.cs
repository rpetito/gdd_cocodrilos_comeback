using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model {

	class Error {

		private String title;
		private String message;

		public static Error errorWithMessage(String message) {
			Error error = new Error();
			error.title = "Error";
			error.message = message;
			return error;
		}


		public void setTitle(String title) {
			this.title = title;
		}

		public String getTitle() {
			return this.title;
		}

		public void setMessage(String message) {
			this.message = message;
		}

		public String getMessage() {
			return this.message;
		}
	
	}

}
