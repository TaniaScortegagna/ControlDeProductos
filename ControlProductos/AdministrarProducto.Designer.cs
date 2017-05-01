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
            this.cmbfamilia = new System.Windows.Forms.ComboBox();
            this.cmproveedor = new System.Windows.Forms.ComboBox();
            this.cmdrubro = new System.Windows.Forms.ComboBox();
            this.txbbuscar = new System.Windows.Forms.TextBox();
            this.btnproductos = new System.Windows.Forms.Button();
            this.lblfamilia = new System.Windows.Forms.Label();
            this.lblrubro = new System.Windows.Forms.Label();
            this.lblproveedor = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproveedores
            // 
            this.dgvproveedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedores.Location = new System.Drawing.Point(23, 97);
            this.dgvproveedores.Name = "dgvproveedores";
            this.dgvproveedores.Size = new System.Drawing.Size(842, 297);
            this.dgvproveedores.TabIndex = 0;
            // 
            // cmbfamilia
            // 
            this.cmbfamilia.FormattingEnabled = true;
            this.cmbfamilia.Location = new System.Drawing.Point(253, 14);
            this.cmbfamilia.Name = "cmbfamilia";
            this.cmbfamilia.Size = new System.Drawing.Size(184, 21);
            this.cmbfamilia.TabIndex = 1;
            // 
            // cmproveedor
            // 
            this.cmproveedor.FormattingEnabled = true;
            this.cmproveedor.Location = new System.Drawing.Point(599, 14);
            this.cmproveedor.Name = "cmproveedor";
            this.cmproveedor.Size = new System.Drawing.Size(184, 21);
            this.cmproveedor.TabIndex = 2;
            // 
            // cmdrubro
            // 
            this.cmdrubro.FormattingEnabled = true;
            this.cmdrubro.Location = new System.Drawing.Point(253, 57);
            this.cmdrubro.Name = "cmdrubro";
            this.cmdrubro.Size = new System.Drawing.Size(184, 21);
            this.cmdrubro.TabIndex = 3;
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(599, 57);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(184, 20);
            this.txbbuscar.TabIndex = 4;
            // 
            // btnproductos
            // 
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Location = new System.Drawing.Point(23, 39);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(119, 36);
            this.btnproductos.TabIndex = 5;
            this.btnproductos.Text = "Ver Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
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
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(871, 131);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(84, 50);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(871, 222);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(84, 50);
            this.btnvolver.TabIndex = 11;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // AdministrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 424);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lblproveedor);
            this.Controls.Add(this.lblrubro);
            this.Controls.Add(this.lblfamilia);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.txbbuscar);
            this.Controls.Add(this.cmdrubro);
            this.Controls.Add(this.cmproveedor);
            this.Controls.Add(this.cmbfamilia);
            this.Controls.Add(this.dgvproveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarProducto";
            this.Text = "Administrar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproveedores;
        private System.Windows.Forms.ComboBox cmbfamilia;
        private System.Windows.Forms.ComboBox cmproveedor;
        private System.Windows.Forms.ComboBox cmdrubro;
        private System.Windows.Forms.TextBox txbbuscar;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Label lblfamilia;
        private System.Windows.Forms.Label lblrubro;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnvolver;
    }
}