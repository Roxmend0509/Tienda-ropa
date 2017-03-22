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

namespace Tienda_Ropa.DATOS
{
    class clsDatClientes
    {
        MySqlConnection conexion = new MySqlConnection();
        private MySqlDataAdapter _adaptador = new MySqlDataAdapter();

        private void conectar()
        {
            conexion.ConnectionString = "server=localhost; database=bdRopa;user id =root; password=Miguel2909; pooling=false";
            conexion.Open();
        }

        public DataTable leerDatos()
        {
            DataTable datos = new DataTable();
            conectar();
            MySqlCommand comando = new MySqlCommand("Select * from Clientes", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Clientes");
            datos = ds.Tables["Clientes"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();


            return datos;

        }


        public POJOS.clsNegClientes insertarCl(ref POJOS.clsNegClientes cli)
        {
            try
            {
                _adaptador.InsertCommand = new MySqlCommand("insert into Clientes (IDCLIENTE,NOMBRE,DIRECCION,TELEFONO) values(@IDCLIENTE,@NOMBRE,@DIRECCION,@TELEFONO)");
                _adaptador.InsertCommand.Parameters.Add("@IDCLIENTE", MySqlDbType.Int32).Value = cli.IdCliente;
                _adaptador.InsertCommand.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = cli.Nombre;
                _adaptador.InsertCommand.Parameters.Add("@DIRECCION", MySqlDbType.VarChar).Value = cli.Direccion;
                _adaptador.InsertCommand.Parameters.Add("@TELEFONO", MySqlDbType.VarChar, 10).Value = cli.Telefono;


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
            return cli;
        }


        public POJOS.clsNegClientes buscarCLI(ref POJOS.clsNegClientes clien)
        {
            conectar();
            string sql = "SELECT * FROM Clientes WHERE IDCLIENTE= '" + clien.IdCliente + "'";
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader miDataR = miCom.ExecuteReader();
            miDataR.Read();
            if (miDataR.HasRows)
            {
                clien.IdCliente = Convert.ToInt32(miDataR["IDCLIENTE"]);
                clien.Nombre = miDataR["NOMBRE"].ToString();
                clien.Direccion = miDataR["DIRECCION"].ToString();
                clien.Telefono =  miDataR["TELEFONO"].ToString();


            }
            else
            {
                return null;
            }
            miDataR.Close();
            miCom.Dispose();
            conexion.Close();
            return clien;

        }


        public DataTable leerDatosIDCli(ref POJOS.clsNegClientes objx)
        {
            DataTable datos = new DataTable();
            conectar();
            MySqlCommand comando = new MySqlCommand("Select * from Clientes where IDCLIENTE=" + objx.IdCliente, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Clientes");
            datos = ds.Tables["Clientes"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();
            return datos;

        }

        public POJOS.clsNegClientes buscarCliporIDCli(ref POJOS.clsNegClientes objx)
        {
            conectar();
            string sql = "SELECT * FROM Clientes WHERE IDCLIENTE=" + objx.IdCliente;
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader miDataR = miCom.ExecuteReader();
            miDataR.Read();
            if (miDataR.HasRows)
            {
                objx.IdCliente = Convert.ToInt32(miDataR["IDCLIENTE"]);
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


        public void eliminarCli(ref POJOS.clsNegClientes objP)
        {
            //conectar();
            //string sql = "delete from Clientes where IDCLIENTE=" + objP.IdCliente;
            //MySqlCommand miCom = new MySqlCommand(sql, conexion);
            //miCom.ExecuteNonQuery();
            //miCom.Dispose();
            //conexion.Close();
            try
            {
                _adaptador.DeleteCommand = new MySqlCommand("delete from Clientes where IDCLIENTE=@IDCLIENTE", conexion);
                _adaptador.DeleteCommand.Parameters.Add("@IDCLIENTE", MySqlDbType.Int32).Value = objP.IdCliente;
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

        public POJOS.clsNegClientes modificarCl(ref POJOS.clsNegClientes cli)
        {
            try
            {
                _adaptador.UpdateCommand = new MySqlCommand("update Clientes set NOMBRE=@NOMBRE,DIRECCION=@DIRECCION,TELEFONO=@TELEFONO where IDCLIENTE="+cli.IdCliente,conexion);
                _adaptador.UpdateCommand.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = cli.Nombre;
                _adaptador.UpdateCommand.Parameters.Add("@DIRECCION", MySqlDbType.VarChar).Value = cli.Direccion;
                _adaptador.UpdateCommand.Parameters.Add("@TELEFONO", MySqlDbType.VarChar, 10).Value = cli.Telefono;


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
            return cli;
        }

        public DataTable Cargar()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=bdRopa;user id =root; password=Miguel2909; pooling=false"))
            {
                conn.Open();
                DataTable dt = new DataTable();

                string query = "SELECT * FROM Clientes";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }


        }
    }
}
