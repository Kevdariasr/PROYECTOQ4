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

namespace PROYECTO
{
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Incluir
            //SqlConnection conexion = new SqlConnection("Server= 403-11\\ULACIT; database=Proyecto;integrated security = true");
            SqlConnection conexion = new SqlConnection("server= DESKTOP-KU604C6; database=Proyecto; integrated security = true");

            conexion.Open();
            string cadena = "insert into Facturas(Proveedor, Producto, Codigo, Cantidad, Precio, Total)"
                + "values('" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','"
                + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            conexion.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //modificar
            //SqlConnection conexion = new SqlConnection("Server= 403-11\\ULACIT; database=Proyecto;integrated security = true");
            SqlConnection conexion = new SqlConnection("server= DESKTOP-KU604C6; database=Proyecto; integrated security = true");

            conexion.Open();
            string cadena = "update Facturas set Proveedor='" + textBox2.Text + "'" +
                ", Producto='" + comboBox1.Text + "'" +
                ", Codigo='" + textBox1.Text + "'" +
                ", Cantidad='" + textBox5.Text + "'" +
                ", Total='" + textBox3.Text + "'" +
                "where Precio=" + textBox4.Text;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cantidad_modificados = comando.ExecuteNonQuery();
            if (cantidad_modificados == 1)
            {
                MessageBox.Show("Se modificaron los datos");
            }
            else
                MessageBox.Show("la identificación no existe");
            conexion.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Eliminar
            //SqlConnection conexion = new SqlConnection("Server= 403-11\\ULACIT; database=Proyecto;integrated security = true");
            SqlConnection conexion = new SqlConnection("server= DESKTOP-KU604C6; database=Proyecto; integrated security = true");

            conexion.Open();
            string cadena = "delete from Facturas where Codigo=" + textBox1.Text;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cantidad_borrados = comando.ExecuteNonQuery();
            if (cantidad_borrados == 1)
            {
                MessageBox.Show("El registro fue borrado");
            }
            else
            {
                MessageBox.Show("la identificación no existe");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            conexion.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //salir 
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Total
            int v1 = int.Parse(textBox5.Text);
            int v2 = int.Parse(textBox4.Text);
            int multi = v1 * v2;
            textBox3.Text = "Total: " + multi.ToString() + " colones";

        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server= 403-12\\ULACIT; database=Proyecto; integrated security = true");
            //SqlConnection conexion = new SqlConnection("server= DESKTOP-KU604C6; database=Proyecto; integrated security = true");
            
            conexion.Open();
            conexion.Close();
        }
    }
}
