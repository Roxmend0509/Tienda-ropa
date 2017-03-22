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
    class clsDatVentas
    {
        MySqlConnection conexion = new MySqlConnection();
        private MySqlDataAdapter _adaptador = new MySqlDataAdapter();
        string vd;

        private void conectar()
        {
            conexion.ConnectionString = "server=localhost; database=bdRopa;user id =root; password=Miguel2909; pooling=false";
            conexion.Open();
        }

        public DataTable leerDatos()
        {
            DataTable datos = new DataTable();
            conectar();
            MySqlCommand comando = new MySqlCommand("Select * from Ventas", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Ventas");
            datos = ds.Tables["Ventas"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();


            return datos;

        }


        public POJOS.clsNegVentas insertarV(ref POJOS.clsNegVentas venta)
        {
            try
            {
                _adaptador.InsertCommand = new MySqlCommand("insert into Ventas (TOTAL,IVA,SUB_TOTAL,FECHA,IDCLIENTE) values(@TOTAL,@IVA,@SUB_TOTAL,@FECHA,@IDCLIENTE)");
                _adaptador.InsertCommand.Parameters.AddWithValue("@TOTAL", venta.Total);
                _adaptador.InsertCommand.Parameters.AddWithValue("@IVA", venta.IVA);
                _adaptador.InsertCommand.Parameters.AddWithValue("@SUB_TOTAL", venta.SubTotal);
                _adaptador.InsertCommand.Parameters.AddWithValue("@FECHA", venta.Fecha);
                _adaptador.InsertCommand.Parameters.AddWithValue("@IDCLIENTE", venta.IdCliente);

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
            return venta;
        }

        public string NVenta()
        {
            conectar();
            string nv;
            string sql = "select max(IDVENTA) as idVenta from Ventas";
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader myreader = miCom.ExecuteReader();
            myreader.Read();
            nv = myreader["IDVENTA"].ToString();
            conexion.Close();
            return nv;
        }

        public string NDVenta()
        {
            conectar();
            string sql = "select (max(IDDETALLEVENTA)+1) as idDVenta from DETALLESVENTA";
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader myreader = miCom.ExecuteReader();
            myreader.Read();
            vd = myreader["idDVenta"].ToString();
            conexion.Close();
            return vd;
        }

        public POJOS.clsNegVentas insertarVD(ref POJOS.clsNegVentas objPr)
        {
            try {
                conectar();
                string sql = "INSERT INTO DETALLESVENTA (IDDETALLEVENTA,IDVENTA,IDPRODUCTO) VALUES(null, " + objPr.IdVenta + "," + objPr.IdProducto + ")";

                MySqlCommand miCom = new MySqlCommand(sql, conexion);
                miCom.ExecuteNonQuery();
                miCom.Dispose();
                
                //return objPr;
            }catch(Exception r)
            {
                MessageBox.Show(r.Message+"hola");
            }
            finally
            {
                conexion.Close();
            }

            return objPr;
        }


        public POJOS.clsNegProductos modificarV(ref POJOS.clsNegProductos venta)
        {
            conectar();
            MySqlTransaction trans = conexion.BeginTransaction();

            try
            {
                _adaptador.UpdateCommand = new MySqlCommand("update PRODUCTOS set EXISTENCIA=@EXISTENCIA where IDPRODUCTO=" + venta.IdProducto, conexion);
                _adaptador.UpdateCommand.Parameters.Add("@EXISTENCIA", MySqlDbType.Int32, 6).Value =(venta.Existencia-1);
 

 
                _adaptador.UpdateCommand.Connection = conexion;
                _adaptador.UpdateCommand.ExecuteNonQuery();

                trans.Commit();

            }

            
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                trans.Rollback();
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
            return venta;
        }

        public List<POJOS.clsNegVentas> ObtenerDetallesV(int idventa)
        {
            conectar();
            List<POJOS.clsNegVentas> detalles = new List<POJOS.clsNegVentas>();
            string strSQL = "select * from DETALLESVENTA where IDVENTA=@IDVENTA";
            MySqlCommand comando = new MySqlCommand(strSQL, conexion);
            comando.Parameters.AddWithValue("@IDVENTA", idventa);
            MySqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                POJOS.clsNegVentas negv = new POJOS.clsNegVentas();
                negv.IdVenta = dr.GetInt32(0);
                negv.IdProducto = dr.GetInt32(1);
                negv.Total = dr.GetDouble(2);
                detalles.Add(negv);
            }
            comando.Dispose();

            /// FINALIZAMOS LA CONEXION CERRAMOS TODO
            conexion.Close();
            conexion.Dispose();
            return detalles;
        }

    }
}
