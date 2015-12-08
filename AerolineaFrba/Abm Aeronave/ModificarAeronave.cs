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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ModificarAeronave : Form
    {
        private Aeronave aeronave;

        public ModificarAeronave()
        {
            InitializeComponent();
        }

        internal void ShowDialog(Aeronave aeronave)
        {
            this.aeronave = Aeronave.Copy(aeronave);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                if (rehabilitar.Checked)
                {
                    new AeronaveRepository().modificarAeronave(
                        Convert.ToInt32(codigo.Text),
                        Convert.ToDateTime(fechaAlta.Value),
                        (Fabricante)fabricante.SelectedItem,
                        modelo.Text,
                        (TipoServicio)servicio.SelectedItem,
                        true);
                }
                else {
                    new AeronaveRepository().modificarAeronave(
                        Convert.ToInt32(codigo.Text),
                        Convert.ToDateTime(fechaAlta.Value),
                        (Fabricante)fabricante.SelectedItem,
                        modelo.Text,
                        (TipoServicio)servicio.SelectedItem,
                        false);
                }
                MessageBox.Show("Modificacion de Aeronave exitosa");
                this.Close();
               } else { MessageBox.Show("Debe llenar todos los campos"); }
                    
        }
    }
}

