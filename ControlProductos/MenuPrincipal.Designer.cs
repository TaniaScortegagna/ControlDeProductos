namespace ControlProductos
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnadmprov = new System.Windows.Forms.Button();
            this.btnadmflia = new System.Windows.Forms.Button();
            this.btnadmrubro = new System.Windows.Forms.Button();
            this.btnadmprod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadmprov
            // 
            this.btnadmprov.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadmprov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadmprov.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmprov.Image = global::ControlProductos.Properties.Resources.AdmPrv;
            this.btnadmprov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmprov.Location = new System.Drawing.Point(361, 185);
            this.btnadmprov.Name = "btnadmprov";
            this.btnadmprov.Size = new System.Drawing.Size(309, 94);
            this.btnadmprov.TabIndex = 3;
            this.btnadmprov.Text = "Administrar Proveedores";
            this.btnadmprov.UseVisualStyleBackColor = false;
            // 
            // btnadmflia
            // 
            this.btnadmflia.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadmflia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadmflia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmflia.Image = global::ControlProductos.Properties.Resources.AdmFlia;
            this.btnadmflia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmflia.Location = new System.Drawing.Point(361, 53);
            this.btnadmflia.Name = "btnadmflia";
            this.btnadmflia.Size = new System.Drawing.Size(309, 94);
            this.btnadmflia.TabIndex = 2;
            this.btnadmflia.Text = "Administrar Familias";
            this.btnadmflia.UseVisualStyleBackColor = false;
            // 
            // btnadmrubro
            // 
            this.btnadmrubro.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadmrubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadmrubro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmrubro.Image = global::ControlProductos.Properties.Resources.AdmRubros;
            this.btnadmrubro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmrubro.Location = new System.Drawing.Point(15, 185);
            this.btnadmrubro.Name = "btnadmrubro";
            this.btnadmrubro.Size = new System.Drawing.Size(309, 94);
            this.btnadmrubro.TabIndex = 1;
            this.btnadmrubro.Text = "Administrar Rubros";
            this.btnadmrubro.UseVisualStyleBackColor = false;
            // 
            // btnadmprod
            // 
            this.btnadmprod.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadmprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadmprod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmprod.Image = global::ControlProductos.Properties.Resources.AdmProd;
            this.btnadmprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmprod.Location = new System.Drawing.Point(15, 54);
            this.btnadmprod.Name = "btnadmprod";
            this.btnadmprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnadmprod.Size = new System.Drawing.Size(309, 94);
            this.btnadmprod.TabIndex = 0;
            this.btnadmprod.Text = "Administrar Producto";
            this.btnadmprod.UseVisualStyleBackColor = false;
            this.btnadmprod.Click += new System.EventHandler(this.btnadmprod_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 311);
            this.Controls.Add(this.btnadmprov);
            this.Controls.Add(this.btnadmflia);
            this.Controls.Add(this.btnadmrubro);
            this.Controls.Add(this.btnadmprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadmprod;
        private System.Windows.Forms.Button btnadmrubro;
        private System.Windows.Forms.Button btnadmflia;
        private System.Windows.Forms.Button btnadmprov;
    }
}