using AerolineaFrba.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class Encomienda : Form
    {
        int kgs = -1;

        public Encomienda()
        {
            InitializeComponent();
        }

        internal int ShowDialog()
        {
            this.ShowDialog();
            return kgs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls) && Validacion.soloNumeros( this.kgsTextBox, "Kgs a enviar"))
            { 
                kgs = Convert.ToInt32(kgsTextBox.Text);
                this.Close();
            }
            else MessageBox.Show("Debe cargar los kgs a enviar para confirmar");
        }
    }
}
