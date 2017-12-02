using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba
{
    class Empresa
    {

        public static Empresa instance = null;

        private String cuit = null;
        private String nombre = null;
        private String direccion = null;
        private Int32 dia_rendicion = -1;
        private Decimal rubro = -1;
        private Int32 habilitado = 999;

        public static Empresa getInstance()
        {
            if (instance == null)
            {
                instance = new Empresa();
            }

            return instance;
        }

        public void setCuit(String cuit) {
            this.cuit = cuit;
        }

        public String getCuit() {
            return this.cuit;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getDireccion()
        {
            return this.direccion;
        }

        public void setDiaRendicion(Int32 dia)
        {
            this.dia_rendicion = dia;
        }

        public Int32 getDiaRendicion()
        {
            return this.dia_rendicion;
        }

        public void setHabilitado(Int32 habilitado)
        {
            this.habilitado = habilitado;
        }

        public Int32 getHabilitado()
        {
            return this.habilitado;
        }

    }
}
