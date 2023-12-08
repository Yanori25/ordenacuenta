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
    internal class opcionesController
    {
        public opcionesController() { }

        public MaterialListView Gettransacciones()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("opcionesshow", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {

                    ListViewItem item = new ListViewItem(fila["Id"].ToString());

                    item.SubItems.Add(fila["Nombre"].ToString());
                    item.SubItems.Add(fila["Nivel"].ToString());
                    item.SubItems.Add(fila["icono"].ToString());
                    item.SubItems.Add(fila["rutafrm"].ToString());

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



        public MaterialListView Getopcbuscador()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("opcionesshow", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {

                    ListViewItem item = new ListViewItem(fila["Id"].ToString());

                    item.SubItems.Add(fila["Nombre"].ToString());
                    item.SubItems.Add(fila["Nivel"].ToString());
                
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


        public bool Crear(opcionesmodel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute opcionesevento " + Modelo.ind + " , "
                        + Modelo.id + " , '"
                        + Modelo.Nombre + "' , '"
                        + Modelo.Nivel + "' , '"
                        + Modelo.icono + "' , '"
                        + Modelo.rutafrm + "' , "
                         + Modelo.OpcionPadre + "  "

                           ;

                    ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    if(Modelo.ind == 1)
                    {
                        MaterialMessageBox.Show("Se agrego exitosamente");
                    }
                    else
                    {
                        MaterialMessageBox.Show("Se borro exitosamente");
                    }
                    

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
