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
            this.CantFacturas = new System.Windows.Forms.Label();
            this.FacturasGV = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.ComisionPorcentaje = new System.Windows.Forms.Label();
            this.ComisionPorcentajeTB = new System.Windows.Forms.TextBox();
            this.RendicionTotal = new System.Windows.Forms.Label();
            this.Empresa = new System.Windows.Forms.Label();
            this.ComisionPesos = new System.Windows.Forms.Label();
            this.EmpresaTB = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.RendirButton = new System.Windows.Forms.Button();
            this.FacturasButton = new System.Windows.Forms.Button();
            this.FechaCB = new System.Windows.Forms.ComboBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ComisionLabel = new System.Windows.Forms.Label();
            this.RendicionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(76, 22);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(40, 13);
            this.Fecha.TabIndex = 0;
            this.Fecha.Text = "Fecha:";
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
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(33, 289);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total:";
            // 
            // ComisionPorcentaje
            // 
            this.ComisionPorcentaje.AutoSize = true;
            this.ComisionPorcentaje.Location = new System.Drawing.Point(33, 315);
            this.ComisionPorcentaje.Name = "ComisionPorcentaje";
            this.ComisionPorcentaje.Size = new System.Drawing.Size(69, 13);
            this.ComisionPorcentaje.TabIndex = 7;
            this.ComisionPorcentaje.Text = "Comisión (%):";
            // 
            // ComisionPorcentajeTB
            // 
            this.ComisionPorcentajeTB.Location = new System.Drawing.Point(114, 312);
            this.ComisionPorcentajeTB.Name = "ComisionPorcentajeTB";
            this.ComisionPorcentajeTB.Size = new System.Drawing.Size(30, 20);
            this.ComisionPorcentajeTB.TabIndex = 8;
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
            this.Empresa.Location = new System.Drawing.Point(65, 59);
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
            this.EmpresaTB.Location = new System.Drawing.Point(122, 54);
            this.EmpresaTB.Name = "EmpresaTB";
            this.EmpresaTB.Size = new System.Drawing.Size(100, 20);
            this.EmpresaTB.TabIndex = 13;
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
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
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
            this.RendirButton.Click += new System.EventHandler(this.RendirButton_Click);
            // 
            // FacturasButton
            // 
            this.FacturasButton.Location = new System.Drawing.Point(256, 71);
            this.FacturasButton.Name = "FacturasButton";
            this.FacturasButton.Size = new System.Drawing.Size(104, 23);
            this.FacturasButton.TabIndex = 22;
            this.FacturasButton.Text = "Buscar Facturas";
            this.FacturasButton.UseVisualStyleBackColor = true;
            this.FacturasButton.Click += new System.EventHandler(this.FacturasButton_Click);
            // 
            // FechaCB
            // 
            this.FechaCB.FormattingEnabled = true;
            this.FechaCB.Location = new System.Drawing.Point(122, 19);
            this.FechaCB.Name = "FechaCB";
            this.FechaCB.Size = new System.Drawing.Size(100, 21);
            this.FechaCB.TabIndex = 23;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Location = new System.Drawing.Point(133, 263);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(13, 13);
            this.CantidadLabel.TabIndex = 24;
            this.CantidadLabel.Text = "0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(111, 289);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 13);
            this.TotalLabel.TabIndex = 25;
            this.TotalLabel.Text = "$ 0,00";
            // 
            // ComisionLabel
            // 
            this.ComisionLabel.AutoSize = true;
            this.ComisionLabel.Location = new System.Drawing.Point(291, 315);
            this.ComisionLabel.Name = "ComisionLabel";
            this.ComisionLabel.Size = new System.Drawing.Size(37, 13);
            this.ComisionLabel.TabIndex = 26;
            this.ComisionLabel.Text = "$ 0,00";
            // 
            // RendicionLabel
            // 
            this.RendicionLabel.AutoSize = true;
            this.RendicionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RendicionLabel.Location = new System.Drawing.Point(293, 363);
            this.RendicionLabel.Name = "RendicionLabel";
            this.RendicionLabel.Size = new System.Drawing.Size(43, 13);
            this.RendicionLabel.TabIndex = 27;
            this.RendicionLabel.Text = "$ 0,00";
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 452);
            this.Controls.Add(this.RendicionLabel);
            this.Controls.Add(this.ComisionLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.FechaCB);
            this.Controls.Add(this.FacturasButton);
            this.Controls.Add(this.RendirButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EmpresaTB);
            this.Controls.Add(this.ComisionPesos);
            this.Controls.Add(this.Empresa);
            this.Controls.Add(this.RendicionTotal);
            this.Controls.Add(this.ComisionPorcentajeTB);
            this.Controls.Add(this.ComisionPorcentaje);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.FacturasGV);
            this.Controls.Add(this.CantFacturas);
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
        private System.Windows.Forms.Label CantFacturas;
        private System.Windows.Forms.DataGridView FacturasGV;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label ComisionPorcentaje;
        private System.Windows.Forms.TextBox ComisionPorcentajeTB;
        private System.Windows.Forms.Label RendicionTotal;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.Label ComisionPesos;
        private System.Windows.Forms.TextBox EmpresaTB;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button RendirButton;
        private System.Windows.Forms.Button FacturasButton;
        private System.Windows.Forms.ComboBox FechaCB;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label ComisionLabel;
        private System.Windows.Forms.Label RendicionLabel;
    }
}