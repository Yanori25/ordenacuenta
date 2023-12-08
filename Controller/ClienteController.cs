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
    internal class ClienteController
    {
        public ClienteController() { }

        public bool Crear(ClienteModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute ClienteAdd '" + Modelo.Nombre + "' , '"
                        + Modelo.Apellido + "' , '"
                        + Modelo.Direccion + "' , '"
                        + Modelo.email + "' , '"
                        + Modelo.FechaIngreso + "' , '" +
                        Modelo.Telefono + "' , "
                         + Modelo.CliIdEmpresa + " , " +
                          +Modelo.Abono + " , '"
                           + Modelo.segundoNombre + "' , '"
                           + Modelo.segundoApellido + "' , " +
                           Modelo.CliTipMonid + " , " +
                           Modelo.subcueidcli + " , '"+
                           Modelo.NombreCia + "' , '" +
                        Modelo.RTN + "' , '" +
                        Modelo.usuariocreacion + "'  " 
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


        public MaterialListView GetCliente()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("clienteSho", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["Id"].ToString());

                    string fechaConHora = fila["FechaIngreso"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fecha = DateTime.Parse(fechaConHora); // Convierte la cadena a un objeto DateTime.

                    string fechaFormateada = fecha.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.


                    item.SubItems.Add(fila["Nombre"].ToString());
                    item.SubItems.Add(fila["segundoNombre"].ToString());
                    item.SubItems.Add(fila["Apellido"].ToString());
                    item.SubItems.Add(fila["segundoApellido"].ToString());
                    item.SubItems.Add(fila["email"].ToString());
                    item.SubItems.Add(fechaFormateada);
                    item.SubItems.Add(fila["Telefono"].ToString());
                    item.SubItems.Add(fila["Abono"].ToString());
                    item.SubItems.Add(fila["moneda"].ToString());
                    item.SubItems.Add(fila["monid"].ToString());
                    item.SubItems.Add(fila["Direccion"].ToString());
                    item.SubItems.Add(fila["subcuentanum"].ToString());
                    item.SubItems.Add(fila["subcuenta"].ToString());
                    item.SubItems.Add(fila["rtn"].ToString());
                    item.SubItems.Add(fila["NombreCia"].ToString());




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




        public bool eliminar(ClienteModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute ClienteDelete " + Modelo.Id + " ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MaterialMessageBox.Show("Se borro el registro exitosamente");
                    //   MessageBox.Show("Se elimino exitosamente");

                    Con.Close();
                }

                return true;
            }
            catch (Exception errores)
            {
                MaterialMessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //   MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public bool Editar(ClienteModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute clienteedit " + Modelo.Id + " , '"
                        + Modelo.Nombre + "' , '"
                        + Modelo.Apellido + "' , '"
                        + Modelo.Direccion + "' , '"
                        + Modelo.email + "' , '" +
                        Modelo.FechaIngreso + "' , ' "
                        + Modelo.Telefono + "' , " +
                        +Modelo.CliIdEmpresa + " , " +
                        +Modelo.Abono + " , '" 
                        +Modelo.segundoNombre + "' , '" 
                        +Modelo.segundoApellido + "' , " 
                        +Modelo.CliTipMonid + " , "
                        + Modelo.subcueidcli + " , '"
                        + Modelo.NombreCia + "' , '"
                        + Modelo.RTN + "' , '"
                        + Modelo.usuariocreacion + "'  "
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


        public MaterialListView GetClienteBuscador()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("clienteSho", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["Id"].ToString());

                    string fechaConHora = fila["FechaIngreso"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fecha = DateTime.Parse(fechaConHora); // Convierte la cadena a un objeto DateTime.

                    string fechaFormateada = fecha.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.


                    item.SubItems.Add(fila["Nombre"].ToString());
                    item.SubItems.Add(fila["segundoNombre"].ToString());
                    item.SubItems.Add(fila["Apellido"].ToString());
                    item.SubItems.Add(fila["segundoApellido"].ToString());
                  //  item.SubItems.Add(fila["email"].ToString());
                  //  item.SubItems.Add(fechaFormateada);
                  //  item.SubItems.Add(fila["Telefono"].ToString());
                    item.SubItems.Add(fila["Abono"].ToString());
                    item.SubItems.Add(fila["moneda"].ToString());
                 //   item.SubItems.Add(fila["monid"].ToString());
                //    item.SubItems.Add(fila["Direccion"].ToString());
                  //  item.SubItems.Add(fila["subcuentanum"].ToString());
                 //   item.SubItems.Add(fila["subcuenta"].ToString());
                    item.SubItems.Add(fila["rtn"].ToString());
                    item.SubItems.Add(fila["NombreCia"].ToString());




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

        public int getclientesubcue(int Modelo)
        {
            int valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute clientesubcueshow " + Modelo + " ";


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
