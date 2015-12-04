using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Utils;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private DateTime parsearFechaInicial()
        {

            DateTime fecha;
            switch (semestre.SelectedIndex)
            {
                case 0: 
                    fecha = Convert.ToDateTime("01/01/" + Convert.ToString(anio.Value));
                    break;
                default:
                    fecha = Convert.ToDateTime("01/07/" + Convert.ToString(anio.Value + 1));
                    break;
            }

            return fecha;

        }

        private DateTime parsearFechaFinal()
        {

            DateTime fecha;
            switch (semestre.SelectedIndex)
            {
                case 0: 
                    fecha = Convert.ToDateTime("01/07/" + Convert.ToString(anio.Value)); 
                    break;
                default:
                    fecha = Convert.ToDateTime("01/01/" + Convert.ToString(anio.Value + 1));
                    break;
            }

            return fecha;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validacion.estaVacio(semestre, "semestre") && !Validacion.estaVacio(anio, "año") && !Validacion.estaVacio(estadistica, "consulta"))
            {

                DateTime fechaInicial = this.parsearFechaInicial();
                DateTime fechaFinal = this.parsearFechaFinal();

                switch (estadistica.SelectedIndex)
                {
                    case 0:
                        {
                            DataTable tablaRetorno = DBAdapter.retrieveDataTable("Pasajes_Mas_Comprados", fechaInicial, fechaFinal);
                            dataGridEstadistica.DataSource = tablaRetorno;
                        } 
                        break;

                    case 1:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("Aeronaves_Mas_Vacias", fechaInicial, fechaFinal);
                            dataGridEstadistica.DataSource = dt0;
                        } break;

                    case 2:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("Cliente_Mayoria_Puntos");
                            dataGridEstadistica.DataSource = dt0;
                        } break;

                    case 3:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("Destinos_Mas_Cancelados", fechaInicial, fechaFinal);
                            dataGridEstadistica.DataSource = dt0;
                        } break;

                    case 4:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("Aeronave_Mayoria_Fuera_Servicio", fechaInicial, fechaFinal);
                            dataGridEstadistica.DataSource = dt0;
                        } break;

                }

            }
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void dataGridEstadistica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
