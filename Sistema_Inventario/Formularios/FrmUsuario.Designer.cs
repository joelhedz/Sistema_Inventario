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
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(104, 50);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 29);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 58);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 23;
            label1.Text = "Buscar";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabpageListUsuario);
            tabControl1.Controls.Add(tabPageFormUsuarios);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(905, 548);
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
            tabpageListUsuario.Location = new Point(4, 24);
            tabpageListUsuario.Name = "tabpageListUsuario";
            tabpageListUsuario.Padding = new Padding(3);
            tabpageListUsuario.Size = new Size(897, 520);
            tabpageListUsuario.TabIndex = 0;
            tabpageListUsuario.Text = "Lista de Usuarios";
            tabpageListUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Image = (Image)resources.GetObject("BtnBuscar.Image");
            BtnBuscar.Location = new Point(486, 46);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(160, 38);
            BtnBuscar.TabIndex = 27;
            BtnBuscar.Text = "   Buscar";
            BtnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnEstado
            // 
            BtnEstado.Location = new Point(758, 228);
            BtnEstado.Name = "BtnEstado";
            BtnEstado.Size = new Size(114, 40);
            BtnEstado.TabIndex = 26;
            BtnEstado.Text = "button3";
            BtnEstado.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(758, 179);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(114, 40);
            BtnEditar.TabIndex = 25;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(758, 130);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(114, 40);
            BtnNuevo.TabIndex = 24;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(698, 379);
            dataGridView1.TabIndex = 11;
            // 
            // tabPageFormUsuarios
            // 
            tabPageFormUsuarios.Controls.Add(BtnCancelar);
            tabPageFormUsuarios.Controls.Add(BtnGuardar);
            tabPageFormUsuarios.Controls.Add(groupBox1);
            tabPageFormUsuarios.Location = new Point(4, 24);
            tabPageFormUsuarios.Name = "tabPageFormUsuarios";
            tabPageFormUsuarios.Padding = new Padding(3);
            tabPageFormUsuarios.Size = new Size(897, 520);
            tabPageFormUsuarios.TabIndex = 1;
            tabPageFormUsuarios.Text = "Formulario Usuario";
            tabPageFormUsuarios.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(483, 320);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(113, 35);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(310, 320);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(113, 35);
            BtnGuardar.TabIndex = 5;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(39, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 208);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // rbSuspendido
            // 
            rbSuspendido.AutoSize = true;
            rbSuspendido.Location = new Point(568, 108);
            rbSuspendido.Margin = new Padding(3, 2, 3, 2);
            rbSuspendido.Name = "rbSuspendido";
            rbSuspendido.Size = new Size(87, 19);
            rbSuspendido.TabIndex = 21;
            rbSuspendido.TabStop = true;
            rbSuspendido.Text = "Suspendido";
            rbSuspendido.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            rbActivo.AutoSize = true;
            rbActivo.Location = new Point(568, 67);
            rbActivo.Margin = new Padding(3, 2, 3, 2);
            rbActivo.Name = "rbActivo";
            rbActivo.Size = new Size(59, 19);
            rbActivo.TabIndex = 20;
            rbActivo.TabStop = true;
            rbActivo.Text = "Activo";
            rbActivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(568, 31);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 22;
            label9.Text = "Estado:";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "", "Basico", "Avanzado", "Administrador", "Desarrollador" });
            cmbRol.Location = new Point(97, 107);
            cmbRol.Margin = new Padding(3, 2, 3, 2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(368, 23);
            cmbRol.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 110);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 18;
            label5.Text = "Rol:";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(97, 68);
            txtcontraseña.Margin = new Padding(3, 2, 3, 2);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(368, 23);
            txtcontraseña.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(11, 71);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 17;
            label8.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 34);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 14;
            label3.Text = "Usuario:";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(97, 31);
            txtuser.Margin = new Padding(3, 2, 3, 2);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(368, 23);
            txtuser.TabIndex = 15;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(905, 548);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
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