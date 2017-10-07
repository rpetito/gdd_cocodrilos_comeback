﻿namespace PagoAgilFrba.AbmCliente
{
    partial class DatosCliente
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
            this.ClienteGB = new System.Windows.Forms.GroupBox();
            this.DomicilioGB = new System.Windows.Forms.GroupBox();
            this.PisoTB = new System.Windows.Forms.TextBox();
            this.LocalidadTB = new System.Windows.Forms.TextBox();
            this.DireccionTB = new System.Windows.Forms.TextBox();
            this.DepartamentoTB = new System.Windows.Forms.TextBox();
            this.CodigoPostalTB = new System.Windows.Forms.TextBox();
            this.Localidad = new System.Windows.Forms.Label();
            this.Departamento = new System.Windows.Forms.Label();
            this.CodigoPostal = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Piso = new System.Windows.Forms.Label();
            this.FecNacDP = new System.Windows.Forms.DateTimePicker();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.DniTB = new System.Windows.Forms.TextBox();
            this.TelefonoTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Dni = new System.Windows.Forms.Label();
            this.FecNac = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.EstadoCB = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.ClienteGB.SuspendLayout();
            this.DomicilioGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(352, 300);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 7;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(186, 300);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 6;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(21, 300);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // ClienteGB
            // 
            this.ClienteGB.Controls.Add(this.EstadoCB);
            this.ClienteGB.Controls.Add(this.Estado);
            this.ClienteGB.Controls.Add(this.DomicilioGB);
            this.ClienteGB.Controls.Add(this.FecNacDP);
            this.ClienteGB.Controls.Add(this.ApellidoTB);
            this.ClienteGB.Controls.Add(this.MailTB);
            this.ClienteGB.Controls.Add(this.DniTB);
            this.ClienteGB.Controls.Add(this.TelefonoTB);
            this.ClienteGB.Controls.Add(this.NombreTB);
            this.ClienteGB.Controls.Add(this.Apellido);
            this.ClienteGB.Controls.Add(this.Mail);
            this.ClienteGB.Controls.Add(this.Telefono);
            this.ClienteGB.Controls.Add(this.Dni);
            this.ClienteGB.Controls.Add(this.FecNac);
            this.ClienteGB.Controls.Add(this.Nombre);
            this.ClienteGB.Location = new System.Drawing.Point(11, 13);
            this.ClienteGB.Name = "ClienteGB";
            this.ClienteGB.Size = new System.Drawing.Size(426, 271);
            this.ClienteGB.TabIndex = 4;
            this.ClienteGB.TabStop = false;
            this.ClienteGB.Text = "Cliente";
            // 
            // DomicilioGB
            // 
            this.DomicilioGB.Controls.Add(this.PisoTB);
            this.DomicilioGB.Controls.Add(this.LocalidadTB);
            this.DomicilioGB.Controls.Add(this.DireccionTB);
            this.DomicilioGB.Controls.Add(this.DepartamentoTB);
            this.DomicilioGB.Controls.Add(this.CodigoPostalTB);
            this.DomicilioGB.Controls.Add(this.Localidad);
            this.DomicilioGB.Controls.Add(this.Departamento);
            this.DomicilioGB.Controls.Add(this.CodigoPostal);
            this.DomicilioGB.Controls.Add(this.Direccion);
            this.DomicilioGB.Controls.Add(this.Piso);
            this.DomicilioGB.Location = new System.Drawing.Point(22, 122);
            this.DomicilioGB.Name = "DomicilioGB";
            this.DomicilioGB.Size = new System.Drawing.Size(377, 97);
            this.DomicilioGB.TabIndex = 23;
            this.DomicilioGB.TabStop = false;
            this.DomicilioGB.Text = "Domicilio";
            // 
            // PisoTB
            // 
            this.PisoTB.Location = new System.Drawing.Point(51, 59);
            this.PisoTB.Name = "PisoTB";
            this.PisoTB.Size = new System.Drawing.Size(33, 20);
            this.PisoTB.TabIndex = 17;
            // 
            // LocalidadTB
            // 
            this.LocalidadTB.Location = new System.Drawing.Point(263, 27);
            this.LocalidadTB.Name = "LocalidadTB";
            this.LocalidadTB.Size = new System.Drawing.Size(100, 20);
            this.LocalidadTB.TabIndex = 16;
            // 
            // DireccionTB
            // 
            this.DireccionTB.Location = new System.Drawing.Point(76, 27);
            this.DireccionTB.Name = "DireccionTB";
            this.DireccionTB.Size = new System.Drawing.Size(100, 20);
            this.DireccionTB.TabIndex = 21;
            // 
            // DepartamentoTB
            // 
            this.DepartamentoTB.Location = new System.Drawing.Point(138, 59);
            this.DepartamentoTB.Name = "DepartamentoTB";
            this.DepartamentoTB.Size = new System.Drawing.Size(38, 20);
            this.DepartamentoTB.TabIndex = 19;
            // 
            // CodigoPostalTB
            // 
            this.CodigoPostalTB.Location = new System.Drawing.Point(263, 59);
            this.CodigoPostalTB.Name = "CodigoPostalTB";
            this.CodigoPostalTB.Size = new System.Drawing.Size(100, 20);
            this.CodigoPostalTB.TabIndex = 20;
            // 
            // Localidad
            // 
            this.Localidad.AutoSize = true;
            this.Localidad.Location = new System.Drawing.Point(201, 30);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(56, 13);
            this.Localidad.TabIndex = 6;
            this.Localidad.Text = "Localidad:";
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Location = new System.Drawing.Point(90, 62);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(42, 13);
            this.Departamento.TabIndex = 10;
            this.Departamento.Text = "Depto.:";
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSize = true;
            this.CodigoPostal.Location = new System.Drawing.Point(182, 62);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.CodigoPostal.TabIndex = 9;
            this.CodigoPostal.Text = "Código Postal:";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(15, 30);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(55, 13);
            this.Direccion.TabIndex = 0;
            this.Direccion.Text = "Dirección:";
            // 
            // Piso
            // 
            this.Piso.AutoSize = true;
            this.Piso.Location = new System.Drawing.Point(15, 62);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(30, 13);
            this.Piso.TabIndex = 4;
            this.Piso.Text = "Piso:";
            // 
            // FecNacDP
            // 
            this.FecNacDP.Location = new System.Drawing.Point(273, 87);
            this.FecNacDP.Name = "FecNacDP";
            this.FecNacDP.Size = new System.Drawing.Size(100, 20);
            this.FecNacDP.TabIndex = 22;
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Location = new System.Drawing.Point(273, 21);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(100, 20);
            this.ApellidoTB.TabIndex = 15;
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(80, 87);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(100, 20);
            this.MailTB.TabIndex = 14;
            // 
            // DniTB
            // 
            this.DniTB.Location = new System.Drawing.Point(80, 54);
            this.DniTB.Name = "DniTB";
            this.DniTB.Size = new System.Drawing.Size(100, 20);
            this.DniTB.TabIndex = 13;
            // 
            // TelefonoTB
            // 
            this.TelefonoTB.Location = new System.Drawing.Point(273, 54);
            this.TelefonoTB.Name = "TelefonoTB";
            this.TelefonoTB.Size = new System.Drawing.Size(100, 20);
            this.TelefonoTB.TabIndex = 12;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(80, 21);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(100, 20);
            this.NombreTB.TabIndex = 11;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(220, 24);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(47, 13);
            this.Apellido.TabIndex = 8;
            this.Apellido.Text = "Apellido:";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(45, 90);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(29, 13);
            this.Mail.TabIndex = 7;
            this.Mail.Text = "Mail:";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(215, 57);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(52, 13);
            this.Telefono.TabIndex = 5;
            this.Telefono.Text = "Teléfono:";
            // 
            // Dni
            // 
            this.Dni.AutoSize = true;
            this.Dni.Location = new System.Drawing.Point(45, 57);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(29, 13);
            this.Dni.TabIndex = 3;
            this.Dni.Text = "DNI:";
            // 
            // FecNac
            // 
            this.FecNac.AutoSize = true;
            this.FecNac.Location = new System.Drawing.Point(186, 90);
            this.FecNac.Name = "FecNac";
            this.FecNac.Size = new System.Drawing.Size(81, 13);
            this.FecNac.TabIndex = 2;
            this.FecNac.Text = "Fecha de Nac.:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(27, 24);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre:";
            // 
            // EstadoCB
            // 
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.Location = new System.Drawing.Point(175, 234);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(100, 21);
            this.EstadoCB.TabIndex = 8;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(126, 237);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(43, 13);
            this.Estado.TabIndex = 9;
            this.Estado.Text = "Estado:";
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 336);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.ClienteGB);
            this.Name = "DatosCliente";
            this.Text = "DatosCliente";
            this.ClienteGB.ResumeLayout(false);
            this.ClienteGB.PerformLayout();
            this.DomicilioGB.ResumeLayout(false);
            this.DomicilioGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.GroupBox ClienteGB;
        private System.Windows.Forms.ComboBox EstadoCB;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.GroupBox DomicilioGB;
        private System.Windows.Forms.TextBox PisoTB;
        private System.Windows.Forms.TextBox LocalidadTB;
        private System.Windows.Forms.TextBox DireccionTB;
        private System.Windows.Forms.TextBox DepartamentoTB;
        private System.Windows.Forms.TextBox CodigoPostalTB;
        private System.Windows.Forms.Label Localidad;
        private System.Windows.Forms.Label Departamento;
        private System.Windows.Forms.Label CodigoPostal;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Piso;
        private System.Windows.Forms.DateTimePicker FecNacDP;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox DniTB;
        private System.Windows.Forms.TextBox TelefonoTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Dni;
        private System.Windows.Forms.Label FecNac;
        private System.Windows.Forms.Label Nombre;
    }
}