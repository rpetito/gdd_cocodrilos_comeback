namespace PagoAgilFrba.AbmEmpresa
{
    partial class DatosEmpresa
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
            this.EmpresaGB = new System.Windows.Forms.GroupBox();
            this.EstadoCB = new System.Windows.Forms.CheckBox();
            this.RubroCB = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.CuitTB = new System.Windows.Forms.TextBox();
            this.DireccionTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.Rubro = new System.Windows.Forms.Label();
            this.Dni = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.FecRendicion = new System.Windows.Forms.Label();
            this.FecRendicionTB = new System.Windows.Forms.TextBox();
            this.EmpresaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(352, 235);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 11;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(186, 235);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 10;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(21, 235);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 9;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EmpresaGB
            // 
            this.EmpresaGB.Controls.Add(this.FecRendicionTB);
            this.EmpresaGB.Controls.Add(this.FecRendicion);
            this.EmpresaGB.Controls.Add(this.EstadoCB);
            this.EmpresaGB.Controls.Add(this.RubroCB);
            this.EmpresaGB.Controls.Add(this.Estado);
            this.EmpresaGB.Controls.Add(this.CuitTB);
            this.EmpresaGB.Controls.Add(this.DireccionTB);
            this.EmpresaGB.Controls.Add(this.NombreTB);
            this.EmpresaGB.Controls.Add(this.Rubro);
            this.EmpresaGB.Controls.Add(this.Dni);
            this.EmpresaGB.Controls.Add(this.Nombre);
            this.EmpresaGB.Controls.Add(this.Direccion);
            this.EmpresaGB.Location = new System.Drawing.Point(12, 12);
            this.EmpresaGB.Name = "EmpresaGB";
            this.EmpresaGB.Size = new System.Drawing.Size(426, 189);
            this.EmpresaGB.TabIndex = 8;
            this.EmpresaGB.TabStop = false;
            this.EmpresaGB.Text = "Empresa";
            // 
            // EstadoCB
            // 
            this.EstadoCB.AutoSize = true;
            this.EstadoCB.Location = new System.Drawing.Point(190, 151);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(73, 17);
            this.EstadoCB.TabIndex = 23;
            this.EstadoCB.Text = "Habilitado";
            this.EstadoCB.UseVisualStyleBackColor = true;
            // 
            // RubroCB
            // 
            this.RubroCB.FormattingEnabled = true;
            this.RubroCB.Location = new System.Drawing.Point(284, 54);
            this.RubroCB.Name = "RubroCB";
            this.RubroCB.Size = new System.Drawing.Size(100, 21);
            this.RubroCB.TabIndex = 22;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(141, 152);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(43, 13);
            this.Estado.TabIndex = 13;
            this.Estado.Text = "Estado:";
            // 
            // CuitTB
            // 
            this.CuitTB.Location = new System.Drawing.Point(80, 54);
            this.CuitTB.Name = "CuitTB";
            this.CuitTB.Size = new System.Drawing.Size(100, 20);
            this.CuitTB.TabIndex = 13;
            // 
            // DireccionTB
            // 
            this.DireccionTB.Location = new System.Drawing.Point(284, 21);
            this.DireccionTB.Name = "DireccionTB";
            this.DireccionTB.Size = new System.Drawing.Size(100, 20);
            this.DireccionTB.TabIndex = 21;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(80, 21);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 11;
            // 
            // Rubro
            // 
            this.Rubro.AutoSize = true;
            this.Rubro.Location = new System.Drawing.Point(239, 57);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(39, 13);
            this.Rubro.TabIndex = 6;
            this.Rubro.Text = "Rubro:";
            // 
            // Dni
            // 
            this.Dni.AutoSize = true;
            this.Dni.Location = new System.Drawing.Point(39, 57);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(35, 13);
            this.Dni.TabIndex = 3;
            this.Dni.Text = "CUIT:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(27, 24);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre:";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(223, 24);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(55, 13);
            this.Direccion.TabIndex = 0;
            this.Direccion.Text = "Dirección:";
            // 
            // FecRendicion
            // 
            this.FecRendicion.AutoSize = true;
            this.FecRendicion.Location = new System.Drawing.Point(90, 94);
            this.FecRendicion.Name = "FecRendicion";
            this.FecRendicion.Size = new System.Drawing.Size(94, 13);
            this.FecRendicion.TabIndex = 24;
            this.FecRendicion.Text = "Día de Rendición:";
            // 
            // FecRendicionTB
            // 
            this.FecRendicionTB.Location = new System.Drawing.Point(190, 91);
            this.FecRendicionTB.Name = "FecRendicionTB";
            this.FecRendicionTB.Size = new System.Drawing.Size(100, 20);
            this.FecRendicionTB.TabIndex = 25;
            // 
            // DatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 270);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EmpresaGB);
            this.Name = "DatosEmpresa";
            this.Text = "DatosEmpresa";
            this.EmpresaGB.ResumeLayout(false);
            this.EmpresaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.GroupBox EmpresaGB;
        private System.Windows.Forms.ComboBox RubroCB;
        private System.Windows.Forms.TextBox CuitTB;
        private System.Windows.Forms.TextBox DireccionTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label Rubro;
        private System.Windows.Forms.Label Dni;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.CheckBox EstadoCB;
        private System.Windows.Forms.TextBox FecRendicionTB;
        private System.Windows.Forms.Label FecRendicion;
    }
}