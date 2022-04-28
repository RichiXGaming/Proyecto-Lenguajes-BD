using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguajes_BD.Datos
{
    class Logica
    {

        #region Usuarios

        public static DataTable TraeUsuario()
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_Usuarios.TraeUsuarios", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tb = new DataTable();
            adaptador.Fill(tb);

            con.Close();

            return tb;
        }

        public static void EliminaUsuario(int us)
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            try {
                OracleCommand comando = new OracleCommand("pkg_Usuarios.Eliminar_usuario", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("id_usuario", us).Direction = ParameterDirection.Input;
                comando.ExecuteNonQuery();
            
                con.Close();

                MessageBox.Show("Realizado de manera satisfactoria");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("No se puede eliminar el registro, contacte con el administrador");
            }
        }

        #endregion

        #region Proveedores

        public static DataTable TraeProveedor()
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_proveedores.TraeProveedores", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tb = new DataTable();
            adaptador.Fill(tb);

            con.Close();

            return tb;
        }

        public static void EliminaProveedor(int identificador)
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            try {
                OracleCommand comando = new OracleCommand("pkg_proveedores.Eliminar_Proveedor", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("id_proveedor", identificador).Direction = ParameterDirection.Input;
                comando.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Realizado de manera satisfactoria");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("No se puede eliminar el registro, contacte con el administrador");
            }
}

        #endregion

        #region ProductosXProveedor

        public static DataTable TraeProductoXProveedor()
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_Usuarios.TraeProductosXProveedores", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tb = new DataTable();
            adaptador.Fill(tb);

            con.Close();

            return tb;
        }

        public static void EliminaProductoXProveedor(int identificador)
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_Usuarios.Eliminar_productoxproveedor", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("id_productoxproveedor", identificador).Direction = ParameterDirection.Input;
            comando.ExecuteNonQuery();

            con.Close();
        }

        #endregion

        #region ProductosXBodega

        public static DataTable TraeProductoXBodega()
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_Usuarios.TraeProductosXBodegas", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tb = new DataTable();
            adaptador.Fill(tb);

            con.Close();

            return tb;
        }

        public static void EliminaProductoXBodega(int identificador)
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_Usuarios.Eliminar_productoxbodega", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("id_productoxbodega", identificador).Direction = ParameterDirection.Input;
            comando.ExecuteNonQuery();

            con.Close();
        }

        #endregion

        #region Productos

        public static DataTable TraeProducto()
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_productos.TraeProductos", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tb = new DataTable();
            adaptador.Fill(tb);

            con.Close();

            return tb;
        }

        public static void EliminaProducto(int identificador)
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            try
            {
                OracleCommand comando = new OracleCommand("pkg_productos.Eliminar_Productos", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("interno", identificador).Direction = ParameterDirection.Input;
                comando.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Realizado de manera satisfactoria");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("No se puede eliminar el registro, contacte con el administrador");
            }
            
        }

        #endregion

        #region Monedas
    
        public static DataTable TraeMoneda()
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_monedas.Traemonedas", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tb = new DataTable();
            adaptador.Fill(tb);

            con.Close();

            return tb;
        }

        public static void EliminaMoneda(int identificador)
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            try { 
                

                OracleCommand comando = new OracleCommand("pkg_monedas.Eliminar_monedas", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("interno", identificador).Direction = ParameterDirection.Input;
                comando.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Realizado de manera satisfactoria");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("No se puede eliminar el registro, contacte con el administrador");
            }
        }

        public static void ActualizaMoneda(int identificador, int nuevoValor)
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            try
            {


                OracleCommand comando = new OracleCommand("pkg_monedas.Update_monedas", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("interno", identificador).Direction = ParameterDirection.Input;
                comando.Parameters.Add("nuevoValor", nuevoValor).Direction = ParameterDirection.Input;
                comando.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Realizado de manera satisfactoria");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("No se puede actualizar el registro, contacte con el administrador");
            }
        }

        #endregion

        #region Bodegas

        public static DataTable TraeBodegas()
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            OracleCommand comando = new OracleCommand("pkg_bodegas.TraeBodegas", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tb = new DataTable();
            adaptador.Fill(tb);

            con.Close();

            return tb;
        }

        public static void EliminaBodegas(int identificador)
        {
            OracleConnection con = Conexion.TraeConexion();
            con.Open();

            try
            {
                OracleCommand comando = new OracleCommand("pkg_bodegas.Eliminar_Bodegas", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("interno", identificador).Direction = ParameterDirection.Input;
                comando.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Realizado de manera satisfactoria");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("No se puede eliminar el registro, contacte con el administrador");
            }

        }

        #endregion


    }
}
