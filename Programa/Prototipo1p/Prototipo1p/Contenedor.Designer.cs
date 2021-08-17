
namespace Prototipo1p
{
    partial class Contenedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATALOGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASENCABEZADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASDETALLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hERRAMIENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBRIRToolStripMenuItem,
            this.cATALOGOSToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.iNFORMESToolStripMenuItem,
            this.hERRAMIENTASToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            // 
            // cATALOGOSToolStripMenuItem
            // 
            this.cATALOGOSToolStripMenuItem.Name = "cATALOGOSToolStripMenuItem";
            this.cATALOGOSToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cATALOGOSToolStripMenuItem.Text = "CATALOGOS";
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASENCABEZADOToolStripMenuItem,
            this.vENTASDETALLEToolStripMenuItem});
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // vENTASENCABEZADOToolStripMenuItem
            // 
            this.vENTASENCABEZADOToolStripMenuItem.Name = "vENTASENCABEZADOToolStripMenuItem";
            this.vENTASENCABEZADOToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.vENTASENCABEZADOToolStripMenuItem.Text = "VENTAS ENCABEZADO";
            this.vENTASENCABEZADOToolStripMenuItem.Click += new System.EventHandler(this.vENTASENCABEZADOToolStripMenuItem_Click);
            // 
            // vENTASDETALLEToolStripMenuItem
            // 
            this.vENTASDETALLEToolStripMenuItem.Name = "vENTASDETALLEToolStripMenuItem";
            this.vENTASDETALLEToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.vENTASDETALLEToolStripMenuItem.Text = "VENTAS DETALLE";
            this.vENTASDETALLEToolStripMenuItem.Click += new System.EventHandler(this.vENTASDETALLEToolStripMenuItem_Click);
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // hERRAMIENTASToolStripMenuItem
            // 
            this.hERRAMIENTASToolStripMenuItem.Name = "hERRAMIENTASToolStripMenuItem";
            this.hERRAMIENTASToolStripMenuItem.Size = new System.Drawing.Size(119, 23);
            this.hERRAMIENTASToolStripMenuItem.Text = "HERRAMIENTAS";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Contenedor";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATALOGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASENCABEZADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASDETALLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hERRAMIENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
    }
}

