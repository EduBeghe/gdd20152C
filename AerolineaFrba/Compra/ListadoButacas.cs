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
using AerolineaFrba.Utils;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ListadoButacas : Form
    {
        int aeronave;
            
        public ListadoButacas()
        {
            InitializeComponent();
        }

        internal void ShowDialog(object func)
        {
            this.aeronave = Convert.ToInt32(func);
            this.ShowDialog();
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string button3_Click(object sender, EventArgs e)
        {
            string butacaSeleccionda = "";
            if (butacas.SelectedRows.Count != 0)
            {
                butacaSeleccionda = butacas.SelectedRows[0].Cells[0].Value.ToString();
                return butacaSeleccionda;
                this.Close();
            }
            else return butacaSeleccionda = "Butaca sin seleccionar";

        }

        private void ListadoButacas_Load(object sender, EventArgs e)
        {
            this.butacas.DataSource = DBAdapter.retrieveDataTable("Butacas_Libres", aeronave );
        }

      
    }
}
