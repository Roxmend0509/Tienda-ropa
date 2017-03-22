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
    class clsDatUsuarios
    {

        public bool Login(String user, String pas)
        {
            MySqlConnection cn = new MySqlConnection("server=localhost; database=bdRopa; user=root; pwd=Miguel2909");
            MySqlDataReader rd = null;

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
