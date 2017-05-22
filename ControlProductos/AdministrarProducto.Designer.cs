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
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproveedores
            // 
            this.dgvproveedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedores.Location = new System.Drawing.Point(23, 97);
            this.dgvproveedores.Name = "dgvproveedores";
            this.dgvproveedores.Size = new System.Drawing.Size(821, 297);
            this.dgvproveedores.TabIndex = 0;
            // 
            // cmbfamilias
            // 
            this.cmbfamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfamilias.FormattingEnabled = true;
            this.cmbfamilias.Location = new System.Drawing.Point(253, 14);
            this.cmbfamilias.Name = "cmbfamilias";
            this.cmbfamilias.Size = new System.Drawing.Size(184, 21);
            this.cmbfamilias.TabIndex = 1;
            this.cmbfamilias.SelectedIndexChanged += new System.EventHandler(this.cmbfamilia_SelectedIndexChanged);
            // 
            // cmbproveedores
            // 
            this.cmbproveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproveedores.FormattingEnabled = true;
            this.cmbproveedores.Location = new System.Drawing.Point(599, 14);
            this.cmbproveedores.Name = "cmbproveedores";
            this.cmbproveedores.Size = new System.Drawing.Size(184, 21);
            this.cmbproveedores.TabIndex = 2;
            // 
            // cmbrubros
            // 
            this.cmbrubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrubros.FormattingEnabled = true;
            this.cmbrubros.Location = new System.Drawing.Point(253, 57);
            this.cmbrubros.Name = "cmbrubros";
            this.cmbrubros.Size = new System.Drawing.Size(184, 21);
            this.cmbrubros.TabIndex = 3;
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(599, 57);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(184, 20);
            this.txbbuscar.TabIndex = 4;
            // 
            // lblfamilia
            // 
            this.lblfamilia.AutoSize = true;
            this.lblfamilia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfamilia.Location = new System.Drawing.Point(176, 16);
            this.lblfamilia.Name = "lblfamilia";
            this.lblfamilia.Size = new System.Drawing.Size(60, 16);
            this.lblfamilia.TabIndex = 6;
            this.lblfamilia.Text = "Familia:";
            // 
            // lblrubro
            // 
            this.lblrubro.AutoSize = true;
            this.lblrubro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubro.Location = new System.Drawing.Point(176, 59);
            this.lblrubro.Name = "lblrubro";
            this.lblrubro.Size = new System.Drawing.Size(50, 16);
            this.lblrubro.TabIndex = 7;
            this.lblrubro.Text = "Rubro:";
            // 
            // lblproveedor
            // 
            this.lblproveedor.AutoSize = true;
            this.lblproveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproveedor.Location = new System.Drawing.Point(503, 15);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(77, 16);
            this.lblproveedor.TabIndex = 8;
            this.lblproveedor.Text = "Proveedor:";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(503, 58);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(56, 16);
            this.lblbuscar.TabIndex = 9;
            this.lblbuscar.Text = "Buscar:";
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
            // btnproductos
            // 
            this.btnproductos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Image = global::ControlProductos.Properties.Resources.verProductos;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(23, 39);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(133, 36);
            this.btnproductos.TabIndex = 5;
            this.btnproductos.Text = "Ver Productos";
            this.btnproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnproductos.UseVisualStyleBackColor = false;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(803, 57);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 12;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // AdministrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 403);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lblproveedor);
            this.Controls.Add(this.lblrubro);
            this.Controls.Add(this.lblfamilia);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.txbbuscar);
            this.Controls.Add(this.cmbrubros);
            this.Controls.Add(this.cmbproveedores);
            this.Controls.Add(this.cmbfamilias);
            this.Controls.Add(this.dgvproveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarProducto";
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
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Label lblfamilia;
        private System.Windows.Forms.Label lblrubro;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnbuscar;
    }
}