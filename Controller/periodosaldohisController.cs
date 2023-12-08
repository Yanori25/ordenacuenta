using MaterialSkin.Controls;
using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace OrdenaCuenta.Controller
{
    public class periodosaldohisController
    {

        public periodosaldohisController() { }


        public MaterialListView Getsaldoperiodo(int periodo)
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                DataTable dataTable = new DataTable();

                using (SqlCommand cmd = new SqlCommand("periodosaldohisperiodos", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agrega parámetros si es necesario.
                    cmd.Parameters.Add(new SqlParameter("@perid", SqlDbType.Int)).Value = periodo;

                    // Ejecuta el procedimiento almacenado.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["id"].ToString());
                            item.SubItems.Add(reader["percueid"].ToString());
                            item.SubItems.Add(reader["cuentacontable"].ToString());
                            item.SubItems.Add(reader["descripcion"].ToString());
                            item.SubItems.Add(reader["valorcuenta"].ToString());
                            lista.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Con.Close();
            return lista;
        }


        //public MaterialListView Getsaldoperiodo(int periodo )
        //{
        //    SqlConnection Con = new Conexion().GetConexion("BDConexion");
        //    Con.Open();

        //    MaterialListView lista = new MaterialListView();

        //    try
        //    {
        //        // Tu código aquí

        //        DataTable dataTable = new DataTable();

        //      //  SqlCommand cmd = new SqlCommand("exec periodosaldohisperiodos " + periodo + " ", Con);
        //       // cmd.CommandType = CommandType.StoredProcedure;




        //       // SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        using (SqlDataAdapter da = new SqlDataAdapter(" dbo.periodosaldohisperiodos ", Con))
        //        {
        //            da.SelectCommand.CommandType = CommandType.StoredProcedure;

        //            // Agrega parámetros si es necesario.
        //            da.SelectCommand.Parameters.Add(new SqlParameter("@perid", SqlDbType.Int)).Value = periodo;

        //            // Crea un DataTable para almacenar los resultados.


        //            // Llena el DataTable con los resultados del procedimiento almacenado.
        //            da.Fill(dataTable);
        //        }
        //        //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
        //        // da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //      //  da.Fill(dataTable);


        //        foreach (DataRow fila in dataTable.Rows)
        //        {


        //            ListViewItem item = new ListViewItem(fila["id"].ToString());

        //            item.SubItems.Add(fila["percueid"].ToString());
        //            item.SubItems.Add(fila["cuentacontable"].ToString());
        //            item.SubItems.Add(fila["descripcion"].ToString());
        //            item.SubItems.Add(fila["valorcuenta "].ToString());
        //            // item.SubItems.Add(fila["Activo"].ToString());

        //            lista.Items.Add(item);


        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }



        //    Con.Close();
        //    return lista;


        //}



    }
        }
