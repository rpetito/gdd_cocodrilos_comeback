namespace PagoAgilFrba.Rendicion
{
    partial class Rendicion
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
            this.Fecha = new System.Windows.Forms.Label();
            this.FechaTB = new System.Windows.Forms.TextBox();
            this.CantFacturasTB = new System.Windows.Forms.TextBox();
            this.CantFacturas = new System.Windows.Forms.Label();
            this.FacturasGV = new System.Windows.Forms.DataGridView();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.ComisionPorcentaje = new System.Windows.Forms.Label();
            this.ComisionPorcentajeTB = new System.Windows.Forms.TextBox();
            this.RendicionTotalTB = new System.Windows.Forms.TextBox();
            this.RendicionTotal = new System.Windows.Forms.Label();
            this.Empresa = new System.Windows.Forms.Label();
            this.ComisionPesos = new System.Windows.Forms.Label();
            this.EmpresaTB = new System.Windows.Forms.TextBox();
            this.ComisionPesosTB = new System.Windows.Forms.TextBox();
            this.EmpresaButton = new System.Windows.Forms.Button();
            this.AgregarFactButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.RendirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(104, 22);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(40, 13);
            this.Fecha.TabIndex = 0;
            this.Fecha.Text = "Fecha:";
            // 
            // FechaTB
            // 
            this.FechaTB.Location = new System.Drawing.Point(150, 19);
            this.FechaTB.Name = "FechaTB";
            this.FechaTB.Size = new System.Drawing.Size(100, 20);
            this.FechaTB.TabIndex = 1;
            // 
            // CantFacturasTB
            // 
            this.CantFacturasTB.Enabled = false;
            this.CantFacturasTB.Location = new System.Drawing.Point(133, 260);
            this.CantFacturasTB.Name = "CantFacturasTB";
            this.CantFacturasTB.Size = new System.Drawing.Size(36, 20);
            this.CantFacturasTB.TabIndex = 2;
            // 
            // CantFacturas
            // 
            this.CantFacturas.AutoSize = true;
            this.CantFacturas.Location = new System.Drawing.Point(33, 263);
            this.CantFacturas.Name = "CantFacturas";
            this.CantFacturas.Size = new System.Drawing.Size(94, 13);
            this.CantFacturas.TabIndex = 3;
            this.CantFacturas.Text = "Cantidad de Fact.:";
            // 
            // FacturasGV
            // 
            this.FacturasGV.AllowUserToAddRows = false;
            this.FacturasGV.AllowUserToDeleteRows = false;
            this.FacturasGV.AllowUserToOrderColumns = true;
            this.FacturasGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturasGV.Location = new System.Drawing.Point(31, 100);
            this.FacturasGV.MultiSelect = false;
            this.FacturasGV.Name = "FacturasGV";
            this.FacturasGV.ReadOnly = true;
            this.FacturasGV.Size = new System.Drawing.Size(329, 150);
            this.FacturasGV.TabIndex = 4;
            // 
            // TotalTB
            // 
            this.TotalTB.Enabled = false;
            this.TotalTB.Location = new System.Drawing.Point(86, 286);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(100, 20);
            this.TotalTB.TabIndex = 5;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(46, 289);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total:";
            // 
            // ComisionPorcentaje
            // 
            this.ComisionPorcentaje.AutoSize = true;
            this.ComisionPorcentaje.Location = new System.Drawing.Point(11, 315);
            this.ComisionPorcentaje.Name = "ComisionPorcentaje";
            this.ComisionPorcentaje.Size = new System.Drawing.Size(69, 13);
            this.ComisionPorcentaje.TabIndex = 7;
            this.ComisionPorcentaje.Text = "Comisión (%):";
            // 
            // ComisionPorcentajeTB
            // 
            this.ComisionPorcentajeTB.Location = new System.Drawing.Point(86, 312);
            this.ComisionPorcentajeTB.Name = "ComisionPorcentajeTB";
            this.ComisionPorcentajeTB.Size = new System.Drawing.Size(100, 20);
            this.ComisionPorcentajeTB.TabIndex = 8;
            // 
            // RendicionTotalTB
            // 
            this.RendicionTotalTB.Location = new System.Drawing.Point(271, 356);
            this.RendicionTotalTB.Name = "RendicionTotalTB";
            this.RendicionTotalTB.Size = new System.Drawing.Size(100, 20);
            this.RendicionTotalTB.TabIndex = 9;
            // 
            // RendicionTotal
            // 
            this.RendicionTotal.AutoSize = true;
            this.RendicionTotal.Location = new System.Drawing.Point(180, 363);
            this.RendicionTotal.Name = "RendicionTotal";
            this.RendicionTotal.Size = new System.Drawing.Size(85, 13);
            this.RendicionTotal.TabIndex = 10;
            this.RendicionTotal.Text = "Rendición Total:";
            // 
            // Empresa
            // 
            this.Empresa.AutoSize = true;
            this.Empresa.Location = new System.Drawing.Point(93, 59);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(51, 13);
            this.Empresa.TabIndex = 11;
            this.Empresa.Text = "Empresa:";
            // 
            // ComisionPesos
            // 
            this.ComisionPesos.AutoSize = true;
            this.ComisionPesos.Location = new System.Drawing.Point(198, 315);
            this.ComisionPesos.Name = "ComisionPesos";
            this.ComisionPesos.Size = new System.Drawing.Size(67, 13);
            this.ComisionPesos.TabIndex = 12;
            this.ComisionPesos.Text = "Comisión ($):";
            // 
            // EmpresaTB
            // 
            this.EmpresaTB.Enabled = false;
            this.EmpresaTB.Location = new System.Drawing.Point(150, 54);
            this.EmpresaTB.Name = "EmpresaTB";
            this.EmpresaTB.Size = new System.Drawing.Size(100, 20);
            this.EmpresaTB.TabIndex = 13;
            // 
            // ComisionPesosTB
            // 
            this.ComisionPesosTB.Enabled = false;
            this.ComisionPesosTB.Location = new System.Drawing.Point(271, 312);
            this.ComisionPesosTB.Name = "ComisionPesosTB";
            this.ComisionPesosTB.Size = new System.Drawing.Size(100, 20);
            this.ComisionPesosTB.TabIndex = 14;
            // 
            // EmpresaButton
            // 
            this.EmpresaButton.Location = new System.Drawing.Point(256, 54);
            this.EmpresaButton.Name = "EmpresaButton";
            this.EmpresaButton.Size = new System.Drawing.Size(29, 23);
            this.EmpresaButton.TabIndex = 15;
            this.EmpresaButton.Text = "...";
            this.EmpresaButton.UseVisualStyleBackColor = true;
            // 
            // AgregarFactButton
            // 
            this.AgregarFactButton.Location = new System.Drawing.Point(261, 258);
            this.AgregarFactButton.Name = "AgregarFactButton";
            this.AgregarFactButton.Size = new System.Drawing.Size(99, 23);
            this.AgregarFactButton.TabIndex = 17;
            this.AgregarFactButton.Text = "Agregar Factura";
            this.AgregarFactButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(31, 417);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 18;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(157, 417);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 19;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // RendirButton
            // 
            this.RendirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RendirButton.Location = new System.Drawing.Point(296, 417);
            this.RendirButton.Name = "RendirButton";
            this.RendirButton.Size = new System.Drawing.Size(75, 23);
            this.RendirButton.TabIndex = 20;
            this.RendirButton.Text = "Rendir";
            this.RendirButton.UseVisualStyleBackColor = true;
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 452);
            this.Controls.Add(this.RendirButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AgregarFactButton);
            this.Controls.Add(this.EmpresaButton);
            this.Controls.Add(this.ComisionPesosTB);
            this.Controls.Add(this.EmpresaTB);
            this.Controls.Add(this.ComisionPesos);
            this.Controls.Add(this.Empresa);
            this.Controls.Add(this.RendicionTotal);
            this.Controls.Add(this.RendicionTotalTB);
            this.Controls.Add(this.ComisionPorcentajeTB);
            this.Controls.Add(this.ComisionPorcentaje);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TotalTB);
            this.Controls.Add(this.FacturasGV);
            this.Controls.Add(this.CantFacturas);
            this.Controls.Add(this.CantFacturasTB);
            this.Controls.Add(this.FechaTB);
            this.Controls.Add(this.Fecha);
            this.Name = "Rendicion";
            this.Text = "Rendición";
            this.Load += new System.EventHandler(this.Rendicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturasGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.TextBox FechaTB;
        private System.Windows.Forms.TextBox CantFacturasTB;
        private System.Windows.Forms.Label CantFacturas;
        private System.Windows.Forms.DataGridView FacturasGV;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label ComisionPorcentaje;
        private System.Windows.Forms.TextBox ComisionPorcentajeTB;
        private System.Windows.Forms.TextBox RendicionTotalTB;
        private System.Windows.Forms.Label RendicionTotal;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.Label ComisionPesos;
        private System.Windows.Forms.TextBox EmpresaTB;
        private System.Windows.Forms.TextBox ComisionPesosTB;
        private System.Windows.Forms.Button EmpresaButton;
        private System.Windows.Forms.Button AgregarFactButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button RendirButton;
    }
}