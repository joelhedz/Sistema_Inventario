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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblnombreproducto = new Label();
            lblprecio = new Label();
            lblcantidad = new Label();
            lbltotalapagar = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label9 = new Label();
            rbExistente = new RadioButton();
            rbNuevo = new RadioButton();
            dtFecha = new DateTimePicker();
            label6 = new Label();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            PbFoto = new PictureBox();
            btnimagen = new Button();
            textBox7 = new TextBox();
            lblproductos = new Label();
            textBox8 = new TextBox();
            lBLIGV = new Label();
            tabControl1 = new TabControl();
            ListCompra = new TabPage();
            groupBox3 = new GroupBox();
            rbNombre = new RadioButton();
            rbId = new RadioButton();
            textBox1 = new TextBox();
            BtnEstado = new Button();
            BtnNuevo = new Button();
            BtnEditar = new Button();
            button2 = new Button();
            FormCompra = new TabPage();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoto).BeginInit();
            tabControl1.SuspendLayout();
            ListCompra.SuspendLayout();
            groupBox3.SuspendLayout();
            FormCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(43, 174);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(56, 21);
            lblprecio.TabIndex = 1;
            lblprecio.Text = "Precio:";
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
            // lbltotalapagar
            // 
            lbltotalapagar.AutoSize = true;
            lbltotalapagar.Location = new Point(417, 174);
            lbltotalapagar.Name = "lbltotalapagar";
            lbltotalapagar.Size = new Size(80, 21);
            lbltotalapagar.TabIndex = 3;
            lbltotalapagar.Text = "Categoria:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 29);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 29);
            textBox3.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(152, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(257, 29);
            comboBox2.TabIndex = 43;
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
            rbExistente.TabIndex = 29;
            rbExistente.TabStop = true;
            rbExistente.Text = "Existente";
            rbExistente.UseVisualStyleBackColor = true;
            // 
            // rbNuevo
            // 
            rbNuevo.AutoSize = true;
            rbNuevo.Location = new Point(760, 93);
            rbNuevo.Margin = new Padding(3, 2, 3, 2);
            rbNuevo.Name = "rbNuevo";
            rbNuevo.Size = new Size(74, 25);
            rbNuevo.TabIndex = 28;
            rbNuevo.TabStop = true;
            rbNuevo.Text = "Nuevo";
            rbNuevo.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            dtFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(152, 87);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(429, 29);
            dtFecha.TabIndex = 27;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(PbFoto);
            groupBox2.Controls.Add(lbltotalapagar);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(lblcantidad);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(btnimagen);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(lblproductos);
            groupBox2.Controls.Add(lblprecio);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(lBLIGV);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(52, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 264);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(259, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(415, 29);
            textBox4.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 42);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 41;
            label1.Text = "Id Articulo:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(417, 198);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 29);
            comboBox1.TabIndex = 40;
            // 
            // PbFoto
            // 
            PbFoto.BorderStyle = BorderStyle.FixedSingle;
            PbFoto.Location = new Point(795, 27);
            PbFoto.Margin = new Padding(3, 2, 3, 2);
            PbFoto.Name = "PbFoto";
            PbFoto.Size = new Size(151, 135);
            PbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            PbFoto.TabIndex = 39;
            PbFoto.TabStop = false;
            // 
            // btnimagen
            // 
            btnimagen.BackColor = Color.FromArgb(10, 153, 246);
            btnimagen.FlatStyle = FlatStyle.Flat;
            btnimagen.ForeColor = Color.White;
            btnimagen.Location = new Point(795, 176);
            btnimagen.Margin = new Padding(3, 2, 3, 2);
            btnimagen.Name = "btnimagen";
            btnimagen.Size = new Size(151, 40);
            btnimagen.TabIndex = 38;
            btnimagen.Text = "Cargar Imagen";
            btnimagen.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(43, 66);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(202, 29);
            textBox7.TabIndex = 6;
            // 
            // lblproductos
            // 
            lblproductos.AutoSize = true;
            lblproductos.Location = new Point(259, 42);
            lblproductos.Name = "lblproductos";
            lblproductos.Size = new Size(87, 21);
            lblproductos.TabIndex = 0;
            lblproductos.Text = " Productos:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(43, 131);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(631, 29);
            textBox8.TabIndex = 7;
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
            // ListCompra
            // 
            ListCompra.Controls.Add(dataGridView1);
            ListCompra.Controls.Add(groupBox3);
            ListCompra.Controls.Add(BtnEstado);
            ListCompra.Controls.Add(BtnNuevo);
            ListCompra.Controls.Add(BtnEditar);
            ListCompra.Controls.Add(button2);
            ListCompra.Location = new Point(4, 30);
            ListCompra.Name = "ListCompra";
            ListCompra.Padding = new Padding(3);
            ListCompra.Size = new Size(1215, 659);
            ListCompra.TabIndex = 0;
            ListCompra.Text = "Compras";
            ListCompra.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(rbNombre);
            groupBox3.Controls.Add(rbId);
            groupBox3.Controls.Add(textBox1);
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 30);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 29);
            textBox1.TabIndex = 12;
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
            BtnEstado.Text = "button3";
            BtnEstado.UseVisualStyleBackColor = false;
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
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(38, 56, 78);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1015, 344);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(168, 50);
            button2.TabIndex = 62;
            button2.Text = "    Reporte ";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormCompra
            // 
            FormCompra.Controls.Add(BtnCancelar);
            FormCompra.Controls.Add(BtnGuardar);
            FormCompra.Controls.Add(groupBox1);
            FormCompra.Controls.Add(groupBox2);
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
            BtnCancelar.TabIndex = 36;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
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
            BtnGuardar.TabIndex = 35;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
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
            dataGridView1.Location = new Point(68, 157);
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
            dataGridView1.Size = new Size(910, 448);
            dataGridView1.TabIndex = 68;
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1223, 693);
            Controls.Add(tabControl1);
            Name = "FrmCompras";
            Text = "Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoto).EndInit();
            tabControl1.ResumeLayout(false);
            ListCompra.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            FormCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblnombreproducto;
        private Label lblprecio;
        private Label lblcantidad;
        private Label lbltotalapagar;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox7;
        private Label lblproductos;
        private TextBox textBox8;
        private Label lBLIGV;
        private TabControl tabControl1;
        private TabPage ListCompra;
        private TabPage FormCompra;
        private Button BtnEstado;
        private Button BtnNuevo;
        private Button BtnEditar;
        private Button button2;
        private PictureBox PbFoto;
        private Button btnimagen;
        private Label label9;
        private RadioButton rbExistente;
        private RadioButton rbNuevo;
        private DateTimePicker dtFecha;
        private Label label6;
        private TextBox textBox4;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox3;
        private RadioButton rbNombre;
        private RadioButton rbId;
        private TextBox textBox1;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private DataGridView dataGridView1;
    }
}