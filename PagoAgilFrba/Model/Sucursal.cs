using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    class Sucursal
    {
        public static Sucursal instance = null;

        private Int32 id = -1;
        private String nombre = null;
        private String direccion = null;
        private Int32 codPostal = -1;
        private Int32 habilitado = 999;

        public static Sucursal getInstance()
        {
            if (instance == null)
            {
                instance = new Sucursal();
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

        public void setCodPostal(Int32 codPostal)
        {
            this.codPostal = codPostal;
        }

        public Int32 getCodPostal()
        {
            return this.codPostal;
        }

        public void setHabilitado(Int32 habilitado)
        {
            this.habilitado = habilitado;
        }

        public Boolean getHabilitado()
        {
            if (this.habilitado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
