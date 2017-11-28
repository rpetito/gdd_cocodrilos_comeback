namespace PagoAgilFrba.AbmFactura
{
    partial class BajaFactura
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
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.BajaFacturaGV = new System.Windows.Forms.DataGridView();
            this.FiltroGB = new System.Windows.Forms.GroupBox();
            this.FacturaButton = new System.Windows.Forms.Button();
            this.FacturaTB = new System.Windows.Forms.TextBox();
            this.Factura = new System.Windows.Forms.Label();
            this.EmpresaButton = new System.Windows.Forms.Button();
            this.ClienteButton = new System.Windows.Forms.Button();
            this.EmpresaTB = new System.Windows.Forms.TextBox();
            this.ClienteTB = new System.Windows.Forms.TextBox();
            this.Empresa = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BajaFacturaGV)).BeginInit();
            this.FiltroGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarButton.Location = new System.Drawing.Point(337, 168);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 21;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(12, 168);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 20;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // BajaFacturaGV
            // 
            this.BajaFacturaGV.AllowUserToAddRows = false;
            this.BajaFacturaGV.AllowUserToDeleteRows = false;
            this.BajaFacturaGV.AllowUserToOrderColumns = true;
            this.BajaFacturaGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BajaFacturaGV.Location = new System.Drawing.Point(12, 206);
            this.BajaFacturaGV.MultiSelect = false;
            this.BajaFacturaGV.Name = "BajaFacturaGV";
            this.BajaFacturaGV.ReadOnly = true;
            this.BajaFacturaGV.Size = new System.Drawing.Size(400, 199);
            this.BajaFacturaGV.TabIndex = 22;
            // 
            // FiltroGB
            // 
            this.FiltroGB.Controls.Add(this.FacturaButton);
            this.FiltroGB.Controls.Add(this.FacturaTB);
            this.FiltroGB.Controls.Add(this.Factura);
            this.FiltroGB.Controls.Add(this.EmpresaButton);
            this.FiltroGB.Controls.Add(this.ClienteButton);
            this.FiltroGB.Controls.Add(this.EmpresaTB);
            this.FiltroGB.Controls.Add(this.ClienteTB);
            this.FiltroGB.Controls.Add(this.Empresa);
            this.FiltroGB.Controls.Add(this.Cliente);
            this.FiltroGB.Location = new System.Drawing.Point(12, 14);
            this.FiltroGB.Name = "FiltroGB";
            this.FiltroGB.Size = new System.Drawing.Size(400, 136);
            this.FiltroGB.TabIndex = 19;
            this.FiltroGB.TabStop = false;
            this.FiltroGB.Text = "Filtro";
            // 
            // FacturaButton
            // 
            this.FacturaButton.Location = new System.Drawing.Point(264, 83);
            this.FacturaButton.Name = "FacturaButton";
            this.FacturaButton.Size = new System.Drawing.Size(34, 23);
            this.FacturaButton.TabIndex = 10;
            this.FacturaButton.Text = "...";
            this.FacturaButton.UseVisualStyleBackColor = true;
            // 
            // FacturaTB
            // 
            this.FacturaTB.Enabled = false;
            this.FacturaTB.Location = new System.Drawing.Point(158, 85);
            this.FacturaTB.Name = "FacturaTB";
            this.FacturaTB.Size = new System.Drawing.Size(100, 20);
            this.FacturaTB.TabIndex = 9;
            // 
            // Factura
            // 
            this.Factura.AutoSize = true;
            this.Factura.Location = new System.Drawing.Point(85, 88);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(61, 13);
            this.Factura.TabIndex = 8;
            this.Factura.Text = "Nº Factura:";
            // 
            // EmpresaButton
            // 
            this.EmpresaButton.Location = new System.Drawing.Point(264, 54);
            this.EmpresaButton.Name = "EmpresaButton";
            this.EmpresaButton.Size = new System.Drawing.Size(34, 23);
            this.EmpresaButton.TabIndex = 7;
            this.EmpresaButton.Text = "...";
            this.EmpresaButton.UseVisualStyleBackColor = true;
            // 
            // ClienteButton
            // 
            this.ClienteButton.Location = new System.Drawing.Point(264, 23);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(34, 23);
            this.ClienteButton.TabIndex = 6;
            this.ClienteButton.Text = "...";
            this.ClienteButton.UseVisualStyleBackColor = true;
            // 
            // EmpresaTB
            // 
            this.EmpresaTB.Enabled = false;
            this.EmpresaTB.Location = new System.Drawing.Point(158, 55);
            this.EmpresaTB.Name = "EmpresaTB";
            this.EmpresaTB.Size = new System.Drawing.Size(100, 20);
            this.EmpresaTB.TabIndex = 5;
            // 
            // ClienteTB
            // 
            this.ClienteTB.Enabled = false;
            this.ClienteTB.Location = new System.Drawing.Point(158, 25);
            this.ClienteTB.Name = "ClienteTB";
            this.ClienteTB.Size = new System.Drawing.Size(100, 20);
            this.ClienteTB.TabIndex = 3;
            // 
            // Empresa
            // 
            this.Empresa.AutoSize = true;
            this.Empresa.Location = new System.Drawing.Point(85, 59);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(51, 13);
            this.Empresa.TabIndex = 2;
            this.Empresa.Text = "Empresa:";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(85, 28);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(42, 13);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 411);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 23;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // BajaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 439);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BajaFacturaGV);
            this.Controls.Add(this.FiltroGB);
            this.Name = "BajaFactura";
            this.Text = "BajaFactura";
            ((System.ComponentModel.ISupportInitialize)(this.BajaFacturaGV)).EndInit();
            this.FiltroGB.ResumeLayout(false);
            this.FiltroGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.DataGridView BajaFacturaGV;
        private System.Windows.Forms.GroupBox FiltroGB;
        private System.Windows.Forms.Button FacturaButton;
        private System.Windows.Forms.TextBox FacturaTB;
        private System.Windows.Forms.Label Factura;
        private System.Windows.Forms.Button EmpresaButton;
        private System.Windows.Forms.Button ClienteButton;
        private System.Windows.Forms.TextBox EmpresaTB;
        private System.Windows.Forms.TextBox ClienteTB;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Button CancelarButton;
    }
}