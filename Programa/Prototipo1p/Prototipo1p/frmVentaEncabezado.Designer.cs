
namespace Prototipo1p
{
    partial class frmVentaEncabezado
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
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbxIdCliente = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.documentoventaencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaventaencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalventaencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusventaencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaEncabezadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCliente.Location = new System.Drawing.Point(12, 9);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(707, 39);
            this.lblTituloCliente.TabIndex = 2;
            this.lblTituloCliente.Text = "MANTENIMIENTO VENTA ENCABEZADO";
            this.lblTituloCliente.Click += new System.EventHandler(this.lblTituloCliente_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(33, 97);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(125, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID Venta Encabezado";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(192, 92);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 35);
            this.txtId.TabIndex = 4;
            // 
            // cbxIdCliente
            // 
            this.cbxIdCliente.FormattingEnabled = true;
            this.cbxIdCliente.Location = new System.Drawing.Point(192, 164);
            this.cbxIdCliente.Name = "cbxIdCliente";
            this.cbxIdCliente.Size = new System.Drawing.Size(171, 21);
            this.cbxIdCliente.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(418, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 47);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha Venta";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(192, 284);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(171, 35);
            this.txtTotal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Venta Encabezado";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(192, 339);
            this.txtEstatus.Multiline = true;
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(171, 35);
            this.txtEstatus.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Estatus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 15;
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Location = new System.Drawing.Point(192, 224);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(201, 20);
            this.txtFechaVenta.TabIndex = 37;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(568, 379);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 47);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(728, 379);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 47);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AutoGenerateColumns = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentoventaencaDataGridViewTextBoxColumn,
            this.codigoclienteDataGridViewTextBoxColumn,
            this.fechaventaencaDataGridViewTextBoxColumn,
            this.totalventaencaDataGridViewTextBoxColumn,
            this.estatusventaencaDataGridViewTextBoxColumn});
            this.dgvTabla.DataSource = this.ventaEncabezadoBindingSource;
            this.dgvTabla.Location = new System.Drawing.Point(443, 157);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 45;
            this.dgvTabla.Size = new System.Drawing.Size(508, 202);
            this.dgvTabla.TabIndex = 40;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(617, 116);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 35);
            this.txtBuscar.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "BUSCAR";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(814, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 47);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBuscar_MouseClick);
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(882, 379);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(137, 47);
            this.btnLlenar.TabIndex = 44;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLlenar_MouseClick);
            // 
            // documentoventaencaDataGridViewTextBoxColumn
            // 
            this.documentoventaencaDataGridViewTextBoxColumn.DataPropertyName = "Documento_ventaenca";
            this.documentoventaencaDataGridViewTextBoxColumn.HeaderText = "Documento_ventaenca";
            this.documentoventaencaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentoventaencaDataGridViewTextBoxColumn.Name = "documentoventaencaDataGridViewTextBoxColumn";
            this.documentoventaencaDataGridViewTextBoxColumn.Width = 110;
            // 
            // codigoclienteDataGridViewTextBoxColumn
            // 
            this.codigoclienteDataGridViewTextBoxColumn.DataPropertyName = "Codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.HeaderText = "Codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoclienteDataGridViewTextBoxColumn.Name = "codigoclienteDataGridViewTextBoxColumn";
            this.codigoclienteDataGridViewTextBoxColumn.Width = 110;
            // 
            // fechaventaencaDataGridViewTextBoxColumn
            // 
            this.fechaventaencaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_ventaenca";
            this.fechaventaencaDataGridViewTextBoxColumn.HeaderText = "Fecha_ventaenca";
            this.fechaventaencaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaventaencaDataGridViewTextBoxColumn.Name = "fechaventaencaDataGridViewTextBoxColumn";
            this.fechaventaencaDataGridViewTextBoxColumn.Width = 110;
            // 
            // totalventaencaDataGridViewTextBoxColumn
            // 
            this.totalventaencaDataGridViewTextBoxColumn.DataPropertyName = "Total_ventaenca";
            this.totalventaencaDataGridViewTextBoxColumn.HeaderText = "Total_ventaenca";
            this.totalventaencaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalventaencaDataGridViewTextBoxColumn.Name = "totalventaencaDataGridViewTextBoxColumn";
            this.totalventaencaDataGridViewTextBoxColumn.Width = 110;
            // 
            // estatusventaencaDataGridViewTextBoxColumn
            // 
            this.estatusventaencaDataGridViewTextBoxColumn.DataPropertyName = "Estatus_ventaenca";
            this.estatusventaencaDataGridViewTextBoxColumn.HeaderText = "Estatus_ventaenca";
            this.estatusventaencaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusventaencaDataGridViewTextBoxColumn.Name = "estatusventaencaDataGridViewTextBoxColumn";
            this.estatusventaencaDataGridViewTextBoxColumn.Width = 110;
            // 
            // ventaEncabezadoBindingSource
            // 
            this.ventaEncabezadoBindingSource.DataSource = typeof(Prototipo1p.Clases.VentaEncabezado);
            // 
            // frmVentaEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 523);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtFechaVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxIdCliente);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTituloCliente);
            this.Name = "frmVentaEncabezado";
            this.Text = "frmVentaEncabezado";
            this.Load += new System.EventHandler(this.frmVentaEncabezado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaEncabezadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbxIdCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtFechaVenta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoventaencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaventaencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalventaencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusventaencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ventaEncabezadoBindingSource;
        private System.Windows.Forms.Button btnLlenar;
    }
}