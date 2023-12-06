namespace Sistema_Inventario.Formularios
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            tabControl1 = new TabControl();
            FormProducto = new TabPage();
            dataGridView1 = new DataGridView();
            BtnEliminar = new Button();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            rbNombre = new RadioButton();
            rbId = new RadioButton();
            textBox1 = new TextBox();
            BtnEstado = new Button();
            BtnEditar = new Button();
            BtnReporte = new Button();
            ListProductos = new TabPage();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            groupBox1 = new GroupBox();
            PbFoto = new PictureBox();
            btnimagen = new Button();
            CmbCategorias = new ComboBox();
            txtNombreArticulo = new TextBox();
            TxtPrecioVenta = new TextBox();
            TxtDescripcion = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            FormProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ListProductos.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(FormProducto);
            tabControl1.Controls.Add(ListProductos);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1223, 693);
            tabControl1.TabIndex = 22;
            // 
            // FormProducto
            // 
            FormProducto.Controls.Add(dataGridView1);
            FormProducto.Controls.Add(BtnEliminar);
            FormProducto.Controls.Add(groupBox3);
            FormProducto.Controls.Add(BtnEstado);
            FormProducto.Controls.Add(BtnEditar);
            FormProducto.Controls.Add(BtnReporte);
            FormProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormProducto.Location = new Point(4, 30);
            FormProducto.Name = "FormProducto";
            FormProducto.Padding = new Padding(3);
            FormProducto.Size = new Size(1215, 659);
            FormProducto.TabIndex = 0;
            FormProducto.Text = "Productos";
            FormProducto.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(234, 219, 240);
            dataGridView1.Location = new Point(50, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(910, 449);
            dataGridView1.TabIndex = 75;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminar.BackColor = Color.Maroon;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEliminar.ForeColor = SystemColors.ButtonHighlight;
            BtnEliminar.Location = new Point(1005, 293);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(168, 49);
            BtnEliminar.TabIndex = 74;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(rbNombre);
            groupBox3.Controls.Add(rbId);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(50, 55);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(910, 80);
            groupBox3.TabIndex = 73;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar por:";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 29);
            comboBox1.TabIndex = 76;
            // 
            // rbNombre
            // 
            rbNombre.AutoSize = true;
            rbNombre.Location = new Point(433, 32);
            rbNombre.Name = "rbNombre";
            rbNombre.Size = new Size(95, 25);
            rbNombre.TabIndex = 31;
            rbNombre.TabStop = true;
            rbNombre.Text = "Categoria";
            rbNombre.UseVisualStyleBackColor = true;
            rbNombre.CheckedChanged += rbNombre_CheckedChanged;
            // 
            // rbId
            // 
            rbId.AutoSize = true;
            rbId.Location = new Point(330, 32);
            rbId.Name = "rbId";
            rbId.Size = new Size(86, 25);
            rbId.TabIndex = 30;
            rbId.TabStop = true;
            rbId.Text = "Nombre";
            rbId.UseVisualStyleBackColor = true;
            rbId.CheckedChanged += rbId_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 30);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 29);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BtnEstado
            // 
            BtnEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEstado.BackColor = Color.Maroon;
            BtnEstado.FlatStyle = FlatStyle.Flat;
            BtnEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEstado.ForeColor = SystemColors.ButtonHighlight;
            BtnEstado.Location = new Point(1005, 223);
            BtnEstado.Name = "BtnEstado";
            BtnEstado.Size = new Size(168, 49);
            BtnEstado.TabIndex = 71;
            BtnEstado.Text = "Activar";
            BtnEstado.UseVisualStyleBackColor = false;
            BtnEstado.Click += BtnEstado_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditar.BackColor = Color.Teal;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEditar.ForeColor = SystemColors.ButtonHighlight;
            BtnEditar.Location = new Point(1005, 155);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(168, 49);
            BtnEditar.TabIndex = 70;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnReporte
            // 
            BtnReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnReporte.BackColor = Color.FromArgb(38, 56, 78);
            BtnReporte.FlatStyle = FlatStyle.Flat;
            BtnReporte.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnReporte.ForeColor = Color.White;
            BtnReporte.Image = (Image)resources.GetObject("BtnReporte.Image");
            BtnReporte.Location = new Point(1005, 362);
            BtnReporte.Margin = new Padding(3, 2, 3, 2);
            BtnReporte.Name = "BtnReporte";
            BtnReporte.Size = new Size(168, 50);
            BtnReporte.TabIndex = 68;
            BtnReporte.Text = "    Reporte ";
            BtnReporte.TextAlign = ContentAlignment.MiddleLeft;
            BtnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReporte.UseVisualStyleBackColor = false;
            // 
            // ListProductos
            // 
            ListProductos.Controls.Add(BtnCancelar);
            ListProductos.Controls.Add(BtnGuardar);
            ListProductos.Controls.Add(groupBox1);
            ListProductos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListProductos.Location = new Point(4, 30);
            ListProductos.Name = "ListProductos";
            ListProductos.Padding = new Padding(3);
            ListProductos.Size = new Size(1215, 659);
            ListProductos.TabIndex = 1;
            ListProductos.Text = "Producto";
            ListProductos.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.None;
            BtnCancelar.BackColor = Color.Maroon;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(627, 424);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(169, 44);
            BtnCancelar.TabIndex = 38;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.None;
            BtnGuardar.BackColor = Color.FromArgb(0, 64, 64);
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(422, 424);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(169, 44);
            BtnGuardar.TabIndex = 37;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PbFoto);
            groupBox1.Controls.Add(btnimagen);
            groupBox1.Controls.Add(CmbCategorias);
            groupBox1.Controls.Add(txtNombreArticulo);
            groupBox1.Controls.Add(TxtPrecioVenta);
            groupBox1.Controls.Add(TxtDescripcion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(71, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1070, 270);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Productos";
            // 
            // PbFoto
            // 
            PbFoto.BorderStyle = BorderStyle.FixedSingle;
            PbFoto.Location = new Point(840, 45);
            PbFoto.Margin = new Padding(3, 2, 3, 2);
            PbFoto.Name = "PbFoto";
            PbFoto.Size = new Size(151, 135);
            PbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            PbFoto.TabIndex = 41;
            PbFoto.TabStop = false;
            // 
            // btnimagen
            // 
            btnimagen.BackColor = Color.FromArgb(10, 153, 246);
            btnimagen.FlatStyle = FlatStyle.Flat;
            btnimagen.ForeColor = Color.White;
            btnimagen.Location = new Point(840, 194);
            btnimagen.Margin = new Padding(3, 2, 3, 2);
            btnimagen.Name = "btnimagen";
            btnimagen.Size = new Size(151, 40);
            btnimagen.TabIndex = 40;
            btnimagen.Text = "Cargar Imagen";
            btnimagen.UseVisualStyleBackColor = false;
            // 
            // CmbCategorias
            // 
            CmbCategorias.FormattingEnabled = true;
            CmbCategorias.Location = new Point(157, 194);
            CmbCategorias.Name = "CmbCategorias";
            CmbCategorias.Size = new Size(480, 29);
            CmbCategorias.TabIndex = 15;
            // 
            // txtNombreArticulo
            // 
            txtNombreArticulo.Location = new Point(157, 45);
            txtNombreArticulo.Name = "txtNombreArticulo";
            txtNombreArticulo.Size = new Size(480, 29);
            txtNombreArticulo.TabIndex = 14;
            // 
            // TxtPrecioVenta
            // 
            TxtPrecioVenta.Location = new Point(157, 91);
            TxtPrecioVenta.Name = "TxtPrecioVenta";
            TxtPrecioVenta.Size = new Size(480, 29);
            TxtPrecioVenta.TabIndex = 12;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(157, 137);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(480, 29);
            TxtDescripcion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 192);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 7;
            label6.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 136);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 5;
            label4.Text = "Descripcion ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 94);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 4;
            label3.Text = "Precio Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 48);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 3;
            label2.Text = "Nombre Articulo";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 693);
            Controls.Add(tabControl1);
            Name = "FrmProductos";
            Text = "Productos";
            Load += FrmProductos_Load;
            tabControl1.ResumeLayout(false);
            FormProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ListProductos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage FormProducto;
        private TabPage ListProductos;
        private GroupBox groupBox1;
        private ComboBox CmbCategorias;
        private TextBox txtNombreArticulo;
        private TextBox TxtPrecioVenta;
        private TextBox TxtDescripcion;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox PbFoto;
        private Button btnimagen;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private GroupBox groupBox3;
        private RadioButton rbNombre;
        private RadioButton rbId;
        private TextBox textBox1;
        private Button BtnEstado;
        private Button BtnEditar;
        private Button BtnReporte;
        private Button BtnEliminar;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private ComboBox comboBox1;
    }
}