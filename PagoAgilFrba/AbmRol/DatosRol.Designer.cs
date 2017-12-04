namespace PagoAgilFrba.AbmRol
{
    partial class DatosRol
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
            this.RolGb = new System.Windows.Forms.GroupBox();
            this.FuncionalidadesGV = new System.Windows.Forms.DataGridView();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.HabilitadoCB = new System.Windows.Forms.CheckBox();
            this.RolGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(302, 356);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 7;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(157, 356);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 6;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(14, 356);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // RolGb
            // 
            this.RolGb.Controls.Add(this.FuncionalidadesGV);
            this.RolGb.Controls.Add(this.NombreTB);
            this.RolGb.Controls.Add(this.label2);
            this.RolGb.Controls.Add(this.Nombre);
            this.RolGb.Location = new System.Drawing.Point(14, 16);
            this.RolGb.Name = "RolGb";
            this.RolGb.Size = new System.Drawing.Size(363, 268);
            this.RolGb.TabIndex = 4;
            this.RolGb.TabStop = false;
            this.RolGb.Text = "Rol";
            // 
            // FuncionalidadesGV
            // 
            this.FuncionalidadesGV.AllowUserToAddRows = false;
            this.FuncionalidadesGV.AllowUserToDeleteRows = false;
            this.FuncionalidadesGV.AllowUserToOrderColumns = true;
            this.FuncionalidadesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionalidadesGV.Location = new System.Drawing.Point(33, 91);
            this.FuncionalidadesGV.MultiSelect = false;
            this.FuncionalidadesGV.Name = "FuncionalidadesGV";
            this.FuncionalidadesGV.Size = new System.Drawing.Size(291, 150);
            this.FuncionalidadesGV.TabIndex = 3;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(83, 23);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionalidades:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(30, 26);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(108, 304);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(43, 13);
            this.Estado.TabIndex = 9;
            this.Estado.Text = "Estado:";
            // 
            // HabilitadoCB
            // 
            this.HabilitadoCB.AutoSize = true;
            this.HabilitadoCB.Location = new System.Drawing.Point(157, 303);
            this.HabilitadoCB.Name = "HabilitadoCB";
            this.HabilitadoCB.Size = new System.Drawing.Size(73, 17);
            this.HabilitadoCB.TabIndex = 10;
            this.HabilitadoCB.Text = "Habilitado";
            this.HabilitadoCB.UseVisualStyleBackColor = true;
            // 
            // DatosRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 392);
            this.Controls.Add(this.HabilitadoCB);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.RolGb);
            this.Name = "DatosRol";
            this.Text = "DatosRol";
            this.RolGb.ResumeLayout(false);
            this.RolGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.GroupBox RolGb;
        private System.Windows.Forms.DataGridView FuncionalidadesGV;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.CheckBox HabilitadoCB;
    }
}