namespace PagoAgilFrba.AbmCliente
{
    partial class BajaCliente
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
            this.FiltroGB = new System.Windows.Forms.GroupBox();
            this.DniTB = new System.Windows.Forms.TextBox();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.Dni = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.BajaClienteGV = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.FiltroGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BajaClienteGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroGB
            // 
            this.FiltroGB.Controls.Add(this.DniTB);
            this.FiltroGB.Controls.Add(this.ApellidoTB);
            this.FiltroGB.Controls.Add(this.NombreTB);
            this.FiltroGB.Controls.Add(this.Dni);
            this.FiltroGB.Controls.Add(this.Apellido);
            this.FiltroGB.Controls.Add(this.Nombre);
            this.FiltroGB.Location = new System.Drawing.Point(12, 12);
            this.FiltroGB.Name = "FiltroGB";
            this.FiltroGB.Size = new System.Drawing.Size(400, 111);
            this.FiltroGB.TabIndex = 0;
            this.FiltroGB.TabStop = false;
            this.FiltroGB.Text = "Filtro";
            // 
            // DniTB
            // 
            this.DniTB.Location = new System.Drawing.Point(81, 69);
            this.DniTB.Name = "DniTB";
            this.DniTB.Size = new System.Drawing.Size(100, 20);
            this.DniTB.TabIndex = 5;
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Location = new System.Drawing.Point(263, 25);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(100, 20);
            this.ApellidoTB.TabIndex = 4;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(81, 25);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 3;
            // 
            // Dni
            // 
            this.Dni.AutoSize = true;
            this.Dni.Location = new System.Drawing.Point(46, 72);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(29, 13);
            this.Dni.TabIndex = 2;
            this.Dni.Text = "DNI:";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(210, 28);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(47, 13);
            this.Apellido.TabIndex = 1;
            this.Apellido.Text = "Apellido:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(28, 28);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(12, 129);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 1;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarButton.Location = new System.Drawing.Point(337, 129);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 2;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // BajaClienteGV
            // 
            this.BajaClienteGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BajaClienteGV.Location = new System.Drawing.Point(12, 168);
            this.BajaClienteGV.Name = "BajaClienteGV";
            this.BajaClienteGV.Size = new System.Drawing.Size(400, 199);
            this.BajaClienteGV.TabIndex = 6;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 376);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 406);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BajaClienteGV);
            this.Controls.Add(this.FiltroGB);
            this.Name = "BajaCliente";
            this.Text = "BajaCliente";
            this.FiltroGB.ResumeLayout(false);
            this.FiltroGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BajaClienteGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FiltroGB;
        private System.Windows.Forms.TextBox DniTB;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label Dni;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.DataGridView BajaClienteGV;
        private System.Windows.Forms.Button CancelarButton;
    }
}