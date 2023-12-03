namespace Sistema_Inventario.Formularios
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TxtBuscar = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabpageListUsuario = new TabPage();
            BtnBuscar = new Button();
            BtnEstado = new Button();
            BtnEditar = new Button();
            BtnNuevo = new Button();
            dgvUsuario = new DataGridView();
            tabPageFormUsuarios = new TabPage();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            groupBox1 = new GroupBox();
            gboxEstados = new GroupBox();
            rbInactivo = new RadioButton();
            rbActivo = new RadioButton();
            cmbRol = new ComboBox();
            label5 = new Label();
            txtcontraseña = new TextBox();
            label8 = new Label();
            label3 = new Label();
            txtuser = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabpageListUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            tabPageFormUsuarios.SuspendLayout();
            groupBox1.SuspendLayout();
            gboxEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBuscar.Location = new Point(203, 65);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(363, 29);
            TxtBuscar.TabIndex = 23;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(40, 68);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 23;
            label1.Text = "Nombre de Usuario:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabpageListUsuario);
            tabControl1.Controls.Add(tabPageFormUsuarios);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(20, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1223, 745);
            tabControl1.TabIndex = 24;
            // 
            // tabpageListUsuario
            // 
            tabpageListUsuario.Controls.Add(BtnBuscar);
            tabpageListUsuario.Controls.Add(BtnEstado);
            tabpageListUsuario.Controls.Add(BtnEditar);
            tabpageListUsuario.Controls.Add(BtnNuevo);
            tabpageListUsuario.Controls.Add(dgvUsuario);
            tabpageListUsuario.Controls.Add(label1);
            tabpageListUsuario.Controls.Add(TxtBuscar);
            tabpageListUsuario.ForeColor = SystemColors.ButtonHighlight;
            tabpageListUsuario.Location = new Point(4, 30);
            tabpageListUsuario.Name = "tabpageListUsuario";
            tabpageListUsuario.Padding = new Padding(3);
            tabpageListUsuario.Size = new Size(1215, 711);
            tabpageListUsuario.TabIndex = 0;
            tabpageListUsuario.Text = "Lista de Usuarios";
            tabpageListUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.FromArgb(255, 128, 0);
            BtnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Image = (Image)resources.GetObject("BtnBuscar.Image");
            BtnBuscar.Location = new Point(590, 57);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(184, 43);
            BtnBuscar.TabIndex = 27;
            BtnBuscar.Text = "   Buscar";
            BtnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnEstado
            // 
            BtnEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEstado.BackColor = Color.Firebrick;
            BtnEstado.FlatStyle = FlatStyle.Flat;
            BtnEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEstado.ForeColor = SystemColors.ButtonHighlight;
            BtnEstado.Location = new Point(1003, 239);
            BtnEstado.Name = "BtnEstado";
            BtnEstado.Size = new Size(168, 46);
            BtnEstado.TabIndex = 26;
            BtnEstado.Text = "Estado";
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
            BtnEditar.Location = new Point(1003, 178);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(168, 46);
            BtnEditar.TabIndex = 25;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNuevo.BackColor = Color.Green;
            BtnNuevo.FlatStyle = FlatStyle.Flat;
            BtnNuevo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNuevo.ForeColor = SystemColors.ButtonHighlight;
            BtnNuevo.Location = new Point(1003, 117);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(168, 46);
            BtnNuevo.TabIndex = 24;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.BackgroundColor = Color.White;
            dgvUsuario.BorderStyle = BorderStyle.None;
            dgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuario.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuario.EnableHeadersVisualStyles = false;
            dgvUsuario.GridColor = Color.FromArgb(234, 219, 240);
            dgvUsuario.Location = new Point(40, 136);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(923, 526);
            dgvUsuario.TabIndex = 11;
            dgvUsuario.Click += dgvUsuario_Click;
            // 
            // tabPageFormUsuarios
            // 
            tabPageFormUsuarios.Controls.Add(BtnConfirmar);
            tabPageFormUsuarios.Controls.Add(BtnCancelar);
            tabPageFormUsuarios.Controls.Add(BtnGuardar);
            tabPageFormUsuarios.Controls.Add(groupBox1);
            tabPageFormUsuarios.Location = new Point(4, 30);
            tabPageFormUsuarios.Name = "tabPageFormUsuarios";
            tabPageFormUsuarios.Padding = new Padding(3);
            tabPageFormUsuarios.Size = new Size(1215, 711);
            tabPageFormUsuarios.TabIndex = 1;
            tabPageFormUsuarios.Text = "Formulario Usuario";
            tabPageFormUsuarios.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.BackColor = Color.FromArgb(0, 64, 64);
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.ForeColor = Color.White;
            BtnConfirmar.Location = new Point(424, 410);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(153, 44);
            BtnConfirmar.TabIndex = 7;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = false;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Maroon;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(629, 410);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(153, 44);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(0, 64, 64);
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(424, 410);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(153, 44);
            BtnGuardar.TabIndex = 5;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(gboxEstados);
            groupBox1.Controls.Add(cmbRol);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtcontraseña);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtuser);
            groupBox1.Location = new Point(58, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1094, 271);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // gboxEstados
            // 
            gboxEstados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gboxEstados.Controls.Add(rbInactivo);
            gboxEstados.Controls.Add(rbActivo);
            gboxEstados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gboxEstados.Location = new Point(818, 43);
            gboxEstados.Name = "gboxEstados";
            gboxEstados.Size = new Size(217, 178);
            gboxEstados.TabIndex = 23;
            gboxEstados.TabStop = false;
            gboxEstados.Text = "Estado";
            // 
            // rbInactivo
            // 
            rbInactivo.AutoSize = true;
            rbInactivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbInactivo.Location = new Point(45, 89);
            rbInactivo.Margin = new Padding(3, 2, 3, 2);
            rbInactivo.Name = "rbInactivo";
            rbInactivo.Size = new Size(86, 25);
            rbInactivo.TabIndex = 21;
            rbInactivo.TabStop = true;
            rbInactivo.Text = "Inactivo";
            rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            rbActivo.AutoSize = true;
            rbActivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbActivo.Location = new Point(45, 48);
            rbActivo.Margin = new Padding(3, 2, 3, 2);
            rbActivo.Name = "rbActivo";
            rbActivo.Size = new Size(75, 25);
            rbActivo.TabIndex = 20;
            rbActivo.TabStop = true;
            rbActivo.Text = "Activo";
            rbActivo.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "" });
            cmbRol.Location = new Point(139, 145);
            cmbRol.Margin = new Padding(3, 2, 3, 2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(439, 29);
            cmbRol.TabIndex = 19;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 151);
            label5.Name = "label5";
            label5.Size = new Size(38, 21);
            label5.TabIndex = 18;
            label5.Text = "Rol:";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(139, 95);
            txtcontraseña.Margin = new Padding(3, 2, 3, 2);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(439, 29);
            txtcontraseña.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(26, 101);
            label8.Name = "label8";
            label8.Size = new Size(96, 21);
            label8.TabIndex = 17;
            label8.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 46);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 14;
            label3.Text = "Usuario:";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(139, 43);
            txtuser.Margin = new Padding(3, 2, 3, 2);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(439, 29);
            txtuser.TabIndex = 15;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1223, 745);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmUsuario";
            Text = "Usuarios";
            Load += FrmUsuario_Load;
            tabControl1.ResumeLayout(false);
            tabpageListUsuario.ResumeLayout(false);
            tabpageListUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            tabPageFormUsuarios.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gboxEstados.ResumeLayout(false);
            gboxEstados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TxtBuscar;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabpageListUsuario;
        private Button BtnEstado;
        private Button BtnEditar;
        private Button BtnNuevo;
        private DataGridView dgvUsuario;
        private TabPage tabPageFormUsuarios;
        private GroupBox groupBox1;
        private ComboBox cmbRol;
        private Label label5;
        private TextBox txtcontraseña;
        private Label label8;
        private Label label3;
        private TextBox txtuser;
        private Button BtnBuscar;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private ErrorProvider errorProvider1;
        private Button BtnConfirmar;
        private GroupBox gboxEstados;
        private RadioButton rbInactivo;
        private RadioButton rbActivo;
    }
}