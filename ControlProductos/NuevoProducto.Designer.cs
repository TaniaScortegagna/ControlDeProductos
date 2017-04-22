namespace ControlProductos
{
    partial class NuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProducto));
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txbdescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblrubro = new System.Windows.Forms.Label();
            this.lblfamilia = new System.Windows.Forms.Label();
            this.lblproveedor = new System.Windows.Forms.Label();
            this.cmbproveedores = new System.Windows.Forms.ComboBox();
            this.cmbrubros = new System.Windows.Forms.ComboBox();
            this.cmbfamilias = new System.Windows.Forms.ComboBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txbprecio = new System.Windows.Forms.TextBox();
            this.txbmarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = global::ControlProductos.Properties.Resources.editar;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(17, 331);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(110, 54);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = global::ControlProductos.Properties.Resources.eliminar;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(165, 331);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(110, 54);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = global::ControlProductos.Properties.Resources.cancelar;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(326, 331);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(110, 54);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::ControlProductos.Properties.Resources.guardar;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(478, 331);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(110, 54);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(16, 31);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(60, 16);
            this.lblcodigo.TabIndex = 5;
            this.lblcodigo.Text = "Codigo:";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(113, 28);
            this.txbcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.ReadOnly = true;
            this.txbcodigo.Size = new System.Drawing.Size(160, 23);
            this.txbcodigo.TabIndex = 6;
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(113, 111);
            this.txbnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(160, 23);
            this.txbnombre.TabIndex = 8;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(16, 114);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(64, 16);
            this.lblnombre.TabIndex = 7;
            this.lblnombre.Text = "Nombre:";
            // 
            // txbdescripcion
            // 
            this.txbdescripcion.Location = new System.Drawing.Point(113, 195);
            this.txbdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txbdescripcion.Name = "txbdescripcion";
            this.txbdescripcion.Size = new System.Drawing.Size(160, 23);
            this.txbdescripcion.TabIndex = 10;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.Location = new System.Drawing.Point(16, 198);
            this.lbldescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(89, 16);
            this.lbldescripcion.TabIndex = 9;
            this.lbldescripcion.Text = "Descripcion:";
            // 
            // lblrubro
            // 
            this.lblrubro.AutoSize = true;
            this.lblrubro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubro.Location = new System.Drawing.Point(333, 198);
            this.lblrubro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrubro.Name = "lblrubro";
            this.lblrubro.Size = new System.Drawing.Size(50, 16);
            this.lblrubro.TabIndex = 15;
            this.lblrubro.Text = "Rubro:";
            // 
            // lblfamilia
            // 
            this.lblfamilia.AutoSize = true;
            this.lblfamilia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfamilia.Location = new System.Drawing.Point(323, 113);
            this.lblfamilia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfamilia.Name = "lblfamilia";
            this.lblfamilia.Size = new System.Drawing.Size(60, 16);
            this.lblfamilia.TabIndex = 13;
            this.lblfamilia.Text = "Familia:";
            // 
            // lblproveedor
            // 
            this.lblproveedor.AutoSize = true;
            this.lblproveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproveedor.Location = new System.Drawing.Point(323, 34);
            this.lblproveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(77, 16);
            this.lblproveedor.TabIndex = 11;
            this.lblproveedor.Text = "Proveedor:";
            // 
            // cmbproveedores
            // 
            this.cmbproveedores.FormattingEnabled = true;
            this.cmbproveedores.Location = new System.Drawing.Point(415, 31);
            this.cmbproveedores.Margin = new System.Windows.Forms.Padding(4);
            this.cmbproveedores.Name = "cmbproveedores";
            this.cmbproveedores.Size = new System.Drawing.Size(160, 24);
            this.cmbproveedores.TabIndex = 16;
            // 
            // cmbrubros
            // 
            this.cmbrubros.FormattingEnabled = true;
            this.cmbrubros.Location = new System.Drawing.Point(415, 195);
            this.cmbrubros.Margin = new System.Windows.Forms.Padding(4);
            this.cmbrubros.Name = "cmbrubros";
            this.cmbrubros.Size = new System.Drawing.Size(160, 24);
            this.cmbrubros.TabIndex = 17;
            // 
            // cmbfamilias
            // 
            this.cmbfamilias.FormattingEnabled = true;
            this.cmbfamilias.Location = new System.Drawing.Point(415, 110);
            this.cmbfamilias.Margin = new System.Windows.Forms.Padding(4);
            this.cmbfamilias.Name = "cmbfamilias";
            this.cmbfamilias.Size = new System.Drawing.Size(160, 24);
            this.cmbfamilias.TabIndex = 18;
            this.cmbfamilias.SelectedIndexChanged += new System.EventHandler(this.cmbfamilias_SelectedIndexChanged);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(21, 276);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(55, 16);
            this.lblmarca.TabIndex = 19;
            this.lblmarca.Text = "Marca:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(331, 279);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(52, 16);
            this.lblprecio.TabIndex = 20;
            this.lblprecio.Text = "Precio:";
            // 
            // txbprecio
            // 
            this.txbprecio.Location = new System.Drawing.Point(415, 276);
            this.txbprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txbprecio.Name = "txbprecio";
            this.txbprecio.Size = new System.Drawing.Size(160, 23);
            this.txbprecio.TabIndex = 21;
            // 
            // txbmarca
            // 
            this.txbmarca.Location = new System.Drawing.Point(113, 273);
            this.txbmarca.Margin = new System.Windows.Forms.Padding(4);
            this.txbmarca.Name = "txbmarca";
            this.txbmarca.Size = new System.Drawing.Size(160, 23);
            this.txbmarca.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "$";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbmarca);
            this.Controls.Add(this.txbprecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.cmbfamilias);
            this.Controls.Add(this.cmbrubros);
            this.Controls.Add(this.cmbproveedores);
            this.Controls.Add(this.lblrubro);
            this.Controls.Add(this.lblfamilia);
            this.Controls.Add(this.lblproveedor);
            this.Controls.Add(this.txbdescripcion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txbdescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblrubro;
        private System.Windows.Forms.Label lblfamilia;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.ComboBox cmbproveedores;
        private System.Windows.Forms.ComboBox cmbrubros;
        private System.Windows.Forms.ComboBox cmbfamilias;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txbprecio;
        private System.Windows.Forms.TextBox txbmarca;
        private System.Windows.Forms.Label label1;
    }
}