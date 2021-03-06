﻿using System;
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
    /// <summary>
    /// clase usada como interfaz para interactuar con las ventas de la base de datos
    /// </summary>
    class clsDatVentas
    {
        MySqlConnection conexion = new MySqlConnection(); //objeto de conexion
        private MySqlDataAdapter _adaptador = new MySqlDataAdapter(); //objeto adaptador
        string vd;

        /// <summary>
        /// metodo usado para realizar la conexion
        /// </summary>
        private void conectar()
        {
            conexion.ConnectionString = "server=localhost; database=bdRopa;user id =root; password=Miguel2909; pooling=false";
            conexion.Open();
        }

        /// <summary>
        /// metodo usado para leer todos los datos de la base de datos
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// metodo usado para insertar una nueva venta en la base de datos
        /// </summary>
        /// <param name="venta">objeto de venta a ser insertado</param>
        /// <param name="ids">arreglo de ids los cuales estan involucrados en la venta</param>
        public void insertarV(ref POJOS.clsNegVentas venta, int[] ids)
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
                cm = new MySqlCommand("insert into detallesventa values(null, @idproducto, (select max(idventa) from ventas), (select precioventa from productos where idproducto = @idproducto));", conexion);
                for (int i = 0; i < ids.Length; i++)
                {
                    cm.Parameters.AddWithValue("idproducto", ids[i]);
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                }

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

        /// <summary>
        /// metodo usado para conocer la ultima venta realizada
        /// </summary>
        /// <returns>ultima fecha realizada</returns>
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

        /// <summary>
        /// metodo usado para obtener el maximo detalle de venta
        /// </summary>
        /// <returns>obtiene el maximo detalle de venta</returns>
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

        /// <summary>
        /// metodo usado para modificar una venta
        /// </summary>
        /// <param name="venta">objeto de venta con los nuevos valores</param>
        /// <returns>venta actualizada con sus nuevos valores</returns>
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

        /// <summary>
        /// metodo usado para obtener los detalles de todas las ventas filtrado por id de venta
        /// </summary>
        /// <param name="idventa">id de la venta que se desea filtrar</param>
        /// <returns>arreglo de ventas obtenidos con el filtrado</returns>
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

        /// <summary>
        /// metodo usado para mostrar la informacion de la venta
        /// </summary>
        /// <param name="dvgDatos">tabla donde se mostraran los datos</param>
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
