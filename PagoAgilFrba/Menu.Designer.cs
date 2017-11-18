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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 335);
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
    }
}