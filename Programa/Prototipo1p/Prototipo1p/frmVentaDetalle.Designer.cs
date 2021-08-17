
namespace Prototipo1p
{
    partial class frmVentaDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxIdProducto = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.cbxid = new System.Windows.Forms.ComboBox();
            this.txtCantidadV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxIdBodega = new System.Windows.Forms.ComboBox();
            this.ventaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentoventaencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadventadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoventadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigobodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(889, 400);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(137, 47);
            this.btnLlenar.TabIndex = 64;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLlenar_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(821, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 47);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBuscar_MouseClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(624, 137);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 35);
            this.txtBuscar.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "BUSCAR";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AutoGenerateColumns = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentoventaencaDataGridViewTextBoxColumn,
            this.codigoproductoDataGridViewTextBoxColumn,
            this.cantidadventadetDataGridViewTextBoxColumn,
            this.costoventadetDataGridViewTextBoxColumn,
            this.precioventadetDataGridViewTextBoxColumn,
            this.codigobodegaDataGridViewTextBoxColumn});
            this.dgvTabla.DataSource = this.ventaDetalleBindingSource;
            this.dgvTabla.Location = new System.Drawing.Point(450, 178);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 45;
            this.dgvTabla.Size = new System.Drawing.Size(508, 202);
            this.dgvTabla.TabIndex = 60;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(735, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 47);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(575, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 47);
            this.btnModificar.TabIndex = 58;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 56;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(199, 360);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(171, 35);
            this.txtPrecio.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Precio Venta";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(199, 305);
            this.txtCosto.Multiline = true;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(171, 35);
            this.txtCosto.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Costo Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cantidad Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Codigo Producto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(425, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 47);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseClick);
            // 
            // cbxIdProducto
            // 
            this.cbxIdProducto.FormattingEnabled = true;
            this.cbxIdProducto.Location = new System.Drawing.Point(199, 185);
            this.cbxIdProducto.Name = "cbxIdProducto";
            this.cbxIdProducto.Size = new System.Drawing.Size(171, 21);
            this.cbxIdProducto.TabIndex = 48;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(40, 118);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(93, 15);
            this.lblId.TabIndex = 46;
            this.lblId.Text = "ID Docuemento";
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCliente.Location = new System.Drawing.Point(19, 30);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(619, 39);
            this.lblTituloCliente.TabIndex = 45;
            this.lblTituloCliente.Text = "MANTENIMIENTO VENTA DETALLE";
            this.lblTituloCliente.Click += new System.EventHandler(this.lblTituloCliente_Click);
            // 
            // cbxid
            // 
            this.cbxid.FormattingEnabled = true;
            this.cbxid.Location = new System.Drawing.Point(199, 118);
            this.cbxid.Name = "cbxid";
            this.cbxid.Size = new System.Drawing.Size(171, 21);
            this.cbxid.TabIndex = 65;
            // 
            // txtCantidadV
            // 
            this.txtCantidadV.Location = new System.Drawing.Point(199, 231);
            this.txtCantidadV.Multiline = true;
            this.txtCantidadV.Name = "txtCantidadV";
            this.txtCantidadV.Size = new System.Drawing.Size(171, 35);
            this.txtCantidadV.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 68;
            this.label7.Text = "Codigo Bodega";
            // 
            // cbxIdBodega
            // 
            this.cbxIdBodega.FormattingEnabled = true;
            this.cbxIdBodega.Location = new System.Drawing.Point(199, 426);
            this.cbxIdBodega.Name = "cbxIdBodega";
            this.cbxIdBodega.Size = new System.Drawing.Size(171, 21);
            this.cbxIdBodega.TabIndex = 67;
            // 
            // ventaDetalleBindingSource
            // 
            this.ventaDetalleBindingSource.DataSource = typeof(Prototipo1p.Clases.VentaDetalle);
            // 
            // documentoventaencaDataGridViewTextBoxColumn
            // 
            this.documentoventaencaDataGridViewTextBoxColumn.DataPropertyName = "Documento_ventaenca";
            this.documentoventaencaDataGridViewTextBoxColumn.HeaderText = "Documento_ventaenca";
            this.documentoventaencaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentoventaencaDataGridViewTextBoxColumn.Name = "documentoventaencaDataGridViewTextBoxColumn";
            this.documentoventaencaDataGridViewTextBoxColumn.Width = 110;
            // 
            // codigoproductoDataGridViewTextBoxColumn
            // 
            this.codigoproductoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.HeaderText = "Codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoproductoDataGridViewTextBoxColumn.Name = "codigoproductoDataGridViewTextBoxColumn";
            this.codigoproductoDataGridViewTextBoxColumn.Width = 110;
            // 
            // cantidadventadetDataGridViewTextBoxColumn
            // 
            this.cantidadventadetDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_ventadet";
            this.cantidadventadetDataGridViewTextBoxColumn.HeaderText = "Cantidad_ventadet";
            this.cantidadventadetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadventadetDataGridViewTextBoxColumn.Name = "cantidadventadetDataGridViewTextBoxColumn";
            this.cantidadventadetDataGridViewTextBoxColumn.Width = 110;
            // 
            // costoventadetDataGridViewTextBoxColumn
            // 
            this.costoventadetDataGridViewTextBoxColumn.DataPropertyName = "Costo_ventadet";
            this.costoventadetDataGridViewTextBoxColumn.HeaderText = "Costo_ventadet";
            this.costoventadetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoventadetDataGridViewTextBoxColumn.Name = "costoventadetDataGridViewTextBoxColumn";
            this.costoventadetDataGridViewTextBoxColumn.Width = 110;
            // 
            // precioventadetDataGridViewTextBoxColumn
            // 
            this.precioventadetDataGridViewTextBoxColumn.DataPropertyName = "Precio_ventadet";
            this.precioventadetDataGridViewTextBoxColumn.HeaderText = "Precio_ventadet";
            this.precioventadetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioventadetDataGridViewTextBoxColumn.Name = "precioventadetDataGridViewTextBoxColumn";
            this.precioventadetDataGridViewTextBoxColumn.Width = 110;
            // 
            // codigobodegaDataGridViewTextBoxColumn
            // 
            this.codigobodegaDataGridViewTextBoxColumn.DataPropertyName = "Codigo_bodega";
            this.codigobodegaDataGridViewTextBoxColumn.HeaderText = "Codigo_bodega";
            this.codigobodegaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigobodegaDataGridViewTextBoxColumn.Name = "codigobodegaDataGridViewTextBoxColumn";
            this.codigobodegaDataGridViewTextBoxColumn.Width = 110;
            // 
            // frmVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 596);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxIdBodega);
            this.Controls.Add(this.txtCantidadV);
            this.Controls.Add(this.cbxid);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxIdProducto);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTituloCliente);
            this.Name = "frmVentaDetalle";
            this.Text = "frmVentaDetalle";
            this.Load += new System.EventHandler(this.frmVentaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxIdProducto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.ComboBox cbxid;
        private System.Windows.Forms.TextBox txtCantidadV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxIdBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoventaencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadventadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoventadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigobodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ventaDetalleBindingSource;
    }
}