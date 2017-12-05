using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba {

	class CustomComboBox<K> : ComboBox {

		private Dictionary<K, String> dataSource;
		public Dictionary<K, String> data { get { return this.dataSource; } set { this.dataSource = value; } }

		public CustomComboBox() : base() {
			this.dataSource = new Dictionary<K, string>();
		}


		public K getSelectedItemID() {
			return dataSource.FirstOrDefault(x => x.Value.Equals(Text.ToString())).Key;
		}


		public void addItem(K key, String text) {
			Items.Add(text);
			this.dataSource.Add(key, text);
		}


	}


}
