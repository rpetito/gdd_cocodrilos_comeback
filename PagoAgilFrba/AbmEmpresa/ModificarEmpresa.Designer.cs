namespace PagoAgilFrba.AbmEmpresa
{
    partial class ModificarEmpresa
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
            this.ModificarEmpresaGV = new System.Windows.Forms.DataGridView();
            this.FiltroGB = new System.Windows.Forms.GroupBox();
            this.RubroCB = new System.Windows.Forms.ComboBox();
            this.CuitTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.Cuit = new System.Windows.Forms.Label();
            this.Rubro = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ModificarEmpresaGV)).BeginInit();
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
            // ModificarEmpresaGV
            // 
            this.ModificarEmpresaGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModificarEmpresaGV.Location = new System.Drawing.Point(12, 172);
            this.ModificarEmpresaGV.Name = "ModificarEmpresaGV";
            this.ModificarEmpresaGV.Size = new System.Drawing.Size(400, 199);
            this.ModificarEmpresaGV.TabIndex = 14;
            // 
            // FiltroGB
            // 
            this.FiltroGB.Controls.Add(this.RubroCB);
            this.FiltroGB.Controls.Add(this.CuitTB);
            this.FiltroGB.Controls.Add(this.NombreTB);
            this.FiltroGB.Controls.Add(this.Cuit);
            this.FiltroGB.Controls.Add(this.Rubro);
            this.FiltroGB.Controls.Add(this.Nombre);
            this.FiltroGB.Location = new System.Drawing.Point(12, 16);
            this.FiltroGB.Name = "FiltroGB";
            this.FiltroGB.Size = new System.Drawing.Size(400, 111);
            this.FiltroGB.TabIndex = 11;
            this.FiltroGB.TabStop = false;
            this.FiltroGB.Text = "Filtro";
            // 
            // RubroCB
            // 
            this.RubroCB.FormattingEnabled = true;
            this.RubroCB.Location = new System.Drawing.Point(255, 25);
            this.RubroCB.Name = "RubroCB";
            this.RubroCB.Size = new System.Drawing.Size(100, 21);
            this.RubroCB.TabIndex = 6;
            // 
            // CuitTB
            // 
            this.CuitTB.Location = new System.Drawing.Point(81, 69);
            this.CuitTB.Name = "CuitTB";
            this.CuitTB.Size = new System.Drawing.Size(100, 20);
            this.CuitTB.TabIndex = 5;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(81, 25);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 3;
            // 
            // Cuit
            // 
            this.Cuit.AutoSize = true;
            this.Cuit.Location = new System.Drawing.Point(40, 72);
            this.Cuit.Name = "Cuit";
            this.Cuit.Size = new System.Drawing.Size(35, 13);
            this.Cuit.TabIndex = 2;
            this.Cuit.Text = "CUIT:";
            // 
            // Rubro
            // 
            this.Rubro.AutoSize = true;
            this.Rubro.Location = new System.Drawing.Point(210, 28);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(39, 13);
            this.Rubro.TabIndex = 1;
            this.Rubro.Text = "Rubro:";
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
            // ModificarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 406);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.ModificarEmpresaGV);
            this.Controls.Add(this.FiltroGB);
            this.Name = "ModificarEmpresa";
            this.Text = "ModificarEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.ModificarEmpresaGV)).EndInit();
            this.FiltroGB.ResumeLayout(false);
            this.FiltroGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.DataGridView ModificarEmpresaGV;
        private System.Windows.Forms.GroupBox FiltroGB;
        private System.Windows.Forms.ComboBox RubroCB;
        private System.Windows.Forms.TextBox CuitTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label Cuit;
        private System.Windows.Forms.Label Rubro;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button CancelarButton;
    }
}