namespace Sistema_Inventario.Formularios
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panelIzquierdo = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            LblUsuario = new Label();
            BtnSalir = new Button();
            BtnFunciones = new Button();
            BtnBitacora = new Button();
            BtnClientes = new Button();
            BtnFactura = new Button();
            BtnProductos = new Button();
            BtnCompras = new Button();
            BtnVentas = new Button();
            BtnUsuarios = new Button();
            BtnProveedores = new Button();
            Panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panelSuperior = new Panel();
            BtnInicio = new Button();
            label1 = new Label();
            panelIzquierdo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel1.SuspendLayout();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.Controls.Add(label2);
            panelIzquierdo.Controls.Add(panel2);
            panelIzquierdo.Controls.Add(BtnSalir);
            panelIzquierdo.Controls.Add(BtnFunciones);
            panelIzquierdo.Controls.Add(BtnBitacora);
            panelIzquierdo.Controls.Add(BtnClientes);
            panelIzquierdo.Controls.Add(BtnFactura);
            panelIzquierdo.Controls.Add(BtnProductos);
            panelIzquierdo.Controls.Add(BtnCompras);
            panelIzquierdo.Controls.Add(BtnVentas);
            panelIzquierdo.Controls.Add(BtnUsuarios);
            panelIzquierdo.Controls.Add(BtnProveedores);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(192, 693);
            panelIzquierdo.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(0, 610);
            label2.Name = "label2";
            label2.Size = new Size(192, 3);
            label2.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(LblUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 65);
            panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(22, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LblUsuario
            // 
            LblUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblUsuario.ForeColor = SystemColors.ButtonFace;
            LblUsuario.Location = new Point(73, 13);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(113, 43);
            LblUsuario.TabIndex = 1;
            LblUsuario.Text = "Usuario";
            LblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSalir.BackColor = Color.FromArgb(192, 0, 0);
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1, 614);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(192, 49);
            BtnSalir.TabIndex = 9;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalir.UseVisualStyleBackColor = false;
            // 
            // BtnFunciones
            // 
            BtnFunciones.Location = new Point(0, 470);
            BtnFunciones.Name = "BtnFunciones";
            BtnFunciones.Size = new Size(192, 49);
            BtnFunciones.TabIndex = 8;
            BtnFunciones.Text = "Funciones";
            BtnFunciones.TextAlign = ContentAlignment.MiddleRight;
            BtnFunciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFunciones.UseVisualStyleBackColor = true;
            // 
            // BtnBitacora
            // 
            BtnBitacora.Image = (Image)resources.GetObject("BtnBitacora.Image");
            BtnBitacora.Location = new Point(0, 424);
            BtnBitacora.Name = "BtnBitacora";
            BtnBitacora.Size = new Size(192, 49);
            BtnBitacora.TabIndex = 7;
            BtnBitacora.Text = "Bitacora";
            BtnBitacora.TextAlign = ContentAlignment.MiddleRight;
            BtnBitacora.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBitacora.UseVisualStyleBackColor = true;
            // 
            // BtnClientes
            // 
            BtnClientes.Location = new Point(0, 377);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(192, 49);
            BtnClientes.TabIndex = 6;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.MiddleRight;
            BtnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClientes.UseVisualStyleBackColor = true;
            // 
            // BtnFactura
            // 
            BtnFactura.Image = (Image)resources.GetObject("BtnFactura.Image");
            BtnFactura.Location = new Point(0, 283);
            BtnFactura.Name = "BtnFactura";
            BtnFactura.Size = new Size(192, 49);
            BtnFactura.TabIndex = 5;
            BtnFactura.Text = "Factura";
            BtnFactura.TextAlign = ContentAlignment.MiddleRight;
            BtnFactura.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFactura.UseVisualStyleBackColor = true;
            // 
            // BtnProductos
            // 
            BtnProductos.Image = (Image)resources.GetObject("BtnProductos.Image");
            BtnProductos.Location = new Point(0, 330);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(192, 49);
            BtnProductos.TabIndex = 4;
            BtnProductos.Text = "Productos";
            BtnProductos.TextAlign = ContentAlignment.MiddleRight;
            BtnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnProductos.UseVisualStyleBackColor = true;
            // 
            // BtnCompras
            // 
            BtnCompras.Image = (Image)resources.GetObject("BtnCompras.Image");
            BtnCompras.Location = new Point(0, 237);
            BtnCompras.Name = "BtnCompras";
            BtnCompras.Size = new Size(192, 49);
            BtnCompras.TabIndex = 3;
            BtnCompras.Text = "Compras";
            BtnCompras.TextAlign = ContentAlignment.MiddleRight;
            BtnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCompras.UseVisualStyleBackColor = true;
            // 
            // BtnVentas
            // 
            BtnVentas.Location = new Point(0, 190);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(192, 49);
            BtnVentas.TabIndex = 2;
            BtnVentas.Text = "Ventas";
            BtnVentas.TextAlign = ContentAlignment.MiddleRight;
            BtnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnVentas.UseVisualStyleBackColor = true;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.Image = (Image)resources.GetObject("BtnUsuarios.Image");
            BtnUsuarios.Location = new Point(0, 143);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(192, 49);
            BtnUsuarios.TabIndex = 1;
            BtnUsuarios.Text = "Usuario";
            BtnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            BtnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUsuarios.UseVisualStyleBackColor = true;
            // 
            // BtnProveedores
            // 
            BtnProveedores.Image = (Image)resources.GetObject("BtnProveedores.Image");
            BtnProveedores.Location = new Point(0, 98);
            BtnProveedores.Name = "BtnProveedores";
            BtnProveedores.Size = new Size(192, 49);
            BtnProveedores.TabIndex = 0;
            BtnProveedores.Text = "Provedores ";
            BtnProveedores.TextAlign = ContentAlignment.MiddleRight;
            BtnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnProveedores.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Teal;
            Panel1.Controls.Add(label4);
            Panel1.Controls.Add(label3);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(192, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(986, 693);
            Panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(38, 56, 70);
            label4.Location = new Point(455, 377);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 1;
            label4.Text = "Fecha";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(419, 302);
            label3.Name = "label3";
            label3.Size = new Size(168, 71);
            label3.TabIndex = 0;
            label3.Text = "Hora";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.Transparent;
            panelSuperior.Controls.Add(BtnInicio);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(192, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(986, 65);
            panelSuperior.TabIndex = 1;
            // 
            // BtnInicio
            // 
            BtnInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnInicio.BackColor = Color.SteelBlue;
            BtnInicio.FlatAppearance.BorderSize = 0;
            BtnInicio.FlatStyle = FlatStyle.Flat;
            BtnInicio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnInicio.ForeColor = Color.White;
            BtnInicio.Image = (Image)resources.GetObject("BtnInicio.Image");
            BtnInicio.Location = new Point(899, 0);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(87, 65);
            BtnInicio.TabIndex = 10;
            BtnInicio.Text = "Inicio";
            BtnInicio.TextAlign = ContentAlignment.BottomCenter;
            BtnInicio.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnInicio.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(986, 65);
            label1.TabIndex = 0;
            label1.Text = "MENÚ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1178, 693);
            Controls.Add(panelSuperior);
            Controls.Add(Panel1);
            Controls.Add(panelIzquierdo);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Abarroteria ";
            panelIzquierdo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            panelSuperior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIzquierdo;
        private Panel Panel1;
        private Button BtnSalir;
        private Button BtnFunciones;
        private Button BtnBitacora;
        private Button BtnClientes;
        private Button BtnFactura;
        private Button BtnProductos;
        private Button BtnCompras;
        private Button BtnVentas;
        private Button BtnUsuarios;
        private Button BtnProveedores;
        private Label label1;
        private Panel panelSuperior;
        private Label LblUsuario;
        private Button BtnInicio;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}