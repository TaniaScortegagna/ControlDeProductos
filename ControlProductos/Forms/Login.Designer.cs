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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblclave = new System.Windows.Forms.Label();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.txbclave = new System.Windows.Forms.TextBox();
            this.picBLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(127, 112);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(91, 27);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(241, 112);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(91, 27);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(124, 36);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(60, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclave.Location = new System.Drawing.Point(124, 74);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(50, 16);
            this.lblclave.TabIndex = 3;
            this.lblclave.Text = "Clave:";
            // 
            // txbusuario
            // 
            this.txbusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbusuario.Location = new System.Drawing.Point(200, 34);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(132, 23);
            this.txbusuario.TabIndex = 0;
            this.txbusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbusuario_KeyPress);
            // 
            // txbclave
            // 
            this.txbclave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbclave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbclave.Location = new System.Drawing.Point(200, 72);
            this.txbclave.Name = "txbclave";
            this.txbclave.PasswordChar = '*';
            this.txbclave.Size = new System.Drawing.Size(132, 23);
            this.txbclave.TabIndex = 1;
            this.txbclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbclave_KeyPress);
            // 
            // picBLogin
            // 
            this.picBLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBLogin.ErrorImage = global::ControlProductos.Properties.Resources.Login;
            this.picBLogin.Image = global::ControlProductos.Properties.Resources.Login1;
            this.picBLogin.Location = new System.Drawing.Point(12, 22);
            this.picBLogin.Name = "picBLogin";
            this.picBLogin.Size = new System.Drawing.Size(105, 105);
            this.picBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBLogin.TabIndex = 4;
            this.picBLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 165);
            this.Controls.Add(this.picBLogin);
            this.Controls.Add(this.txbclave);
            this.Controls.Add(this.txbusuario);
            this.Controls.Add(this.lblclave);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picBLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.TextBox txbclave;
        private System.Windows.Forms.PictureBox picBLogin;
    }
}

