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
    internal class periodofiscalController
    {
        public periodofiscalController() { }

        public MaterialListView GetPeriodoContable()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("periodofiscalshow", Con);
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
     

                    item.SubItems.Add(fechainiFormateada);
                    item.SubItems.Add(fechafindFormateada);
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




        public bool eliminar(periodofiscalModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute periodofiscaldel " + Modelo.id + " , '"
                        + Modelo.usuariocreacion + "' ";


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



        public bool Crear(periodofiscalModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute periodofiscaladd '" + Modelo.fechaini + "' , '"
                        + Modelo.fechafin + "' , "                
                         + Modelo.idempresa + "  ,  '" +
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

        public bool cerrarperiodo(periodofiscalModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute periodofiscalcierre " + Modelo.id + " , '"
                        + Modelo.usuariocreacion + "' ";


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



    }
}
