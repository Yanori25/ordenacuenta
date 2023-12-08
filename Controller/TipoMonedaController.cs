using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace OrdenaCuenta.Controller
{
    internal class TipoMonedaController
    {
        public TipoMonedaController() { }



        public DataTable GetipoMoneda()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();




            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("showTipoMoneda", Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dataTable);


            Con.Close();
            return dataTable;


        }




        public MaterialListView ShowTipoMoneda()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("showTipoMoneda", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["Id"].ToString());
                    item.SubItems.Add(fila["Descripcion"].ToString());
                    item.SubItems.Add(fila["Simbolo"].ToString());
                    item.SubItems.Add(fila["PaisIsob"].ToString());
                    item.SubItems.Add(fila["PaisIsoc"].ToString());
                    item.SubItems.Add(fila["Moneda"].ToString());

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



        public bool eliminar(TipoMonedaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute TipoMonedadel " + Modelo.Id + " , '"
                        + Modelo.usuariocreacion + "' " ;


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


        public bool Crear(TipoMonedaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute TipoMonedaadd '" + Modelo.Descripcion + "' , '" +
                        Modelo.Simbolo + "' , '" +
                        Modelo.PaisIsob + "' , '" +
                        Modelo.PaisIsoc + "' , '" +
                        Modelo.Moneda + "' , " +
                        Modelo.MonIdEmpresa + " , '" +
                        Modelo.usuariocreacion + "'  " 
                    

                        ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MaterialMessageBox.Show("Se Agrego exitosamente");

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

        public string TipoMonedalocal(TipoMonedaModel Modelo)
        {
            string valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute TipoMonedalocal " + Modelo.Id + "  ";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        valor = (string)cmd.ExecuteScalar();
                    }


                    Con.Close();
                }

                return valor ;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return "";
            }
        }


    }
}
