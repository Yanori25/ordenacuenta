using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace OrdenaCuenta.Model
{
    // esta clase nos sirve para conectarnos a la base de datos a la cual queremos acceder en el appconfig
    internal class Conexion
    {
        public Conexion() { }


        public SqlConnection GetConexion(string Conexion)
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings[Conexion].ToString());
        }

    }
}
