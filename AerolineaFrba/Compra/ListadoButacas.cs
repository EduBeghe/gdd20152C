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

        internal int  ShowDialog(object func)
        {
            this.aeronave = Convert.ToInt32(func);
            this.ShowDialog();
            return aeronave;
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListadoButacas_Load(object sender, EventArgs e)
        {
            this.butacas.DataSource = DBAdapter.retrieveDataTable("Butacas_Libres", aeronave );
        }

        private void button3_Click(object sender, EventArgs e)
        {
           aeronave = -1;
            if (butacas.SelectedRows.Count != 0)
            {
                aeronave = Convert.ToInt32( butacas.SelectedRows[0].Cells[0].Value ) ;
                this.Close();
            }
            
        }

      
    }
}
