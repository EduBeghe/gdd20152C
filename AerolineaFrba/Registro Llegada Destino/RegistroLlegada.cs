using AerolineaFrba.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Repositories;
using AerolineaFrba.Utils;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistroLlegada : Form
    {
        public RegistroLlegada()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingSource aeronaveSource = new BindingSource(new BindingList<Aeronave>(new AeronaveRepository().getAeronaves()), null);
            this.matriculaComboBox.DataSource = aeronaveSource;
            this.matriculaComboBox.DisplayMember = "Matricula";
            this.salida.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.arribo.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aeronave aeronave = (Aeronave)matriculaComboBox.SelectedItem;
            Ciudad origen = (Ciudad)salida.SelectedItem;
            Ciudad llegada = (Ciudad)arribo.SelectedItem;
            int retorno = DBAdapter.executeProcedureWithReturnValue("Registrar_Llegada",
                aeronave.Matricula, origen.Nombre_Ciudad, llegada.Nombre_Ciudad, Convert.ToDateTime(horario.Value));
            if (retorno == -1) MessageBox.Show("La aeronave no debia llegar al destino ingresado");
            else 
            {
                MessageBox.Show("Llegada registrada exitosamente");
                this.Close();
            }
        }
    }
}
