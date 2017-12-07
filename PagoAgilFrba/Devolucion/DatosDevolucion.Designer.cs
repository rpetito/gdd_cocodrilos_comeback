namespace PagoAgilFrba.Devolucion
{
    partial class DatosDevolucion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MotivoTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.FacturaTB = new System.Windows.Forms.TextBox();
            this.ClienteTB = new System.Windows.Forms.TextBox();
            this.EmpresaTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // MotivoTB
            // 
            this.MotivoTB.Location = new System.Drawing.Point(51, 140);
            this.MotivoTB.Name = "MotivoTB";
            this.MotivoTB.Size = new System.Drawing.Size(265, 20);
            this.MotivoTB.TabIndex = 3;
            this.MotivoTB.TextChanged += new System.EventHandler(this.MotivoTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Motivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Empresa:";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(241, 200);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 8;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(51, 200);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 9;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // FacturaTB
            // 
            this.FacturaTB.Location = new System.Drawing.Point(154, 22);
            this.FacturaTB.Name = "FacturaTB";
            this.FacturaTB.ReadOnly = true;
            this.FacturaTB.Size = new System.Drawing.Size(128, 20);
            this.FacturaTB.TabIndex = 10;
            // 
            // ClienteTB
            // 
            this.ClienteTB.Location = new System.Drawing.Point(154, 56);
            this.ClienteTB.Name = "ClienteTB";
            this.ClienteTB.ReadOnly = true;
            this.ClienteTB.Size = new System.Drawing.Size(128, 20);
            this.ClienteTB.TabIndex = 11;
            // 
            // EmpresaTB
            // 
            this.EmpresaTB.Location = new System.Drawing.Point(154, 90);
            this.EmpresaTB.Name = "EmpresaTB";
            this.EmpresaTB.ReadOnly = true;
            this.EmpresaTB.Size = new System.Drawing.Size(128, 20);
            this.EmpresaTB.TabIndex = 12;
            // 
            // DatosDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 241);
            this.Controls.Add(this.EmpresaTB);
            this.Controls.Add(this.ClienteTB);
            this.Controls.Add(this.FacturaTB);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MotivoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosDevolucion";
            this.Text = "DatosDevolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MotivoTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox FacturaTB;
        private System.Windows.Forms.TextBox ClienteTB;
        private System.Windows.Forms.TextBox EmpresaTB;
    }
}