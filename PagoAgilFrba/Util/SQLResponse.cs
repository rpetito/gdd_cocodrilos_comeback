using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Util {

	class SQLResponse<T> {
		public Action<T> onSuccess;
		public Action<Error> onError;
	}

}
