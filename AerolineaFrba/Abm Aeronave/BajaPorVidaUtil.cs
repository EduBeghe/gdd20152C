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
    public partial class BajaPorVidaUtil : Form
    {
        private Aeronave aeronave;

        public BajaPorVidaUtil()
        {
            InitializeComponent();
        }

        internal void ShowDialog(Aeronave aeronave)
        {
            // haver el copy de aeronovae
            this.aeronave = Aeronave.Copy(cli);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
