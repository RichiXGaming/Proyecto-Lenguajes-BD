namespace Proyecto_Lenguajes_BD
{
    partial class Principal
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosEnBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.facturasToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.másInformaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem1.Text = "Usuarios";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.monedasToolStripMenuItem,
            this.bodegasToolStripMenuItem,
            this.productosEnBodegaToolStripMenuItem,
            this.productosPorProveedorToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // proToolStripMenuItem
            // 
            this.proToolStripMenuItem.Name = "proToolStripMenuItem";
            this.proToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.proToolStripMenuItem.Text = "Proveedores";
            this.proToolStripMenuItem.Click += new System.EventHandler(this.proToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // monedasToolStripMenuItem
            // 
            this.monedasToolStripMenuItem.Name = "monedasToolStripMenuItem";
            this.monedasToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.monedasToolStripMenuItem.Text = "Monedas";
            this.monedasToolStripMenuItem.Click += new System.EventHandler(this.monedasToolStripMenuItem_Click);
            // 
            // bodegasToolStripMenuItem
            // 
            this.bodegasToolStripMenuItem.Name = "bodegasToolStripMenuItem";
            this.bodegasToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.bodegasToolStripMenuItem.Text = "Bodegas";
            this.bodegasToolStripMenuItem.Click += new System.EventHandler(this.bodegasToolStripMenuItem_Click);
            // 
            // productosEnBodegaToolStripMenuItem
            // 
            this.productosEnBodegaToolStripMenuItem.Name = "productosEnBodegaToolStripMenuItem";
            this.productosEnBodegaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.productosEnBodegaToolStripMenuItem.Text = "Productos en bodega";
            this.productosEnBodegaToolStripMenuItem.Click += new System.EventHandler(this.productosEnBodegaToolStripMenuItem_Click);
            // 
            // productosPorProveedorToolStripMenuItem
            // 
            this.productosPorProveedorToolStripMenuItem.Name = "productosPorProveedorToolStripMenuItem";
            this.productosPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.productosPorProveedorToolStripMenuItem.Text = "Productos por proveedor";
            this.productosPorProveedorToolStripMenuItem.Click += new System.EventHandler(this.productosPorProveedorToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // másInformaciónToolStripMenuItem
            // 
            this.másInformaciónToolStripMenuItem.Name = "másInformaciónToolStripMenuItem";
            this.másInformaciónToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.másInformaciónToolStripMenuItem.Text = "Más información";
            this.másInformaciónToolStripMenuItem.Click += new System.EventHandler(this.másInformaciónToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1025, 597);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosEnBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másInformaciónToolStripMenuItem;
    }
}

