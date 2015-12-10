using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Domain;
using AerolineaFrba.Repositories;
using AerolineaFrba.Utils;


namespace AerolineaFrba.Consulta_Millas
{
    public partial class HistorialMillas : Form
    {
        public HistorialMillas()
        {
            InitializeComponent();
        }

        private void HistorialMillas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientesRepository = new ClientesRepository();
            if (Validacion.validarInputs(this.Controls) &&
                Validacion.soloNumeros(this.dni, dni.Name) && Validacion.soloLetras(this.apellido, apellido.Name))
            {
                this.dataGridView1.DataSource = DBAdapter.retrieveDataTable("Listado_Consulta_Millas", this.dni.Text, this.apellido.Text);
            }
        }
    }
}
