using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba
{
    class Cliente
    {

        public static Cliente instance = null;

        private Decimal dni = -1;
        private String nombre = null;
        private String apellido = null;
        private DateTime fecNac;
        private String mail = null;
        private String direccion = null;
        private String telefono = null;
        private Int32 piso = 999;
        private String depto = null;
        private String localidad = null;
        private String codPostal = null;
        private Int32 habilitado = 999;


        public static Cliente getInstance()
        {
            if (instance == null)
            {
                instance = new Cliente();
            }

            return instance;
        }

        public Decimal getDni()
        {
            return this.dni;
        }

        public void setDni(Decimal dni)
        {
            this.dni = dni;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getApellido()
        {
            return this.apellido;
        }

        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }

        public DateTime getFecNac()
        {
            return this.fecNac;
        }

        public void setFecNac(DateTime fecNac)
        {
            this.fecNac = fecNac;
        }

        public String getMail()
        {
            return this.mail;
        }

        public void setMail(String mail)
        {
            this.mail = mail;
        }

        public String getDireccion()
        {
            return this.direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getTelefono()
        {
            return this.telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public Int32 getPiso()
        {
            return this.piso;
        }

        public void setPiso(Int32 piso)
        {
            this.piso = piso;
        }

        public String getDepto()
        {
            return this.depto;
        }

        public void setDepto(String depto)
        {
            this.depto = depto;
        }

        public String getLocalidad()
        {
            return this.localidad;
        }

        public void setLocalidad(String localidad)
        {
            this.localidad = localidad;
        }

        public String getCodPostal()
        {
            return this.codPostal;
        }

        public void setCodPostal(String codPostal)
        {
            this.codPostal = codPostal;
        }

        public Int32 getHabilitado()
        {
            return this.habilitado;
        }

        public void setHabilitado(Int32 habilitado)
        {
            this.habilitado = habilitado;
        }

    }
}
