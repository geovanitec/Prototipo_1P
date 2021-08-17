using MySql.Data.MySqlClient;
using Prototipo1p.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1p
{
    public partial class frmVentaDetalle : Form
    {
        public frmVentaDetalle()
        {
            InitializeComponent();
            VentaDetalle venta = new VentaDetalle();
            funCargarTabla(null);
            venta.cargarCombo(cbxid, "ventas_encabezado", "documento_ventaenca", "documento_ventaenca");
            venta.cargarCombo(cbxIdProducto, "productos", "codigo_producto", "nombre_producto");
            venta.cargarCombo(cbxIdBodega, "bodegas", "codigo_bodega", "nombre_bodega");
        }

        private void lblTituloCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmVentaDetalle_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            VentaDetalle venta = funObtenerTxt();


            venta.funInsertar();
            funCargarTabla(null);
            funVaciarCampos();
        }

        public VentaDetalle funObtenerTxt()
        {
           
            String documento_ventaenca = cbxid.SelectedValue.ToString();
            String codigo_producto = cbxIdProducto.SelectedValue.ToString();
            String cantidad_ventadet = txtCantidadV.Text;
            String costo_ventadet = txtCosto.Text;
            String precio_ventadet = txtPrecio.Text;
            String codigo_bodega = cbxIdBodega.SelectedValue.ToString();




            VentaDetalle ventas = new VentaDetalle(documento_ventaenca, codigo_producto, cantidad_ventadet, costo_ventadet, precio_ventadet, codigo_bodega);


            return ventas;
        }

        private void funCargarTabla(string dato)
        {
            List<VentaDetalle> lista = new List<VentaDetalle>();
            VentaDetalle venta = new VentaDetalle();

            dgvTabla.DataSource = venta.consulta(dato);
        }

        public void funVaciarCampos()
        {
            cbxid.Text = "";
            cbxIdProducto.Text = "";
            txtCantidadV.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";
            cbxIdBodega.Text = "";

        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            String id = cbxid.Text;

            VentaDetalle venta = funObtenerTxt();
            venta.funModificar(id);

            venta.funBuscarSetearTxt(cbxid, cbxIdProducto, txtCantidadV, txtCosto, txtPrecio, cbxIdBodega);
            funCargarTabla(null);
            funVaciarCampos();
        }

        private void btnBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            String buscar = txtBuscar.Text;
            funCargarTabla(buscar);

            funVaciarCampos();
        }

        private void btnLlenar_MouseClick(object sender, MouseEventArgs e)
        {

           

            String documento_ventaenca = dgvTabla.CurrentRow.Cells[0].Value.ToString();

            VentaDetalle venta = new VentaDetalle();
            venta.obtenerCodigoVenta(documento_ventaenca);
            //en la funcion documento_ventaenca se le asigna el nombre que existe en la BD y se le coloca al combobox
            cbxid.SelectedValue = documento_ventaenca;



            String codigo_producto = dgvTabla.CurrentRow.Cells[1].Value.ToString();

            VentaDetalle ventas = new VentaDetalle();
            ventas.obtenerNombreProducto(codigo_producto);
            //en la funcion codigo_producto se le asigna el nombre que existe en la BD y se le coloca al combobox
            cbxIdProducto.SelectedValue = codigo_producto;


            txtCantidadV.Text = dgvTabla.CurrentRow.Cells[2].Value.ToString();
            txtCosto.Text = dgvTabla.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Text = dgvTabla.CurrentRow.Cells[4].Value.ToString();

            String codigo_bodega = dgvTabla.CurrentRow.Cells[5].Value.ToString();

            VentaDetalle ventass = new VentaDetalle();
            ventass.obtenerNombreBodega(codigo_bodega);
            //en la funcion codigo_producto se le asigna el nombre que existe en la BD y se le coloca al combobox
            cbxIdBodega.SelectedValue = codigo_bodega;

        }

        private void btnEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            String id = cbxid.Text;

            string sql = "DELETE FROM ventas_detalle WHERE documento_ventaenca='" + id + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                funVaciarCampos();
                funCargarTabla(null);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
