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
    public partial class Monedas : Form
    {
        public Monedas()
        {
            InitializeComponent();
        }

        private void Monedas_Load(object sender, EventArgs e)
        {

            DataTable tb = new DataTable();

            tb = Logica.TraeMoneda();

            dgv.DataSource = tb;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txtInterno.Text = row.Cells[0].Value.ToString();
            txtCodigo.Text = row.Cells[1].Value.ToString();
            txtValorMoneda.Text = row.Cells[2].Value.ToString();
            txtNombreMoneda.Text = row.Cells[3].Value.ToString();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Logica.EliminaMoneda(Int32.Parse(txtInterno.Text.ToString()));

            DataTable tb = new DataTable();

            tb = Logica.TraeMoneda();

            dgv.DataSource = tb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logica.ActualizaMoneda(Int32.Parse(txtInterno.Text.ToString()), Int32.Parse(txtValorMoneda.Text.ToString()));

            DataTable tb = new DataTable();

            tb = Logica.TraeMoneda();

            dgv.DataSource = tb;
        }
    }
}
