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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabpageListUsuario = new TabPage();
            BtnBuscar = new Button();
            BtnEstado = new Button();
            BtnEditar = new Button();
            BtnNuevo = new Button();
            dataGridView1 = new DataGridView();
            tabPageFormUsuarios = new TabPage();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            groupBox1 = new GroupBox();
            rbSuspendido = new RadioButton();
            rbActivo = new RadioButton();
            label9 = new Label();
            cmbRol = new ComboBox();
            label5 = new Label();
            txtcontraseña = new TextBox();
            label8 = new Label();
            label3 = new Label();
            txtuser = new TextBox();
            tabControl1.SuspendLayout();
            tabpageListUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageFormUsuarios.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(203, 65);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 29);
            textBox1.TabIndex = 23;
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
            tabpageListUsuario.Controls.Add(dataGridView1);
            tabpageListUsuario.Controls.Add(label1);
            tabpageListUsuario.Controls.Add(textBox1);
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
            BtnEstado.Text = "button3";
            BtnEstado.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(234, 219, 240);
            dataGridView1.Location = new Point(40, 136);
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
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(923, 526);
            dataGridView1.TabIndex = 11;
            // 
            // tabPageFormUsuarios
            // 
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
            BtnGuardar.Text = "Confirmar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSuspendido);
            groupBox1.Controls.Add(rbActivo);
            groupBox1.Controls.Add(label9);
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
            // rbSuspendido
            // 
            rbSuspendido.AutoSize = true;
            rbSuspendido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbSuspendido.Location = new Point(804, 120);
            rbSuspendido.Margin = new Padding(3, 2, 3, 2);
            rbSuspendido.Name = "rbSuspendido";
            rbSuspendido.Size = new Size(115, 25);
            rbSuspendido.TabIndex = 21;
            rbSuspendido.TabStop = true;
            rbSuspendido.Text = "Suspendido";
            rbSuspendido.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            rbActivo.AutoSize = true;
            rbActivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbActivo.Location = new Point(804, 79);
            rbActivo.Margin = new Padding(3, 2, 3, 2);
            rbActivo.Name = "rbActivo";
            rbActivo.Size = new Size(75, 25);
            rbActivo.TabIndex = 20;
            rbActivo.TabStop = true;
            rbActivo.Text = "Activo";
            rbActivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(804, 43);
            label9.Name = "label9";
            label9.Size = new Size(63, 21);
            label9.TabIndex = 22;
            label9.Text = "Estado:";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "", "Basico", "Avanzado", "Administrador", "Desarrollador" });
            cmbRol.Location = new Point(139, 145);
            cmbRol.Margin = new Padding(3, 2, 3, 2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(439, 29);
            cmbRol.TabIndex = 19;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageFormUsuarios.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabpageListUsuario;
        private Button BtnEstado;
        private Button BtnEditar;
        private Button BtnNuevo;
        private DataGridView dataGridView1;
        private TabPage tabPageFormUsuarios;
        private GroupBox groupBox1;
        private RadioButton rbSuspendido;
        private RadioButton rbActivo;
        private Label label9;
        private ComboBox cmbRol;
        private Label label5;
        private TextBox txtcontraseña;
        private Label label8;
        private Label label3;
        private TextBox txtuser;
        private Button BtnBuscar;
        private Button BtnCancelar;
        private Button BtnGuardar;
    }
}