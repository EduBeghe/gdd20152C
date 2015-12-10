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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class canjeMillas : Form
    {
        public canjeMillas()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int retorno = 0;
            var clientesRepository = new ClientesRepository();
            if (Validacion.validarInputs(this.Controls) &&
                Validacion.soloNumeros(this.dni, dni.Name) && Validacion.soloLetras(this.apellido, apellido.Name)
                && Validacion.soloNumeros(this.cantidad, cantidad.Name))
            {
                retorno = clientesRepository.canjeMillas(
                    clientesRepository.getCliente(Convert.ToInt32(dni.Text), apellido.Text),
                    (ProductoCanje)producto.SelectedItem,
                    Convert.ToInt32(cantidad.Text)
                    );
            }
            if (retorno == -1) MessageBox.Show("Los datos del cliente ingresados no existen");
            else if (retorno == -2) MessageBox.Show("No hay stock del producto elegido");
            else if (retorno == -3) MessageBox.Show("No tiene millas sufieciente para el producto elegido");
            else
            {
                MessageBox.Show("Producto comprado con exito");
                this.Close();
            }
            
        }

        private void canjeMillas_Load(object sender, EventArgs e)
        {
            this.producto.DataSource = new BindingSource(new BindingList<ProductoCanje>(new Repositorios.ProductoRepository().getProductos()), null);
        }
    }
}
