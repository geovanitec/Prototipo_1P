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
    public partial class frmVentaEncabezado : Form
    {
        public frmVentaEncabezado()
        {
            InitializeComponent();
            VentaEncabezado venta = new VentaEncabezado();
            funCargarTabla(null);
            venta.cargarCombo(cbxIdCliente, "clientes", "codigo_cliente", "nombre_cliente");
        }

        private void lblTituloCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmVentaEncabezado_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_MouseClick(object sender, MouseEventArgs e)
        {


            VentaEncabezado venta = funObtenerTxt();


            venta.funInsertar();
            funCargarTabla(null);
            funVaciarCampos();
        }

        public VentaEncabezado funObtenerTxt()
        {
            /*Inicio obteniedo variables a usar con mi ABC cliente */
            String documento_ventaenca = txtId.Text;
            String codigo_cliente = cbxIdCliente.SelectedValue.ToString();
            String fecha_ventaenca = txtFechaVenta.Value.ToString("yyyy-MM-dd");
            String total_ventaenca = txtTotal.Text;
            String estatus_ventaenca = txtEstatus.Text;




         
            VentaEncabezado venta = new VentaEncabezado(documento_ventaenca, codigo_cliente, fecha_ventaenca, total_ventaenca, estatus_ventaenca);
           

            return venta;
        }

        private void funCargarTabla(string dato)
        {
            List<VentaEncabezado> lista = new List<VentaEncabezado>();
            VentaEncabezado venta = new VentaEncabezado();

            dgvTabla.DataSource = venta.consulta(dato);
        }

        public void funVaciarCampos()
        {
            txtId.Text = "";
            cbxIdCliente.Text = "";
            txtFechaVenta.Text = "";
            txtTotal.Text = "";
            txtEstatus.Text = "";
            
        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            
           
           

            String id = txtId.Text;
           
            VentaEncabezado venta = funObtenerTxt();
            venta.funModificar(id);

            venta.funBuscarSetearTxt(txtId, cbxIdCliente, txtFechaVenta, txtTotal, txtEstatus);
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
            txtId.Text = dgvTabla.CurrentRow.Cells[0].Value.ToString();

            String idCliente = dgvTabla.CurrentRow.Cells[1].Value.ToString();

            VentaEncabezado venta = new VentaEncabezado();
            venta.obtenerNombreCliente(idCliente);
            //en la funcion idCliente se le asigna el nombre que existe en la BD y se le coloca al combobox
            cbxIdCliente.SelectedValue = idCliente;

            // De string a dateTime
            txtFechaVenta.Value = Convert.ToDateTime(dgvTabla.CurrentRow.Cells[2].Value.ToString());

            txtTotal.Text = dgvTabla.CurrentRow.Cells[3].Value.ToString();
            txtEstatus.Text = dgvTabla.CurrentRow.Cells[4].Value.ToString();
          


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;

            string sql = "DELETE FROM ventas_encabezado WHERE documento_ventaenca='" + id + "'";

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
