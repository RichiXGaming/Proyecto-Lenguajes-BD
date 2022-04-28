using Proyecto_Lenguajes_BD.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguajes_BD.Pantallas
{
    public partial class ProductosXProveedor : Form
    {
        public ProductosXProveedor()
        {
            InitializeComponent();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {

        }

        private void ProductosXProveedor_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();

            tb = Logica.TraeProductoXProveedor();

            dgv.DataSource = tb;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txtInterno.Text = row.Cells[0].Value.ToString();
            txtCodigo.Text = row.Cells[1].Value.ToString();
            
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Logica.EliminaProductoXProveedor(Int32.Parse(txtInterno.Text.ToString()));

            DataTable tb = new DataTable();

            tb = Logica.TraeProductoXProveedor();

            dgv.DataSource = tb;

        }
    }
}
