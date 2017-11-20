namespace PagoAgilFrba
{
    partial class SeleccionRol
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
            this.Ingresar = new System.Windows.Forms.Button();
            this.Rol = new System.Windows.Forms.Label();
            this.RolCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Ingresar
            // 
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(107, 104);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 0;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Location = new System.Drawing.Point(63, 51);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(26, 13);
            this.Rol.TabIndex = 1;
            this.Rol.Text = "Rol:";
            // 
            // RolCB
            // 
            this.RolCB.FormattingEnabled = true;
            this.RolCB.Location = new System.Drawing.Point(104, 48);
            this.RolCB.Name = "RolCB";
            this.RolCB.Size = new System.Drawing.Size(121, 21);
            this.RolCB.TabIndex = 2;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.RolCB);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.Ingresar);
            this.Name = "Roles";
            this.Text = "Rol a Ingresar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.ComboBox RolCB;
    }
}