using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Model;
using PagoAgilFrba.Util;
using System.Data.SqlClient;
using PagoAgilFrba.Controller;
using System.Windows.Forms;


namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        EstadisticoController estadisticoController = new EstadisticoController();

        public ListadoEstadistico()
        {
            InitializeComponent();
           
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            ListadoCB.ResetText();
            AñoTB.Clear();
            TrimestreCB.ResetText();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            /*switch(combitoboxestadistico.getitemselected)
            {
                case 1:
                    {
                        estadisticoController.porcentajeFacturasCobradas(new SQLResponse<SqlDataReader>()
                        {

                            onSuccess = (SqlDataReader result) =>
                            {

                            },

                            onError = (Error error) =>
                            {

                            }

                        }, Convert.ToInt32(AñoTB.Text), combotrimestre.getselected, ListadoGV);
                        break;
                    }
                case 2:
                    {
                        estadisticoController.empresasMayorMontoRend(new SQLResponse<SqlDataReader>()
                        {

                            onSuccess = (SqlDataReader result) =>
                            {

                            },

                            onError = (Error error) =>
                            {

                            }

                        }, Convert.ToInt32(AñoTB.Text), combotrimestre.getselected, ListadoGV);
                        break;
                    }
                case 3:
                    {
                        estadisticoController.clienteMasPagos(new SQLResponse<SqlDataReader>()
                        {

                            onSuccess = (SqlDataReader result) =>
                            {

                            },

                            onError = (Error error) =>
                            {

                            }

                        }, Convert.ToInt32(AñoTB.Text), combotrimestre.getselected, ListadoGV);
                        break;
                    }
                case 4:
                    {
                        estadisticoController.clienteMayorPorcentajePagas(new SQLResponse<SqlDataReader>()
                        {

                            onSuccess = (SqlDataReader result) =>
                            {

                            },

                            onError = (Error error) =>
                            {

                            }

                        }, Convert.ToInt32(AñoTB.Text), combotrimestre.getselected, ListadoGV);
                        break;
                    }
                default:
                    
                    break;
            }*/
            
        }
    }
}
