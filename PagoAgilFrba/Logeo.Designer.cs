﻿namespace PagoAgilFrba
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
            this.Usuario = new System.Windows.Forms.Label();
            this.Contrasenia = new System.Windows.Forms.Label();
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.ContraseniaTB = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(66, 29);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(46, 13);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario:";
            // 
            // Contrasenia
            // 
            this.Contrasenia.AutoSize = true;
            this.Contrasenia.Location = new System.Drawing.Point(48, 59);
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.Size = new System.Drawing.Size(64, 13);
            this.Contrasenia.TabIndex = 1;
            this.Contrasenia.Text = "Contraseña:";
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
            // 
            // Logeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.ContraseniaTB);
            this.Controls.Add(this.UsuarioTB);
            this.Controls.Add(this.Contrasenia);
            this.Controls.Add(this.Usuario);
            this.Name = "Logeo";
            this.Text = "Logeo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contrasenia;
        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.TextBox ContraseniaTB;
        private System.Windows.Forms.Button Ingresar;
    }
}

