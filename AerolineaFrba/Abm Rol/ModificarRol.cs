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

namespace AerolineaFrba.Abm_Rol
{
    public partial class ModificarRol : Form
    {
        Rol rol;

        public ModificarRol()
        {
            InitializeComponent();
        }

        internal void ShowDialog(Rol rol )
        {
            this.rol = Rol.Copy(rol);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombre.Text != "")
            {
                var retornoNombre = new RolesRepository().modificarNombre(rol, nombre.Text);
                if (retornoNombre == -1) MessageBox.Show("El nombre de rol al que quiere modificar ya existe");
            }
            if (estado.Checked)
            {
                new RolesRepository().modificarEstado(rol, true);
            }
            else
            {
                new RolesRepository().modificarEstado(rol, false);
            }
            foreach ( Object item in funcionalidadesBox.Items)
            {
                if (funcionalidadesBox.CheckedItems.Contains(item)
                    && !rol.funcionalidades.Contains(item)) { new RolesRepository().relacionRolFuncionabilidad(rol.Nombre_Rol, (Funcionalidades) item ); }
                if (!funcionalidadesBox.CheckedItems.Contains(item) &&
                    rol.funcionalidades.Contains(item)) { new RolesRepository().quitarFuncionabilidad(rol.Cod_Rol, (Funcionalidades)item); }
            }
            MessageBox.Show("Rol modificado con exito");
            this.Close();
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {
            this.funcionalidadesBox.DataSource = new BindingSource(new BindingList<Funcionalidades>(new FuncionalidadRepository().getFuncionalidades()), null);
            
            foreach( Funcionalidades item in funcionalidadesBox.Items ) {
                if (rol.funcionalidades.Contains(item)) {
                    MessageBox.Show(item.Nombre_Funcionalidad);
                    funcionalidadesBox.SetItemCheckState(funcionalidadesBox.Items.IndexOf(item), CheckState.Checked); }
            }
        }

        private void funcionalidadesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
