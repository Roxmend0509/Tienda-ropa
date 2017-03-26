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
using Tienda_Ropa.POJOS;

namespace Tienda_Ropa.DATOS
{
    class clsDatProductos
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
            MySqlCommand comando = new MySqlCommand("Select * from Inventario where idproducto like '%"+filtro+ "%' or nombre like '%" + filtro + "%' or talla like '%" + filtro + "%' or existencia like '%" + filtro + "%' or preciocompra like '%" + filtro + "%' or precioventa like '%" + filtro + "%' or descripcion like '%" + filtro + "%' or IDPROVEEDOR like '%" + filtro + "%' or idcategoria like '%" + filtro + "%';", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "PRODUCTOS");
            datos = ds.Tables["PRODUCTOS"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();
            

            return datos;

        }

       
        public POJOS.clsNegProductos insertarP(ref POJOS.clsNegProductos produc, PictureBox pic)
        {
            try
            {
                _adaptador.InsertCommand = new MySqlCommand("insert into PRODUCTOS (IDPRODUCTO,NOMBRE,TALLA,EXISTENCIA,PRECIOCOMPRA,PRECIOVENTA,IMAGEN,DESCRIPCION,IDPROVEEDOR,IDCATEGORIA) values(@IDPRODUCTO,@NOMBRE,@TALLA,@EXISTENCIA,@PRECIOCOMPRA,@PRECIOVENTA,@IMAGEN,@DESCRIPCION,@IDPROVEEDOR,@IDCATEGORIA)");
                _adaptador.InsertCommand.Parameters.Add("@IDPRODUCTO", MySqlDbType.Int32, 9).Value = produc.IdProducto;
                _adaptador.InsertCommand.Parameters.Add("@NOMBRE", MySqlDbType.VarChar, 70).Value = produc.Nombre;
                _adaptador.InsertCommand.Parameters.Add("@TALLA", MySqlDbType.VarChar, 70).Value = produc.Talla;
                _adaptador.InsertCommand.Parameters.Add("@EXISTENCIA", MySqlDbType.Int32, 6).Value = produc.Existencia;
                _adaptador.InsertCommand.Parameters.Add("@PRECIOCOMPRA", MySqlDbType.Double).Value = produc.PrecioCompra;
                _adaptador.InsertCommand.Parameters.Add("@PRECIOVENTA", MySqlDbType.Double).Value = produc.PrecioVenta;
                _adaptador.InsertCommand.Parameters.Add("@DESCRIPCION", MySqlDbType.Text).Value = produc.descrip;
                _adaptador.InsertCommand.Parameters.Add("@IDPROVEEDOR", MySqlDbType.Int32, 6).Value = produc.IdProveedor;
                _adaptador.InsertCommand.Parameters.Add("@IDCATEGORIA", MySqlDbType.Int32, 6).Value = produc.IdCategoria;

                MemoryStream ms = new MemoryStream();
                pic.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                _adaptador.InsertCommand.Parameters.AddWithValue("@IMAGEN", aByte);

                conectar();
                _adaptador.InsertCommand.Connection = conexion;
                _adaptador.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Producto Registrado");
              
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        return produc;
        }

       
        


        public POJOS.clsNegProductos buscarPRO(ref POJOS.clsNegProductos produc)
        {
            conectar();
            string sql = "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO= '" + produc.IdProducto + "'";
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader miDataR = miCom.ExecuteReader();
            miDataR.Read();
            if (miDataR.HasRows)
            {
                produc.IdProducto = Convert.ToInt32(miDataR["IDPRODUCTO"]);
                produc.Nombre = miDataR["NOMBRE"].ToString();
                produc.Talla = miDataR["TALLA"].ToString();
                produc.Existencia = Convert.ToInt32(miDataR["EXISTENCIA"]);
                produc.PrecioCompra = Convert.ToDouble(miDataR["PRECIOCOMPRA"]);
                produc.PrecioVenta = Convert.ToDouble(miDataR["PRECIOVENTA"]);
                //produc.Imagen =Image (miDataR["IMAGEN"]);
                produc.descrip = miDataR["DESCRIPCION"].ToString();
                produc.IdProveedor =Convert.ToInt32(miDataR["IDPROVEEDOR"]);
                produc.IdCategoria = Convert.ToInt32(miDataR["IDCATEGORIA"]);

            }
            else
            {
                return null;
            }
            miDataR.Close();
            miCom.Dispose();
            conexion.Close();
            return produc;

        }


        public DataTable leerDatosID(ref POJOS.clsNegProductos objx)
        {
            DataTable datos = new DataTable();
            conectar();
            MySqlCommand comando = new MySqlCommand("Select * from PRODUCTOS where IDPRODUCTO=" + objx.IdProducto, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "PRODUCTOS");
            datos = ds.Tables["PRODUCTOS"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();
            return datos;

        }

        public POJOS.clsNegProductos buscarPporID(ref POJOS.clsNegProductos objx)
        {
            conectar();
            string sql = "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO=" + objx.IdProducto;
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader miDataR = miCom.ExecuteReader();
            miDataR.Read();
            if (miDataR.HasRows)
            {
                objx.IdProducto = Convert.ToInt32(miDataR["IDPRODUCTO"]);
                objx.Nombre = miDataR["NOMBRE"].ToString();
                objx.Talla = miDataR["TALLA"].ToString();
                objx.PrecioCompra = Convert.ToDouble(miDataR["PRECIOCOMPRA"]);
                objx.PrecioVenta = Convert.ToDouble(miDataR["PRECIOVENTA"]);
                objx.Existencia = Convert.ToInt32(miDataR["EXISTENCIA"]);
                objx.descrip = miDataR["DESCRIPCION"].ToString();
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

        public void eliminarP(ref POJOS.clsNegProductos objP)
        {
            //conectar();
            //string sql = "delete from PRODUCTOS where IDPRODUCTO=" + objP.IdProducto;
            //MySqlCommand miCom = new MySqlCommand(sql, conexion);
            //miCom.ExecuteNonQuery();
            //miCom.Dispose();
            //conexion.Close();
            try
            {
                _adaptador.DeleteCommand = new MySqlCommand("delete from PRODUCTOS where IDPRODUCTO=@IDPRODUCTO", conexion);
                _adaptador.DeleteCommand.Parameters.Add("@IDPRODUCTO", MySqlDbType.Int32).Value = objP.IdProducto;
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


        public POJOS.clsNegProductos modificarP(ref POJOS.clsNegProductos produc, PictureBox pic)
        {
            try
            {
               _adaptador.UpdateCommand = new MySqlCommand("update PRODUCTOS set NOMBRE=@NOMBRE,TALLA=@TALLA,EXISTENCIA=@EXISTENCIA,PRECIOCOMPRA=@PRECIOCOMPRA,PRECIOVENTA=@PRECIOVENTA,DESCRIPCION=@DESCRIPCION,IDPROVEEDOR=@IDPROVEEDOR,IDCATEGORIA=@IDCATEGORIA,IMAGEN=@IMAGEN where IDPRODUCTO="+produc.IdProducto,conexion);
                _adaptador.UpdateCommand.Parameters.Add("@NOMBRE", MySqlDbType.VarChar, 70).Value = produc.Nombre;
                _adaptador.UpdateCommand.Parameters.Add("@TALLA", MySqlDbType.VarChar, 70).Value = produc.Talla;
                _adaptador.UpdateCommand.Parameters.Add("@EXISTENCIA", MySqlDbType.Int32, 6).Value = produc.Existencia;
                _adaptador.UpdateCommand.Parameters.Add("@PRECIOCOMPRA", MySqlDbType.Double).Value = produc.PrecioCompra;
                _adaptador.UpdateCommand.Parameters.Add("@PRECIOVENTA", MySqlDbType.Double).Value = produc.PrecioVenta;
                _adaptador.UpdateCommand.Parameters.Add("@DESCRIPCION", MySqlDbType.Text).Value = produc.descrip;
                _adaptador.UpdateCommand.Parameters.Add("@IDPROVEEDOR", MySqlDbType.Int32, 6).Value = produc.IdProveedor;
                _adaptador.UpdateCommand.Parameters.Add("@IDCATEGORIA", MySqlDbType.Int32, 6).Value = produc.IdCategoria;

                MemoryStream ms = new MemoryStream();
                pic.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                _adaptador.UpdateCommand.Parameters.AddWithValue("@IMAGEN", aByte);

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
            return produc;
        }
    }
}
