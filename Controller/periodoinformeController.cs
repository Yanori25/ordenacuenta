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
    public  class periodoinformeController
    {
        public periodoinformeController() { }


        public bool Crear(periodoinformeModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute periodosmovimientos " + Modelo.id + " , "
                        + Modelo.idperiodo + " , '"
                        + Modelo.fechainforme + "' , '"
                        + Modelo.usuariocreacion + "' , '"
                        + Modelo.estado + "'  " 
                           ;

                    ;


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    if(Modelo.estado == "Desabilitar")
                    {
                        MaterialMessageBox.Show("Se Desabilito es periodo exitosamente");
                    }
                    else
                    {
                        MaterialMessageBox.Show("Se Habilito para seguir laborando a partir de la fecha interceptada ");
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


        public int periodoinformeestperiodo(periodoinformeModel Modelo)
        {
            int valor;

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDConexion"))
                {
                    Con.Open();

                    string sql = "execute periodoinformeestperiodo '" + Modelo.fechainforme + "'  ";


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
