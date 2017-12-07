namespace PagoAgilFrba.Devolucion
{
    partial class Devolucion
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
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.DevolucionesGV = new System.Windows.Forms.DataGridView();
            this.FiltroGB = new System.Windows.Forms.GroupBox();
            this.EmpresaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FacturaTB = new System.Windows.Forms.TextBox();
            this.ClienteTB = new System.Windows.Forms.TextBox();
            this.CodigoPostal = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DevolucionesGV)).BeginInit();
            this.FiltroGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(97, 338);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 27);
            this.CancelarButton.TabIndex = 24;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarButton.Location = new System.Drawing.Point(422, 89);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 27);
            this.FiltrarButton.TabIndex = 22;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(97, 89);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 27);
            this.LimpiarButton.TabIndex = 21;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // DevolucionesGV
            // 
            this.DevolucionesGV.AllowUserToAddRows = false;
            this.DevolucionesGV.AllowUserToDeleteRows = false;
            this.DevolucionesGV.AllowUserToOrderColumns = true;
            this.DevolucionesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DevolucionesGV.Location = new System.Drawing.Point(97, 122);
            this.DevolucionesGV.MultiSelect = false;
            this.DevolucionesGV.Name = "DevolucionesGV";
            this.DevolucionesGV.ReadOnly = true;
            this.DevolucionesGV.Size = new System.Drawing.Size(400, 191);
            this.DevolucionesGV.TabIndex = 23;
            // 
            // FiltroGB
            // 
            this.FiltroGB.Controls.Add(this.EmpresaTB);
            this.FiltroGB.Controls.Add(this.label1);
            this.FiltroGB.Controls.Add(this.FacturaTB);
            this.FiltroGB.Controls.Add(this.ClienteTB);
            this.FiltroGB.Controls.Add(this.CodigoPostal);
            this.FiltroGB.Controls.Add(this.Nombre);
            this.FiltroGB.Location = new System.Drawing.Point(97, 12);
            this.FiltroGB.Name = "FiltroGB";
            this.FiltroGB.Size = new System.Drawing.Size(400, 71);
            this.FiltroGB.TabIndex = 20;
            this.FiltroGB.TabStop = false;
            this.FiltroGB.Text = "Filtro";
            // 
            // EmpresaTB
            // 
            this.EmpresaTB.Location = new System.Drawing.Point(279, 45);
            this.EmpresaTB.Name = "EmpresaTB";
            this.EmpresaTB.Size = new System.Drawing.Size(100, 20);
            this.EmpresaTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empresa:";
            // 
            // FacturaTB
            // 
            this.FacturaTB.Location = new System.Drawing.Point(279, 19);
            this.FacturaTB.Name = "FacturaTB";
            this.FacturaTB.Size = new System.Drawing.Size(100, 20);
            this.FacturaTB.TabIndex = 5;
            // 
            // ClienteTB
            // 
            this.ClienteTB.Location = new System.Drawing.Point(83, 19);
            this.ClienteTB.Name = "ClienteTB";
            this.ClienteTB.Size = new System.Drawing.Size(100, 20);
            this.ClienteTB.TabIndex = 3;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSize = true;
            this.CodigoPostal.Location = new System.Drawing.Point(227, 22);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(46, 13);
            this.CodigoPostal.TabIndex = 2;
            this.CodigoPostal.Text = "Factura:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(22, 22);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(42, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Cliente:";
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 387);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.DevolucionesGV);
            this.Controls.Add(this.FiltroGB);
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            ((System.ComponentModel.ISupportInitialize)(this.DevolucionesGV)).EndInit();
            this.FiltroGB.ResumeLayout(false);
            this.FiltroGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.DataGridView DevolucionesGV;
        private System.Windows.Forms.GroupBox FiltroGB;
        private System.Windows.Forms.TextBox FacturaTB;
        private System.Windows.Forms.TextBox ClienteTB;
        private System.Windows.Forms.Label CodigoPostal;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox EmpresaTB;
        private System.Windows.Forms.Label label1;
    }
}