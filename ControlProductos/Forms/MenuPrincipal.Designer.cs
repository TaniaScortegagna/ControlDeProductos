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
            this.btnadminproveedores = new System.Windows.Forms.Button();
            this.btnadminrubros = new System.Windows.Forms.Button();
            this.btnadminfamilias = new System.Windows.Forms.Button();
            this.btnadminproductos = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadminproveedores
            // 
            this.btnadminproveedores.BackColor = System.Drawing.Color.White;
            this.btnadminproveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminproveedores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadminproveedores.Image = global::ControlProductos.Properties.Resources.AdmPrv;
            this.btnadminproveedores.Location = new System.Drawing.Point(361, 193);
            this.btnadminproveedores.Name = "btnadminproveedores";
            this.btnadminproveedores.Size = new System.Drawing.Size(289, 115);
            this.btnadminproveedores.TabIndex = 3;
            this.btnadminproveedores.Text = "Administrar Proveedores";
            this.btnadminproveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadminproveedores.UseVisualStyleBackColor = false;
            // 
            // btnadminrubros
            // 
            this.btnadminrubros.BackColor = System.Drawing.Color.White;
            this.btnadminrubros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminrubros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadminrubros.Image = global::ControlProductos.Properties.Resources.AdmRubros;
            this.btnadminrubros.Location = new System.Drawing.Point(29, 193);
            this.btnadminrubros.Name = "btnadminrubros";
            this.btnadminrubros.Size = new System.Drawing.Size(289, 115);
            this.btnadminrubros.TabIndex = 2;
            this.btnadminrubros.Text = "Administrar Rubros";
            this.btnadminrubros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadminrubros.UseVisualStyleBackColor = false;
            // 
            // btnadminfamilias
            // 
            this.btnadminfamilias.BackColor = System.Drawing.Color.White;
            this.btnadminfamilias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminfamilias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadminfamilias.Image = global::ControlProductos.Properties.Resources.AdmFlia;
            this.btnadminfamilias.Location = new System.Drawing.Point(361, 52);
            this.btnadminfamilias.Name = "btnadminfamilias";
            this.btnadminfamilias.Size = new System.Drawing.Size(289, 115);
            this.btnadminfamilias.TabIndex = 1;
            this.btnadminfamilias.Text = "Administrar Familias";
            this.btnadminfamilias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadminfamilias.UseVisualStyleBackColor = false;
            // 
            // btnadminproductos
            // 
            this.btnadminproductos.BackColor = System.Drawing.Color.White;
            this.btnadminproductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminproductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadminproductos.Image = global::ControlProductos.Properties.Resources.AdmProd;
            this.btnadminproductos.Location = new System.Drawing.Point(29, 52);
            this.btnadminproductos.Name = "btnadminproductos";
            this.btnadminproductos.Size = new System.Drawing.Size(289, 115);
            this.btnadminproductos.TabIndex = 0;
            this.btnadminproductos.Text = "Administrar Productos";
            this.btnadminproductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadminproductos.UseVisualStyleBackColor = false;
            this.btnadminproductos.Click += new System.EventHandler(this.btnadminproductos_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Image = global::ControlProductos.Properties.Resources.Logout;
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrar.Location = new System.Drawing.Point(518, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(132, 41);
            this.btncerrar.TabIndex = 4;
            this.btncerrar.Text = "Cerrar sesion";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncerrar.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 334);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnadminproveedores);
            this.Controls.Add(this.btnadminrubros);
            this.Controls.Add(this.btnadminfamilias);
            this.Controls.Add(this.btnadminproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadminproductos;
        private System.Windows.Forms.Button btnadminfamilias;
        private System.Windows.Forms.Button btnadminrubros;
        private System.Windows.Forms.Button btnadminproveedores;
        private System.Windows.Forms.Button btncerrar;
    }
}