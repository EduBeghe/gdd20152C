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

namespace AerolineaFrba.Abm_Rol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Falta que ingresen como parametro las funcionalidades
            if (Validacion.validarInputs(this.Controls))
            { 
                var retorno = new RolesRepository().agregarRol(nombre.Text);

                for (int i = listaFuncionalidades.Items.Count - 1; i >= 0; i--)
                {
                    new RolesRepository().relacionRolFuncionabilidad(nombre.Text, listaFuncionalidades.Items[i].ToString());
                }

                if (retorno == 0)
                {
                    MessageBox.Show("Rol dato de alta exitosamente");
                }
                else {
                    MessageBox.Show("El rol que quiere dar de alta ya existe");
                }
                
            }
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            //BindingSource funcionalidades = new BindingSource(new BindingList<Funcionalidades>(new FuncionalidadRepository().getFuncionalidades()), null);
            //this.funcionabilidad.DataSource = funcionalidades;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaFuncionalidades.Items.Add(funcionabilidad.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaFuncionalidades.Items.Remove(listaFuncionalidades.SelectedItem);
        }
    }
}
