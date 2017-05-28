namespace ControlProductos
{
    partial class ProductoABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoABM));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.txbdescripcion = new System.Windows.Forms.TextBox();
            this.txbmarca = new System.Windows.Forms.TextBox();
            this.cmbproveedores = new System.Windows.Forms.ComboBox();
            this.cmbfamilias = new System.Windows.Forms.ComboBox();
            this.cmbrubros = new System.Windows.Forms.ComboBox();
            this.txbprecio = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.picBABM = new System.Windows.Forms.PictureBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBABM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Familia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rubro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio:";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(134, 46);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(128, 20);
            this.txbcodigo.TabIndex = 8;
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(134, 96);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(128, 20);
            this.txbnombre.TabIndex = 9;
            this.txbnombre.Validated += new System.EventHandler(this.txbnombre_Validated);
            // 
            // txbdescripcion
            // 
            this.txbdescripcion.Location = new System.Drawing.Point(134, 155);
            this.txbdescripcion.Name = "txbdescripcion";
            this.txbdescripcion.Size = new System.Drawing.Size(128, 20);
            this.txbdescripcion.TabIndex = 10;
            this.txbdescripcion.Validated += new System.EventHandler(this.txbdescripcion_Validated);
            // 
            // txbmarca
            // 
            this.txbmarca.Location = new System.Drawing.Point(134, 213);
            this.txbmarca.Name = "txbmarca";
            this.txbmarca.Size = new System.Drawing.Size(128, 20);
            this.txbmarca.TabIndex = 11;
            this.txbmarca.Validated += new System.EventHandler(this.txbmarca_Validated);
            // 
            // cmbproveedores
            // 
            this.cmbproveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproveedores.FormattingEnabled = true;
            this.cmbproveedores.Location = new System.Drawing.Point(374, 45);
            this.cmbproveedores.Name = "cmbproveedores";
            this.cmbproveedores.Size = new System.Drawing.Size(121, 21);
            this.cmbproveedores.TabIndex = 12;
            this.cmbproveedores.Validated += new System.EventHandler(this.cmbproveedores_Validated);
            // 
            // cmbfamilias
            // 
            this.cmbfamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfamilias.FormattingEnabled = true;
            this.cmbfamilias.Location = new System.Drawing.Point(374, 96);
            this.cmbfamilias.Name = "cmbfamilias";
            this.cmbfamilias.Size = new System.Drawing.Size(121, 21);
            this.cmbfamilias.TabIndex = 13;
            this.cmbfamilias.SelectedIndexChanged += new System.EventHandler(this.cmbfamilias_SelectedIndexChanged);
            this.cmbfamilias.Validated += new System.EventHandler(this.cmbfamilias_Validated);
            // 
            // cmbrubros
            // 
            this.cmbrubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrubros.FormattingEnabled = true;
            this.cmbrubros.Location = new System.Drawing.Point(374, 155);
            this.cmbrubros.Name = "cmbrubros";
            this.cmbrubros.Size = new System.Drawing.Size(121, 21);
            this.cmbrubros.TabIndex = 14;
            this.cmbrubros.Validated += new System.EventHandler(this.cmbrubros_Validated);
            // 
            // txbprecio
            // 
            this.txbprecio.Location = new System.Drawing.Point(374, 213);
            this.txbprecio.Name = "txbprecio";
            this.txbprecio.Size = new System.Drawing.Size(121, 20);
            this.txbprecio.TabIndex = 15;
            this.txbprecio.Validated += new System.EventHandler(this.txbprecio_Validated);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // picBABM
            // 
            this.picBABM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBABM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBABM.Image = global::ControlProductos.Properties.Resources.Producto_abm1;
            this.picBABM.Location = new System.Drawing.Point(522, 35);
            this.picBABM.Name = "picBABM";
            this.picBABM.Size = new System.Drawing.Size(78, 252);
            this.picBABM.TabIndex = 19;
            this.picBABM.TabStop = false;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Image = global::ControlProductos.Properties.Resources.guardar;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(156, 267);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(133, 40);
            this.btnactualizar.TabIndex = 18;
            this.btnactualizar.Text = "Guardar Cambios";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = global::ControlProductos.Properties.Resources.cancelar;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(308, 267);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(133, 40);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::ControlProductos.Properties.Resources.guardar;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(156, 267);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(133, 40);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(27, 267);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(68, 20);
            this.chkActivo.TabIndex = 20;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // ProductoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 314);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.picBABM);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txbprecio);
            this.Controls.Add(this.cmbrubros);
            this.Controls.Add(this.cmbfamilias);
            this.Controls.Add(this.cmbproveedores);
            this.Controls.Add(this.txbmarca);
            this.Controls.Add(this.txbdescripcion);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductoABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Activated += new System.EventHandler(this.ProductoABM_Activated);
            this.Load += new System.EventHandler(this.ProductoABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBABM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.TextBox txbdescripcion;
        private System.Windows.Forms.TextBox txbmarca;
        private System.Windows.Forms.ComboBox cmbproveedores;
        private System.Windows.Forms.ComboBox cmbfamilias;
        private System.Windows.Forms.ComboBox cmbrubros;
        private System.Windows.Forms.TextBox txbprecio;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.PictureBox picBABM;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}