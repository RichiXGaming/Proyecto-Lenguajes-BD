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
    public partial class ProductosXBodega : Form
    {
        public ProductosXBodega()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductosXBodega_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();

            tb = Logica.TraeProductoXBodega();

            dgv.DataSource = tb;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txtIdBodega.Text = row.Cells[0].Value.ToString();
            txtIdProducto.Text = row.Cells[1].Value.ToString();
            txtCantidad.Text = row.Cells[2].Value.ToString();
            
        }
     /*   private void Eliminar_Click(object sender, EventArgs e)
        {
            Logica.EliminaUsuario(Int32.Parse(txtInterno.Text.ToString()));

            DataTable tb = new DataTable();

            tb = Logica.TraeUsuario();

            dgv.DataSource = tb;
        }*/
    }
}
