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
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            /*     OracleConnection con = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Shoudymella1986; USER ID = ProyectoLBD;");
                 con.Open();
                 OracleCommand comando = new OracleCommand("select * from Facturas", con); // aqui procedimiento almacenado
                 comando.ExecuteNonQuery();

                 OracleDataAdapter adaptador = new OracleDataAdapter();
                 adaptador.SelectCommand = comando;

                 DataTable tb = new DataTable();
                 adaptador.Fill(tb);

                 dgv.DataSource = tb;*/

            DataTable tb = new DataTable();

            tb = Logica.TraeUsuario();

            dgv.DataSource = tb;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     /*       var row = (sender as DataGridView).CurrentRow;

            txtInterno.Text = row.Cells[0].Value.ToString();
            txtConsecutivo.Text = row.Cells[1].Value.ToString();
            txtFecha.Text = row.Cells[2].Value.ToString();
            txtTasaCambio.Text = row.Cells[3].Value.ToString();
            txtIdUsuario.Text = row.Cells[8].Value.ToString();
            txtIdMoneda.Text = row.Cells[9].Value.ToString();
            txtTotal.Text = row.Cells[4].Value.ToString();
            txtObservaciones.Text = row.Cells[6].Value.ToString();*/
            
        }
    }
}
