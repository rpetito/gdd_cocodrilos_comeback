namespace PagoAgilFrba.AbmRol
{
    partial class BajaRol
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
            this.EliminarRolGV = new System.Windows.Forms.DataGridView();
            this.FiltratButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.FiltroGB = new System.Windows.Forms.GroupBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarRolGV)).BeginInit();
            this.FiltroGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // EliminarRolGV
            // 
            this.EliminarRolGV.AllowUserToAddRows = false;
            this.EliminarRolGV.AllowUserToDeleteRows = false;
            this.EliminarRolGV.AllowUserToOrderColumns = true;
            this.EliminarRolGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EliminarRolGV.Location = new System.Drawing.Point(12, 130);
            this.EliminarRolGV.MultiSelect = false;
            this.EliminarRolGV.Name = "EliminarRolGV";
            this.EliminarRolGV.Size = new System.Drawing.Size(260, 183);
            this.EliminarRolGV.TabIndex = 7;
            // 
            // FiltratButton
            // 
            this.FiltratButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltratButton.Location = new System.Drawing.Point(197, 95);
            this.FiltratButton.Name = "FiltratButton";
            this.FiltratButton.Size = new System.Drawing.Size(75, 23);
            this.FiltratButton.TabIndex = 6;
            this.FiltratButton.Text = "Filtrar";
            this.FiltratButton.UseVisualStyleBackColor = true;
            this.FiltratButton.Click += new System.EventHandler(this.FiltratButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(12, 95);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 5;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // FiltroGB
            // 
            this.FiltroGB.Controls.Add(this.NombreTB);
            this.FiltroGB.Controls.Add(this.Nombre);
            this.FiltroGB.Location = new System.Drawing.Point(12, 12);
            this.FiltroGB.Name = "FiltroGB";
            this.FiltroGB.Size = new System.Drawing.Size(260, 74);
            this.FiltroGB.TabIndex = 4;
            this.FiltroGB.TabStop = false;
            this.FiltroGB.Text = "Filtro";
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(81, 29);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(28, 32);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(12, 319);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // BajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarRolGV);
            this.Controls.Add(this.FiltratButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.FiltroGB);
            this.Name = "BajaRol";
            this.Text = "BajaRol";
            ((System.ComponentModel.ISupportInitialize)(this.EliminarRolGV)).EndInit();
            this.FiltroGB.ResumeLayout(false);
            this.FiltroGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EliminarRolGV;
        private System.Windows.Forms.Button FiltratButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.GroupBox FiltroGB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button CancelarButton;
    }
}