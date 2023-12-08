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
    internal class HistoricoMonedaController
    {
        public HistoricoMonedaController() { }


        public MaterialListView GetHistMoneda()
        {
            SqlConnection Con = new Conexion().GetConexion("BDConexion");
            Con.Open();

            MaterialListView lista = new MaterialListView();

            try
            {
                // Tu código aquí

                DataTable dataTable = new DataTable();

                SqlCommand cmd = new SqlCommand("HistoricoMonedashow", Con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("showClasificacionCuenta", Con);
                // da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dataTable);


                foreach (DataRow fila in dataTable.Rows)
                {


                    ListViewItem item = new ListViewItem(fila["Id"].ToString());
                    string fechaConHora = fila["Fecha"].ToString(); // Supongo que tienes la fecha en una variable.
                    DateTime fecha = DateTime.Parse(fechaConHora); // Convierte la cadena a un objeto DateTime.
                    string fechaFormateada = fecha.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.
                  //  item.SubItems.Add(fechaFormateada);
                    item.SubItems.Add(fila["moneda"].ToString());
                    item.SubItems.Add(fechaFormateada);
                 //   item.SubItems.Add(fila["Fecha"].ToString());
                    item.SubItems.Add(fila["Valor"].ToString());
                  

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

        public bool eliminar(HistoricoMonedaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute HistoricoMonedadel " + Modelo.Id + " , '"
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


        public bool Crear(HistoricoMonedaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute HistoricoMonedaadd " + Modelo.HistMon + " , '" +
                        Modelo.Fecha + "' , " +
                        Modelo.Valor + " , " +
                        Modelo.HistMonEmpresa + " , '" +
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


        public Decimal HistoricoMonedaconversion(HistoricoMonedaModel Modelo)
        {
            Decimal valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute HistoricoMonedaconversion " + Modelo.Id + " , '"+
                        Modelo.Fecha + "' , '"+
                        Modelo.estado + "' "
                        ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        valor = (Decimal)cmd.ExecuteScalar();
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
