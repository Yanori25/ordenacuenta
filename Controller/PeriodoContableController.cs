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
using System.Net.NetworkInformation;

namespace OrdenaCuenta.Controller
{
    internal class PeriodoContableController
    {
        public PeriodoContableController() { }

        public MaterialListView GetPeriodoContabletodos()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("PeriodoContableshowtodos", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["id"].ToString());

                    string fechaini = fila["fechaini"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fecha = DateTime.Parse(fechaini); // Convierte la cadena a un objeto DateTime.
                    string fechainiFormateada = fecha.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                    string fechafin = fila["fechafin"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fechafind = DateTime.Parse(fechafin); // Convierte la cadena a un objeto DateTime.
                    string fechafindFormateada = fechafind.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                    string fechapago = fila["fechapago"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fechapagod = DateTime.Parse(fechapago); // Convierte la cadena a un objeto DateTime.
                    string fechapagodFormateada = fechapagod.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                    string fechacorte = fila["fechacorte"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fechacorted = DateTime.Parse(fechacorte); // Convierte la cadena a un objeto DateTime.
                    string fechacortedFormateada = fechacorted.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.


                    item.SubItems.Add(fila["tippagcueid"].ToString());
                    item.SubItems.Add(fechainiFormateada);
                    item.SubItems.Add(fechafindFormateada);
                    item.SubItems.Add(fechapagodFormateada);
                    item.SubItems.Add(fechacortedFormateada);
                    item.SubItems.Add(fila["frecuencia"].ToString());
                    item.SubItems.Add(fila["mes"].ToString());
                    item.SubItems.Add(fila["Aniocontable"].ToString());
                    item.SubItems.Add(fila["estado"].ToString());





                    // item.SubItems.Add(fila["Activo"].ToString());

                    lista.Items.Add(item);


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            Con.Close();
            return lista;


        }

        public MaterialListView GetPeriodoContable()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("PeriodoContableshow", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["id"].ToString());

                    string fechaini = fila["fechaini"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fecha = DateTime.Parse(fechaini); // Convierte la cadena a un objeto DateTime.
                    string fechainiFormateada = fecha.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                    string fechafin = fila["fechafin"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fechafind = DateTime.Parse(fechafin); // Convierte la cadena a un objeto DateTime.
                    string fechafindFormateada = fechafind.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                    string fechapago = fila["fechapago"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fechapagod = DateTime.Parse(fechapago); // Convierte la cadena a un objeto DateTime.
                    string fechapagodFormateada = fechapagod.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                    string fechacorte = fila["fechacorte"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fechacorted = DateTime.Parse(fechacorte); // Convierte la cadena a un objeto DateTime.
                    string fechacortedFormateada = fechacorted.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                    string fisini = fila["fisini"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fisinid = DateTime.Parse(fisini); // Convierte la cadena a un objeto DateTime.
                    string fisiniFormateada = fisinid.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.

                    string fisfin = fila["fisfin"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fisfind = DateTime.Parse(fisfin); // Convierte la cadena a un objeto DateTime.
                    string fisfinFormateada = fisfind.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.



                    item.SubItems.Add(fila["tippagcueid"].ToString());
                    item.SubItems.Add(fechainiFormateada);
                    item.SubItems.Add(fechafindFormateada);
                    item.SubItems.Add(fechapagodFormateada);
                    item.SubItems.Add(fechacortedFormateada);
                    item.SubItems.Add(fila["frecuencia"].ToString());
                    item.SubItems.Add(fila["mes"].ToString());
                    item.SubItems.Add(fila["Aniocontable"].ToString());
                    item.SubItems.Add(fila["estado"].ToString());
                    item.SubItems.Add(fisiniFormateada);
                    item.SubItems.Add(fisfinFormateada);





                    // item.SubItems.Add(fila["Activo"].ToString());

                    lista.Items.Add(item);


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            Con.Close();
            return lista;


        }




        public bool eliminar(PeriodoContableModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute PeriodoContabledel " + Modelo.Id + " , '"
                        + Modelo.UsuarioCreacion + "' ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MaterialMessageBox.Show("Se elimino exitosamente");

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



        public bool Crear(PeriodoContableModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute PeriodoContableadd '" + Modelo.FechaIni + "' , '"
                        + Modelo.FechaFin + "' , '"
                        + Modelo.FechaPago + "' , '"
                        + Modelo.FechaCorte + "' , '"
                        + Modelo.Frecuencia + "' , '" +
                        Modelo.Estado + "' , "
                         + Modelo.IdPerEmpresa + "  ,  '" +
                          Modelo.UsuarioCreacion + "'  "
                         
                           ;

                    ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MaterialMessageBox.Show("Se agrego exitosamente");

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


        public bool editar(PeriodoContableModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute PeriodoContableedit " + Modelo.Id + " , '"
                        + Modelo.FechaIni + "' , '"
                        + Modelo.FechaFin + "' , '"
                        + Modelo.FechaPago + "' , '"
                        + Modelo.FechaCorte + "' , '"
                        + Modelo.Frecuencia + "' , '" +
                        Modelo.Estado + "' , "
                         + Modelo.IdPerEmpresa + "  ,  '" +
                          Modelo.UsuarioCreacion + "'  "

                           ;

                    ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MaterialMessageBox.Show("Se edito exitosamente");

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


        public bool cerrarperiodo(PeriodoContableModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute periodocierre " + Modelo.Id + " , '"
                        + Modelo.UsuarioCreacion + "' ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MaterialMessageBox.Show("Se cerro exitosamente");

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

        public int periodonogenerado(PeriodoContableModel Modelo)
        {
            int valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute periodonogenerado '" + Modelo.FechaIni + "'  ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        valor = (int)cmd.ExecuteScalar();
                    }


                    Con.Close();
                }

                return valor;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return 0;
            }
        }




    }
}
