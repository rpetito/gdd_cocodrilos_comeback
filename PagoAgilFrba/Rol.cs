﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba
{
    class Rol
    {
        public static Rol instance = null;
        Int32 id;
        String detalle;
        Boolean habilitado;
        List<Int32> funcionalidades = new List<Int32>();

        public static Rol getInstance()
        {
            if (instance == null)
            {
                instance = new Rol();
            }

            return instance;
        }

        public Int32 getID()
        {
            return id;
        }

        public String getDetalle()
        {
            return detalle;
        }

        public void setID(Int32 id)
        {
            this.id = id;
        }

        public void setDetalle(String detalle)
        {
            this.detalle = detalle;
        }

        public void setHabilitado(Int32 habilitado)
        {
            this.habilitado = habilitado == 1;
        }

        public void setHabilitado(Boolean habilitado)
        {
            this.habilitado = habilitado;
        }

        public Boolean getHabilitado()
        {
            return this.habilitado;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return getID() == ((Rol)obj).getID();

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void addFuncionalidad(Int32 funcionalidad)
        {
            this.funcionalidades.Add(funcionalidad);
        }

        public List<Int32> getFuncionalidades()
        {
            return this.funcionalidades;
        }

    }
}
