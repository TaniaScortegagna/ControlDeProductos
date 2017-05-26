namespace ControlProductos
{
    partial class AdministrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarProducto));
            this.dgvproveedores = new System.Windows.Forms.DataGridView();
            this.cmbfamilias = new System.Windows.Forms.ComboBox();
            this.cmbproveedores = new System.Windows.Forms.ComboBox();
            this.cmbrubros = new System.Windows.Forms.ComboBox();
            this.txbbuscar = new System.Windows.Forms.TextBox();
            this.lblfamilia = new System.Windows.Forms.Label();
            this.lblrubro = new System.Windows.Forms.Label();
            this.lblproveedor = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.bnteliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproveedores
            // 
            this.dgvproveedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedores.Location = new System.Drawing.Point(23, 97);
            this.dgvproveedores.Name = "dgvproveedores";
            this.dgvproveedores.ReadOnly = true;
            this.dgvproveedores.Size = new System.Drawing.Size(821, 297);
            this.dgvproveedores.TabIndex = 0;
            // 
            // cmbfamilias
            // 
            this.cmbfamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfamilias.FormattingEnabled = true;
            this.cmbfamilias.Location = new System.Drawing.Point(103, 13);
            this.cmbfamilias.Name = "cmbfamilias";
            this.cmbfamilias.Size = new System.Drawing.Size(184, 21);
            this.cmbfamilias.TabIndex = 1;
<<<<<<< HEAD
=======
            this.cmbfamilias.SelectedIndexChanged += new System.EventHandler(this.cmbfamilia_SelectedIndexChanged);
>>>>>>> origin/master
            // 
            // cmbproveedores
            // 
            this.cmbproveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproveedores.FormattingEnabled = true;
            this.cmbproveedores.Location = new System.Drawing.Point(449, 13);
            this.cmbproveedores.Name = "cmbproveedores";
            this.cmbproveedores.Size = new System.Drawing.Size(184, 21);
            this.cmbproveedores.TabIndex = 2;
            // 
            // cmbrubros
            // 
            this.cmbrubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrubros.FormattingEnabled = true;
            this.cmbrubros.Location = new System.Drawing.Point(103, 56);
            this.cmbrubros.Name = "cmbrubros";
            this.cmbrubros.Size = new System.Drawing.Size(184, 21);
            this.cmbrubros.TabIndex = 3;
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(449, 56);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(184, 20);
            this.txbbuscar.TabIndex = 4;
            // 
            // lblfamilia
            // 
            this.lblfamilia.AutoSize = true;
            this.lblfamilia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfamilia.Location = new System.Drawing.Point(26, 15);
            this.lblfamilia.Name = "lblfamilia";
            this.lblfamilia.Size = new System.Drawing.Size(60, 16);
            this.lblfamilia.TabIndex = 6;
            this.lblfamilia.Text = "Familia:";
            // 
            // lblrubro
            // 
            this.lblrubro.AutoSize = true;
            this.lblrubro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubro.Location = new System.Drawing.Point(26, 58);
            this.lblrubro.Name = "lblrubro";
            this.lblrubro.Size = new System.Drawing.Size(50, 16);
            this.lblrubro.TabIndex = 7;
            this.lblrubro.Text = "Rubro:";
            // 
            // lblproveedor
            // 
            this.lblproveedor.AutoSize = true;
            this.lblproveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproveedor.Location = new System.Drawing.Point(353, 14);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(77, 16);
            this.lblproveedor.TabIndex = 8;
            this.lblproveedor.Text = "Proveedor:";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(353, 57);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(56, 16);
            this.lblbuscar.TabIndex = 9;
            this.lblbuscar.Text = "Buscar:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(653, 56);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 12;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // bnteliminar
            // 
            this.bnteliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnteliminar.Image = global::ControlProductos.Properties.Resources.eliminar;
            this.bnteliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnteliminar.Location = new System.Drawing.Point(850, 265);
            this.bnteliminar.Name = "bnteliminar";
            this.bnteliminar.Size = new System.Drawing.Size(94, 38);
            this.bnteliminar.TabIndex = 14;
            this.bnteliminar.Text = "Eliminar";
            this.bnteliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnteliminar.UseVisualStyleBackColor = true;
            this.bnteliminar.Click += new System.EventHandler(this.bnteliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = global::ControlProductos.Properties.Resources.editar;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(850, 221);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(94, 38);
            this.btneditar.TabIndex = 13;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Image = global::ControlProductos.Properties.Resources.cancelar;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolver.Location = new System.Drawing.Point(850, 177);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(94, 38);
            this.btnvolver.TabIndex = 11;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = global::ControlProductos.Properties.Resources.agregar;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(850, 133);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(94, 38);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // AdministrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 403);
            this.Controls.Add(this.bnteliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lblproveedor);
            this.Controls.Add(this.lblrubro);
            this.Controls.Add(this.lblfamilia);
            this.Controls.Add(this.txbbuscar);
            this.Controls.Add(this.cmbrubros);
            this.Controls.Add(this.cmbproveedores);
            this.Controls.Add(this.cmbfamilias);
            this.Controls.Add(this.dgvproveedores);
<<<<<<< HEAD
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
=======
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarProducto";
>>>>>>> origin/master
            this.Text = "Administrar Producto";
            this.Load += new System.EventHandler(this.AdministrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproveedores;
        private System.Windows.Forms.ComboBox cmbfamilias;
        private System.Windows.Forms.ComboBox cmbproveedores;
        private System.Windows.Forms.ComboBox cmbrubros;
        private System.Windows.Forms.TextBox txbbuscar;
        private System.Windows.Forms.Label lblfamilia;
        private System.Windows.Forms.Label lblrubro;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button bnteliminar;
    }
}