using Proyecto_Lenguajes_BD.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguajes_BD.Pantallas
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();

            tb = Logica.TraeProveedor();

            dgv.DataSource = tb;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txtInterno.Text = row.Cells[0].Value.ToString();
            txtTel.Text = row.Cells[1].Value.ToString();
            txtContacto.Text = row.Cells[2].Value.ToString();
            txtNombreProveedor.Text = row.Cells[3].Value.ToString();
            txtDir.Text = row.Cells[4].Value.ToString();
            txtCorreo.Text = row.Cells[5].Value.ToString();
        }

        private void Eliminar_Click_1(object sender, EventArgs e)
        {
            Logica.EliminaProveedor(Int32.Parse(txtInterno.Text.ToString()));

            DataTable tb = new DataTable();

            tb = Logica.TraeProveedor();

            dgv.DataSource = tb;
        }
    }
}


