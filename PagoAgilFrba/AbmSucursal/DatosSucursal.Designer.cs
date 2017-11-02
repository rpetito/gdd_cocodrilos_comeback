namespace PagoAgilFrba.AbmSucursal
{
    partial class DatosSucursal
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
            this.ModificarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SucursalGB = new System.Windows.Forms.GroupBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.CodigoPostal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CodigoPostalTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.SucursalGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(179, 193);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 13;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(95, 193);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 12;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 193);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 11;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // SucursalGB
            // 
            this.SucursalGB.Controls.Add(this.Direccion);
            this.SucursalGB.Controls.Add(this.Nombre);
            this.SucursalGB.Controls.Add(this.CodigoPostal);
            this.SucursalGB.Controls.Add(this.textBox2);
            this.SucursalGB.Controls.Add(this.CodigoPostalTB);
            this.SucursalGB.Controls.Add(this.NombreTB);
            this.SucursalGB.Location = new System.Drawing.Point(12, 13);
            this.SucursalGB.Name = "SucursalGB";
            this.SucursalGB.Size = new System.Drawing.Size(239, 145);
            this.SucursalGB.TabIndex = 10;
            this.SucursalGB.TabStop = false;
            this.SucursalGB.Text = "Sucursal";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // CodigoPostalTB
            // 
            this.CodigoPostalTB.Location = new System.Drawing.Point(105, 103);
            this.CodigoPostalTB.Name = "CodigoPostalTB";
            this.CodigoPostalTB.Size = new System.Drawing.Size(100, 20);
            this.CodigoPostalTB.TabIndex = 5;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(105, 23);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 3;
            // 
            // DatosSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 228);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.SucursalGB);
            this.Name = "DatosSucursal";
            this.Text = "DatosSucursal";
            this.SucursalGB.ResumeLayout(false);
            this.SucursalGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.GroupBox SucursalGB;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label CodigoPostal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox CodigoPostalTB;
        private System.Windows.Forms.TextBox NombreTB;
    }
}