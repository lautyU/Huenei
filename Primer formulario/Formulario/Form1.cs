using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formulario
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //actualizar

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strNombre, strApellido, strFechaNacimiento, strDireccion;
            strNombre = nombre.Text;
            strApellido = apellido.Text;
            strFechaNacimiento = FN.Value.Year.ToString() + '/' + FN.Value.Month.ToString() + '/' + FN.Value.Day.ToString();
            strDireccion = direccion.Text;

            SqlConnection conectar = new SqlConnection("Data Source = (local); Initial Catalog = Taller; Integrated Security = true; "
);
            string consulta = string.Format("Insert into clientes (Nombre, Apellido, Fecha_Nacimiento, Direccion) values ('{0}','{1}','{2}','{3}')",
                strNombre, strApellido, strFechaNacimiento, strDireccion);

            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //guardar

            string strNombre, strApellido, strFechaNacimiento, strDireccion;
            strNombre = nombre.Text;
            strApellido = apellido.Text;
            strFechaNacimiento = FN.Value.Year.ToString() + '/' + FN.Value.Month.ToString() + '/' + FN.Value.Day.ToString();
            strDireccion = direccion.Text;

            SqlConnection conectar = new SqlConnection("Data Source = (local); Initial Catalog = Taller; Integrated Security = true; ");
            string consulta = string.Format("update clientes (Nombre, Apellido, Fecha_Nacimiento, Direccion) values ('{0}','{1}','{2}','{3}')",
                strNombre, strApellido, strFechaNacimiento, strDireccion);

            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            MessageBox.Show("Se ha modificado correctamente");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void dgvBuscar_Click(object sender, EventArgs e)
        {
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallerDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.tallerDataSet.clientes);

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conectar = new SqlConnection("Data Source=(local);Initial Catalog=Taller;Integrated Security=true;");
            String consulta = "SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes";
            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();
           
            while (reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Direccion = reader.GetString(4);


                lista.Add(pCliente);



            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conectar = new SqlConnection("Data Source=(local);Initial Catalog=Taller;Integrated Security=true;");
            String consulta = "SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes";
            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Direccion = reader.GetString(4);


                lista.Add(pCliente);



            }
        }
    }

  
    }
