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
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cmbfamilia = new System.Windows.Forms.ComboBox();
            this.cmbrubro = new System.Windows.Forms.ComboBox();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(31, 20);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(166, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.Text = "Buscar...";
            // 
            // cmbfamilia
            // 
            this.cmbfamilia.FormattingEnabled = true;
            this.cmbfamilia.Location = new System.Drawing.Point(239, 18);
            this.cmbfamilia.Name = "cmbfamilia";
            this.cmbfamilia.Size = new System.Drawing.Size(187, 21);
            this.cmbfamilia.TabIndex = 1;
            // 
            // cmbrubro
            // 
            this.cmbrubro.FormattingEnabled = true;
            this.cmbrubro.Location = new System.Drawing.Point(454, 18);
            this.cmbrubro.Name = "cmbrubro";
            this.cmbrubro.Size = new System.Drawing.Size(187, 21);
            this.cmbrubro.TabIndex = 2;
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(31, 81);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvproductos.Size = new System.Drawing.Size(610, 342);
            this.dgvproductos.TabIndex = 5;
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Image = global::ControlProductos.Properties.Resources.cancelar;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolver.Location = new System.Drawing.Point(658, 160);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(93, 50);
            this.btnvolver.TabIndex = 4;
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
            this.btnnuevo.Location = new System.Drawing.Point(658, 95);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(93, 50);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // AdministrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(762, 457);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.cmbrubro);
            this.Controls.Add(this.cmbfamilia);
            this.Controls.Add(this.txtbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Producto";
            this.Load += new System.EventHandler(this.AdministrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cmbfamilia;
        private System.Windows.Forms.ComboBox cmbrubro;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.DataGridView dgvproductos;
    }
}