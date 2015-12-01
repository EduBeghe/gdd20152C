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


namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AltaAeronave : Form
    {
        public AltaAeronave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aeronave = (Aeronave)aeronavesGrid.SelectedRows[0].DataBoundItem;
            new AeronaveRepository().darDeBajaXProblemasTecnicos(aeronave, fechaReinicio);
            MessageBox.Show("Aeronave dada de baja con exito");
            this.aeronavesGrid.DataSource = new BindingSource(new BindingList<Aeronave>(new AeronaveRepository().findAeronave()), null); 
        }
    }
}
