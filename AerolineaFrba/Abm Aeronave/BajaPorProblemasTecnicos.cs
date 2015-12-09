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
            int retorno;
            if (reemplazarCheckbox.Checked)
            {
                 retorno =  new AeronaveRepository().darDeBajaXProblemasTecnicos(aeronave, false, fechaProblemasTecnicos.Value);
            }
            else
            {
               retorno = new AeronaveRepository().darDeBajaXProblemasTecnicos(aeronave, true, fechaProblemasTecnicos.Value);
            }
            if (retorno == 0)
            {
                MessageBox.Show("Aeronave dada de baja con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("La aeronave que desea dar de baja ya estaba dada de baja");
                this.Close();
            }
            
        }
    }
}
