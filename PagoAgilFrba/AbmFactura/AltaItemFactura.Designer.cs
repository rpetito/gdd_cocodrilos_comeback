namespace PagoAgilFrba.AbmFactura {
	partial class AltaItemFactura {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.itemFacturaPrecioLabel = new System.Windows.Forms.Label();
			this.itemFacturaCantLabel = new System.Windows.Forms.Label();
			this.itemFacturaPrecioTB = new System.Windows.Forms.TextBox();
			this.itemFacturaCantTB = new System.Windows.Forms.TextBox();
			this.itemFacturaAñadirButton = new System.Windows.Forms.Button();
			this.itemFacturaCancelarButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// itemFacturaPrecioLabel
			// 
			this.itemFacturaPrecioLabel.AutoSize = true;
			this.itemFacturaPrecioLabel.Location = new System.Drawing.Point(50, 53);
			this.itemFacturaPrecioLabel.Name = "itemFacturaPrecioLabel";
			this.itemFacturaPrecioLabel.Size = new System.Drawing.Size(40, 13);
			this.itemFacturaPrecioLabel.TabIndex = 0;
			this.itemFacturaPrecioLabel.Text = "Precio:";
			// 
			// itemFacturaCantLabel
			// 
			this.itemFacturaCantLabel.AutoSize = true;
			this.itemFacturaCantLabel.Location = new System.Drawing.Point(50, 105);
			this.itemFacturaCantLabel.Name = "itemFacturaCantLabel";
			this.itemFacturaCantLabel.Size = new System.Drawing.Size(52, 13);
			this.itemFacturaCantLabel.TabIndex = 1;
			this.itemFacturaCantLabel.Text = "Cantidad:";
			// 
			// itemFacturaPrecioTB
			// 
			this.itemFacturaPrecioTB.Location = new System.Drawing.Point(116, 50);
			this.itemFacturaPrecioTB.Name = "itemFacturaPrecioTB";
			this.itemFacturaPrecioTB.Size = new System.Drawing.Size(100, 20);
			this.itemFacturaPrecioTB.TabIndex = 2;
			// 
			// itemFacturaCantTB
			// 
			this.itemFacturaCantTB.Location = new System.Drawing.Point(116, 102);
			this.itemFacturaCantTB.Name = "itemFacturaCantTB";
			this.itemFacturaCantTB.Size = new System.Drawing.Size(100, 20);
			this.itemFacturaCantTB.TabIndex = 3;
			// 
			// itemFacturaAñadirButton
			// 
			this.itemFacturaAñadirButton.Location = new System.Drawing.Point(165, 155);
			this.itemFacturaAñadirButton.Name = "itemFacturaAñadirButton";
			this.itemFacturaAñadirButton.Size = new System.Drawing.Size(75, 23);
			this.itemFacturaAñadirButton.TabIndex = 4;
			this.itemFacturaAñadirButton.Text = "Añadir Item";
			this.itemFacturaAñadirButton.UseVisualStyleBackColor = true;
			this.itemFacturaAñadirButton.Click += new System.EventHandler(this.itemFacturaAñadirButton_Click);
			// 
			// itemFacturaCancelarButton
			// 
			this.itemFacturaCancelarButton.Location = new System.Drawing.Point(53, 155);
			this.itemFacturaCancelarButton.Name = "itemFacturaCancelarButton";
			this.itemFacturaCancelarButton.Size = new System.Drawing.Size(75, 23);
			this.itemFacturaCancelarButton.TabIndex = 5;
			this.itemFacturaCancelarButton.Text = "Cancelar";
			this.itemFacturaCancelarButton.UseVisualStyleBackColor = true;
			this.itemFacturaCancelarButton.Click += new System.EventHandler(this.itemFacturaCancelarButton_Click);
			// 
			// AltaItemFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 218);
			this.Controls.Add(this.itemFacturaCancelarButton);
			this.Controls.Add(this.itemFacturaAñadirButton);
			this.Controls.Add(this.itemFacturaCantTB);
			this.Controls.Add(this.itemFacturaPrecioTB);
			this.Controls.Add(this.itemFacturaCantLabel);
			this.Controls.Add(this.itemFacturaPrecioLabel);
			this.Name = "AltaItemFactura";
			this.Text = "AltaItemFactura";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label itemFacturaPrecioLabel;
		private System.Windows.Forms.Label itemFacturaCantLabel;
		private System.Windows.Forms.TextBox itemFacturaPrecioTB;
		private System.Windows.Forms.TextBox itemFacturaCantTB;
		private System.Windows.Forms.Button itemFacturaAñadirButton;
		private System.Windows.Forms.Button itemFacturaCancelarButton;

	}
}