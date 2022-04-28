using Proyecto_Lenguajes_BD.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguajes_BD
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        //Usuarios
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios Frm = new Usuarios();
            Frm.ShowDialog();

        }

        //Proveedores
        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores Frm = new Proveedores();
            Frm.ShowDialog();
        }

        //Facturas
        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construcción...");
            //Facturas Frm = new Facturas();
            //Frm.ShowDialog();
        }

        //Productos
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos Frm = new Productos();
            Frm.ShowDialog();
        }

        //Monedas
        private void monedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monedas Frm = new Monedas();
            Frm.ShowDialog();
        }

        //Bodegas
        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bodegas Frm = new Bodegas();
            Frm.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Login Frm = new Login();  //esto lo podemos comentar
            //Frm.ShowDialog();         // para que entre al menu sin pedir usuario
        }

        private void productosEnBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construcción...");
            //ProductosXBodega Frm = new ProductosXBodega();
            //Frm.ShowDialog();
        }

        private void productosPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construcción...");
            //ProductosXProveedor Frm = new ProductosXProveedor();
            //Frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construcción...");
        }

        private void másInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasInfo Frm = new MasInfo();
            Frm.ShowDialog();
        }
    }
}
