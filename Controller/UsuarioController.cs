using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OrdenaCuenta.Model;
using MaterialSkin.Controls;
using System.Drawing;

namespace OrdenaCuenta.Controller
{
    class UsuarioController
    {

        public UsuarioController() { }


        public bool Editar(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute usuarioactualiza " + Modelo.id + " , '" +
                        Modelo.primernombre + "' , '" +
                        Modelo.segundonombre + "' , '" +
                        Modelo.primerapellido + "' , '" +
                        Modelo.segundoapellido + "' , '" +
                        Modelo.fechaingreso + "' , '" +
                        Modelo.dni + "' , '" +
                        Modelo.preguntaSeguridad + "' , '" +
                        Modelo.telefono + "' , '" +
                        Modelo.sexo + "' , " +
                        Modelo.intentos + "  " 
                  
                        ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MaterialMessageBox.Show("Se modifico exitosamente");

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


        public bool Crear(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute addcliente '" + Modelo.primernombre + "' , '"+
                        Modelo.segundonombre +"' , '"+
                        Modelo.primerapellido + "' , '" +
                        Modelo.segundoapellido + "' , '" +
                        Modelo.dni + "' , '" +
                        Modelo.usuario + "' , '" +
                        Modelo.clave + "' , '" +
                        Modelo.preguntaSeguridad + "' , '" +
                        Modelo.RespuestaSeguridad + "' , '" +
                        Modelo.telefono + "' , '" +
                        Modelo.sexo + "' , '" +
                        Modelo.idrol + "' , "+
                        Modelo.usuidempresa + " "
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

        public MaterialListView GetUsuario()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("showcliente", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["id"].ToString());

                    string fechaConHora = fila["fechaIngreso"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fecha = DateTime.Parse(fechaConHora); // Convierte la cadena a un objeto DateTime.

                    string fechaFormateada = fecha.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.


                    item.SubItems.Add(fila["nombre"].ToString());
                    item.SubItems.Add(fila["dni"].ToString());
                    item.SubItems.Add(fila["usuario"].ToString());
                    item.SubItems.Add(fila["clave"].ToString());
                    item.SubItems.Add(fechaFormateada);
                    item.SubItems.Add(fila["telefono"].ToString());
                    item.SubItems.Add(fila["rol"].ToString());
                    item.SubItems.Add(fila["preguntaSeguridad"].ToString());
                    item.SubItems.Add(fila["sexo"].ToString());




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


        public DataTable getcliente()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showcliente", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;


        }

        public bool eliminar(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute inactivarcliente '" + Modelo.id + "' ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MaterialMessageBox.Show("Se retiro exitosamente");

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

        public bool loguear(UsuarioModel Modelo)
        {
            bool valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute logueo '" + Modelo.usuario + "' , '" + Modelo.clave + "'  ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;        
                        valor = (Boolean)cmd.ExecuteScalar();
                    }


                    Con.Close();
                }

                return valor;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }


        public string claveencriptada(UsuarioModel Modelo)
        {
            string valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute getclaveencriptada '" + Modelo.usuario + "'  " ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        valor = (string)cmd.ExecuteScalar();
                    }


                    Con.Close();
                }

                return valor;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return "";
            }
        }


        public string getrol(UsuarioModel Modelo)
        {
            string valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute getrolusuario '" + Modelo.usuario + "' , '" + Modelo.clave + "'  ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;             
                        valor = (string)cmd.ExecuteScalar();
                    }


                    Con.Close();
                }

                return valor;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return "";
            }
        }


        public string getidcliente(string Modelo)
        {
            string valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute getidcliente '" + Modelo + "' " ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        valor = (string)cmd.ExecuteScalar();
                    }


                    Con.Close();
                }

                return valor;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return "";
            }
        }



        public DataTable getusuariomenu(UsuarioModel Modelo)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter("dbo.MenuPadreShow", Con))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        // Agrega parámetros si es necesario.
                        da.SelectCommand.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar)).Value = Modelo.usuario;
                        da.SelectCommand.Parameters.Add(new SqlParameter("@nivel", SqlDbType.VarChar)).Value = Modelo.dni;

                        // Crea un DataTable para almacenar los resultados.


                        // Llena el DataTable con los resultados del procedimiento almacenado.
                        da.Fill(dataTable);
                    }


                     


                    Con.Close();

              

                 

                }

                return dataTable;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return dataTable;
            }
        }


        public MaterialListView GetbuscadorUsuario()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("showcliente", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["id"].ToString());
                    item.SubItems.Add(fila["usuario"].ToString());
                    item.SubItems.Add(fila["nombre"].ToString());            
                   
                


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



    }
}
