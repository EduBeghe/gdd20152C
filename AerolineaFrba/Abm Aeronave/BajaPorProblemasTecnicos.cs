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


namespace AerolineaFrba.Abm_Ciudad
{
    public partial class BajaPorProblemasTecnicos : Form
    {
        private Aeronave aeronave;

        public BajaPorProblemasTecnicos()
        {
            InitializeComponent();
        }

        internal void ShowDialog( Aeronave aeronave )
        {
            this.aeronave = Aeronave.Copy(aeronave);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( reemplazarCheckbox.Checked ) new AeronaveRepository().darDeBajaXProblemasTecnicos(aeronave, false , fechaProblemasTecnicos.Value );
            else new AeronaveRepository().darDeBajaXProblemasTecnicos(aeronave, true, fechaProblemasTecnicos.Value);
            MessageBox.Show("Aeronave dada de baja con exito");
            this.Close();
        }
    }
}
