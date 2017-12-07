using System;
namespace PagoAgilFrba.RegistroPago
{
    partial class RegistroPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.CancelarButton = new System.Windows.Forms.Button();
			this.AgregarButton = new System.Windows.Forms.Button();
			this.FacturasGV = new System.Windows.Forms.DataGridView();
			this.LimpiarButton = new System.Windows.Forms.Button();
			this.RendirButton = new System.Windows.Forms.Button();
			this.Total = new System.Windows.Forms.Label();
			this.registroPagoTotalLabel = new System.Windows.Forms.Label();
			this.medioDePagoCB = new CustomComboBox<Int32>();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.FacturasGV)).BeginInit();
			this.SuspendLayout();
			// 
			// CancelarButton
			// 
			this.CancelarButton.Location = new System.Drawing.Point(12, 351);
			this.CancelarButton.Name = "CancelarButton";
			this.CancelarButton.Size = new System.Drawing.Size(75, 23);
			this.CancelarButton.TabIndex = 16;
			this.CancelarButton.Text = "Cancelar";
			this.CancelarButton.UseVisualStyleBackColor = true;
			this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
			// 
			// AgregarButton
			// 
			this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AgregarButton.Location = new System.Drawing.Point(12, 229);
			this.AgregarButton.Name = "AgregarButton";
			this.AgregarButton.Size = new System.Drawing.Size(121, 23);
			this.AgregarButton.TabIndex = 14;
			this.AgregarButton.Text = "Agregar Factura";
			this.AgregarButton.UseVisualStyleBackColor = true;
			this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
			// 
			// FacturasGV
			// 
			this.FacturasGV.AllowUserToAddRows = false;
			this.FacturasGV.AllowUserToDeleteRows = false;
			this.FacturasGV.AllowUserToOrderColumns = true;
			this.FacturasGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FacturasGV.Location = new System.Drawing.Point(12, 12);
			this.FacturasGV.MultiSelect = false;
			this.FacturasGV.Name = "FacturasGV";
			this.FacturasGV.ReadOnly = true;
			this.FacturasGV.Size = new System.Drawing.Size(400, 199);
			this.FacturasGV.TabIndex = 15;
			// 
			// LimpiarButton
			// 
			this.LimpiarButton.Location = new System.Drawing.Point(176, 351);
			this.LimpiarButton.Name = "LimpiarButton";
			this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
			this.LimpiarButton.TabIndex = 19;
			this.LimpiarButton.Text = "Limpiar";
			this.LimpiarButton.UseVisualStyleBackColor = true;
			this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
			// 
			// RendirButton
			// 
			this.RendirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RendirButton.Location = new System.Drawing.Point(337, 351);
			this.RendirButton.Name = "RendirButton";
			this.RendirButton.Size = new System.Drawing.Size(75, 23);
			this.RendirButton.TabIndex = 20;
			this.RendirButton.Text = "Rendir";
			this.RendirButton.UseVisualStyleBackColor = true;
			this.RendirButton.Click += new System.EventHandler(this.RendirButton_Click);
			// 
			// Total
			// 
			this.Total.AutoSize = true;
			this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Total.Location = new System.Drawing.Point(288, 227);
			this.Total.Name = "Total";
			this.Total.Padding = new System.Windows.Forms.Padding(5);
			this.Total.Size = new System.Drawing.Size(50, 23);
			this.Total.TabIndex = 21;
			this.Total.Text = "Total:";
			// 
			// registroPagoTotalLabel
			// 
			this.registroPagoTotalLabel.AutoSize = true;
			this.registroPagoTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.registroPagoTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registroPagoTotalLabel.Location = new System.Drawing.Point(344, 227);
			this.registroPagoTotalLabel.Name = "registroPagoTotalLabel";
			this.registroPagoTotalLabel.Padding = new System.Windows.Forms.Padding(5);
			this.registroPagoTotalLabel.Size = new System.Drawing.Size(68, 25);
			this.registroPagoTotalLabel.TabIndex = 22;
			this.registroPagoTotalLabel.Text = "9999999";
			// 
			// medioDePagoCB
			// 
			this.medioDePagoCB.FormattingEnabled = true;
			this.medioDePagoCB.Location = new System.Drawing.Point(282, 272);
			this.medioDePagoCB.Name = "medioDePagoCB";
			this.medioDePagoCB.Size = new System.Drawing.Size(121, 21);
			this.medioDePagoCB.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(194, 275);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Medio de Pago:";
			// 
			// RegistroPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 386);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.medioDePagoCB);
			this.Controls.Add(this.registroPagoTotalLabel);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.RendirButton);
			this.Controls.Add(this.LimpiarButton);
			this.Controls.Add(this.CancelarButton);
			this.Controls.Add(this.AgregarButton);
			this.Controls.Add(this.FacturasGV);
			this.Name = "RegistroPago";
			this.RightToLeftLayout = true;
			this.Text = "Registro Pago";
			((System.ComponentModel.ISupportInitialize)(this.FacturasGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AgregarButton;
		private System.Windows.Forms.DataGridView FacturasGV;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button RendirButton;
		private System.Windows.Forms.Label Total;
		private System.Windows.Forms.Label registroPagoTotalLabel;
		private CustomComboBox<Int32> medioDePagoCB;
		private System.Windows.Forms.Label label1;
    }
}