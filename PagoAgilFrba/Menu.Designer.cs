namespace PagoAgilFrba
{
    partial class Menu
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
            this.ClienteButton = new System.Windows.Forms.Button();
            this.EmpresaButton = new System.Windows.Forms.Button();
            this.FacturaButton = new System.Windows.Forms.Button();
            this.RolButton = new System.Windows.Forms.Button();
            this.SucursalButton = new System.Windows.Forms.Button();
            this.ListadoEstadistico = new System.Windows.Forms.Button();
            this.Rendicion = new System.Windows.Forms.Button();
            this.RegistroPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClienteButton
            // 
            this.ClienteButton.Location = new System.Drawing.Point(129, 72);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(75, 23);
            this.ClienteButton.TabIndex = 0;
            this.ClienteButton.Text = "Clientes";
            this.ClienteButton.UseVisualStyleBackColor = true;
            this.ClienteButton.Click += new System.EventHandler(this.ClienteButton_Click);
            // 
            // EmpresaButton
            // 
            this.EmpresaButton.Location = new System.Drawing.Point(129, 112);
            this.EmpresaButton.Name = "EmpresaButton";
            this.EmpresaButton.Size = new System.Drawing.Size(75, 23);
            this.EmpresaButton.TabIndex = 1;
            this.EmpresaButton.Text = "Empresas";
            this.EmpresaButton.UseVisualStyleBackColor = true;
            this.EmpresaButton.Click += new System.EventHandler(this.EmpresaButton_Click);
            // 
            // FacturaButton
            // 
            this.FacturaButton.Location = new System.Drawing.Point(129, 163);
            this.FacturaButton.Name = "FacturaButton";
            this.FacturaButton.Size = new System.Drawing.Size(75, 23);
            this.FacturaButton.TabIndex = 2;
            this.FacturaButton.Text = "Facturas";
            this.FacturaButton.UseVisualStyleBackColor = true;
            this.FacturaButton.Click += new System.EventHandler(this.FacturaButton_Click);
            // 
            // RolButton
            // 
            this.RolButton.Location = new System.Drawing.Point(129, 205);
            this.RolButton.Name = "RolButton";
            this.RolButton.Size = new System.Drawing.Size(75, 23);
            this.RolButton.TabIndex = 3;
            this.RolButton.Text = "Roles";
            this.RolButton.UseVisualStyleBackColor = true;
            this.RolButton.Click += new System.EventHandler(this.RolButton_Click);
            // 
            // SucursalButton
            // 
            this.SucursalButton.Location = new System.Drawing.Point(129, 252);
            this.SucursalButton.Name = "SucursalButton";
            this.SucursalButton.Size = new System.Drawing.Size(75, 23);
            this.SucursalButton.TabIndex = 4;
            this.SucursalButton.Text = "Sucursales";
            this.SucursalButton.UseVisualStyleBackColor = true;
            this.SucursalButton.Click += new System.EventHandler(this.SucursalButton_Click);
            // 
            // ListadoEstadistico
            // 
            this.ListadoEstadistico.Location = new System.Drawing.Point(226, 163);
            this.ListadoEstadistico.Name = "ListadoEstadistico";
            this.ListadoEstadistico.Size = new System.Drawing.Size(106, 23);
            this.ListadoEstadistico.TabIndex = 5;
            this.ListadoEstadistico.Text = "Listado Estadístico";
            this.ListadoEstadistico.UseVisualStyleBackColor = true;
            this.ListadoEstadistico.Click += new System.EventHandler(this.ListadoEstadistico_Click);
            // 
            // Rendicion
            // 
            this.Rendicion.Location = new System.Drawing.Point(226, 112);
            this.Rendicion.Name = "Rendicion";
            this.Rendicion.Size = new System.Drawing.Size(106, 23);
            this.Rendicion.TabIndex = 6;
            this.Rendicion.Text = "Rendición";
            this.Rendicion.UseVisualStyleBackColor = true;
            this.Rendicion.Click += new System.EventHandler(this.Rendicion_Click);
            // 
            // RegistroPago
            // 
            this.RegistroPago.Location = new System.Drawing.Point(226, 205);
            this.RegistroPago.Name = "RegistroPago";
            this.RegistroPago.Size = new System.Drawing.Size(106, 23);
            this.RegistroPago.TabIndex = 7;
            this.RegistroPago.Text = "Registro Pago";
            this.RegistroPago.UseVisualStyleBackColor = true;
            this.RegistroPago.Click += new System.EventHandler(this.RegistroPago_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 335);
            this.Controls.Add(this.RegistroPago);
            this.Controls.Add(this.Rendicion);
            this.Controls.Add(this.ListadoEstadistico);
            this.Controls.Add(this.SucursalButton);
            this.Controls.Add(this.RolButton);
            this.Controls.Add(this.FacturaButton);
            this.Controls.Add(this.EmpresaButton);
            this.Controls.Add(this.ClienteButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClienteButton;
        private System.Windows.Forms.Button EmpresaButton;
        private System.Windows.Forms.Button FacturaButton;
        private System.Windows.Forms.Button RolButton;
        private System.Windows.Forms.Button SucursalButton;
        private System.Windows.Forms.Button ListadoEstadistico;
        private System.Windows.Forms.Button Rendicion;
        private System.Windows.Forms.Button RegistroPago;
    }
}