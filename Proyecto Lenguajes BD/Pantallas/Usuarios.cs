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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            DataTable tb = new DataTable();

            tb = Logica.TraeUsuario();
            
            dgv.DataSource = tb;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            txtInterno.Text = row.Cells[0].Value.ToString();
            txtCodigo.Text = row.Cells[1].Value.ToString();
            txtPrimerNombre.Text = row.Cells[2].Value.ToString();
            txtSegundoNombre.Text = row.Cells[3].Value.ToString();
            txtApellido1.Text = row.Cells[4].Value.ToString();
            txtApellido2.Text = row.Cells[5].Value.ToString();
            txtCorreo.Text = row.Cells[6].Value.ToString();
            txtDir.Text = row.Cells[7].Value.ToString();
            txtCodPostal.Text = row.Cells[8].Value.ToString();
            txtTel.Text = row.Cells[9].Value.ToString();
            //txtInterno.Text = row.Cells[10].Value.ToString();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Logica.EliminaUsuario(Int32.Parse(txtInterno.Text.ToString()));

            DataTable tb = new DataTable();

            tb = Logica.TraeUsuario();

            dgv.DataSource = tb;
        }
    }
}
