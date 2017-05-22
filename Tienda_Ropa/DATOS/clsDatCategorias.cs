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
    /// <summary>
    /// Clase para interactuar con la base de datos especificamente con las categorias
    /// </summary>
    class clsDatCategorias
    {
        MySqlConnection conexion = new MySqlConnection(); //objeto de coneccion
        private MySqlDataAdapter _adaptador = new MySqlDataAdapter(); //objeto de tipo adaptador

        /// <summary>
        /// metodo usado para realizar la coneccion con la base de datos
        /// </summary>
        private void conectar()
        {
            conexion.ConnectionString = "server=localhost; database=bdropa;user id =root; password=Miguel2909; pooling=false";
            conexion.Open();
        }
        /// <summary>
        /// metodo usado para leer datos de categorias dando la posibilidad de usar un filtro por columna
        /// </summary>
        /// <param name="filtro">palabra usada para realizar el filtro por columna</param>
        /// <returns></returns>
        public DataTable leerDatos(string filtro)
        {
            DataTable datos = new DataTable();
            conectar();
            MySqlCommand comando = new MySqlCommand("Select * from CATEGORIAS where IDCATEGORIA like '%"+filtro+ "%' or nombre like '%" + filtro + "%' or DESCRIPCION like '%" + filtro + "%'", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Categorias");
            datos = ds.Tables["Categorias"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();


            return datos;

        }

        /// <summary>
        /// metodo usado para hacer inserciones en la tabla de categorias
        /// 
        /// </summary>
        /// <param name="cat">objeto de tipo categoria usado para obtener los datos a insertar</param>
        /// 
        /// <returns></returns>
        public POJOS.clsNegCategorias insertarC(ref POJOS.clsNegCategorias cat)
        {
            try
            {
                //    _adaptador.InsertCommand = new MySqlCommand("insert into Categorias (IDCATEGORIA,NOMBRE,DESCRIPCION) values(@IDCATEGORIA,@NOMBRE,@DESCRIPCION)");
                //    _adaptador.InsertCommand.Parameters.Add("@IDCATEGORIA", MySqlDbType.Int32, 6).Value = cat.IdCategoria;
                //    _adaptador.InsertCommand.Parameters.Add("@NOMBRE", MySqlDbType.VarChar, 15).Value = cat.Nombre;
                //    _adaptador.InsertCommand.Parameters.Add("@DESCRIPCION", MySqlDbType.VarChar, 45).Value = cat.Descripcion;

                //    conectar();
                //    _adaptador.InsertCommand.Connection = conexion;
                //    _adaptador.InsertCommand.ExecuteNonQuery();

                //}
                //catch (Exception error)
                //{
                //    MessageBox.Show(error.Message);
                //}
                //finally
                //{
                //    conexion.Close();
                //}
                //return cat;
                /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
                conectar();
                /// AGREGAR EL REGISTRO A LA BASE DE DATOS
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "insertarCategoria";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("numCat", cat.IdCategoria);
                comando.Parameters.AddWithValue("name", cat.Nombre);
                comando.Parameters.AddWithValue("descrip", cat.Descripcion);
                comando.ExecuteNonQuery();

                /// FINALIZAMOS LA CONEXION CERRAMOS TODO
                comando.Dispose();
                conexion.Close();
                conexion.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
            return cat;
        }

        /// <summary>
        /// Metodo usado para realizar busquedas de alguna categoria especifica
        /// </summary>
        /// <param name="cat">objeto con la información de la categoria que se desea buscar</param>
        /// <returns></returns>
        public POJOS.clsNegCategorias buscarCATE(ref POJOS.clsNegCategorias cat)
        {
            conectar();
            string sql = "SELECT * FROM CATEGORIAS WHERE IDCATEGORIA= '" + cat.IdCategoria + "'";
            MySqlCommand miCom = new MySqlCommand(sql, conexion);
            MySqlDataReader miDataR = miCom.ExecuteReader();
            miDataR.Read();
            if (miDataR.HasRows)
            {
                cat.IdCategoria = Convert.ToInt32(miDataR["IDCATEGORIA"]);
                cat.Nombre = miDataR["NOMBRE"].ToString();
                cat.Descripcion = miDataR["DESCRIPCION"].ToString();
                

            }
            else
            {
                return null;
            }
            miDataR.Close();
            miCom.Dispose();
            conexion.Close();
            return cat;

        }

        /// <summary>
        /// Metodo usado para obtener datos haciendo un filtro por id
        /// </summary>
        /// <param name="objx">objeto de tipo categoria del cual se obtiene el id para hacer el filtro</param>
        /// <returns></returns>
        public DataTable leerDatosIDC(ref POJOS.clsNegCategorias objx)
        {
            DataTable datos = new DataTable();
            conectar();
            MySqlCommand comando = new MySqlCommand("Select * from CATEGORIAS where IDCATEGORIA=" + objx.IdCategoria, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "CATEGORIAS");
            datos = ds.Tables["CATEGORIAS"];
            adaptador.Dispose();
            comando.Dispose();
            conexion.Close();
            return datos;

        }

        public POJOS.clsNegCategorias buscarCporIDC(ref POJOS.clsNegCategorias objx)
        {
            try {
                conectar();
                string sql = "SELECT * FROM CATEGORIAS WHERE IDCATEGORIA=" + objx.IdCategoria;
                MySqlCommand miCom = new MySqlCommand(sql, conexion);
                MySqlDataReader miDataR = miCom.ExecuteReader();
                miDataR.Read();
                if (miDataR.HasRows)
                {
                    objx.IdCategoria = Convert.ToInt32(miDataR["IDCATEGORIA"]);
                    objx.Nombre = miDataR["NOMBRE"].ToString();
                    objx.Descripcion = miDataR["DESCRIPCION"].ToString();
                }
                else
                {
                    return null;
                }
                miDataR.Close();
                miCom.Dispose();
                conexion.Close();
                
            }catch(Exception e)
            {
                MessageBox.Show(e+"");
            }
            finally
            {
                conexion.Close();
            }
            return objx;
        }

        public DataTable Cargar()
        {

                using (MySqlConnection conn = new MySqlConnection("server=localhost; database=bdRopa; uid=root; password=Miguel2909; pooling=false"))
                {
                    conn.Open();
                    DataTable dt = new DataTable();

                    string query = "SELECT * FROM CATEGORIAS";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dt);
                    return dt;
                }
 
            
        }

        public void eliminarC(ref POJOS.clsNegCategorias objP)
        {
            try
            {
                /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
                conectar();
                /// AGREGAR EL REGISTRO A LA BASE DE DATOS
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "eliminarCategoria";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("numCat", objP.IdCategoria);
                comando.ExecuteNonQuery();

                /// FINALIZAMOS LA CONEXION CERRAMOS TODO
                comando.Dispose();
                conexion.Close();
                conexion.Dispose();
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
    

        public POJOS.clsNegCategorias modificarC(ref POJOS.clsNegCategorias cat)
        {
            try
            {
                /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
                conectar();
                /// AGREGAR EL REGISTRO A LA BASE DE DATOS
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "modificarCategoria";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("numCat", cat.IdCategoria);
                comando.Parameters.AddWithValue("name", cat.Nombre);
                comando.Parameters.AddWithValue("descrip", cat.Descripcion);
                comando.ExecuteNonQuery();

                /// FINALIZAMOS LA CONEXION CERRAMOS TODO
                comando.Dispose();
                conexion.Close();
                conexion.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
            return cat;
        }
    }
}
