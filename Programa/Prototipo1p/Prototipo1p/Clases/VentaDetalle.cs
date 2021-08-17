using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1p.Clases
{
    public class VentaDetalle
    {


        //Atributos
        String documento_ventaenca;
        String codigo_producto;
        String cantidad_ventadet;
        String costo_ventadet;
        String precio_ventadet;
        String codigo_bodega;



        public VentaDetalle()
        {

        }

        public VentaDetalle(string documento_ventaenca, string codigo_producto, string cantidad_ventadet, string costo_ventadet, string precio_ventadet, string codigo_bodega)
        {
            this.Documento_ventaenca = documento_ventaenca;
            this.Codigo_producto = codigo_producto;
            this.Cantidad_ventadet = cantidad_ventadet;
            this.Costo_ventadet = costo_ventadet;
            this.Precio_ventadet = precio_ventadet;
            this.Codigo_bodega = codigo_bodega;
        }

        public string Documento_ventaenca { get => documento_ventaenca; set => documento_ventaenca = value; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Cantidad_ventadet { get => cantidad_ventadet; set => cantidad_ventadet = value; }
        public string Costo_ventadet { get => costo_ventadet; set => costo_ventadet = value; }
        public string Precio_ventadet { get => precio_ventadet; set => precio_ventadet = value; }
        public string Codigo_bodega { get => codigo_bodega; set => codigo_bodega = value; }


        public void funInsertar()
        {
            String psql = "INSERT INTO ventas_detalle(documento_ventaenca,codigo_producto,cantidad_ventadet,costo_ventadet,precio_ventadet,codigo_bodega)" +
                " VALUES ('" + documento_ventaenca + "' , '" + codigo_producto + "' , '" + cantidad_ventadet + "' , '"
                + costo_ventadet + "' , '" + precio_ventadet + "', '" + codigo_bodega + "')";


            Console.WriteLine(psql); 


            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand insertarPE = new MySqlCommand(psql, conexionBD);
                insertarPE.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
                
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void cargarCombo(ComboBox combobox, String tabla, String id, String nombre)
        {
            combobox.DataSource = null;
            combobox.Items.Clear();

            String sql = "SELECT * FROM " + tabla;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand cargarCombobox = new MySqlCommand(sql, conexionBD);
                /*Guarda la consulta en este objeto*/
                MySqlDataAdapter data = new MySqlDataAdapter(cargarCombobox);
                DataTable dt = new DataTable();
                /*Los datos de una consulta los agregamos a un combobox*/
                data.Fill(dt);

                combobox.ValueMember = id;
                combobox.DisplayMember = nombre;
                /*Se llena el combobox*/
                combobox.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos del combobox " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }


        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;

            if (dato == null)
            {
                sql = "SELECT * FROM ventas_detalle";
            }
            else
            {
                sql = "SELECT * FROM ventas_detalle WHERE documento_ventaenca LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarPaqueteE = new MySqlCommand(sql, conexionBD);
                reader = buscarPaqueteE.ExecuteReader();


                while (reader.Read())
                {

                    VentaDetalle venta = new VentaDetalle();

                    venta.documento_ventaenca = reader.GetString("documento_ventaenca");
                    venta.codigo_producto = reader.GetString("codigo_producto");

                    venta.cantidad_ventadet = reader.GetString("cantidad_ventadet");
                    venta.costo_ventadet = reader.GetString("costo_ventadet");
                    venta.precio_ventadet = reader.GetString("precio_ventadet");
                    venta.codigo_bodega = reader.GetString("codigo_bodega");



                    lista.Add(venta);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }

        public void obtenerNombreProducto(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombre_producto from productos WHERE codigo_producto='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombre_producto");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public void obtenerNombreBodega(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombre_bodega from bodegas WHERE codigo_bodega='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombre_bodega");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public void obtenerCodigoVenta(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT documento_ventaenca from ventas_encabezado WHERE documento_ventaenca='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("documento_ventaenca");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public void funModificar(String idModificar)
        {
            //Console.WriteLine(IdDepartamentoEmpleado);
            String pSqlModificar = "UPDATE ventas_detalle SET  codigo_producto='" + codigo_producto + "', cantidad_ventadet='" + cantidad_ventadet + "', costo_ventadet='" + costo_ventadet + "',precio_ventadet='" + precio_ventadet + "', codigo_bodega='" + codigo_bodega + "' WHERE documento_ventaenca='" + documento_ventaenca + "'";
            //Console.WriteLine(pSqlModificar);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand modificarEmpleado = new MySqlCommand(pSqlModificar, conexionBD);
                modificarEmpleado.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }


        public void funBuscarSetearTxt(ComboBox documento_ventaenca, ComboBox codigo_producto, TextBox cantidad_ventadet, TextBox costo_ventadet, TextBox precio_ventadet, ComboBox codigo_bodega)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from ventas_detalle WHERE documento_ventaenca='" + documento_ventaenca + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand busqueda = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = busqueda.ExecuteReader();

                while (leer.Read())
                {
                    documento_ventaenca.Text = leer.GetString(0);
                    codigo_producto.Text = leer.GetString(1);
                    cantidad_ventadet.Text = leer.GetString(2);
                    costo_ventadet.Text = leer.GetString(3);
                    precio_ventadet.Text = leer.GetString(4);
                    codigo_bodega.Text = leer.GetString(5);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

    }
}
