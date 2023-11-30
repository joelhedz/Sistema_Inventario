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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            tabControl1 = new TabControl();
            FormProducto = new TabPage();
            groupBox3 = new GroupBox();
            radioButton1 = new RadioButton();
            rbNombre = new RadioButton();
            rbId = new RadioButton();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            BtnEstado = new Button();
            BtnEditar = new Button();
            button2 = new Button();
            ListProductos = new TabPage();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            groupBox1 = new GroupBox();
            PbFoto = new PictureBox();
            btnimagen = new Button();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            tabControl1.SuspendLayout();
            FormProducto.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ListProductos.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoto).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(FormProducto);
            tabControl1.Controls.Add(ListProductos);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1223, 693);
            tabControl1.TabIndex = 22;
            // 
            // FormProducto
            // 
            FormProducto.Controls.Add(button1);
            FormProducto.Controls.Add(groupBox3);
            FormProducto.Controls.Add(dataGridView1);
            FormProducto.Controls.Add(BtnEstado);
            FormProducto.Controls.Add(BtnEditar);
            FormProducto.Controls.Add(button2);
            FormProducto.Location = new Point(4, 24);
            FormProducto.Name = "FormProducto";
            FormProducto.Padding = new Padding(3);
            FormProducto.Size = new Size(1215, 665);
            FormProducto.TabIndex = 0;
            FormProducto.Text = "Productos";
            FormProducto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(radioButton1);
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
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(549, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 25);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "Precio";
            radioButton1.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(64, 0, 64);
            dataGridView1.Location = new Point(50, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(910, 455);
            dataGridView1.TabIndex = 72;
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
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(38, 56, 78);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1005, 362);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(168, 50);
            button2.TabIndex = 68;
            button2.Text = "    Reporte ";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // ListProductos
            // 
            ListProductos.Controls.Add(BtnCancelar);
            ListProductos.Controls.Add(BtnGuardar);
            ListProductos.Controls.Add(groupBox1);
            ListProductos.Location = new Point(4, 24);
            ListProductos.Name = "ListProductos";
            ListProductos.Padding = new Padding(3);
            ListProductos.Size = new Size(1215, 665);
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
            BtnCancelar.Location = new Point(627, 427);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(169, 44);
            BtnCancelar.TabIndex = 38;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.None;
            BtnGuardar.BackColor = Color.FromArgb(0, 64, 64);
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(422, 427);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(169, 44);
            BtnGuardar.TabIndex = 37;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PbFoto);
            groupBox1.Controls.Add(btnimagen);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(157, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(480, 29);
            comboBox1.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(157, 45);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(480, 29);
            textBox6.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 91);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(480, 29);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(480, 29);
            textBox3.TabIndex = 11;
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1005, 293);
            button1.Name = "button1";
            button1.Size = new Size(168, 49);
            button1.TabIndex = 74;
            button1.Text = "Suspender";
            button1.UseVisualStyleBackColor = false;
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ListProductos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage FormProducto;
        private TabPage ListProductos;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox PbFoto;
        private Button btnimagen;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton rbNombre;
        private RadioButton rbId;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button BtnEstado;
        private Button BtnEditar;
        private Button button2;
        private Button button1;
    }
}