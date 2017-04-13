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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarProducto));
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.controlDeProductosDataSet = new ControlProductos.ControlDeProductosDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new ControlProductos.ControlDeProductosDataSetTableAdapters.ProductosTableAdapter();
            this.familiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familiasTableAdapter = new ControlProductos.ControlDeProductosDataSetTableAdapters.FamiliasTableAdapter();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubrosTableAdapter = new ControlProductos.ControlDeProductosDataSetTableAdapters.RubrosTableAdapter();
            this.controlProductosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ControlProductos.ControlDeProductosDataSetTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gvproductos = new System.Windows.Forms.DataGridView();
            this.btverprod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlDeProductosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlProductosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(12, 38);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(172, 21);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.Text = "Buscar...";
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Image = global::ControlProductos.Properties.Resources.cancelar;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolver.Location = new System.Drawing.Point(736, 240);
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
            this.btnnuevo.Location = new System.Drawing.Point(736, 170);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(93, 50);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // controlDeProductosDataSet
            // 
            this.controlDeProductosDataSet.DataSetName = "ControlDeProductosDataSet";
            this.controlDeProductosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.controlDeProductosDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // familiasBindingSource
            // 
            this.familiasBindingSource.DataMember = "Familias";
            this.familiasBindingSource.DataSource = this.controlDeProductosDataSet;
            // 
            // familiasTableAdapter
            // 
            this.familiasTableAdapter.ClearBeforeFill = true;
            // 
            // rubrosBindingSource
            // 
            this.rubrosBindingSource.DataMember = "Rubros";
            this.rubrosBindingSource.DataSource = this.controlDeProductosDataSet;
            // 
            // rubrosTableAdapter
            // 
            this.rubrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FamiliasTableAdapter = this.familiasTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RubrosTableAdapter = this.rubrosTableAdapter;
            this.tableAdapterManager.UpdateOrder = ControlProductos.ControlDeProductosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.familiasBindingSource, "IdFamilia", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(497, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // gvproductos
            // 
            this.gvproductos.AllowUserToAddRows = false;
            this.gvproductos.AllowUserToDeleteRows = false;
            this.gvproductos.BackgroundColor = System.Drawing.Color.White;
            this.gvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvproductos.Location = new System.Drawing.Point(12, 89);
            this.gvproductos.Name = "gvproductos";
            this.gvproductos.ReadOnly = true;
            this.gvproductos.Size = new System.Drawing.Size(718, 301);
            this.gvproductos.TabIndex = 7;
            // 
            // btverprod
            // 
            this.btverprod.Location = new System.Drawing.Point(572, 396);
            this.btverprod.Name = "btverprod";
            this.btverprod.Size = new System.Drawing.Size(115, 28);
            this.btverprod.TabIndex = 8;
            this.btverprod.Text = "Ver Productos";
            this.btverprod.UseVisualStyleBackColor = true;
            this.btverprod.Click += new System.EventHandler(this.btverprod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(192, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Familia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(446, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rubro:";
            // 
            // AdministrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(836, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btverprod);
            this.Controls.Add(this.gvproductos);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Producto";
            this.Load += new System.EventHandler(this.AdministrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlDeProductosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlProductosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnvolver;
        private ControlDeProductosDataSet controlDeProductosDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private ControlDeProductosDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource familiasBindingSource;
        private ControlDeProductosDataSetTableAdapters.FamiliasTableAdapter familiasTableAdapter;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private ControlDeProductosDataSetTableAdapters.RubrosTableAdapter rubrosTableAdapter;
        private System.Windows.Forms.BindingSource controlProductosDataSetBindingSource;
        private ControlDeProductosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView gvproductos;
        private System.Windows.Forms.Button btverprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}