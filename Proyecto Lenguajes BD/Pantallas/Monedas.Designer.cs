namespace Proyecto_Lenguajes_BD.Pantallas
{
    partial class Monedas
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorMoneda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMoneda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.dgv.Size = new System.Drawing.Size(673, 526);
            this.dgv.TabIndex = 49;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Código Interno";
            // 
            // txtInterno
            // 
            this.txtInterno.Location = new System.Drawing.Point(707, 54);
            this.txtInterno.Name = "txtInterno";
            this.txtInterno.ReadOnly = true;
            this.txtInterno.Size = new System.Drawing.Size(100, 20);
            this.txtInterno.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Código ISO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(707, 117);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 19);
            this.button1.TabIndex = 71;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 490);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 19);
            this.button2.TabIndex = 70;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 401);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 19);
            this.button3.TabIndex = 69;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Valor de la moneda";
            // 
            // txtValorMoneda
            // 
            this.txtValorMoneda.Location = new System.Drawing.Point(706, 176);
            this.txtValorMoneda.Name = "txtValorMoneda";
            this.txtValorMoneda.Size = new System.Drawing.Size(100, 20);
            this.txtValorMoneda.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Nombre Moneda";
            // 
            // txtNombreMoneda
            // 
            this.txtNombreMoneda.Location = new System.Drawing.Point(706, 238);
            this.txtNombreMoneda.Name = "txtNombreMoneda";
            this.txtNombreMoneda.ReadOnly = true;
            this.txtNombreMoneda.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMoneda.TabIndex = 76;
            // 
            // Monedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorMoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreMoneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Monedas";
            this.Text = "Monedas";
            this.Load += new System.EventHandler(this.Monedas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMoneda;
    }
}