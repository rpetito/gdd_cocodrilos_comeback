namespace PagoAgilFrba
{
    partial class Logeo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuario = new System.Windows.Forms.Label();
            this.contrasenia = new System.Windows.Forms.Label();
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.ContraseniaTB = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(66, 29);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(46, 13);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuario:";
            // 
            // contrasenia
            // 
            this.contrasenia.AutoSize = true;
            this.contrasenia.Location = new System.Drawing.Point(48, 59);
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.Size = new System.Drawing.Size(64, 13);
            this.contrasenia.TabIndex = 1;
            this.contrasenia.Text = "Contraseña:";
            // 
            // UsuarioTB
            // 
            this.UsuarioTB.Location = new System.Drawing.Point(118, 26);
            this.UsuarioTB.Name = "UsuarioTB";
            this.UsuarioTB.Size = new System.Drawing.Size(100, 20);
            this.UsuarioTB.TabIndex = 2;
            // 
            // ContraseniaTB
            // 
            this.ContraseniaTB.Location = new System.Drawing.Point(118, 56);
            this.ContraseniaTB.Name = "ContraseniaTB";
            this.ContraseniaTB.Size = new System.Drawing.Size(100, 20);
            this.ContraseniaTB.TabIndex = 3;
            // 
            // Ingresar
            // 
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(103, 105);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 4;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Logeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.ContraseniaTB);
            this.Controls.Add(this.UsuarioTB);
            this.Controls.Add(this.contrasenia);
            this.Controls.Add(this.usuario);
            this.Name = "Logeo";
            this.Text = "Logeo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contrasenia;
        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.TextBox ContraseniaTB;
        private System.Windows.Forms.Button Ingresar;
    }
}

