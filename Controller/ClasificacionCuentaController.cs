using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace OrdenaCuenta.Controller
{
    internal class ClasificacionCuentaController
    {

        public ClasificacionCuentaController() { }

        public MaterialListView GetClasificacionCuenta()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("showClasificacionCuenta", Con);
                cmd.CommandType = CommandType.StoredProcedure;

          
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
               // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);

                //if (dataTable.Rows.Count > 0)
                //{
                //    // El DataTable contiene al menos una fila de datos, lo que significa que se recuperó información.
                //    // Puedes realizar acciones adicionales aquí si es necesario.
                //    Console.WriteLine("Se encontraron datos en el DataTable.");
                //}
                //else
                //{
                //    // El DataTable está vacío, lo que significa que no se recuperó información.
                //    Console.WriteLine("El DataTable está vacío. No se encontraron datos.");
                //}

                foreach (DataRow fila in dataTable.Rows)
                {

                    Console.WriteLine("Id: " + fila["Id"].ToString());
                    Console.WriteLine("Clase: " + fila["Clase"].ToString());
                    Console.WriteLine("TipoCuenta: " + fila["TipoCuenta"].ToString());
                    Console.WriteLine("Naturaleza: " + fila["Naturaleza"].ToString());
                    Console.WriteLine("Activo: " + fila["Activo"].ToString());

                    ListViewItem item = new ListViewItem(fila["Id"].ToString());
                    
                    item.SubItems.Add(fila["Clase"].ToString());
                    item.SubItems.Add(fila["TipoCuenta"].ToString());
                    item.SubItems.Add(fila["Naturaleza"].ToString());
                   // item.SubItems.Add(fila["Activo"].ToString());

                    lista.Items.Add(item);

                    //if (lista.Items.Count > 0)
                    //{
                    //    // El MaterialListView contiene datos (elementos)
                    //    // Puedes realizar acciones adicionales aquí si es necesario.
                    //    Console.WriteLine("El MaterialListView contiene datos.");
                    //}
                    //else
                    //{
                    //    // El MaterialListView está vacío, lo que significa que no hay datos.
                    //    Console.WriteLine("El MaterialListView está vacío. No hay datos.");
                    //}

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


          
            Con.Close();
            return lista;


        }


        public DataTable GetClasificaCuenta()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;


        }



    }
}
