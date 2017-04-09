using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Data;
using MySql.Data;

namespace Tienda_Ropa.DATOS
{
    class clsDatProveedores
    {
        MySqlConnection conexion = new MySqlConnection();
        private MySqlDataAdapter _adaptador = new MySqlDataAdapter();

        private void conectar()
        {
            conexion.ConnectionString = "server=localhost; database=bdRopa;user id =root; password=Miguel2909; pooling=false";
            conexion.Open();
        }

        public DataTable leerDatos(string filtro)
        {
            DataTable datos = new DataTable();
            conectar();
            MySqlCommand comando = new MySqlCommand("Select * from Proveedores where IDPROVEEDOR like '%"+filtro+ "%' or nombre like '%" + filtro + "%' or direccion like '%" + filtro + "%' or telefono like '%" + filtro + "%'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Proveedores");
            datos = ds.Tables["Proveedores"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();


            return datos;

        }


        public POJOS.clsNegProveedores insertarPro(ref POJOS.clsNegProveedores proved)
        {
            try
            {
                _adaptador.InsertCommand = new MySqlCommand("insert into Proveedores (IDPROVEEDOR,NOMBRE,DIRECCION,TELEFONO) values(@IDPROVEEDOR,@NOMBRE,@DIRECCION,@TELEFONO)");
                _adaptador.InsertCommand.Parameters.AddWithValue("@IDPROVEEDOR",proved.IdProveedor);
                _adaptador.InsertCommand.Parameters.AddWithValue("@NOMBRE", proved.Nombre);
                _adaptador.InsertCommand.Parameters.AddWithValue("@DIRECCION", proved.Direccion);
                _adaptador.InsertCommand.Parameters.AddWithValue("@TELEFONO", proved.Telefono);


                conectar();
                _adaptador.InsertCommand.Connection = conexion;
                _adaptador.InsertCommand.ExecuteNonQuery();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
            return proved;
        }


        public POJOS.clsNegProveedores buscarPRO(ref POJOS.clsNegProveedores prove)
        {
            conectar();
            string sql = "SELECT * FROM Proveedores WHERE IDPROVEEDOR= '" + prove.IdProveedor + "'";
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader miDataR = miCom.ExecuteReader();
            miDataR.Read();
            if (miDataR.HasRows)
            {
                prove.IdProveedor = Convert.ToInt32(miDataR["IDPROVEEDOR"]);
                prove.Nombre = miDataR["NOMBRE"].ToString();
                prove.Direccion = miDataR["DIRECCION"].ToString();
                prove.Telefono = miDataR["TELEFONO"].ToString();


            }
            else
            {
                return null;
            }
            miDataR.Close();
            miCom.Dispose();
            conexion.Close();
            return prove;

        }


        public DataTable leerDatosIDP(ref POJOS.clsNegProveedores objx)
        {
            DataTable datos = new DataTable();
            conectar();
            MySqlCommand comando = new MySqlCommand("Select * from Proveedores where IDPROVEEDOR=" + objx.IdProveedor, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Proveedores");
            datos = ds.Tables["Proveedores"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();
            return datos;

        }

        public POJOS.clsNegProveedores buscarPporIDP(ref POJOS.clsNegProveedores objx)
        {
            conectar();
            string sql = "SELECT * FROM Proveedores WHERE IDPROVEEDOR=" + objx.IdProveedor;
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader miDataR = miCom.ExecuteReader();
            miDataR.Read();
            if (miDataR.HasRows)
            {
                objx.IdProveedor = Convert.ToInt32(miDataR["IDPROVEEDOR"]);
                objx.Nombre = miDataR["NOMBRE"].ToString();
                objx.Direccion = miDataR["DIRECCION"].ToString();
                objx.Telefono = miDataR["TELEFONO"].ToString();
            }
            else
            {
                return null;
            }
            miDataR.Close();
            miCom.Dispose();
            conexion.Close();
            return objx;

        }

        

        public DataTable Cargar()
{
        using (MySqlConnection conn = new MySqlConnection("server=localhost; database=bdRopa;user id =root; password=Miguel2909; pooling=false"))
        {
                conn.Open();
                DataTable dt = new DataTable();
                
                string query = "SELECT * FROM proveedores";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
        }


}

        public void eliminarPRO(ref POJOS.clsNegProveedores objP)
        {
            //conectar();
            //string sql = "delete from Proveedores where IDPROVEEDOR=" + objP.IdProveedor;
            //MySqlCommand miCom = new MySqlCommand(sql, conexion);
            //miCom.ExecuteNonQuery();
            //miCom.Dispose();
            //conexion.Close();
            try
            {
                _adaptador.DeleteCommand = new MySqlCommand("delete from Proveedores where IDPROVEEDOR=@IDPROVEEDOR", conexion);
                _adaptador.DeleteCommand.Parameters.Add("@IDPROVEEDOR", MySqlDbType.Int32).Value = objP.IdProveedor;
                conectar();
                _adaptador.DeleteCommand.ExecuteNonQuery();                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public POJOS.clsNegProveedores modificarPro(ref POJOS.clsNegProveedores proved)
        {
            try
            {
                _adaptador.UpdateCommand = new MySqlCommand("update Proveedores set NOMBRE=@NOMBRE,DIRECCION=@DIRECCION,TELEFONO=@TELEFONO where IDPROVEEDOR=" + proved.IdProveedor, conexion);
                _adaptador.UpdateCommand.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = proved.Nombre;
                _adaptador.UpdateCommand.Parameters.Add("@DIRECCION", MySqlDbType.VarChar).Value = proved.Direccion;
                _adaptador.UpdateCommand.Parameters.Add("@TELEFONO", MySqlDbType.VarChar, 10).Value = proved.Telefono;


                conectar();
                _adaptador.UpdateCommand.Connection = conexion;
                _adaptador.UpdateCommand.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
            return proved;
        }

    }
}
