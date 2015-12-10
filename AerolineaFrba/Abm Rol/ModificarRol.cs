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
                new RolesRepository().modificarNombre(rol, nombre.Text);
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
                    && !rol.funcionalidades.Exists( x => x.Nombre_Funcionalidad == item.ToString() ) ) { new RolesRepository().relacionRolFuncionabilidad(rol.Nombre_Rol, (Funcionalidades) item ); }
                if (!funcionalidadesBox.CheckedItems.Contains(item) &&
                    rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == item.ToString())) { new RolesRepository().quitarFuncionabilidad(rol.Cod_Rol, (Funcionalidades)item); }
            }
            MessageBox.Show("Rol modificado con exito");
            this.Close();
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {
            this.funcionalidadesBox.DataSource = new BindingSource(new BindingList<Funcionalidades>(new FuncionalidadRepository().getFuncionalidades()), null);
            
            for(int i = funcionalidadesBox.Items.Count - 1; i >= 0 ; i--) {
                if (rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == funcionalidadesBox.Items[i].ToString() ))
                {
                    funcionalidadesBox.SetItemCheckState(i, CheckState.Checked); }
            }
        }
    }
}
