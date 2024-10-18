namespace EmpresaBenja.CPresentacion
{
    partial class Principal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMoviYCrud = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnVentaProd = new System.Windows.Forms.Button();
            this.btnActuEmpleados = new System.Windows.Forms.Button();
            this.btnCompraProd = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnMoviYCrud);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.btnVentaProd);
            this.panelMenu.Controls.Add(this.btnActuEmpleados);
            this.panelMenu.Controls.Add(this.btnCompraProd);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 779);
            this.panelMenu.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(9, 259);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(210, 75);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(9, 692);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(210, 75);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMoviYCrud
            // 
            this.btnMoviYCrud.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMoviYCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoviYCrud.ForeColor = System.Drawing.Color.White;
            this.btnMoviYCrud.Location = new System.Drawing.Point(9, 501);
            this.btnMoviYCrud.Name = "btnMoviYCrud";
            this.btnMoviYCrud.Size = new System.Drawing.Size(210, 75);
            this.btnMoviYCrud.TabIndex = 5;
            this.btnMoviYCrud.Text = "Movimiento y CRUD productos";
            this.btnMoviYCrud.UseVisualStyleBackColor = false;
            this.btnMoviYCrud.Click += new System.EventHandler(this.btnMoviYCrud_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(9, 97);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(210, 75);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnVentaProd
            // 
            this.btnVentaProd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVentaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaProd.ForeColor = System.Drawing.Color.White;
            this.btnVentaProd.Location = new System.Drawing.Point(9, 420);
            this.btnVentaProd.Name = "btnVentaProd";
            this.btnVentaProd.Size = new System.Drawing.Size(210, 75);
            this.btnVentaProd.TabIndex = 4;
            this.btnVentaProd.Text = "Venta de producto";
            this.btnVentaProd.UseVisualStyleBackColor = false;
            this.btnVentaProd.Click += new System.EventHandler(this.btnVentaProd_Click);
            // 
            // btnActuEmpleados
            // 
            this.btnActuEmpleados.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnActuEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnActuEmpleados.Location = new System.Drawing.Point(9, 178);
            this.btnActuEmpleados.Name = "btnActuEmpleados";
            this.btnActuEmpleados.Size = new System.Drawing.Size(210, 75);
            this.btnActuEmpleados.TabIndex = 2;
            this.btnActuEmpleados.Text = "Actualización empleados";
            this.btnActuEmpleados.UseVisualStyleBackColor = false;
            this.btnActuEmpleados.Click += new System.EventHandler(this.btnActuEmpleados_Click);
            // 
            // btnCompraProd
            // 
            this.btnCompraProd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCompraProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraProd.ForeColor = System.Drawing.Color.White;
            this.btnCompraProd.Location = new System.Drawing.Point(9, 339);
            this.btnCompraProd.Name = "btnCompraProd";
            this.btnCompraProd.Size = new System.Drawing.Size(210, 75);
            this.btnCompraProd.TabIndex = 3;
            this.btnCompraProd.Text = "Compra de producto";
            this.btnCompraProd.UseVisualStyleBackColor = false;
            this.btnCompraProd.Click += new System.EventHandler(this.btnCompraProd_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(230, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 779);
            this.panelContenedor.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1310, 779);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMoviYCrud;
        private System.Windows.Forms.Button btnVentaProd;
        private System.Windows.Forms.Button btnActuEmpleados;
        private System.Windows.Forms.Button btnCompraProd;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnClientes;
    }
}