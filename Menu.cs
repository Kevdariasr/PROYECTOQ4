using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas fa = new Facturas();
            fa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // crear usuario
            Usuario us = new Usuario();
            us.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Show();
        }
    }
}
