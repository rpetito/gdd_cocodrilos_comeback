using System;
namespace PagoAgilFrba.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            this.ListadoGV = new System.Windows.Forms.DataGridView();
            this.FiltroGB = new System.Windows.Forms.GroupBox();
            this.ListadoCB = new CustomComboBox<Int32>();
            this.TrimestreCB = new CustomComboBox<Int32>();
            this.AñoTB = new System.Windows.Forms.TextBox();
            this.Año = new System.Windows.Forms.Label();
            this.Trimestre = new System.Windows.Forms.Label();
            this.Listado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGV)).BeginInit();
            this.FiltroGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 372);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 16;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarButton.Location = new System.Drawing.Point(337, 128);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 14;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(12, 128);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 13;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ListadoGV
            // 
            this.ListadoGV.AllowUserToAddRows = false;
            this.ListadoGV.AllowUserToDeleteRows = false;
            this.ListadoGV.AllowUserToOrderColumns = true;
            this.ListadoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoGV.Location = new System.Drawing.Point(12, 167);
            this.ListadoGV.MultiSelect = false;
            this.ListadoGV.Name = "ListadoGV";
            this.ListadoGV.ReadOnly = true;
            this.ListadoGV.Size = new System.Drawing.Size(400, 199);
            this.ListadoGV.TabIndex = 15;
            // 
            // FiltroGB
            // 
            this.FiltroGB.Controls.Add(this.ListadoCB);
            this.FiltroGB.Controls.Add(this.TrimestreCB);
            this.FiltroGB.Controls.Add(this.AñoTB);
            this.FiltroGB.Controls.Add(this.Año);
            this.FiltroGB.Controls.Add(this.Trimestre);
            this.FiltroGB.Controls.Add(this.Listado);
            this.FiltroGB.Location = new System.Drawing.Point(12, 11);
            this.FiltroGB.Name = "FiltroGB";
            this.FiltroGB.Size = new System.Drawing.Size(400, 111);
            this.FiltroGB.TabIndex = 12;
            this.FiltroGB.TabStop = false;
            this.FiltroGB.Text = "Filtro";
            // 
            // ListadoCB
            // 
            this.ListadoCB.FormattingEnabled = true;
            this.ListadoCB.Location = new System.Drawing.Point(78, 25);
            this.ListadoCB.Name = "ListadoCB";
            this.ListadoCB.Size = new System.Drawing.Size(238, 21);
            this.ListadoCB.TabIndex = 7;
            // 
            // TrimestreCB
            // 
            this.TrimestreCB.FormattingEnabled = true;
            this.TrimestreCB.Location = new System.Drawing.Point(268, 69);
            this.TrimestreCB.Name = "TrimestreCB";
            this.TrimestreCB.Size = new System.Drawing.Size(48, 21);
            this.TrimestreCB.TabIndex = 6;
            // 
            // AñoTB
            // 
            this.AñoTB.Location = new System.Drawing.Point(78, 69);
            this.AñoTB.Name = "AñoTB";
            this.AñoTB.Size = new System.Drawing.Size(100, 20);
            this.AñoTB.TabIndex = 5;
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(28, 72);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(29, 13);
            this.Año.TabIndex = 2;
            this.Año.Text = "Año:";
            // 
            // Trimestre
            // 
            this.Trimestre.AutoSize = true;
            this.Trimestre.Location = new System.Drawing.Point(209, 72);
            this.Trimestre.Name = "Trimestre";
            this.Trimestre.Size = new System.Drawing.Size(53, 13);
            this.Trimestre.TabIndex = 1;
            this.Trimestre.Text = "Trimestre:";
            // 
            // Listado
            // 
            this.Listado.AutoSize = true;
            this.Listado.Location = new System.Drawing.Point(28, 28);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(44, 13);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listado:";
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 406);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.ListadoGV);
            this.Controls.Add(this.FiltroGB);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            ((System.ComponentModel.ISupportInitialize)(this.ListadoGV)).EndInit();
            this.FiltroGB.ResumeLayout(false);
            this.FiltroGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.DataGridView ListadoGV;
        private System.Windows.Forms.GroupBox FiltroGB;
        private CustomComboBox<Int32> ListadoCB;
        private CustomComboBox<Int32> TrimestreCB;
        private System.Windows.Forms.TextBox AñoTB;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.Label Trimestre;
        private System.Windows.Forms.Label Listado;
    }
}