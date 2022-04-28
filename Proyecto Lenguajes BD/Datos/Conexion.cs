using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lenguajes_BD.Datos
{
    class Conexion
    {

        private static OracleConnection con = new OracleConnection("DATA SOURCE = orcl; PASSWORD=Shoudymella1986; USER ID = ProyectoLBD;");

        public static OracleConnection TraeConexion()
        {
            OracleConnection Conexion = con;

            return Conexion;
        }


    }
}
