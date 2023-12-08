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

namespace OrdenaCuenta.Controller
{
    internal class ProveedoresController
    {
        public ProveedoresController() { }


        public MaterialListView GetProveedor()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("proveedoresshow", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["Id"].ToString());


                    item.SubItems.Add(fila["NombreCia"].ToString());
                    item.SubItems.Add(fila["NombreContacto"].ToString());
                    item.SubItems.Add(fila["email"].ToString());
                    item.SubItems.Add(fila["Telefono"].ToString());
                    item.SubItems.Add(fila["RTN"].ToString());
                    item.SubItems.Add(fila["Deuda"].ToString());
                    item.SubItems.Add(fila["moneda"].ToString());
                    item.SubItems.Add(fila["Direccion"].ToString());
                    item.SubItems.Add(fila["subcue"].ToString());
                    item.SubItems.Add(fila["cuenta"].ToString());



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


        public MaterialListView GetProveedorBuscador()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("proveedoresshow", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["Id"].ToString());


                    item.SubItems.Add(fila["NombreCia"].ToString());
                    item.SubItems.Add(fila["NombreContacto"].ToString());
                    item.SubItems.Add(fila["email"].ToString());
                    item.SubItems.Add(fila["Telefono"].ToString());
                    item.SubItems.Add(fila["RTN"].ToString());
                    item.SubItems.Add(fila["Deuda"].ToString());
                    item.SubItems.Add(fila["moneda"].ToString());
                //    item.SubItems.Add(fila["Direccion"].ToString());
               //     item.SubItems.Add(fila["subcue"].ToString());
              //      item.SubItems.Add(fila["cuenta"].ToString());



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


        public bool eliminar(ProveedoresModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute proveedoresdelete " + Modelo.Id + " , '"
                        + Modelo.usuariocreacion+ "' ";


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



        public bool Crear(ProveedoresModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute proveedoresadd '" + Modelo.NombreCia + "' , '" +
                        Modelo.NombreContacto + "' , '" +
                        Modelo.email + "' , '" +
                        Modelo.Telefono + "' , '" +
                        Modelo.RTN + "' , '" +
                        Modelo.Direccion + "' , " +
                        Modelo.ProIdEmpresa + " , " +
                        Modelo.Deuda + " , " +
                        Modelo.ProtipMon + " , '" +
                        Modelo.usuariocreacion + "' , " +
                        Modelo.subcuentaid + " "

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


        public bool Editar(ProveedoresModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute proveedoresedit " + Modelo.Id + " , '" +
                        Modelo.NombreCia + "' , '"+
                        Modelo.NombreContacto + "' , '" +
                        Modelo.email + "' , '" +
                        Modelo.Telefono + "' , '" +
                        Modelo.RTN + "' , '" +
                        Modelo.Direccion + "' , " +
                        Modelo.ProIdEmpresa + " , " +
                        Modelo.Deuda + " , " +
                        Modelo.ProtipMon + " , '" +
                        Modelo.usuariocreacion + "' , "+
                         Modelo.subcuentaid + " "

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

        public int getproveedorsubcue(int Modelo)
        {

            int valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute proveedoressubcueshow " + Modelo + " ";


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

        public DataTable Getestadocuentaproveedores(int nombreParametro, int proveedor )
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            DataTable dataTable = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("estadocuentaproveedores", Con))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro
                da.SelectCommand.Parameters.AddWithValue("@ind", nombreParametro);
                da.SelectCommand.Parameters.AddWithValue("@idproveedor", proveedor);


                da.Fill(dataTable);
            }

            Con.Close();
            return dataTable;
        }


    




    }
}
