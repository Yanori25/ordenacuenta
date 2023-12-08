using MaterialSkin.Controls;
using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.Controller
{
    internal class PartidaController
    {
        public PartidaController() { }


        public bool Crear(Partida Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute partidaadd " + Modelo.Asiento + " , '"
                        + Modelo.Fecha + "' , "
                        + Modelo.CuentaPar + " , "
                        + Modelo.Parcial + " , "
                        + Modelo.Debe + " , " +
                        Modelo.Haber + " , '"
                         + Modelo.Referencia + "' , " +
                          +Modelo.ParIdEmpresa + " , " +
                           +Modelo.ParIdLibro + " , '"
                           + Modelo.UsuarioCreacion + "' , '" 
                           +Modelo.TipoTransaccion + "' , '"
                            + Modelo.estado + "' , "
                             + Modelo.subcueid + "  "
                        ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                 //   MaterialMessageBox.Show("Se agrego exitosamente");

                    Con.Close();
                }

                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public MaterialListView Getmovimientodiariopartidas(Partida Modelo)
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                DataTable dataTable = new DataTable();

                using (SqlCommand cmd = new SqlCommand("movimientodiariopartidas", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agrega parámetros si es necesario.
                    cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date)).Value = Modelo.Fecha;
                    cmd.Parameters.Add(new SqlParameter("@Fechafin", SqlDbType.Date)).Value = Modelo.FechaCreacion;

                    // Ejecuta el procedimiento almacenado.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fechaini = reader["fechaini"].ToString(); // Supongo que tienes la fecha en una variable.
                            DateTime fechaa = DateTime.Parse(fechaini); // Convierte la cadena a un objeto DateTime.
                            string fechainiFormateada = fechaa.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                            string fechafin = reader["fechafin"].ToString(); // Supongo que tienes la fecha en una variable.
                            DateTime fechab = DateTime.Parse(fechafin); // Convierte la cadena a un objeto DateTime.
                            string fechafinFormateada = fechab.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                            string fechapartida = reader["fechapartida"].ToString(); // Supongo que tienes la fecha en una variable.
                            DateTime fechac = DateTime.Parse(fechapartida); // Convierte la cadena a un objeto DateTime.
                            string fechapartidaFormateada = fechac.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.



                            ListViewItem item = new ListViewItem(reader["id"].ToString());
                            item.SubItems.Add(reader["asiento"].ToString());
                            item.SubItems.Add(reader["CuentaPar"].ToString());
                            item.SubItems.Add(fechapartidaFormateada);
                            item.SubItems.Add(reader["cuentacontable"].ToString());
                            item.SubItems.Add(reader["descripcion"].ToString());
                            item.SubItems.Add(reader["debe"].ToString());
                            item.SubItems.Add(reader["haber"].ToString());
                            item.SubItems.Add(reader["Referencia"].ToString());
                            item.SubItems.Add(reader["libro"].ToString());
                            item.SubItems.Add(reader["tippagcueid"].ToString());
                            item.SubItems.Add(fechainiFormateada);
                            item.SubItems.Add(fechafinFormateada);

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





        public MaterialListView Getmovimientoscuentapartida(Partida Modelo)
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                DataTable dataTable = new DataTable();

                using (SqlCommand cmd = new SqlCommand("movimientoscuentapartida", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agrega parámetros si es necesario.
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = Modelo.Id;
                   

                    // Ejecuta el procedimiento almacenado.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fechaini = reader["fechaini"].ToString(); // Supongo que tienes la fecha en una variable.
                            DateTime fechaa = DateTime.Parse(fechaini); // Convierte la cadena a un objeto DateTime.
                            string fechainiFormateada = fechaa.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                            string fechafin = reader["fechafin"].ToString(); // Supongo que tienes la fecha en una variable.
                            DateTime fechab = DateTime.Parse(fechafin); // Convierte la cadena a un objeto DateTime.
                            string fechafinFormateada = fechab.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                            string fechapartida = reader["fechapartida"].ToString(); // Supongo que tienes la fecha en una variable.
                            DateTime fechac = DateTime.Parse(fechapartida); // Convierte la cadena a un objeto DateTime.
                            string fechapartidaFormateada = fechac.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.



                            ListViewItem item = new ListViewItem(reader["id"].ToString());
                            item.SubItems.Add(reader["asiento"].ToString());
                            item.SubItems.Add(reader["CuentaPar"].ToString());
                            item.SubItems.Add(fechapartidaFormateada);
                            item.SubItems.Add(reader["cuentacontable"].ToString());
                            item.SubItems.Add(reader["descripcion"].ToString());
                            item.SubItems.Add(reader["debe"].ToString());
                            item.SubItems.Add(reader["haber"].ToString());
                            item.SubItems.Add(reader["Referencia"].ToString());
                            item.SubItems.Add(reader["libro"].ToString());
                            item.SubItems.Add(reader["tippagcueid"].ToString());
                            item.SubItems.Add(fechainiFormateada);
                            item.SubItems.Add(fechafinFormateada);

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


        public DataTable GetestadoResultadosreportes(DateTime fechaini, DateTime fechafin)
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            DataTable dataTable = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("estadoResultadosreportes", Con))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro
                da.SelectCommand.Parameters.AddWithValue("@fechaini", fechaini);
                da.SelectCommand.Parameters.AddWithValue("@fechafin", fechafin);


                da.Fill(dataTable);
            }

            Con.Close();
            return dataTable;
        }


        public DataTable Getbalancegeneralrpt(DateTime fechaini, DateTime fechafin)
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            DataTable dataTable = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("balancegeneralrpt", Con))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro
                da.SelectCommand.Parameters.AddWithValue("@fechaini", fechaini);
                da.SelectCommand.Parameters.AddWithValue("@fechafin", fechafin);


                da.Fill(dataTable);
            }

            Con.Close();
            return dataTable;
        }




    }
}
