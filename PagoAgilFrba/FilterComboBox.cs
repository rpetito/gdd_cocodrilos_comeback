using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba {

	class FilterComboBox<K> : CustomComboBox<K> {

		private K emptyID;

		public FilterComboBox(K emptyID) : base() {
			this.emptyID = emptyID;
			addItem(emptyID, "Sin filtro");
			Text = data.FirstOrDefault(x => x.Key.Equals(emptyID)).Value;
		}

		public void clear() {
			Text = data.FirstOrDefault(x => x.Key.Equals(this.emptyID)).Value;
		}

	}
}
