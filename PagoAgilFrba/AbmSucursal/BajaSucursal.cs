﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class BajaSucursal : Form
    {
        public BajaSucursal()
        {
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTB.Clear();
            DireccionTB.Clear();
            CodigoPostalTB.Clear();
            BajaSucursalGV.Rows.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
