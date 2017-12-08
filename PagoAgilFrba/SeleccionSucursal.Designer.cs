namespace PagoAgilFrba
{
    partial class SeleccionSucursal
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
            this.SucursalCB = new System.Windows.Forms.ComboBox();
            this.SucursalButton = new System.Windows.Forms.Button();
            this.Sucursal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SucursalCB
            // 
            this.SucursalCB.FormattingEnabled = true;
            this.SucursalCB.Location = new System.Drawing.Point(99, 37);
            this.SucursalCB.Name = "SucursalCB";
            this.SucursalCB.Size = new System.Drawing.Size(121, 21);
            this.SucursalCB.TabIndex = 0;
            // 
            // SucursalButton
            // 
            this.SucursalButton.Location = new System.Drawing.Point(99, 94);
            this.SucursalButton.Name = "SucursalButton";
            this.SucursalButton.Size = new System.Drawing.Size(75, 23);
            this.SucursalButton.TabIndex = 1;
            this.SucursalButton.Text = "Ingresar";
            this.SucursalButton.UseVisualStyleBackColor = true;
            this.SucursalButton.Click += new System.EventHandler(this.SucursalButton_Click);
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSize = true;
            this.Sucursal.Location = new System.Drawing.Point(42, 40);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(51, 13);
            this.Sucursal.TabIndex = 2;
            this.Sucursal.Text = "Sucursal:";
            // 
            // SeleccionSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.Sucursal);
            this.Controls.Add(this.SucursalButton);
            this.Controls.Add(this.SucursalCB);
            this.Name = "SeleccionSucursal";
            this.Text = "SeleccionSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SucursalCB;
        private System.Windows.Forms.Button SucursalButton;
        private System.Windows.Forms.Label Sucursal;
    }
}