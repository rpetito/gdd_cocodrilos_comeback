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
            this.Sucursal = new System.Windows.Forms.Label();
            this.SucursalCB = new System.Windows.Forms.ComboBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.RendirButton = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 372);
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
            this.AgregarButton.Location = new System.Drawing.Point(291, 74);
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
            this.FacturasGV.Location = new System.Drawing.Point(12, 115);
            this.FacturasGV.MultiSelect = false;
            this.FacturasGV.Name = "FacturasGV";
            this.FacturasGV.ReadOnly = true;
            this.FacturasGV.Size = new System.Drawing.Size(400, 199);
            this.FacturasGV.TabIndex = 15;
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSize = true;
            this.Sucursal.Location = new System.Drawing.Point(108, 35);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(51, 13);
            this.Sucursal.TabIndex = 17;
            this.Sucursal.Text = "Sucursal:";
            // 
            // SucursalCB
            // 
            this.SucursalCB.FormattingEnabled = true;
            this.SucursalCB.Location = new System.Drawing.Point(165, 32);
            this.SucursalCB.Name = "SucursalCB";
            this.SucursalCB.Size = new System.Drawing.Size(121, 21);
            this.SucursalCB.TabIndex = 18;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(165, 371);
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
            this.RendirButton.Location = new System.Drawing.Point(337, 372);
            this.RendirButton.Name = "RendirButton";
            this.RendirButton.Size = new System.Drawing.Size(75, 23);
            this.RendirButton.TabIndex = 20;
            this.RendirButton.Text = "Rendir";
            this.RendirButton.UseVisualStyleBackColor = true;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(272, 337);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 21;
            this.Total.Text = "Total:";
            // 
            // TotalTB
            // 
            this.TotalTB.Location = new System.Drawing.Point(312, 334);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(100, 20);
            this.TotalTB.TabIndex = 22;
            // 
            // RegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 406);
            this.Controls.Add(this.TotalTB);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.RendirButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.SucursalCB);
            this.Controls.Add(this.Sucursal);
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
        private System.Windows.Forms.Label Sucursal;
        private System.Windows.Forms.ComboBox SucursalCB;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button RendirButton;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox TotalTB;
    }
}