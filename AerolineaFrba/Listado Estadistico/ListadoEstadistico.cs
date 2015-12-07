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
using AerolineaFrba.Domain;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
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
                            this.dataGridEstadistica.DataSource = new BindingSource(new BindingList<Ciudad>( new Repositories.Estadísticos().destinosConMasPasajes(fechaInicial, fechaFinal)), null);
                           
                        } 
                        break;

                    case 1:
                        {
                            this.dataGridEstadistica.DataSource = new BindingSource(new BindingList<Ciudad>(new Repositories.Estadísticos().destinosConMasAeronavesVacias(fechaInicial, fechaFinal)), null);
                        } break;

                    case 2:
                        {
                            this.dataGridEstadistica.DataSource = new BindingSource(new BindingList<Cliente>(new Repositories.Estadísticos().clientesConMasPuntos()), null);
                        } break;

                    case 3:
                        {
                            this.dataGridEstadistica.DataSource = new BindingSource(new BindingList<Ciudad>(new Repositories.Estadísticos().destinosConMasPasajesCancelados(fechaInicial, fechaFinal) ), null);
                        } break;

                    case 4:
                        {
                            this.dataGridEstadistica.DataSource = new BindingSource(new BindingList<Aeronave>(new Repositories.Estadísticos().aeronavesConMasDiasFueraDeServicio(fechaInicial, fechaFinal) ), null);
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
