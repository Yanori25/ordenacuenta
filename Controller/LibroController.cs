using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Controller
{
    internal class LibroController
    {
        public LibroController() { }

        public DataTable GetLibro()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("libroshow", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;


        }

    }
}
