﻿using System;
using System.Collections.Generic;
using System.Data;
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

		public static void addButtonSeleccionarColumnToGridView(DataGridView gridView, DataGridViewCellEventHandler listener) {
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = "Seleccionar";
			button.Name = "seleccionarButton";
			button.Text = "Seleccionar";
			button.UseColumnTextForButtonValue = true;
			gridView.Columns.Add(button);
			gridView.CellContentClick += listener;
			gridView.AllowUserToAddRows = false;
			button.Frozen = true;
		}

		public static void addButtonColumnToGridView(DataGridView gridView, String text, DataGridViewCellEventHandler listener = null) {
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = text;
			button.Name = text + "Button";
			button.Text = text;
			button.UseColumnTextForButtonValue = true;
			gridView.Columns.Add(button);
			if(listener != null) {
				gridView.CellContentClick += listener;
			}
			button.Frozen = true;
		}


		public static Boolean onlyNumbersText(String text) {
			Regex pattern = new Regex("^\\d+([\\,\\d]{1,2})?$");
			return pattern.IsMatch(text);
		}


		public static void handleOnlyNumbersLengthInput(String text, int maxLength, KeyPressEventArgs e) {
			if(text.Length < maxLength) {
				if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
					e.Handled = true;
				}
			} else {
				if(!char.IsControl(e.KeyChar)) {
					e.Handled = true;
				}
			}
		}


		public static String getPlainTextFromCurrency(String text) {
			return text.Substring(2, (text.Length - 2));
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


		public static void CopyDataTable(DataTable to, DataTable from) { 
			foreach(DataColumn column in from.Columns) {
				to.Columns.Add(column);
			}
			foreach(DataRow row in from.Rows) {
				to.Rows.Add(row);
			}
		}

		public static void AddColumnWithValue(DataTable dataTable, String columnName, Int32 value) {
			dataTable.Columns.Add(columnName);
			foreach(DataRow row in dataTable.Rows) {
				row.ItemArray[dataTable.Rows.Count - 1] = value;
			}
		}

    }


}
