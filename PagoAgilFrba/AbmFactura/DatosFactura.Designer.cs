namespace PagoAgilFrba.AbmFactura
{
    partial class DatosFactura
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
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.ItemsFacturaGV = new System.Windows.Forms.DataGridView();
            this.FacturaGB = new System.Windows.Forms.GroupBox();
            this.VencimientoDP = new System.Windows.Forms.DateTimePicker();
            this.AltaDP = new System.Windows.Forms.DateTimePicker();
            this.FacturaTB = new System.Windows.Forms.TextBox();
            this.EmpresaButton = new System.Windows.Forms.Button();
            this.EmpresaTB = new System.Windows.Forms.TextBox();
            this.ClienteButton = new System.Windows.Forms.Button();
            this.ClienteTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EstadoCB = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsFacturaGV)).BeginInit();
            this.FacturaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(362, 500);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 21;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(187, 500);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 20;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 500);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 19;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // TotalTB
            // 
            this.TotalTB.Enabled = false;
            this.TotalTB.Location = new System.Drawing.Point(337, 377);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(100, 20);
            this.TotalTB.TabIndex = 18;
            // 
            // ItemsFacturaGV
            // 
            this.ItemsFacturaGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsFacturaGV.Location = new System.Drawing.Point(12, 210);
            this.ItemsFacturaGV.Name = "ItemsFacturaGV";
            this.ItemsFacturaGV.Size = new System.Drawing.Size(425, 150);
            this.ItemsFacturaGV.TabIndex = 17;
            // 
            // FacturaGB
            // 
            this.FacturaGB.Controls.Add(this.VencimientoDP);
            this.FacturaGB.Controls.Add(this.AltaDP);
            this.FacturaGB.Controls.Add(this.FacturaTB);
            this.FacturaGB.Controls.Add(this.EmpresaButton);
            this.FacturaGB.Controls.Add(this.EmpresaTB);
            this.FacturaGB.Controls.Add(this.ClienteButton);
            this.FacturaGB.Controls.Add(this.ClienteTB);
            this.FacturaGB.Controls.Add(this.label9);
            this.FacturaGB.Controls.Add(this.label1);
            this.FacturaGB.Controls.Add(this.label8);
            this.FacturaGB.Controls.Add(this.label2);
            this.FacturaGB.Controls.Add(this.label3);
            this.FacturaGB.Location = new System.Drawing.Point(12, 12);
            this.FacturaGB.Name = "FacturaGB";
            this.FacturaGB.Size = new System.Drawing.Size(425, 192);
            this.FacturaGB.TabIndex = 16;
            this.FacturaGB.TabStop = false;
            this.FacturaGB.Text = "Factura";
            // 
            // VencimientoDP
            // 
            this.VencimientoDP.Location = new System.Drawing.Point(175, 142);
            this.VencimientoDP.Name = "VencimientoDP";
            this.VencimientoDP.Size = new System.Drawing.Size(108, 20);
            this.VencimientoDP.TabIndex = 15;
            // 
            // AltaDP
            // 
            this.AltaDP.Enabled = false;
            this.AltaDP.Location = new System.Drawing.Point(175, 112);
            this.AltaDP.Name = "AltaDP";
            this.AltaDP.Size = new System.Drawing.Size(108, 20);
            this.AltaDP.TabIndex = 14;
            // 
            // FacturaTB
            // 
            this.FacturaTB.Enabled = false;
            this.FacturaTB.Location = new System.Drawing.Point(175, 82);
            this.FacturaTB.Name = "FacturaTB";
            this.FacturaTB.Size = new System.Drawing.Size(108, 20);
            this.FacturaTB.TabIndex = 10;
            // 
            // EmpresaButton
            // 
            this.EmpresaButton.Enabled = false;
            this.EmpresaButton.Location = new System.Drawing.Point(298, 50);
            this.EmpresaButton.Name = "EmpresaButton";
            this.EmpresaButton.Size = new System.Drawing.Size(37, 23);
            this.EmpresaButton.TabIndex = 13;
            this.EmpresaButton.Text = "...";
            this.EmpresaButton.UseVisualStyleBackColor = true;
            // 
            // EmpresaTB
            // 
            this.EmpresaTB.Enabled = false;
            this.EmpresaTB.Location = new System.Drawing.Point(175, 52);
            this.EmpresaTB.Name = "EmpresaTB";
            this.EmpresaTB.Size = new System.Drawing.Size(108, 20);
            this.EmpresaTB.TabIndex = 12;
            // 
            // ClienteButton
            // 
            this.ClienteButton.Enabled = false;
            this.ClienteButton.Location = new System.Drawing.Point(298, 20);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(37, 23);
            this.ClienteButton.TabIndex = 11;
            this.ClienteButton.Text = "...";
            this.ClienteButton.UseVisualStyleBackColor = true;
            // 
            // ClienteTB
            // 
            this.ClienteTB.Enabled = false;
            this.ClienteTB.Location = new System.Drawing.Point(175, 22);
            this.ClienteTB.Name = "ClienteTB";
            this.ClienteTB.Size = new System.Drawing.Size(108, 20);
            this.ClienteTB.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de Venc.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de alta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº Factura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total:";
            // 
            // EstadoCB
            // 
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.Location = new System.Drawing.Point(187, 425);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(108, 21);
            this.EstadoCB.TabIndex = 22;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(138, 428);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(43, 13);
            this.Estado.TabIndex = 23;
            this.Estado.Text = "Estado:";
            // 
            // DatosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 534);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.EstadoCB);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.TotalTB);
            this.Controls.Add(this.ItemsFacturaGV);
            this.Controls.Add(this.FacturaGB);
            this.Controls.Add(this.label7);
            this.Name = "DatosFactura";
            this.Text = "ModificarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsFacturaGV)).EndInit();
            this.FacturaGB.ResumeLayout(false);
            this.FacturaGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.DataGridView ItemsFacturaGV;
        private System.Windows.Forms.GroupBox FacturaGB;
        private System.Windows.Forms.DateTimePicker VencimientoDP;
        private System.Windows.Forms.DateTimePicker AltaDP;
        private System.Windows.Forms.TextBox FacturaTB;
        private System.Windows.Forms.Button EmpresaButton;
        private System.Windows.Forms.TextBox EmpresaTB;
        private System.Windows.Forms.Button ClienteButton;
        private System.Windows.Forms.TextBox ClienteTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EstadoCB;
        private System.Windows.Forms.Label Estado;
    }
}