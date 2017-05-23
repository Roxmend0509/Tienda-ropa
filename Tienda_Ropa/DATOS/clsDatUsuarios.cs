using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Tienda_Ropa.DATOS
{
    /// <summary>
    /// clase usada como interfaz para interactuar con usuarios de la base de datos
    /// </summary>
    class clsDatUsuarios
    {
        /// <summary>
        /// metodo usado para verificar el acceso a sesión
        /// </summary>
        /// <param name="user">nombre de usuario</param>
        /// <param name="pas">contraseña</param>
        /// <returns>true si accede falso si no</returns>
        public bool Login(String user, String pas)
        {
            MySqlConnection cn = new MySqlConnection("server=localhost; database=bdRopa; user=root; pwd=Miguel2909"); //objeto de tipo conexion
            MySqlDataReader rd = null; //objeto data reader

            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select LOGIN,PASSWORD from USUARIOS where LOGIN  = '" + user  + "' and PASSWORD = sha1 ('" + pas + "')", cn);
                rd = cmd.ExecuteReader();
            

                if (rd.Read()) 
                {                   
                   
                    return true;
                   
                }else
                {
                    MessageBox.Show("Contraseña o Usuario no Validos", "ERROR");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contraseña o Usuario no Validos", "ERROR");
                return false;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
                rd.Close();
                rd.Dispose();
            }



        }
    }
}
