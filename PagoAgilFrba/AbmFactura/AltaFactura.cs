﻿using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Controller;
using PagoAgilFrba.Util;
using PagoAgilFrba.Model; 

namespace PagoAgilFrba.AbmFactura
{
    public partial class AltaFactura : Form
    {

		FacturaController facturaController;
		DataTable itemsFacturaDataTable;

        public AltaFactura()
        {
            InitializeComponent();
			this.facturaController = new FacturaController();
			this.itemsFacturaDataTable = new DataTable();
			this.itemsFacturaDataTable.Columns.Add("Precio");
			this.itemsFacturaDataTable.Columns.Add("Cantidad");
			this.ItemsFacturaGV.DataSource = itemsFacturaDataTable;
			Util.Util.addButtonColumnToGridView(
				ItemsFacturaGV,
				new DataGridViewCellEventHandler(this.AltaFactura_EliminarItemHandler),
				"Eliminar"
			);
			
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            ClienteTB.Clear();
			EmpresaTB1.Clear();
			EmpresaTB2.Clear();
			EmpresaTB3.Clear();
            FacturaTB.Clear();
            AltaDP.ResetText();
            VencimientoDP.ResetText();
			itemsFacturaDataTable.Rows.Clear();
            TotalTB.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void CrearButton_Click(object sender, EventArgs e) {

			Factura factura = new Factura();
			factura.numero = Int32.Parse(FacturaTB.Text.ToString());
			factura.cliente = Int32.Parse(ClienteTB.Text.ToString());
			factura.empresa = EmpresaTB1.Text.ToString() + "-" + EmpresaTB2.Text.ToString() + "-" + EmpresaTB3.Text.ToString();
			factura.fechaEmision = AltaDP.Value.Date;
			factura.fechaVto = VencimientoDP.Value.Date;
			foreach(DataGridViewRow row in ItemsFacturaGV.Rows) {
				Decimal precio = Decimal.Parse(row.Cells[1].Value.ToString());
				Int32 cantidad = Int32.Parse(row.Cells[2].Value.ToString());
				factura.addItem(precio, cantidad);
			}


			this.facturaController.altaFactura(new SQLResponse<Int32>() {

				onSuccess = (Int32 result) => {
					if(result == 0) {
						Util.Util.showSuccessDialog();
					}
				},

				onError = (Error error) => { 
				
				}

			}, factura);
		}


		private void agregarItemButton_Click(object sender, EventArgs e) {
			using(AltaItemFactura altaItemFactura = new AltaItemFactura()) {
				altaItemFactura.ShowDialog();
				String precio = altaItemFactura.precio;
				String cant = altaItemFactura.cantidad;

				if(altaItemFactura.DialogResult == DialogResult.OK) {
					itemsFacturaDataTable.Rows.Add(precio, cant);
				}
				
			}
		}


		private void AltaFactura_EliminarItemHandler(object sender, DataGridViewCellEventArgs e) {

			if(e.ColumnIndex == 0) {
				itemsFacturaDataTable.Rows.Remove(itemsFacturaDataTable.Rows[e.RowIndex]);
			}

		}


		

		


    }
}
