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
            this.SucursalB = new System.Windows.Forms.Button();
            this.RegistroButton = new System.Windows.Forms.Button();
            this.RendicionButton = new System.Windows.Forms.Button();
            this.DevolucionButton = new System.Windows.Forms.Button();
            this.ListadoEstadisticoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClienteButton
            // 
            this.ClienteButton.Location = new System.Drawing.Point(197, 110);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(75, 23);
            this.ClienteButton.TabIndex = 0;
            this.ClienteButton.Text = "Cliente";
            this.ClienteButton.UseVisualStyleBackColor = true;
            // 
            // EmpresaButton
            // 
            this.EmpresaButton.Location = new System.Drawing.Point(116, 139);
            this.EmpresaButton.Name = "EmpresaButton";
            this.EmpresaButton.Size = new System.Drawing.Size(75, 23);
            this.EmpresaButton.TabIndex = 1;
            this.EmpresaButton.Text = "Empresa";
            this.EmpresaButton.UseVisualStyleBackColor = true;
            // 
            // FacturaButton
            // 
            this.FacturaButton.Location = new System.Drawing.Point(197, 139);
            this.FacturaButton.Name = "FacturaButton";
            this.FacturaButton.Size = new System.Drawing.Size(75, 23);
            this.FacturaButton.TabIndex = 2;
            this.FacturaButton.Text = "Factura";
            this.FacturaButton.UseVisualStyleBackColor = true;
            // 
            // RolButton
            // 
            this.RolButton.Location = new System.Drawing.Point(116, 168);
            this.RolButton.Name = "RolButton";
            this.RolButton.Size = new System.Drawing.Size(75, 23);
            this.RolButton.TabIndex = 3;
            this.RolButton.Text = "Rol";
            this.RolButton.UseVisualStyleBackColor = true;
            // 
            // SucursalB
            // 
            this.SucursalB.Location = new System.Drawing.Point(197, 168);
            this.SucursalB.Name = "SucursalB";
            this.SucursalB.Size = new System.Drawing.Size(75, 23);
            this.SucursalB.TabIndex = 4;
            this.SucursalB.Text = "Sucursal";
            this.SucursalB.UseVisualStyleBackColor = true;
            // 
            // RegistroButton
            // 
            this.RegistroButton.Location = new System.Drawing.Point(73, 197);
            this.RegistroButton.Name = "RegistroButton";
            this.RegistroButton.Size = new System.Drawing.Size(118, 23);
            this.RegistroButton.TabIndex = 5;
            this.RegistroButton.Text = "Registro de Pagos";
            this.RegistroButton.UseVisualStyleBackColor = true;
            // 
            // RendicionButton
            // 
            this.RendicionButton.Location = new System.Drawing.Point(197, 197);
            this.RendicionButton.Name = "RendicionButton";
            this.RendicionButton.Size = new System.Drawing.Size(75, 23);
            this.RendicionButton.TabIndex = 6;
            this.RendicionButton.Text = "Rendición";
            this.RendicionButton.UseVisualStyleBackColor = true;
            // 
            // DevolucionButton
            // 
            this.DevolucionButton.Location = new System.Drawing.Point(73, 226);
            this.DevolucionButton.Name = "DevolucionButton";
            this.DevolucionButton.Size = new System.Drawing.Size(75, 23);
            this.DevolucionButton.TabIndex = 7;
            this.DevolucionButton.Text = "Devolución";
            this.DevolucionButton.UseVisualStyleBackColor = true;
            // 
            // ListadoEstadisticoButton
            // 
            this.ListadoEstadisticoButton.Location = new System.Drawing.Point(154, 226);
            this.ListadoEstadisticoButton.Name = "ListadoEstadisticoButton";
            this.ListadoEstadisticoButton.Size = new System.Drawing.Size(118, 23);
            this.ListadoEstadisticoButton.TabIndex = 8;
            this.ListadoEstadisticoButton.Text = "Listado Estadístico";
            this.ListadoEstadisticoButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ListadoEstadisticoButton);
            this.Controls.Add(this.DevolucionButton);
            this.Controls.Add(this.RendicionButton);
            this.Controls.Add(this.RegistroButton);
            this.Controls.Add(this.SucursalB);
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
        private System.Windows.Forms.Button SucursalB;
        private System.Windows.Forms.Button RegistroButton;
        private System.Windows.Forms.Button RendicionButton;
        private System.Windows.Forms.Button DevolucionButton;
        private System.Windows.Forms.Button ListadoEstadisticoButton;
    }
}