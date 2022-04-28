namespace Proyecto_Lenguajes_BD.Pantallas
{
    partial class Login
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
            this.Ingresar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.textUserLogin = new System.Windows.Forms.TextBox();
            this.textPassLogin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(172, 135);
            this.Ingresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(56, 19);
            this.Ingresar.TabIndex = 0;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(172, 167);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(56, 19);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // textUserLogin
            // 
            this.textUserLogin.Location = new System.Drawing.Point(114, 54);
            this.textUserLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textUserLogin.Name = "textUserLogin";
            this.textUserLogin.Size = new System.Drawing.Size(182, 20);
            this.textUserLogin.TabIndex = 2;
            this.textUserLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textUserLogin.Enter += new System.EventHandler(this.textUserLogin_Enter);
            this.textUserLogin.Leave += new System.EventHandler(this.textUserLogin_Leave);
            // 
            // textPassLogin
            // 
            this.textPassLogin.Location = new System.Drawing.Point(114, 105);
            this.textPassLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPassLogin.Name = "textPassLogin";
            this.textPassLogin.Size = new System.Drawing.Size(182, 20);
            this.textPassLogin.TabIndex = 3;
            this.textPassLogin.TextChanged += new System.EventHandler(this.textPassLogin_TextChanged);
            this.textPassLogin.Enter += new System.EventHandler(this.textPassLogin_Enter);
            this.textPassLogin.Leave += new System.EventHandler(this.textPassLogin_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Nombre de usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Contraseña:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 236);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPassLogin);
            this.Controls.Add(this.textUserLogin);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Ingresar);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox textUserLogin;
        private System.Windows.Forms.TextBox textPassLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
    }
}