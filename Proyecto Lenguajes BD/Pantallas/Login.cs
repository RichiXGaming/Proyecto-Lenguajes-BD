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
    public partial class Login : Form
    {
        string user = "";
        string pass = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textUserLogin.Text = "Digite nombre de usuario";
            textUserLogin.ForeColor = Color.Gray;
            textPassLogin.PasswordChar = '\0';
            textPassLogin.Text = "Digite su contraña";
            textPassLogin.ForeColor = Color.Gray;
        }
     
        private void textUserLogin_Enter(object sender, EventArgs e)
        {
            textUserLogin.Text = "";
            textUserLogin.ForeColor = Color.Black;
        }

        private void textUserLogin_Leave(object sender, EventArgs e)
        {
            user = textUserLogin.Text;
            if (user.Equals("Digite nombre de usuario"))
            {
                textUserLogin.Text = "Digite el nombre de usuario";
                textUserLogin.ForeColor = Color.Gray;
            }
            else
            {
                if (user.Equals(""))
                {
                    textUserLogin.Text = "Digite nombre de usuario";
                    textUserLogin.ForeColor = Color.Gray;
                }
                else
                {
                    textUserLogin.Text = user;
                    textUserLogin.ForeColor = Color.Black;
                }
            }
        }

        private void textPassLogin_Enter(object sender, EventArgs e)
        {
            textPassLogin.Text = "";
            textPassLogin.ForeColor = Color.Black;
            textPassLogin.PasswordChar = '*';
        }

        private void textPassLogin_Leave(object sender, EventArgs e)
        {
            pass = textPassLogin.Text;
            if (pass.Equals("Digite su contraseña"))
            {
                textPassLogin.Text = "Digite su contraseña";
                textPassLogin.ForeColor = Color.Gray;
            }
            else
            {
                if (pass.Equals(""))
                {
                    textPassLogin.PasswordChar = '\0';
                    textPassLogin.Text = "Digite su contraseña";
                    textPassLogin.ForeColor = Color.Gray;
                }
                else
                {
                    textPassLogin.PasswordChar= '*';
                    textPassLogin.Text = pass;
                    textPassLogin.ForeColor = Color.Black;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassLogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void Ingresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario es: {0}  y el pass es: {1}" + user, pass);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
