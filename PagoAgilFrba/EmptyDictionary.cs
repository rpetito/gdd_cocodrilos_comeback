using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba {

	
	class EmptyDictionary<K> : Dictionary<K,String> {

		public EmptyDictionary(K empty) : base() {
			Add(empty, "Todos");
		}

	}

}
