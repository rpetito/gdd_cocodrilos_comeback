using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Util {

	class SQLExecutorHelper<T> {
		public Func<String> getProcedureName;
		public Action<SqlCommand> addParams;
		public Action<T> onReadData;
		public Action<Boolean> onDataProcessed;
		public Action<Error> onError;
	}

}
