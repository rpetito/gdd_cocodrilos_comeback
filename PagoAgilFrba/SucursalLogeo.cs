using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba
{
    class SucursalLogeo
    {

        public static SucursalLogeo instance = null;

        private Int32 id = -1;
        private String nombre = null;
        private String direccion = null;
        private Decimal codPostal = -1;
        private Boolean habilitado = false;

        public static SucursalLogeo getInstance()
        {
            if (instance == null)
            {
                instance = new SucursalLogeo();
            }

            return instance;
        }

        public void setId(Int32 id)
        {
            this.id = id;
        }

        public Int32 getId()
        {
            return this.id;
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

        public void setCodPostal(Decimal codPostal)
        {
            this.codPostal = codPostal;
        }

        public Decimal getCodPostal()
        {
            return this.codPostal;
        }

        public void setHabilitado(Boolean habilitado)
        {
            this.habilitado = habilitado;
        }

        public Boolean getHabilitado()
        {
            return this.habilitado;

        }

    }
}
