using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba
{
    class Usuario
    {
        public static Usuario instance = null;

        private Decimal dni = -1;
        private List<RolLogeo> roles = new List<RolLogeo>();
        private RolLogeo rolSeleccionado = null;
        private SucursalLogeo sucursalSeleccionada = null;
        private List<SucursalLogeo> sucursales = new List<SucursalLogeo>();

        public static Usuario getInstance()
        {
            if (instance == null)
            {
                instance = new Usuario();
            }

            return instance;
        }


        public void setDNI(Decimal dni)
        {
            this.dni = dni;
        }

        public Decimal getDNI()
        {
            return this.dni;
        }


        public void addRol(RolLogeo rol)
        {
            if (!this.roles.Contains(rol))
            {
                this.roles.Add(rol);
            }
        }

        public List<RolLogeo> getRoles()
        {
            return this.roles;
        }

        public void setRolSeleccionado(RolLogeo rol)
        {
            this.rolSeleccionado = rol;
        }

        public RolLogeo getRolSeleccionado()
        {
            return this.rolSeleccionado;
        }

        public RolLogeo getRolAtIndex(int index)
        {
            return this.roles[index];
        }

        public SucursalLogeo getSucursalAtIndex(int index)
        {
            return this.sucursales[index];
        }

		public Boolean hasOnlyOneRol() {
			return this.roles.Count == 1;
		}
        public Boolean hasNoneRol()
        {
            return this.roles.Count == 0;
        }

        public Boolean hasMultipleRoles() {
			return this.roles.Count > 1;
		}

        public Boolean hasOnlyOneSucursal()
        {
            return this.sucursales.Count == 1;
        }

        public Boolean hasNoneSucursal()
        {
            return this.sucursales.Count == 0;
        }

        public Boolean hasMultipleSucursales()
        {
            return this.sucursales.Count > 1;
        }

        public void addSucursal(SucursalLogeo sucursal)
        {
            this.sucursales.Add(sucursal);
        }

        public List<SucursalLogeo> getSucursales()
        {
            return this.sucursales;
        }

        public void setSucursalSeleccionada(SucursalLogeo sucursal)
        {
            this.sucursalSeleccionada = sucursal;
        }

        public SucursalLogeo GetSucursalLogeo()
        {
            return this.sucursalSeleccionada;
        }

    }
}
