using System;
namespace PagoAgilFrba.RegistroPago
{
    partial class AgregarFacturas
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
			this.NumFactura = new System.Windows.Forms.Label();
			this.FecCobro = new System.Windows.Forms.Label();
			this.Empresa = new System.Windows.Forms.Label();
			this.Cliente = new System.Windows.Forms.Label();
			this.FecVencimiento = new System.Windows.Forms.Label();
			this.Importe = new System.Windows.Forms.Label();
			this.FecVencimientoDP = new System.Windows.Forms.DateTimePicker();
			this.FecCobroDP = new System.Windows.Forms.DateTimePicker();
			this.NumFacturaTB = new System.Windows.Forms.TextBox();
			this.ImporteTB = new System.Windows.Forms.TextBox();
			this.ClienteTB = new System.Windows.Forms.TextBox();
			this.CancelarButton = new System.Windows.Forms.Button();
			this.LimpiarButton = new System.Windows.Forms.Button();
			this.AgregarButton = new System.Windows.Forms.Button();
			this.agregarFacturaPagoEmpresaCB = new FilterComboBox<String>("");
			this.SuspendLayout();
			// 
			// NumFactura
			// 
			this.NumFactura.AutoSize = true;
			this.NumFactura.Location = new System.Drawing.Point(26, 29);
			this.NumFactura.Name = "NumFactura";
			this.NumFactura.Size = new System.Drawing.Size(61, 13);
			this.NumFactura.TabIndex = 0;
			this.NumFactura.Text = "N° Factura:";
			// 
			// FecCobro
			// 
			this.FecCobro.AutoSize = true;
			this.FecCobro.Location = new System.Drawing.Point(26, 111);
			this.FecCobro.Name = "FecCobro";
			this.FecCobro.Size = new System.Drawing.Size(86, 13);
			this.FecCobro.TabIndex = 1;
			this.FecCobro.Text = "Fecha de Cobro:";
			// 
			// Empresa
			// 
			this.Empresa.AutoSize = true;
			this.Empresa.Location = new System.Drawing.Point(26, 188);
			this.Empresa.Name = "Empresa";
			this.Empresa.Size = new System.Drawing.Size(51, 13);
			this.Empresa.TabIndex = 2;
			this.Empresa.Text = "Empresa:";
			// 
			// Cliente
			// 
			this.Cliente.AutoSize = true;
			this.Cliente.Location = new System.Drawing.Point(26, 149);
			this.Cliente.Name = "Cliente";
			this.Cliente.Size = new System.Drawing.Size(42, 13);
			this.Cliente.TabIndex = 3;
			this.Cliente.Text = "Cliente:";
			// 
			// FecVencimiento
			// 
			this.FecVencimiento.AutoSize = true;
			this.FecVencimiento.Location = new System.Drawing.Point(26, 74);
			this.FecVencimiento.Name = "FecVencimiento";
			this.FecVencimiento.Size = new System.Drawing.Size(86, 13);
			this.FecVencimiento.TabIndex = 4;
			this.FecVencimiento.Text = "Fecha de Venc.:";
			// 
			// Importe
			// 
			this.Importe.AutoSize = true;
			this.Importe.Location = new System.Drawing.Point(26, 229);
			this.Importe.Name = "Importe";
			this.Importe.Size = new System.Drawing.Size(45, 13);
			this.Importe.TabIndex = 5;
			this.Importe.Text = "Importe:";
			// 
			// FecVencimientoDP
			// 
			this.FecVencimientoDP.Location = new System.Drawing.Point(118, 68);
			this.FecVencimientoDP.Name = "FecVencimientoDP";
			this.FecVencimientoDP.Size = new System.Drawing.Size(116, 20);
			this.FecVencimientoDP.TabIndex = 6;
			// 
			// FecCobroDP
			// 
			this.FecCobroDP.Enabled = false;
			this.FecCobroDP.Location = new System.Drawing.Point(118, 105);
			this.FecCobroDP.Name = "FecCobroDP";
			this.FecCobroDP.Size = new System.Drawing.Size(116, 20);
			this.FecCobroDP.TabIndex = 7;
			// 
			// NumFacturaTB
			// 
			this.NumFacturaTB.Location = new System.Drawing.Point(118, 26);
			this.NumFacturaTB.Name = "NumFacturaTB";
			this.NumFacturaTB.Size = new System.Drawing.Size(116, 20);
			this.NumFacturaTB.TabIndex = 8;
			// 
			// ImporteTB
			// 
			this.ImporteTB.Location = new System.Drawing.Point(118, 226);
			this.ImporteTB.Name = "ImporteTB";
			this.ImporteTB.Size = new System.Drawing.Size(116, 20);
			this.ImporteTB.TabIndex = 9;
			// 
			// ClienteTB
			// 
			this.ClienteTB.Enabled = false;
			this.ClienteTB.Location = new System.Drawing.Point(118, 146);
			this.ClienteTB.Name = "ClienteTB";
			this.ClienteTB.Size = new System.Drawing.Size(116, 20);
			this.ClienteTB.TabIndex = 10;
			// 
			// CancelarButton
			// 
			this.CancelarButton.Location = new System.Drawing.Point(12, 290);
			this.CancelarButton.Name = "CancelarButton";
			this.CancelarButton.Size = new System.Drawing.Size(75, 23);
			this.CancelarButton.TabIndex = 12;
			this.CancelarButton.Text = "Cancelar";
			this.CancelarButton.UseVisualStyleBackColor = true;
			this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
			// 
			// LimpiarButton
			// 
			this.LimpiarButton.Location = new System.Drawing.Point(118, 290);
			this.LimpiarButton.Name = "LimpiarButton";
			this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
			this.LimpiarButton.TabIndex = 13;
			this.LimpiarButton.Text = "Limpiar";
			this.LimpiarButton.UseVisualStyleBackColor = true;
			this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
			// 
			// AgregarButton
			// 
			this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AgregarButton.Location = new System.Drawing.Point(224, 290);
			this.AgregarButton.Name = "AgregarButton";
			this.AgregarButton.Size = new System.Drawing.Size(75, 23);
			this.AgregarButton.TabIndex = 14;
			this.AgregarButton.Text = "Agregar";
			this.AgregarButton.UseVisualStyleBackColor = true;
			this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
			// 
			// agregarFacturaPagoEmpresaCB
			// 
			this.agregarFacturaPagoEmpresaCB.FormattingEnabled = true;
			this.agregarFacturaPagoEmpresaCB.Location = new System.Drawing.Point(118, 185);
			this.agregarFacturaPagoEmpresaCB.Name = "agregarFacturaPagoEmpresaCB";
			this.agregarFacturaPagoEmpresaCB.Size = new System.Drawing.Size(121, 21);
			this.agregarFacturaPagoEmpresaCB.TabIndex = 15;
			// 
			// AgregarFacturas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 325);
			this.Controls.Add(this.agregarFacturaPagoEmpresaCB);
			this.Controls.Add(this.AgregarButton);
			this.Controls.Add(this.LimpiarButton);
			this.Controls.Add(this.CancelarButton);
			this.Controls.Add(this.ClienteTB);
			this.Controls.Add(this.ImporteTB);
			this.Controls.Add(this.NumFacturaTB);
			this.Controls.Add(this.FecCobroDP);
			this.Controls.Add(this.FecVencimientoDP);
			this.Controls.Add(this.Importe);
			this.Controls.Add(this.FecVencimiento);
			this.Controls.Add(this.Cliente);
			this.Controls.Add(this.Empresa);
			this.Controls.Add(this.FecCobro);
			this.Controls.Add(this.NumFactura);
			this.Name = "AgregarFacturas";
			this.Text = "Agregar Facturas";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumFactura;
        private System.Windows.Forms.Label FecCobro;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label FecVencimiento;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.DateTimePicker FecVencimientoDP;
        private System.Windows.Forms.DateTimePicker FecCobroDP;
        private System.Windows.Forms.TextBox NumFacturaTB;
        private System.Windows.Forms.TextBox ImporteTB;
		private System.Windows.Forms.TextBox ClienteTB;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button LimpiarButton;
		private System.Windows.Forms.Button AgregarButton;
		private FilterComboBox<String> agregarFacturaPagoEmpresaCB;
    }
}