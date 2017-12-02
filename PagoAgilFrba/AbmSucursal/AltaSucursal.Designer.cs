namespace PagoAgilFrba.AbmSucursal
{
    partial class AltaSucursal
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
            this.Nombre = new System.Windows.Forms.Label();
            this.CodigoPostal = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.DireccionTB = new System.Windows.Forms.TextBox();
            this.CodigoPostalTB = new System.Windows.Forms.TextBox();
            this.SucursalGB = new System.Windows.Forms.GroupBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.CrearButton = new System.Windows.Forms.Button();
            this.SucursalGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(24, 26);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSize = true;
            this.CodigoPostal.Location = new System.Drawing.Point(24, 106);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.CodigoPostal.TabIndex = 1;
            this.CodigoPostal.Text = "Código Postal:";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(24, 66);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(55, 13);
            this.Direccion.TabIndex = 2;
            this.Direccion.Text = "Dirección:";
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(105, 23);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 3;
            // 
            // DireccionTB
            // 
            this.DireccionTB.Location = new System.Drawing.Point(105, 63);
            this.DireccionTB.Name = "DireccionTB";
            this.DireccionTB.Size = new System.Drawing.Size(100, 20);
            this.DireccionTB.TabIndex = 4;
            // 
            // CodigoPostalTB
            // 
            this.CodigoPostalTB.Location = new System.Drawing.Point(105, 103);
            this.CodigoPostalTB.Name = "CodigoPostalTB";
            this.CodigoPostalTB.Size = new System.Drawing.Size(100, 20);
            this.CodigoPostalTB.TabIndex = 5;
            // 
            // SucursalGB
            // 
            this.SucursalGB.Controls.Add(this.Direccion);
            this.SucursalGB.Controls.Add(this.Nombre);
            this.SucursalGB.Controls.Add(this.CodigoPostal);
            this.SucursalGB.Controls.Add(this.DireccionTB);
            this.SucursalGB.Controls.Add(this.CodigoPostalTB);
            this.SucursalGB.Controls.Add(this.NombreTB);
            this.SucursalGB.Location = new System.Drawing.Point(12, 12);
            this.SucursalGB.Name = "SucursalGB";
            this.SucursalGB.Size = new System.Drawing.Size(239, 145);
            this.SucursalGB.TabIndex = 6;
            this.SucursalGB.TabStop = false;
            this.SucursalGB.Text = "Sucursal";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 192);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(95, 192);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 8;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // CrearButton
            // 
            this.CrearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearButton.Location = new System.Drawing.Point(179, 192);
            this.CrearButton.Name = "CrearButton";
            this.CrearButton.Size = new System.Drawing.Size(75, 23);
            this.CrearButton.TabIndex = 9;
            this.CrearButton.Text = "Crear";
            this.CrearButton.UseVisualStyleBackColor = true;
            this.CrearButton.Click += new System.EventHandler(this.CrearButton_Click);
            // 
            // AltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 228);
            this.Controls.Add(this.CrearButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.SucursalGB);
            this.Name = "AltaSucursal";
            this.Text = "AltaSucursal";
            this.SucursalGB.ResumeLayout(false);
            this.SucursalGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label CodigoPostal;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox DireccionTB;
        private System.Windows.Forms.TextBox CodigoPostalTB;
        private System.Windows.Forms.GroupBox SucursalGB;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CrearButton;
    }
}