namespace PagoAgilFrba.AbmSucursal
{
    partial class BajaSucursal
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
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.BajaSucursalGV = new System.Windows.Forms.DataGridView();
            this.FiltroGB = new System.Windows.Forms.GroupBox();
            this.DireccionTB = new System.Windows.Forms.TextBox();
            this.CodigoPostalTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.CodigoPostal = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BajaSucursalGV)).BeginInit();
            this.FiltroGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarButton.Location = new System.Drawing.Point(337, 133);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 13;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(12, 133);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 12;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // BajaSucursalGV
            // 
            this.BajaSucursalGV.AllowUserToAddRows = false;
            this.BajaSucursalGV.AllowUserToDeleteRows = false;
            this.BajaSucursalGV.AllowUserToOrderColumns = true;
            this.BajaSucursalGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BajaSucursalGV.Location = new System.Drawing.Point(12, 172);
            this.BajaSucursalGV.MultiSelect = false;
            this.BajaSucursalGV.Name = "BajaSucursalGV";
            this.BajaSucursalGV.ReadOnly = true;
            this.BajaSucursalGV.Size = new System.Drawing.Size(400, 199);
            this.BajaSucursalGV.TabIndex = 14;
            // 
            // FiltroGB
            // 
            this.FiltroGB.Controls.Add(this.DireccionTB);
            this.FiltroGB.Controls.Add(this.CodigoPostalTB);
            this.FiltroGB.Controls.Add(this.NombreTB);
            this.FiltroGB.Controls.Add(this.CodigoPostal);
            this.FiltroGB.Controls.Add(this.Direccion);
            this.FiltroGB.Controls.Add(this.Nombre);
            this.FiltroGB.Location = new System.Drawing.Point(12, 16);
            this.FiltroGB.Name = "FiltroGB";
            this.FiltroGB.Size = new System.Drawing.Size(400, 111);
            this.FiltroGB.TabIndex = 11;
            this.FiltroGB.TabStop = false;
            this.FiltroGB.Text = "Filtro";
            // 
            // DireccionTB
            // 
            this.DireccionTB.Location = new System.Drawing.Point(83, 71);
            this.DireccionTB.Name = "DireccionTB";
            this.DireccionTB.Size = new System.Drawing.Size(100, 20);
            this.DireccionTB.TabIndex = 6;
            // 
            // CodigoPostalTB
            // 
            this.CodigoPostalTB.Location = new System.Drawing.Point(279, 25);
            this.CodigoPostalTB.Name = "CodigoPostalTB";
            this.CodigoPostalTB.Size = new System.Drawing.Size(100, 20);
            this.CodigoPostalTB.TabIndex = 5;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(83, 25);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 3;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSize = true;
            this.CodigoPostal.Location = new System.Drawing.Point(203, 28);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.CodigoPostal.TabIndex = 2;
            this.CodigoPostal.Text = "Código Postal:";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(22, 74);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(55, 13);
            this.Direccion.TabIndex = 1;
            this.Direccion.Text = "Dirección:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(22, 28);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 377);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 15;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarB
            // 
            this.EliminarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarB.Location = new System.Drawing.Point(337, 377);
            this.EliminarB.Name = "EliminarB";
            this.EliminarB.Size = new System.Drawing.Size(75, 23);
            this.EliminarB.TabIndex = 16;
            this.EliminarB.Text = "Eliminar";
            this.EliminarB.UseVisualStyleBackColor = true;
            this.EliminarB.Click += new System.EventHandler(this.EliminarB_Click);
            // 
            // BajaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 406);
            this.Controls.Add(this.EliminarB);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BajaSucursalGV);
            this.Controls.Add(this.FiltroGB);
            this.Name = "BajaSucursal";
            this.Text = "BajaSucursal";
            ((System.ComponentModel.ISupportInitialize)(this.BajaSucursalGV)).EndInit();
            this.FiltroGB.ResumeLayout(false);
            this.FiltroGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.DataGridView BajaSucursalGV;
        private System.Windows.Forms.GroupBox FiltroGB;
        private System.Windows.Forms.TextBox DireccionTB;
        private System.Windows.Forms.TextBox CodigoPostalTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label CodigoPostal;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button EliminarB;
    }
}