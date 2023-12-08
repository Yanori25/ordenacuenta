using MaterialSkin.Controls;
using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.Controller
{
    internal class subcuentaController
    {
        public subcuentaController() { }

        public bool Crear(subcuentaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute subcuentaadd '" + Modelo.Cuentacontablesub + "' , '" +
                        Modelo.Descripcion + "' , " +
                        Modelo.CuentaId + " , " +
                        Modelo.SubCueIdEmpresa + " , '"+
                        Modelo.usuariocreacion+ "' "
                        

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


        public int getsubcuentashowid(subcuentaModel Modelo)
        {
            int valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute subcuentashowid '" + Modelo.Cuentacontablesub + "' , " + Modelo.CuentaId + " , '"
                        + Modelo.usuariocreacion + "'  "
                        ;


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

        public int getsubcuentaid(subcuentaModel Modelo)
        {
            int valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute subcuentaid '" + Modelo.Cuentacontablesub + "' , " + Modelo.CuentaId + " , '"
                        + Modelo.usuariocreacion + "'  "
                        ;


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


        public int getsubcuentaidcuenta(int Modelo)
        {
            int valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute subcuentaidcuenta " + Modelo + " " 
                        
                        ;


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
