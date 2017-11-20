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
            this.EmpresaTB = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EmpresaButton = new System.Windows.Forms.Button();
            this.ClienteButton = new System.Windows.Forms.Button();
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
            this.FecCobro.Location = new System.Drawing.Point(26, 72);
            this.FecCobro.Name = "FecCobro";
            this.FecCobro.Size = new System.Drawing.Size(86, 13);
            this.FecCobro.TabIndex = 1;
            this.FecCobro.Text = "Fecha de Cobro:";
            // 
            // Empresa
            // 
            this.Empresa.AutoSize = true;
            this.Empresa.Location = new System.Drawing.Point(26, 109);
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
            this.FecVencimiento.Location = new System.Drawing.Point(26, 192);
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
            this.FecVencimientoDP.Location = new System.Drawing.Point(118, 186);
            this.FecVencimientoDP.Name = "FecVencimientoDP";
            this.FecVencimientoDP.Size = new System.Drawing.Size(116, 20);
            this.FecVencimientoDP.TabIndex = 6;
            // 
            // FecCobroDP
            // 
            this.FecCobroDP.Enabled = false;
            this.FecCobroDP.Location = new System.Drawing.Point(118, 66);
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
            // EmpresaTB
            // 
            this.EmpresaTB.Enabled = false;
            this.EmpresaTB.Location = new System.Drawing.Point(118, 106);
            this.EmpresaTB.Name = "EmpresaTB";
            this.EmpresaTB.Size = new System.Drawing.Size(116, 20);
            this.EmpresaTB.TabIndex = 11;
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
            // 
            // EmpresaButton
            // 
            this.EmpresaButton.Location = new System.Drawing.Point(240, 104);
            this.EmpresaButton.Name = "EmpresaButton";
            this.EmpresaButton.Size = new System.Drawing.Size(29, 23);
            this.EmpresaButton.TabIndex = 15;
            this.EmpresaButton.Text = "...";
            this.EmpresaButton.UseVisualStyleBackColor = true;
            this.EmpresaButton.Click += new System.EventHandler(this.EmpresaButton_Click);
            // 
            // ClienteButton
            // 
            this.ClienteButton.Location = new System.Drawing.Point(240, 144);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(29, 23);
            this.ClienteButton.TabIndex = 16;
            this.ClienteButton.Text = "...";
            this.ClienteButton.UseVisualStyleBackColor = true;
            this.ClienteButton.Click += new System.EventHandler(this.ClienteButton_Click);
            // 
            // AgregarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 325);
            this.Controls.Add(this.ClienteButton);
            this.Controls.Add(this.EmpresaButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EmpresaTB);
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
        private System.Windows.Forms.TextBox EmpresaTB;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EmpresaButton;
        private System.Windows.Forms.Button ClienteButton;
    }
}