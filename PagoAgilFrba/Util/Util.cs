using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Util {


	class Util {

		public static void showSuccessDialog() {
			MessageBox.Show("Acción completada con éxito.");
		}

		public static void addButtonSeleccionarColumnToGridView(DataGridView gridView, DataGridViewCellEventHandler listener) {
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = "Seleccionar";
			button.Name = "seleccionarButton";
			button.Text = "Seleccionar";
			button.UseColumnTextForButtonValue = true;
			gridView.Columns.Add(button);
			gridView.CellContentClick += listener;
			button.Frozen = true;
		}

        public static void addButtonEliminarColumnToGridView(DataGridView gridView, DataGridViewCellEventHandler listener)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Eliminar";
            button.Name = "eliminarButton";
            button.Text = "Eliminar";
            button.UseColumnTextForButtonValue = true;
            gridView.Columns.Add(button);
            gridView.CellContentClick += listener;
            button.Frozen = true;
        }

    }


}
