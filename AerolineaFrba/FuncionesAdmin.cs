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
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Login;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Listado_Estadistico;
using AerolineaFrba.Generacion_Viaje;
using AerolineaFrba.Registro_Llegada_Destino;
using AerolineaFrba.Compra;
using AerolineaFrba.Utils;
using AerolineaFrba.Devolucion;

namespace AerolineaFrba
{
    public partial class FuncionesAdmin : Form
    {
        Boolean esAdministrador;

        public FuncionesAdmin()
        {
            InitializeComponent();
        }

        internal void ShowDialog( Boolean administrador )
        {
            this.esAdministrador = administrador;
            this.ShowDialog();
        }

        private void AltaAeronaveButton_Click(object sender, EventArgs e)
        {

            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Alta Aeronave")) new AltaAeronave().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void BuscarAeronaveButton_Click(object sender, EventArgs e)
        {
            new ListadoAeronave().ShowDialog(this);
            
        }

        private void AltaRutaButton_Click(object sender, EventArgs e)
        {

            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Alta Ruta")) new AltaRuta().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void BuscarRutaButton_Click(object sender, EventArgs e)
        {
            new ListadoRuta().ShowDialog(this);
            
        }

        private void AltaRolButton_Click(object sender, EventArgs e)
        {
            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Alta Rol")) new AltaRol().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void BuscarRolButton_Click(object sender, EventArgs e)
        {
            new ListadoRol().ShowDialog(this);
        }

        private void AltaCiudadButton_Click(object sender, EventArgs e)
        {

            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Alta Ciudad")) new AltaCiudad().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void BuscarCiudadButton_Click(object sender, EventArgs e)
        {

            new ListadoCiudad().ShowDialog(this);
            
        }

        private void CanjeMillasButton_Click(object sender, EventArgs e)
        {
            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Canje Millas")) new canjeMillas().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void ConsultarMillasButton_Click(object sender, EventArgs e)
        {

            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Consulta Millas")) new ConsultaMillas().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            new LoginScreen().ShowDialog(this);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Listado Estadístico")) new ListadoEstadistico().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Generación Viaje")) new AltaViaje().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Registro Llegada Destino")) new RegistroLlegada().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Compra Pasajes" || x.Nombre_Funcionalidad == "Compra Encomiendas")) new Compra.Compra().ShowDialog(esAdministrador);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

        private void FuncionesAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CLC_SessionManager.currentUser.rol.funcionalidades.Exists(x => x.Nombre_Funcionalidad == "Devolución" || x.Nombre_Funcionalidad == "Compra Encomiendas")) new RegistroDevolucion().ShowDialog(this);
            else MessageBox.Show("No tiene permisos para realizar esta funcion");
        }

       
    }
}
