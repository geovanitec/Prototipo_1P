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
    public class VentaEncabezado
    {

        //Atributos
        String documento_ventaenca;
        String codigo_cliente;
        String fecha_ventaenca;
        String total_ventaenca;
        String estatus_ventaenca;



        public VentaEncabezado()
        {

        }

        public VentaEncabezado(string documento_ventaenca, string codigo_cliente, string fecha_ventaenca, string total_ventaenca, string estatus_ventaenca)
        {
            this.Documento_ventaenca = documento_ventaenca;
            this.Codigo_cliente = codigo_cliente;
            this.Fecha_ventaenca = fecha_ventaenca;
            this.Total_ventaenca = total_ventaenca;
            this.Estatus_ventaenca = estatus_ventaenca;
        }

        public string Documento_ventaenca { get => documento_ventaenca; set => documento_ventaenca = value; }
        public string Codigo_cliente { get => codigo_cliente; set => codigo_cliente = value; }
        public string Fecha_ventaenca { get => fecha_ventaenca; set => fecha_ventaenca = value; }
        public string Total_ventaenca { get => total_ventaenca; set => total_ventaenca = value; }
        public string Estatus_ventaenca { get => estatus_ventaenca; set => estatus_ventaenca = value; }


        public void funInsertar()
        {
            String psql = "INSERT INTO ventas_encabezado(documento_ventaenca,codigo_cliente,fecha_ventaenca,total_ventaenca,estatus_ventaenca)" +
                " VALUES ('" + documento_ventaenca + "' , '" + codigo_cliente + "' , '" + fecha_ventaenca + "' , '"
                + total_ventaenca + "' , '" + estatus_ventaenca + "')";

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
                sql = "SELECT * FROM ventas_encabezado";
            }
            else
            {
                sql = "SELECT * FROM ventas_encabezado WHERE documento_ventaenca LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarPaqueteE = new MySqlCommand(sql, conexionBD);
                reader = buscarPaqueteE.ExecuteReader();


                while (reader.Read())
                {

                    VentaEncabezado venta = new VentaEncabezado();

                    venta.documento_ventaenca = reader.GetString("documento_ventaenca");
                    venta.codigo_cliente = reader.GetString("codigo_cliente");

                    venta.fecha_ventaenca = reader.GetString("fecha_ventaenca");
                    venta.total_ventaenca = reader.GetString("total_ventaenca");
                    venta.estatus_ventaenca = reader.GetString("estatus_ventaenca");

                   


                    lista.Add(venta);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }

        public void obtenerNombreCliente(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombre_cliente from clientes WHERE codigo_cliente='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombre_cliente");
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
            String pSqlModificar = "UPDATE ventas_encabezado SET  codigo_cliente='" + codigo_cliente + "', fecha_ventaenca='" + fecha_ventaenca + "', total_ventaenca='" + total_ventaenca + "',estatus_ventaenca='" + estatus_ventaenca + "'WHERE documento_ventaenca='" + documento_ventaenca + "'";
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



        public void funBuscarSetearTxt(TextBox documento_ventaenca, ComboBox codigo_cliente, DateTimePicker fecha_ventaenca, TextBox total_ventaenca, TextBox estatus_ventaenca)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from ventas_encabezado WHERE documento_ventaenca='" + documento_ventaenca + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand busqueda = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = busqueda.ExecuteReader();

                while (leer.Read())
                {
                    documento_ventaenca.Text = leer.GetString(0);
                    codigo_cliente.Text = leer.GetString(1);
                    fecha_ventaenca.Text = leer.GetString(2);
                    total_ventaenca.Text = leer.GetString(3);
                    estatus_ventaenca.Text = leer.GetString(4);
                   
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
