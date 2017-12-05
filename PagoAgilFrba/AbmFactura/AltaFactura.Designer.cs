namespace PagoAgilFrba.AbmFactura
{
    partial class AltaFactura
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
			this.Cliente = new System.Windows.Forms.Label();
			this.Empresa = new System.Windows.Forms.Label();
			this.nroFacturaLabel = new System.Windows.Forms.Label();
			this.TotalTB = new System.Windows.Forms.Label();
			this.FecAlta = new System.Windows.Forms.Label();
			this.FecVenc = new System.Windows.Forms.Label();
			this.FacturaGB = new System.Windows.Forms.GroupBox();
			this.EmpresaTB3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.EmpresaTB2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.VencimientoDP = new System.Windows.Forms.DateTimePicker();
			this.AltaDP = new System.Windows.Forms.DateTimePicker();
			this.FacturaTB = new System.Windows.Forms.TextBox();
			this.EmpresaTB1 = new System.Windows.Forms.TextBox();
			this.ClienteTB = new System.Windows.Forms.TextBox();
			this.ItemsFacturaGV = new System.Windows.Forms.DataGridView();
			this.CancelarButton = new System.Windows.Forms.Button();
			this.LimpiarButton = new System.Windows.Forms.Button();
			this.CrearButton = new System.Windows.Forms.Button();
			this.agregarItemButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.FacturaGB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemsFacturaGV)).BeginInit();
			this.SuspendLayout();
			// 
			// Cliente
			// 
			this.Cliente.AutoSize = true;
			this.Cliente.Location = new System.Drawing.Point(83, 25);
			this.Cliente.Name = "Cliente";
			this.Cliente.Size = new System.Drawing.Size(42, 13);
			this.Cliente.TabIndex = 0;
			this.Cliente.Text = "Cliente:";
			// 
			// Empresa
			// 
			this.Empresa.AutoSize = true;
			this.Empresa.Location = new System.Drawing.Point(83, 55);
			this.Empresa.Name = "Empresa";
			this.Empresa.Size = new System.Drawing.Size(51, 13);
			this.Empresa.TabIndex = 1;
			this.Empresa.Text = "Empresa:";
			// 
			// nroFacturaLabel
			// 
			this.nroFacturaLabel.AutoSize = true;
			this.nroFacturaLabel.Location = new System.Drawing.Point(83, 85);
			this.nroFacturaLabel.Name = "nroFacturaLabel";
			this.nroFacturaLabel.Size = new System.Drawing.Size(61, 13);
			this.nroFacturaLabel.TabIndex = 2;
			this.nroFacturaLabel.Text = "Nº Factura:";
			// 
			// TotalTB
			// 
			this.TotalTB.AutoSize = true;
			this.TotalTB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalTB.Location = new System.Drawing.Point(353, 372);
			this.TotalTB.Name = "TotalTB";
			this.TotalTB.Padding = new System.Windows.Forms.Padding(5);
			this.TotalTB.Size = new System.Drawing.Size(89, 25);
			this.TotalTB.TabIndex = 6;
			this.TotalTB.Text = "$999999999";
			// 
			// FecAlta
			// 
			this.FecAlta.AutoSize = true;
			this.FecAlta.Location = new System.Drawing.Point(83, 116);
			this.FecAlta.Name = "FecAlta";
			this.FecAlta.Size = new System.Drawing.Size(75, 13);
			this.FecAlta.TabIndex = 7;
			this.FecAlta.Text = "Fecha de alta:";
			// 
			// FecVenc
			// 
			this.FecVenc.AutoSize = true;
			this.FecVenc.Location = new System.Drawing.Point(83, 148);
			this.FecVenc.Name = "FecVenc";
			this.FecVenc.Size = new System.Drawing.Size(86, 13);
			this.FecVenc.TabIndex = 8;
			this.FecVenc.Text = "Fecha de Venc.:";
			// 
			// FacturaGB
			// 
			this.FacturaGB.Controls.Add(this.EmpresaTB3);
			this.FacturaGB.Controls.Add(this.label2);
			this.FacturaGB.Controls.Add(this.EmpresaTB2);
			this.FacturaGB.Controls.Add(this.label1);
			this.FacturaGB.Controls.Add(this.VencimientoDP);
			this.FacturaGB.Controls.Add(this.AltaDP);
			this.FacturaGB.Controls.Add(this.FacturaTB);
			this.FacturaGB.Controls.Add(this.EmpresaTB1);
			this.FacturaGB.Controls.Add(this.ClienteTB);
			this.FacturaGB.Controls.Add(this.FecVenc);
			this.FacturaGB.Controls.Add(this.Cliente);
			this.FacturaGB.Controls.Add(this.FecAlta);
			this.FacturaGB.Controls.Add(this.Empresa);
			this.FacturaGB.Controls.Add(this.nroFacturaLabel);
			this.FacturaGB.Location = new System.Drawing.Point(12, 12);
			this.FacturaGB.Name = "FacturaGB";
			this.FacturaGB.Size = new System.Drawing.Size(425, 192);
			this.FacturaGB.TabIndex = 9;
			this.FacturaGB.TabStop = false;
			this.FacturaGB.Text = "Factura";
			// 
			// EmpresaTB3
			// 
			this.EmpresaTB3.Location = new System.Drawing.Point(341, 52);
			this.EmpresaTB3.Name = "EmpresaTB3";
			this.EmpresaTB3.Size = new System.Drawing.Size(27, 20);
			this.EmpresaTB3.TabIndex = 19;
			this.EmpresaTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpresaTB3_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(325, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "-";
			// 
			// EmpresaTB2
			// 
			this.EmpresaTB2.Location = new System.Drawing.Point(225, 52);
			this.EmpresaTB2.Name = "EmpresaTB2";
			this.EmpresaTB2.Size = new System.Drawing.Size(94, 20);
			this.EmpresaTB2.TabIndex = 17;
			this.EmpresaTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpresaTB2_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(209, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "-";
			// 
			// VencimientoDP
			// 
			this.VencimientoDP.Location = new System.Drawing.Point(175, 142);
			this.VencimientoDP.Name = "VencimientoDP";
			this.VencimientoDP.Size = new System.Drawing.Size(108, 20);
			this.VencimientoDP.TabIndex = 15;
			// 
			// AltaDP
			// 
			this.AltaDP.Location = new System.Drawing.Point(175, 112);
			this.AltaDP.Name = "AltaDP";
			this.AltaDP.Size = new System.Drawing.Size(108, 20);
			this.AltaDP.TabIndex = 14;
			// 
			// FacturaTB
			// 
			this.FacturaTB.Location = new System.Drawing.Point(175, 82);
			this.FacturaTB.Name = "FacturaTB";
			this.FacturaTB.Size = new System.Drawing.Size(108, 20);
			this.FacturaTB.TabIndex = 10;
			// 
			// EmpresaTB1
			// 
			this.EmpresaTB1.Location = new System.Drawing.Point(175, 52);
			this.EmpresaTB1.Name = "EmpresaTB1";
			this.EmpresaTB1.Size = new System.Drawing.Size(27, 20);
			this.EmpresaTB1.TabIndex = 12;
			this.EmpresaTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpresaTB1_KeyPress);
			// 
			// ClienteTB
			// 
			this.ClienteTB.Location = new System.Drawing.Point(175, 22);
			this.ClienteTB.Name = "ClienteTB";
			this.ClienteTB.Size = new System.Drawing.Size(108, 20);
			this.ClienteTB.TabIndex = 10;
			this.ClienteTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClienteTB_KeyPress);
			// 
			// ItemsFacturaGV
			// 
			this.ItemsFacturaGV.AllowUserToAddRows = false;
			this.ItemsFacturaGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemsFacturaGV.Location = new System.Drawing.Point(12, 210);
			this.ItemsFacturaGV.Name = "ItemsFacturaGV";
			this.ItemsFacturaGV.Size = new System.Drawing.Size(425, 150);
			this.ItemsFacturaGV.TabIndex = 10;
			this.ItemsFacturaGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ItemsFacturaGV_ItemAdded);
			this.ItemsFacturaGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ItemsFacturaGV_ItemRemoved);
			// 
			// CancelarButton
			// 
			this.CancelarButton.Location = new System.Drawing.Point(12, 444);
			this.CancelarButton.Name = "CancelarButton";
			this.CancelarButton.Size = new System.Drawing.Size(75, 23);
			this.CancelarButton.TabIndex = 12;
			this.CancelarButton.Text = "Cancelar";
			this.CancelarButton.UseVisualStyleBackColor = true;
			this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
			// 
			// LimpiarButton
			// 
			this.LimpiarButton.Location = new System.Drawing.Point(187, 444);
			this.LimpiarButton.Name = "LimpiarButton";
			this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
			this.LimpiarButton.TabIndex = 13;
			this.LimpiarButton.Text = "Limpiar";
			this.LimpiarButton.UseVisualStyleBackColor = true;
			this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
			// 
			// CrearButton
			// 
			this.CrearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CrearButton.Location = new System.Drawing.Point(362, 444);
			this.CrearButton.Name = "CrearButton";
			this.CrearButton.Size = new System.Drawing.Size(75, 23);
			this.CrearButton.TabIndex = 14;
			this.CrearButton.Text = "Crear";
			this.CrearButton.UseVisualStyleBackColor = true;
			this.CrearButton.Click += new System.EventHandler(this.CrearButton_Click);
			// 
			// agregarItemButton
			// 
			this.agregarItemButton.Location = new System.Drawing.Point(12, 374);
			this.agregarItemButton.Name = "agregarItemButton";
			this.agregarItemButton.Size = new System.Drawing.Size(95, 23);
			this.agregarItemButton.TabIndex = 15;
			this.agregarItemButton.Text = "Agregar Item";
			this.agregarItemButton.UseVisualStyleBackColor = true;
			this.agregarItemButton.Click += new System.EventHandler(this.agregarItemButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(307, 379);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Total:";
			// 
			// AltaFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 479);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.agregarItemButton);
			this.Controls.Add(this.CrearButton);
			this.Controls.Add(this.LimpiarButton);
			this.Controls.Add(this.CancelarButton);
			this.Controls.Add(this.ItemsFacturaGV);
			this.Controls.Add(this.FacturaGB);
			this.Controls.Add(this.TotalTB);
			this.Name = "AltaFactura";
			this.Text = "AltaFactura";
			this.FacturaGB.ResumeLayout(false);
			this.FacturaGB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemsFacturaGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.Label nroFacturaLabel;
        private System.Windows.Forms.Label TotalTB;
        private System.Windows.Forms.Label FecAlta;
        private System.Windows.Forms.Label FecVenc;
        private System.Windows.Forms.GroupBox FacturaGB;
        private System.Windows.Forms.DateTimePicker VencimientoDP;
        private System.Windows.Forms.DateTimePicker AltaDP;
		private System.Windows.Forms.TextBox FacturaTB;
		private System.Windows.Forms.TextBox EmpresaTB1;
        private System.Windows.Forms.TextBox ClienteTB;
		private System.Windows.Forms.DataGridView ItemsFacturaGV;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CrearButton;
		private System.Windows.Forms.Button agregarItemButton;
		private System.Windows.Forms.TextBox EmpresaTB3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox EmpresaTB2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
    }
}