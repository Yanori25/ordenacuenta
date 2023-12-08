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
    internal class CuentaController
    {
        public CuentaController() { }


        public DataTable Getcuentadt()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showCCuenta", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;


        }

        public MaterialListView GetCuenta()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("showCCuenta", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);

              
                foreach (DataRow fila in dataTable.Rows)
                {

                 
                    ListViewItem item = new ListViewItem(fila["Id"].ToString());

                    item.SubItems.Add(fila["CuentaContable"].ToString());
                    item.SubItems.Add(fila["Descripcion"].ToString());
                    item.SubItems.Add(fila["TipoCuenta"].ToString());
                    item.SubItems.Add(fila["CuentaTipo"].ToString());
                    item.SubItems.Add(fila["Moneda"].ToString());
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

        public bool Crear(Cuenta Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute cuentaAdd '" + Modelo.CuentaContable + "' , '"
                        + Modelo.Descripcion + "' , "
                        + Modelo.ClaseCuentaId + " , '"
                        + Modelo.CuentaTipo + "' , "
                        + Modelo.MonedaId + " , " +
                        Modelo.CueIdEmpresa + " ";
                        
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



        public bool eliminar(Cuenta Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute delcuenta " + Modelo.id + " ";


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
                MaterialMessageBox.Show( errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
             //   MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }


        public string GetcuentaClasificacion( int idcuenta )
        {

            string correlativo = null;

            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("cuentaClasificacion", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // Agregar el parámetro al comando
            da.SelectCommand.Parameters.Add(new SqlParameter("@cuentaid", SqlDbType.Int));
            da.SelectCommand.Parameters["@cuentaid"].Value = idcuenta;
            da.Fill(dataTable);
            correlativo = dataTable.Rows[0][0].ToString();



            Con.Close();
            return correlativo;


        }


        public MaterialListView GetCuentaBuscador()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("showCCuenta", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["Id"].ToString());

                    item.SubItems.Add(fila["CuentaContable"].ToString());
                    item.SubItems.Add(fila["Descripcion"].ToString());
                    //item.SubItems.Add(fila["TipoCuenta"].ToString());
                    //item.SubItems.Add(fila["CuentaTipo"].ToString());
                    //item.SubItems.Add(fila["Moneda"].ToString());
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
