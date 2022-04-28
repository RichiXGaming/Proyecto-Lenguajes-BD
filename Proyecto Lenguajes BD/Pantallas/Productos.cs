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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();

            tb = Logica.TraeProducto();

            dgv.DataSource = tb;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void INSERTAR_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txtInterno.Text = row.Cells[0].Value.ToString();
            txtNombreProducto.Text = row.Cells[1].Value.ToString();
            txtCodigo.Text = row.Cells[2].Value.ToString();
            txtDescripcion.Text = row.Cells[3].Value.ToString();
            txtPrecio.Text = row.Cells[4].Value.ToString();
            txtIVA.Text = row.Cells[5].Value.ToString();
            txtCodBarras.Text = row.Cells[6].Value.ToString();
            txtCabys.Text = row.Cells[7].Value.ToString();
        }

        private void Eliminar_Click_1(object sender, EventArgs e)
        {
            Logica.EliminaProducto(Int32.Parse(txtInterno.Text.ToString()));

            DataTable tb = new DataTable();

            tb = Logica.TraeProducto();

            dgv.DataSource = tb;
        }
    }
}
