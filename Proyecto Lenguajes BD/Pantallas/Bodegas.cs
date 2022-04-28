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
    public partial class Bodegas : Form
    {
        public Bodegas()
        {
            InitializeComponent();
        }

        private void Bodegas_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();

            tb = Logica.TraeBodegas();

            dgv.DataSource = tb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txtInterno.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtDesc.Text = row.Cells[2].Value.ToString();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Logica.EliminaBodegas(Int32.Parse(txtInterno.Text.ToString()));

            DataTable tb = new DataTable();

            tb = Logica.TraeBodegas();

            dgv.DataSource = tb;
        }
    }
}
