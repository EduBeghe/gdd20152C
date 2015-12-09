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
namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ListadoButacas : Form
    {
        Aeronave aeronave;
            
        public ListadoButacas()
        {
            InitializeComponent();
        }

        internal void ShowDialog(Aeronave aeronave)
        {
            this.aeronave = Aeronave.Copy(aeronave);
            this.ShowDialog();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (butacas.SelectedRows.Count != 0) return ;
            else MessageBox.Show("Debe seleccionar una butaca");
        }

        private void ListadoButacas_Load(object sender, EventArgs e)
        {

        }
    }
}
