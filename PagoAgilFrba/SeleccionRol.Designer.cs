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
            this.rol = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rol
            // 
            this.rol.AutoSize = true;
            this.rol.Location = new System.Drawing.Point(57, 39);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(26, 13);
            this.rol.TabIndex = 0;
            this.rol.Text = "Rol:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // IngresarButton
            // 
            this.IngresarButton.Location = new System.Drawing.Point(89, 93);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(75, 23);
            this.IngresarButton.TabIndex = 3;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            // 
            // SeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rol);
            this.Name = "SeleccionRol";
            this.Text = "SeleccionRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rol;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button IngresarButton;
    }
}