using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    class Devoluciones
    {
        public static Devoluciones instance = null;

        private Decimal factura = -1;
        private String empresa = null;
        private Decimal usuario = -1;

        public static Devoluciones getInstance()
        {
            if (instance == null)
            {
                instance = new Devoluciones();
            }

            return instance;
        }

        public void setFactura(Decimal factura)
        {
            this.factura = factura;
        }

        public Decimal getFactura()
        {
            return this.factura;
        }

        public void setEmpresa(String empresa)
        {
            this.empresa = empresa;
        }

        public String getEmpresa()
        {
            return this.empresa;
        }

        public void setUsuario(Decimal usuario)
        {
            this.usuario = usuario;
        }

        public Decimal getUsuario()
        {
            return this.usuario;
        }

    }
}

