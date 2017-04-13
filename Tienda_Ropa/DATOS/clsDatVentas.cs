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


        public void insertarV(ref POJOS.clsNegVentas venta)
        {
            MySqlCommand cm = null;
            MySqlTransaction tr = null;
            try
            {
                conectar();
                tr = conexion.BeginTransaction();
                cm = new MySqlCommand("insert into ventas values(null, @total, now(), @cliente);", conexion);
                
                cm.Parameters.AddWithValue("total", venta.Total);                
                cm.Parameters.AddWithValue("cliente",venta.IdCliente);
                cm.ExecuteNonQuery();
                tr.Commit();
            }
            catch (Exception ex)
            {
                tr.Rollback();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cm.Dispose();
                conexion.Close();
            }
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

        public void reporte(DataGridView dvgDatos)
        {
            // Se abre la conexion
            conectar();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("select v.idventa as folio, v.fecha, v.total, c.nombre from ventas v natural join clientes c order by v.idventa;", conexion);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            // Se asigna el DataTable como origen de datos del DataGridView
            dvgDatos.DataSource = dtDatos;

            // Se cierra la conexión a la base de datos
            conexion.Close();
            conexion.Dispose();
        }

    }
}
