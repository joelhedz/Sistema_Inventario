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
            components = new System.ComponentModel.Container();
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
            PanelCentral = new Panel();
            LblFecha = new Label();
            LblHora = new Label();
            panelSuperior = new Panel();
            BtnInicio = new Button();
            labelTitulo = new Label();
            FechaHora = new System.Windows.Forms.Timer(components);
            panelIzquierdo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelCentral.SuspendLayout();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(4, 41, 68);
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
            panelIzquierdo.Size = new Size(220, 784);
            panelIzquierdo.TabIndex = 0;
            panelIzquierdo.Paint += panelIzquierdo_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.FromArgb(180, 187, 197);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(0, 709);
            label2.Name = "label2";
            label2.Size = new Size(220, 2);
            label2.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 31, 56);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(LblUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 65);
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
            BtnSalir.BackColor = Color.Transparent;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(1, 714);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(220, 49);
            BtnSalir.TabIndex = 9;
            BtnSalir.Text = "   Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleLeft;
            BtnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnFunciones
            // 
            BtnFunciones.BackColor = Color.FromArgb(4, 41, 68);
            BtnFunciones.FlatAppearance.BorderSize = 0;
            BtnFunciones.FlatStyle = FlatStyle.Flat;
            BtnFunciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFunciones.ForeColor = Color.White;
            BtnFunciones.Image = (Image)resources.GetObject("BtnFunciones.Image");
            BtnFunciones.Location = new Point(-3, 569);
            BtnFunciones.Name = "BtnFunciones";
            BtnFunciones.Padding = new Padding(5, 5, 0, 5);
            BtnFunciones.Size = new Size(224, 65);
            BtnFunciones.TabIndex = 8;
            BtnFunciones.Text = "Funciones";
            BtnFunciones.TextAlign = ContentAlignment.MiddleLeft;
            BtnFunciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFunciones.UseVisualStyleBackColor = false;
            // 
            // BtnBitacora
            // 
            BtnBitacora.BackColor = Color.FromArgb(4, 41, 68);
            BtnBitacora.FlatAppearance.BorderSize = 0;
            BtnBitacora.FlatStyle = FlatStyle.Flat;
            BtnBitacora.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBitacora.ForeColor = Color.White;
            BtnBitacora.Image = (Image)resources.GetObject("BtnBitacora.Image");
            BtnBitacora.Location = new Point(-3, 508);
            BtnBitacora.Name = "BtnBitacora";
            BtnBitacora.Padding = new Padding(5, 5, 0, 5);
            BtnBitacora.Size = new Size(224, 65);
            BtnBitacora.TabIndex = 7;
            BtnBitacora.Text = "Bitacora";
            BtnBitacora.TextAlign = ContentAlignment.MiddleLeft;
            BtnBitacora.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBitacora.UseVisualStyleBackColor = false;
            // 
            // BtnClientes
            // 
            BtnClientes.BackColor = Color.FromArgb(4, 41, 68);
            BtnClientes.FlatAppearance.BorderSize = 0;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClientes.ForeColor = Color.White;
            BtnClientes.Image = (Image)resources.GetObject("BtnClientes.Image");
            BtnClientes.Location = new Point(-3, 447);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Padding = new Padding(5, 5, 0, 5);
            BtnClientes.Size = new Size(224, 65);
            BtnClientes.TabIndex = 6;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.MiddleLeft;
            BtnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClientes.UseVisualStyleBackColor = false;
            // 
            // BtnFactura
            // 
            BtnFactura.BackColor = Color.FromArgb(4, 41, 68);
            BtnFactura.FlatAppearance.BorderSize = 0;
            BtnFactura.FlatStyle = FlatStyle.Flat;
            BtnFactura.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFactura.ForeColor = Color.White;
            BtnFactura.Image = (Image)resources.GetObject("BtnFactura.Image");
            BtnFactura.Location = new Point(-3, 387);
            BtnFactura.Name = "BtnFactura";
            BtnFactura.Padding = new Padding(5, 5, 0, 5);
            BtnFactura.Size = new Size(224, 65);
            BtnFactura.TabIndex = 5;
            BtnFactura.Text = "Factura";
            BtnFactura.TextAlign = ContentAlignment.MiddleLeft;
            BtnFactura.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFactura.UseVisualStyleBackColor = false;
            // 
            // BtnProductos
            // 
            BtnProductos.BackColor = Color.FromArgb(4, 41, 68);
            BtnProductos.FlatAppearance.BorderSize = 0;
            BtnProductos.FlatStyle = FlatStyle.Flat;
            BtnProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnProductos.ForeColor = Color.White;
            BtnProductos.Image = (Image)resources.GetObject("BtnProductos.Image");
            BtnProductos.Location = new Point(-3, 331);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Padding = new Padding(5, 5, 0, 5);
            BtnProductos.Size = new Size(224, 60);
            BtnProductos.TabIndex = 4;
            BtnProductos.Text = "Productos";
            BtnProductos.TextAlign = ContentAlignment.MiddleLeft;
            BtnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnProductos.UseVisualStyleBackColor = false;
            // 
            // BtnCompras
            // 
            BtnCompras.BackColor = Color.FromArgb(4, 41, 68);
            BtnCompras.FlatAppearance.BorderSize = 0;
            BtnCompras.FlatStyle = FlatStyle.Flat;
            BtnCompras.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCompras.ForeColor = Color.White;
            BtnCompras.Image = (Image)resources.GetObject("BtnCompras.Image");
            BtnCompras.Location = new Point(-3, 270);
            BtnCompras.Name = "BtnCompras";
            BtnCompras.Padding = new Padding(5, 5, 0, 5);
            BtnCompras.Size = new Size(224, 65);
            BtnCompras.TabIndex = 3;
            BtnCompras.Text = "Compras";
            BtnCompras.TextAlign = ContentAlignment.MiddleLeft;
            BtnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCompras.UseVisualStyleBackColor = false;
            // 
            // BtnVentas
            // 
            BtnVentas.BackColor = Color.FromArgb(4, 41, 68);
            BtnVentas.FlatAppearance.BorderSize = 0;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVentas.ForeColor = Color.White;
            BtnVentas.Image = (Image)resources.GetObject("BtnVentas.Image");
            BtnVentas.Location = new Point(-3, 209);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Padding = new Padding(5, 5, 0, 5);
            BtnVentas.Size = new Size(224, 65);
            BtnVentas.TabIndex = 2;
            BtnVentas.Text = "Ventas";
            BtnVentas.TextAlign = ContentAlignment.MiddleLeft;
            BtnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnVentas.UseVisualStyleBackColor = false;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.FromArgb(4, 41, 68);
            BtnUsuarios.FlatAppearance.BorderSize = 0;
            BtnUsuarios.FlatStyle = FlatStyle.Flat;
            BtnUsuarios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUsuarios.ForeColor = Color.White;
            BtnUsuarios.Image = (Image)resources.GetObject("BtnUsuarios.Image");
            BtnUsuarios.Location = new Point(-3, 148);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Padding = new Padding(5, 5, 0, 5);
            BtnUsuarios.Size = new Size(224, 65);
            BtnUsuarios.TabIndex = 1;
            BtnUsuarios.Text = "Usuario";
            BtnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            BtnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnProveedores
            // 
            BtnProveedores.BackColor = Color.FromArgb(4, 41, 68);
            BtnProveedores.FlatAppearance.BorderSize = 0;
            BtnProveedores.FlatStyle = FlatStyle.Flat;
            BtnProveedores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnProveedores.ForeColor = Color.White;
            BtnProveedores.Image = (Image)resources.GetObject("BtnProveedores.Image");
            BtnProveedores.Location = new Point(-3, 87);
            BtnProveedores.Name = "BtnProveedores";
            BtnProveedores.Padding = new Padding(5, 5, 0, 5);
            BtnProveedores.Size = new Size(224, 65);
            BtnProveedores.TabIndex = 0;
            BtnProveedores.Text = "Provedores ";
            BtnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            BtnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnProveedores.UseVisualStyleBackColor = false;
            // 
            // PanelCentral
            // 
            PanelCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelCentral.BackColor = Color.FromArgb(255, 255, 251);
            PanelCentral.Controls.Add(LblFecha);
            PanelCentral.Controls.Add(LblHora);
            PanelCentral.ForeColor = SystemColors.ControlText;
            PanelCentral.Location = new Point(220, 52);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(1239, 732);
            PanelCentral.TabIndex = 2;
            // 
            // LblFecha
            // 
            LblFecha.Anchor = AnchorStyles.None;
            LblFecha.AutoSize = true;
            LblFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblFecha.ForeColor = Color.FromArgb(38, 56, 70);
            LblFecha.Location = new Point(517, 318);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(52, 21);
            LblFecha.TabIndex = 1;
            LblFecha.Text = "Fecha";
            // 
            // LblHora
            // 
            LblHora.Anchor = AnchorStyles.None;
            LblHora.AutoSize = true;
            LblHora.Font = new Font("Britannic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            LblHora.ForeColor = Color.Black;
            LblHora.Location = new Point(496, 247);
            LblHora.Name = "LblHora";
            LblHora.Size = new Size(168, 71);
            LblHora.TabIndex = 0;
            LblHora.Text = "Hora";
            // 
            // panelSuperior
            // 
            panelSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSuperior.BackColor = Color.Transparent;
            panelSuperior.Controls.Add(BtnInicio);
            panelSuperior.Controls.Add(labelTitulo);
            panelSuperior.Location = new Point(220, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1239, 53);
            panelSuperior.TabIndex = 1;
            // 
            // BtnInicio
            // 
            BtnInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnInicio.BackColor = Color.FromArgb(13, 93, 142);
            BtnInicio.FlatAppearance.BorderSize = 0;
            BtnInicio.FlatStyle = FlatStyle.Flat;
            BtnInicio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnInicio.ForeColor = Color.White;
            BtnInicio.Image = (Image)resources.GetObject("BtnInicio.Image");
            BtnInicio.Location = new Point(1152, 0);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(87, 53);
            BtnInicio.TabIndex = 10;
            BtnInicio.Text = "Inicio";
            BtnInicio.TextAlign = ContentAlignment.BottomCenter;
            BtnInicio.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnInicio.UseVisualStyleBackColor = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.BackColor = Color.FromArgb(13, 93, 142);
            labelTitulo.Dock = DockStyle.Fill;
            labelTitulo.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(0, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(1239, 53);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "MENÚ";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FechaHora
            // 
            FechaHora.Enabled = true;
            FechaHora.Tick += FechaHora_Tick;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1459, 784);
            Controls.Add(panelSuperior);
            Controls.Add(PanelCentral);
            Controls.Add(panelIzquierdo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Abarroteria ";
            Load += FrmMenu_Load_1;
            panelIzquierdo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelCentral.ResumeLayout(false);
            PanelCentral.PerformLayout();
            panelSuperior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIzquierdo;
        private Panel PanelCentral;
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
        private Label labelTitulo;
        private Panel panelSuperior;
        private Label LblUsuario;
        private Button BtnInicio;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label LblFecha;
        private Label LblHora;
        private System.Windows.Forms.Timer FechaHora;
    }
}