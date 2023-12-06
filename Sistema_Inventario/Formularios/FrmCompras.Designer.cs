namespace Sistema_Inventario.Formularios
{
    partial class FrmCompras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            OPDFoto = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            FormCompra = new TabPage();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            groupBox1 = new GroupBox();
            LblError = new Label();
            cmbProveedores = new ComboBox();
            label9 = new Label();
            rbExistente = new RadioButton();
            rbNuevo = new RadioButton();
            dtFecha = new DateTimePicker();
            label6 = new Label();
            lblnombreproducto = new Label();
            groupBox2 = new GroupBox();
            TxtProducto = new TextBox();
            label1 = new Label();
            CmbCategoria = new ComboBox();
            PbFoto = new PictureBox();
            lbltotalapagar = new Label();
            TxtCantidad = new TextBox();
            lblcantidad = new Label();
            TxtPrecio = new TextBox();
            btnimagen = new Button();
            TxtIdArticulo = new TextBox();
            lblproductos = new Label();
            lblprecio = new Label();
            TxtDescripcion = new TextBox();
            lBLIGV = new Label();
            CmbProductos = new ComboBox();
            BtnConfirmar = new Button();
            ListCompra = new TabPage();
            dataGridView1 = new DataGridView();
            ColumIdCompra = new DataGridViewTextBoxColumn();
            ColumnProveedor = new DataGridViewTextBoxColumn();
            ColumnIdArticulo = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            IdArticulo = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            rbNombre = new RadioButton();
            rbId = new RadioButton();
            txtBuscar = new TextBox();
            BtnEstado = new Button();
            BtnNuevo = new Button();
            BtnEditar = new Button();
            BtnReportes = new Button();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            FormCompra.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoto).BeginInit();
            ListCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // OPDFoto
            // 
            OPDFoto.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormCompra
            // 
            FormCompra.Controls.Add(BtnCancelar);
            FormCompra.Controls.Add(BtnGuardar);
            FormCompra.Controls.Add(groupBox1);
            FormCompra.Controls.Add(groupBox2);
            FormCompra.Controls.Add(BtnConfirmar);
            FormCompra.Location = new Point(4, 30);
            FormCompra.Name = "FormCompra";
            FormCompra.Padding = new Padding(3);
            FormCompra.Size = new Size(1215, 659);
            FormCompra.TabIndex = 1;
            FormCompra.Text = "Compra";
            FormCompra.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.None;
            BtnCancelar.BackColor = Color.Maroon;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(654, 518);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(153, 44);
            BtnCancelar.TabIndex = 14;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.None;
            BtnGuardar.BackColor = Color.FromArgb(0, 64, 64);
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(449, 518);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(153, 44);
            BtnGuardar.TabIndex = 13;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblError);
            groupBox1.Controls.Add(cmbProveedores);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(rbExistente);
            groupBox1.Controls.Add(rbNuevo);
            groupBox1.Controls.Add(dtFecha);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblnombreproducto);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(52, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1101, 143);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Datos";
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.ForeColor = Color.FromArgb(255, 128, 128);
            LblError.Location = new Point(760, 59);
            LblError.Name = "LblError";
            LblError.Size = new Size(28, 21);
            LblError.TabIndex = 32;
            LblError.Text = "......";
            LblError.Visible = false;
            // 
            // cmbProveedores
            // 
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(152, 48);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(257, 29);
            cmbProveedores.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(667, 93);
            label9.Name = "label9";
            label9.Size = new Size(76, 21);
            label9.TabIndex = 31;
            label9.Text = "Producto:";
            // 
            // rbExistente
            // 
            rbExistente.AutoSize = true;
            rbExistente.Location = new Point(857, 93);
            rbExistente.Margin = new Padding(3, 2, 3, 2);
            rbExistente.Name = "rbExistente";
            rbExistente.Size = new Size(89, 25);
            rbExistente.TabIndex = 4;
            rbExistente.TabStop = true;
            rbExistente.Text = "Existente";
            rbExistente.UseVisualStyleBackColor = true;
            rbExistente.CheckedChanged += rbExistente_CheckedChanged;
            // 
            // rbNuevo
            // 
            rbNuevo.AutoSize = true;
            rbNuevo.Location = new Point(760, 93);
            rbNuevo.Margin = new Padding(3, 2, 3, 2);
            rbNuevo.Name = "rbNuevo";
            rbNuevo.Size = new Size(74, 25);
            rbNuevo.TabIndex = 3;
            rbNuevo.TabStop = true;
            rbNuevo.Text = "Nuevo";
            rbNuevo.UseVisualStyleBackColor = true;
            rbNuevo.CheckedChanged += rbNuevo_CheckedChanged;
            // 
            // dtFecha
            // 
            dtFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(152, 87);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(429, 29);
            dtFecha.TabIndex = 2;
            dtFecha.Value = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 93);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 30;
            label6.Text = "Fecha Compra:";
            // 
            // lblnombreproducto
            // 
            lblnombreproducto.AutoSize = true;
            lblnombreproducto.Location = new Point(21, 51);
            lblnombreproducto.Name = "lblnombreproducto";
            lblnombreproducto.Size = new Size(85, 21);
            lblnombreproducto.TabIndex = 0;
            lblnombreproducto.Text = "Proveedor:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtProducto);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(CmbCategoria);
            groupBox2.Controls.Add(PbFoto);
            groupBox2.Controls.Add(lbltotalapagar);
            groupBox2.Controls.Add(TxtCantidad);
            groupBox2.Controls.Add(lblcantidad);
            groupBox2.Controls.Add(TxtPrecio);
            groupBox2.Controls.Add(btnimagen);
            groupBox2.Controls.Add(TxtIdArticulo);
            groupBox2.Controls.Add(lblproductos);
            groupBox2.Controls.Add(lblprecio);
            groupBox2.Controls.Add(TxtDescripcion);
            groupBox2.Controls.Add(lBLIGV);
            groupBox2.Controls.Add(CmbProductos);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(52, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 264);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles";
            // 
            // TxtProducto
            // 
            TxtProducto.Location = new Point(259, 66);
            TxtProducto.Name = "TxtProducto";
            TxtProducto.Size = new Size(415, 29);
            TxtProducto.TabIndex = 7;
            TxtProducto.TextChanged += TxtProducto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 42);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 41;
            label1.Text = "Id Producto:";
            // 
            // CmbCategoria
            // 
            CmbCategoria.FormattingEnabled = true;
            CmbCategoria.Location = new Point(417, 198);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(257, 29);
            CmbCategoria.TabIndex = 11;
            // 
            // PbFoto
            // 
            PbFoto.BorderStyle = BorderStyle.FixedSingle;
            PbFoto.Location = new Point(857, 42);
            PbFoto.Margin = new Padding(3, 2, 3, 2);
            PbFoto.Name = "PbFoto";
            PbFoto.Size = new Size(151, 135);
            PbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            PbFoto.TabIndex = 39;
            PbFoto.TabStop = false;
            // 
            // lbltotalapagar
            // 
            lbltotalapagar.AutoSize = true;
            lbltotalapagar.Location = new Point(417, 174);
            lbltotalapagar.Name = "lbltotalapagar";
            lbltotalapagar.Size = new Size(80, 21);
            lbltotalapagar.TabIndex = 3;
            lbltotalapagar.Text = "Categoria:";
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(239, 198);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(153, 29);
            TxtCantidad.TabIndex = 10;
            TxtCantidad.KeyPress += TxtCantidad_KeyPress;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(239, 174);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(75, 21);
            lblcantidad.TabIndex = 2;
            lblcantidad.Text = "Cantidad:";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(43, 198);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(158, 29);
            TxtPrecio.TabIndex = 9;
            TxtPrecio.TextChanged += TxtPrecio_TextChanged;
            TxtPrecio.KeyPress += TxtPrecio_KeyPress;
            // 
            // btnimagen
            // 
            btnimagen.BackColor = Color.FromArgb(10, 153, 246);
            btnimagen.FlatStyle = FlatStyle.Flat;
            btnimagen.ForeColor = Color.White;
            btnimagen.Location = new Point(857, 191);
            btnimagen.Margin = new Padding(3, 2, 3, 2);
            btnimagen.Name = "btnimagen";
            btnimagen.Size = new Size(151, 40);
            btnimagen.TabIndex = 12;
            btnimagen.Text = "Cargar Imagen";
            btnimagen.UseVisualStyleBackColor = false;
            btnimagen.Click += btnimagen_Click;
            // 
            // TxtIdArticulo
            // 
            TxtIdArticulo.BackColor = Color.White;
            TxtIdArticulo.Location = new Point(43, 66);
            TxtIdArticulo.Name = "TxtIdArticulo";
            TxtIdArticulo.ReadOnly = true;
            TxtIdArticulo.Size = new Size(202, 29);
            TxtIdArticulo.TabIndex = 6;
            // 
            // lblproductos
            // 
            lblproductos.AutoSize = true;
            lblproductos.Location = new Point(259, 42);
            lblproductos.Name = "lblproductos";
            lblproductos.Size = new Size(76, 21);
            lblproductos.TabIndex = 0;
            lblproductos.Text = "Producto:";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(43, 174);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(56, 21);
            lblprecio.TabIndex = 1;
            lblprecio.Text = "Precio:";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(43, 131);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(631, 29);
            TxtDescripcion.TabIndex = 8;
            // 
            // lBLIGV
            // 
            lBLIGV.AutoSize = true;
            lBLIGV.Location = new Point(43, 107);
            lBLIGV.Name = "lBLIGV";
            lBLIGV.Size = new Size(94, 21);
            lBLIGV.TabIndex = 1;
            lBLIGV.Text = "Descripcion:";
            // 
            // CmbProductos
            // 
            CmbProductos.FormattingEnabled = true;
            CmbProductos.Location = new Point(259, 66);
            CmbProductos.Name = "CmbProductos";
            CmbProductos.Size = new Size(415, 29);
            CmbProductos.TabIndex = 42;
            CmbProductos.SelectedIndexChanged += CmbProductos_SelectedIndexChanged;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Anchor = AnchorStyles.None;
            BtnConfirmar.BackColor = Color.FromArgb(0, 64, 64);
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.ForeColor = Color.White;
            BtnConfirmar.Location = new Point(449, 518);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(153, 44);
            BtnConfirmar.TabIndex = 20;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = false;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // ListCompra
            // 
            ListCompra.Controls.Add(dataGridView1);
            ListCompra.Controls.Add(groupBox3);
            ListCompra.Controls.Add(BtnEstado);
            ListCompra.Controls.Add(BtnNuevo);
            ListCompra.Controls.Add(BtnEditar);
            ListCompra.Controls.Add(BtnReportes);
            ListCompra.Location = new Point(4, 30);
            ListCompra.Name = "ListCompra";
            ListCompra.Padding = new Padding(3);
            ListCompra.Size = new Size(1215, 659);
            ListCompra.TabIndex = 0;
            ListCompra.Text = "Compras";
            ListCompra.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumIdCompra, ColumnProveedor, ColumnIdArticulo, ColumnCategoria, ColumnCantidad, Precio, ColumnEstado, ColumnFecha, IdArticulo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(234, 219, 240);
            dataGridView1.Location = new Point(68, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(910, 448);
            dataGridView1.TabIndex = 68;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // ColumIdCompra
            // 
            ColumIdCompra.HeaderText = "Id Compra";
            ColumIdCompra.Name = "ColumIdCompra";
            ColumIdCompra.ReadOnly = true;
            // 
            // ColumnProveedor
            // 
            ColumnProveedor.HeaderText = "Proveedor";
            ColumnProveedor.Name = "ColumnProveedor";
            ColumnProveedor.ReadOnly = true;
            // 
            // ColumnIdArticulo
            // 
            ColumnIdArticulo.HeaderText = "Articulo";
            ColumnIdArticulo.Name = "ColumnIdArticulo";
            ColumnIdArticulo.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.HeaderText = "Cantidad";
            ColumnCantidad.Name = "ColumnCantidad";
            ColumnCantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            ColumnEstado.HeaderText = "Estado";
            ColumnEstado.Name = "ColumnEstado";
            ColumnEstado.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "Fecha";
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.ReadOnly = true;
            // 
            // IdArticulo
            // 
            IdArticulo.HeaderText = "IdArticulo";
            IdArticulo.Name = "IdArticulo";
            IdArticulo.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(rbNombre);
            groupBox3.Controls.Add(rbId);
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Location = new Point(68, 33);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(910, 80);
            groupBox3.TabIndex = 67;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar por:";
            // 
            // rbNombre
            // 
            rbNombre.AutoSize = true;
            rbNombre.Location = new Point(469, 33);
            rbNombre.Name = "rbNombre";
            rbNombre.Size = new Size(82, 25);
            rbNombre.TabIndex = 31;
            rbNombre.TabStop = true;
            rbNombre.Text = "Articulo";
            rbNombre.UseVisualStyleBackColor = true;
            rbNombre.CheckedChanged += rbNombre_CheckedChanged;
            // 
            // rbId
            // 
            rbId.AutoSize = true;
            rbId.Location = new Point(320, 33);
            rbId.Name = "rbId";
            rbId.Size = new Size(100, 25);
            rbId.TabIndex = 30;
            rbId.TabStop = true;
            rbId.Text = "Proveedor";
            rbId.UseVisualStyleBackColor = true;
            rbId.CheckedChanged += rbId_CheckedChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(6, 30);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.MaxLength = 20;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(270, 29);
            txtBuscar.TabIndex = 12;
            // 
            // BtnEstado
            // 
            BtnEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEstado.BackColor = Color.Maroon;
            BtnEstado.FlatStyle = FlatStyle.Flat;
            BtnEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEstado.ForeColor = SystemColors.ButtonHighlight;
            BtnEstado.Location = new Point(1015, 279);
            BtnEstado.Name = "BtnEstado";
            BtnEstado.Size = new Size(168, 49);
            BtnEstado.TabIndex = 65;
            BtnEstado.Text = "Estado";
            BtnEstado.UseVisualStyleBackColor = false;
            BtnEstado.Click += BtnEstado_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNuevo.BackColor = Color.Green;
            BtnNuevo.FlatStyle = FlatStyle.Flat;
            BtnNuevo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNuevo.ForeColor = SystemColors.ButtonHighlight;
            BtnNuevo.Location = new Point(1015, 157);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(168, 49);
            BtnNuevo.TabIndex = 63;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditar.BackColor = Color.Teal;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEditar.ForeColor = SystemColors.ButtonHighlight;
            BtnEditar.Location = new Point(1015, 218);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(168, 49);
            BtnEditar.TabIndex = 64;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnReportes.BackColor = Color.FromArgb(38, 56, 78);
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnReportes.ForeColor = Color.White;
            BtnReportes.Image = (Image)resources.GetObject("BtnReportes.Image");
            BtnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReportes.Location = new Point(1015, 344);
            BtnReportes.Margin = new Padding(3, 2, 3, 2);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(168, 50);
            BtnReportes.TabIndex = 62;
            BtnReportes.Text = "    Reporte ";
            BtnReportes.UseVisualStyleBackColor = false;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ListCompra);
            tabControl1.Controls.Add(FormCompra);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1223, 693);
            tabControl1.TabIndex = 20;
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1223, 693);
            Controls.Add(tabControl1);
            Name = "FrmCompras";
            Text = "Compras";
            Load += FrmCompras_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            FormCompra.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoto).EndInit();
            ListCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog OPDFoto;
        private ErrorProvider errorProvider1;
        private TabControl tabControl1;
        private TabPage ListCompra;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private RadioButton rbNombre;
        private RadioButton rbId;
        private TextBox txtBuscar;
        private Button BtnEstado;
        private Button BtnNuevo;
        private Button BtnEditar;
        private Button BtnReportes;
        private TabPage FormCompra;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private GroupBox groupBox1;
        private Label LblError;
        private ComboBox cmbProveedores;
        private Label label9;
        private RadioButton rbExistente;
        private RadioButton rbNuevo;
        private DateTimePicker dtFecha;
        private Label label6;
        private Label lblnombreproducto;
        private GroupBox groupBox2;
        private TextBox TxtProducto;
        private Label label1;
        private ComboBox CmbCategoria;
        private PictureBox PbFoto;
        private Label lbltotalapagar;
        private TextBox TxtCantidad;
        private Label lblcantidad;
        private TextBox TxtPrecio;
        private Button btnimagen;
        private TextBox TxtIdArticulo;
        private Label lblproductos;
        private Label lblprecio;
        private TextBox TxtDescripcion;
        private Label lBLIGV;
        private ComboBox CmbProductos;
        private Button BtnConfirmar;
        private DataGridViewTextBoxColumn ColumIdCompra;
        private DataGridViewTextBoxColumn ColumnProveedor;
        private DataGridViewTextBoxColumn ColumnIdArticulo;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnCantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn ColumnEstado;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn IdArticulo;
    }
}