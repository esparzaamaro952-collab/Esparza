using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Esparza.config
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\espar\\OneDrive\\Escritorio\\Esparza\\Esparza\\App_Data\\PRUEBA4.mdf;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}