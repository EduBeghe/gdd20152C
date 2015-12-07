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
            if (nombre.Text != "") new RolesRepository().modificarNombre( rol, nombre.Text);
            if (estado.Checked) new RolesRepository().modificarEstado( rol, true );
            else new RolesRepository().modificarEstado(rol, false);
            // foreach ( checked funcionalidad ) 
            // if not in Rol.Fun
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {
            this.funcionalidadesBox.DataSource = new BindingSource(new BindingList<Funcionalidades>(new FuncionalidadRepository().getFuncionalidades()), null);
            // foreach( Funcionalidad in funcionalidades ) check if esta en rol.funcionalidades
        }
    }
}
