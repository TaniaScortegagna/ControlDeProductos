namespace ControlProductos
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblclave = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(31, 31);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(60, 16);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclave.Location = new System.Drawing.Point(35, 82);
            this.lblclave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(50, 16);
            this.lblclave.TabIndex = 1;
            this.lblclave.Text = "Clave:";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Location = new System.Drawing.Point(110, 31);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.MaxLength = 15;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(224, 23);
            this.txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Location = new System.Drawing.Point(112, 75);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.MaxLength = 10;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(222, 23);
            this.txtpass.TabIndex = 3;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(59, 122);
            this.btnaceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(100, 28);
            this.btnaceptar.TabIndex = 4;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(199, 121);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 28);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(362, 166);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblclave);
            this.Controls.Add(this.lblusuario);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtpass;
    }
}

