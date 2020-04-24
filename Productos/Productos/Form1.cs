using Conexiones;
using Producto;
using System;
using System.Windows.Forms;


namespace Productos
{
    public partial class Form1 : Form
    {
        Conexion conex = new Conexion();
        Product nuevoProducto = new Product();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallerDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.tallerDataSet.productos);
            conex.mostrarDatos(dgvProducto);
        }

        public void cargarDatos()
        {
            nuevoProducto.nombre = textNombre.Text.ToString();
            nuevoProducto.descripcion = textDescripcion.Text.ToString();
            nuevoProducto.precio = int.Parse(textPrecio.Text.ToString());
            nuevoProducto.stock = int.Parse(textStock.Text.ToString());

        } 

        public void vaciarDatos()
        {
            textNombre.ResetText();
            textDescripcion.ResetText();
            textPrecio.ResetText();
            textStock.ResetText();
        }

        public void cargarId()
        {
            string id = dgvProducto.CurrentRow.Cells[0].Value.ToString();
            nuevoProducto.idProducto = int.Parse(id);
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            cargarDatos();
            if (nuevoProducto.idProducto != 0)
            {
                conex.update(nuevoProducto);
            }
            else
            {
                conex.insert(nuevoProducto);
            }
            conex.mostrarDatos(dgvProducto);
            vaciarDatos();
        }


        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarId();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
