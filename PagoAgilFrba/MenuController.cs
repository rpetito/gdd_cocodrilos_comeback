using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    class MenuController
    {
        public static Form getViewForFunctionality(int id)
        {

            Form form = null;

            switch (id)
            {

                case 1:
                    form = new AbmCliente.ABMCliente();
                    break;
                case 2:
                    form = new AbmEmpresa.ABMEmpresa();
                    break;
                case 3:
                    form = new AbmSucursal.ABMSucursal();
                    break;
                case 4:
                    form = new AbmFactura.ABMFactura();
                    break;
                case 5:
                    form = new RegistroPago.RegistroPago();
                    break;
                case 6:
                    form = new Rendicion.Rendicion();
                    break;
                case 7:
                    form = new Devolucion.Devolucion();
                    break;
                case 8:
                    form = new ListadoEstadistico.ListadoEstadistico();
                    break;
                case 9:
                    form = new AbmRol.ABMRol();
                    break;

            }


            return form;

        }
    }
}