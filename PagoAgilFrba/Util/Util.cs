using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Util {


	class Util {

		public static void showSuccessDialog() {
			MessageBox.Show("Acción completada con éxito.");
		}

		public static void addButtonColumnToGridView(DataGridView gridView, DataGridViewCellEventHandler listener) {
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = "Seleccionar";
			button.Name = "seleccionarButton";
			button.Text = "Seleccionar";
			button.UseColumnTextForButtonValue = true;
			gridView.Columns.Add(button);
			gridView.CellContentClick += listener;
			button.Frozen = true;
		}

		public static void addButtonColumnToGridView(DataGridView gridView, DataGridViewCellEventHandler listener, String text) {
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = text;
			button.Name = text + "Button";
			button.Text = text;
			button.UseColumnTextForButtonValue = true;
			gridView.Columns.Add(button);
			gridView.CellContentClick += listener;
			button.Frozen = true;
		}

		public static Boolean onlyNumbersText(String text) {
			Regex pattern = new Regex("^\\d+([\\.\\d].{1,2})?$");
			return pattern.IsMatch(text);
		}
	
	}


}
