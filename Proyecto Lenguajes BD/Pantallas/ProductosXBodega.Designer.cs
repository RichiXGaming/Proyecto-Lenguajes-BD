namespace Proyecto_Lenguajes_BD.Pantallas
{
    partial class ProductosXBodega
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdBodega = new System.Windows.Forms.TextBox();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(742, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(718, 163);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID Bodega";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdBodega
            // 
            this.txtIdBodega.Location = new System.Drawing.Point(719, 47);
            this.txtIdBodega.Name = "txtIdBodega";
            this.txtIdBodega.Size = new System.Drawing.Size(100, 20);
            this.txtIdBodega.TabIndex = 30;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(719, 466);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(100, 19);
            this.Actualizar.TabIndex = 28;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(719, 509);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 19);
            this.Eliminar.TabIndex = 27;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 11);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(680, 538);
            this.dgv.TabIndex = 25;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(719, 105);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "ID Productos";
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(718, 425);
            this.Insertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(100, 19);
            this.Insertar.TabIndex = 50;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            // 
            // ProductosXBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 559);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdBodega);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductosXBodega";
            this.Text = "ProductosXBodega";
            this.Load += new System.EventHandler(this.ProductosXBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdBodega;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Insertar;
    }
}