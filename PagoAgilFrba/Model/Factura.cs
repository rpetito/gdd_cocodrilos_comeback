using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model {
	

	public class Factura {

		public Int32 numero { get; set; }
		public Int32 cliente { get; set; }
		public String empresa { get; set; }
		public DateTime fechaEmision { get; set; }
		public DateTime fechaVto { get; set; }
		public Decimal total { get; set; }
		public List<ItemFactura> items { get; set; }
		public int habilitada { get; set; }
		public int pagada { get; set; }
		public int rendida { get; set; }

		public Factura() {
			this.items = new List<ItemFactura>();
		}


		public void addItem(Decimal precio, Int32 cant) {
			ItemFactura item = new ItemFactura(precio, cant);
			this.items.Add(item);
		}

		public void addItem(Int32 id, Decimal precio, Int32 cant) {
			ItemFactura item = new ItemFactura(id, precio, cant);
			this.items.Add(item);
		}


		public void updateItem(Int32 id, Decimal precio, Int32 cant) {
			foreach(ItemFactura item in this.items) {
				if(item.id == id) {
					item.precio = precio;
					item.cantidad = cant;
				}
			}
		}

		public Decimal getTotal() {
			Decimal total = 0;
			foreach(ItemFactura item in items) {
				total += item.precio * item.cantidad;
			}
			return total;
		}

		public String getItemsAsStream() {
			String output = "";
			foreach(ItemFactura i in this.items) {
				String cant = i.cantidad.ToString();
				String precio = i.precio.ToString().Replace(',', '.');
				if(output.Equals("")) {
					output = precio + ";" + cant;
				} else {
					output = output + "&" + precio + ";" + cant;
				}
			}
			return output;
		}

		public String getItemAsStreamWithId() {
			String output = "";
			foreach(ItemFactura i in this.items) {
				String id = i.id.ToString();
				String cant = i.cantidad.ToString();
				String precio = i.precio.ToString().Replace(',', '.');
				if(output.Equals("")) {
					output = id + ";" + precio + ";" + cant;
				} else {
					output = output + "&" + id + ";" + precio + ";" + cant;
				}
			}
			return output;
		}

		
	
	}

}
