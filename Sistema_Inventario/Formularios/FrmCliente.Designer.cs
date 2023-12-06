namespace Sistema_Inventario.Formularios
{
    partial class FrmCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            textId = new TextBox();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDireccion = new TextBox();
            textEmail = new TextBox();
            lblcodigo = new Label();
            lblnombre = new Label();
            lblapellido = new Label();
            lbltelefono = new Label();
            lblemail = new Label();
            lblsalario = new Label();
            tabControl1 = new TabControl();
            tabpageListClientes = new TabPage();
            dgvCliente = new DataGridView();
            BtnEstado = new Button();
            BtnEditar = new Button();
            BtnNuevo = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            rbNombre = new RadioButton();
            rbId = new RadioButton();
            textBuscar = new TextBox();
            tabPageFormClientes = new TabPage();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            maskedtbTel = new MaskedTextBox();
            tabControl1.SuspendLayout();
            tabpageListClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            groupBox1.SuspendLayout();
            tabPageFormClientes.SuspendLayout();
            SuspendLayout();
            // 
            // textId
            // 
            textId.Location = new Point(204, 80);
            textId.Name = "textId";
            textId.Size = new Size(345, 29);
            textId.TabIndex = 20;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(204, 131);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(345, 29);
            textNombre.TabIndex = 21;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(712, 131);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(345, 29);
            textApellido.TabIndex = 22;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(204, 246);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(853, 29);
            textDireccion.TabIndex = 24;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(204, 187);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 29);
            textEmail.TabIndex = 25;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(83, 83);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(106, 21);
            lblcodigo.TabIndex = 26;
            lblcodigo.Text = "No. Identidad:";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(118, 134);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(71, 21);
            lblnombre.TabIndex = 27;
            lblnombre.Text = "Nombre:";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(612, 134);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(70, 21);
            lblapellido.TabIndex = 28;
            lblapellido.Text = "Apellido:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(611, 190);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(71, 21);
            lbltelefono.TabIndex = 29;
            lbltelefono.Text = "Telefono:";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(111, 249);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(78, 21);
            lblemail.TabIndex = 30;
            lblemail.Text = "Direccion:";
            // 
            // lblsalario
            // 
            lblsalario.AutoSize = true;
            lblsalario.Location = new Point(138, 190);
            lblsalario.Name = "lblsalario";
            lblsalario.Size = new Size(51, 21);
            lblsalario.TabIndex = 31;
            lblsalario.Text = "Email:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabpageListClientes);
            tabControl1.Controls.Add(tabPageFormClientes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1199, 562);
            tabControl1.TabIndex = 32;
            // 
            // tabpageListClientes
            // 
            tabpageListClientes.Controls.Add(dgvCliente);
            tabpageListClientes.Controls.Add(BtnEstado);
            tabpageListClientes.Controls.Add(BtnEditar);
            tabpageListClientes.Controls.Add(BtnNuevo);
            tabpageListClientes.Controls.Add(button2);
            tabpageListClientes.Controls.Add(groupBox1);
            tabpageListClientes.Location = new Point(4, 30);
            tabpageListClientes.Name = "tabpageListClientes";
            tabpageListClientes.Padding = new Padding(3);
            tabpageListClientes.Size = new Size(1191, 528);
            tabpageListClientes.TabIndex = 0;
            tabpageListClientes.Text = "Lista Usuarios";
            tabpageListClientes.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCliente.BackgroundColor = Color.White;
            dgvCliente.BorderStyle = BorderStyle.None;
            dgvCliente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCliente.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCliente.EnableHeadersVisualStyles = false;
            dgvCliente.GridColor = Color.FromArgb(234, 219, 240);
            dgvCliente.Location = new Point(83, 153);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(886, 347);
            dgvCliente.TabIndex = 62;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            dgvCliente.Click += dgvCliente_Click;
            // 
            // BtnEstado
            // 
            BtnEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEstado.BackColor = Color.Maroon;
            BtnEstado.FlatStyle = FlatStyle.Flat;
            BtnEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEstado.ForeColor = SystemColors.ButtonHighlight;
            BtnEstado.Location = new Point(998, 275);
            BtnEstado.Name = "BtnEstado";
            BtnEstado.Size = new Size(168, 49);
            BtnEstado.TabIndex = 61;
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
            BtnEditar.Location = new Point(998, 214);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(168, 49);
            BtnEditar.TabIndex = 60;
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
            BtnNuevo.Location = new Point(998, 153);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(168, 49);
            BtnNuevo.TabIndex = 59;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
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
            button2.Location = new Point(998, 340);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(168, 50);
            button2.TabIndex = 58;
            button2.Text = "    Reporte ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(rbNombre);
            groupBox1.Controls.Add(rbId);
            groupBox1.Controls.Add(textBuscar);
            groupBox1.Location = new Point(83, 53);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(886, 80);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por:";
            // 
            // rbNombre
            // 
            rbNombre.AutoSize = true;
            rbNombre.Location = new Point(469, 34);
            rbNombre.Name = "rbNombre";
            rbNombre.Size = new Size(86, 25);
            rbNombre.TabIndex = 31;
            rbNombre.TabStop = true;
            rbNombre.Text = "Nombre";
            rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbId
            // 
            rbId.AutoSize = true;
            rbId.Location = new Point(320, 34);
            rbId.Name = "rbId";
            rbId.Size = new Size(121, 25);
            rbId.TabIndex = 30;
            rbId.TabStop = true;
            rbId.Text = "No. Identidad";
            rbId.UseVisualStyleBackColor = true;
            // 
            // textBuscar
            // 
            textBuscar.Location = new Point(6, 30);
            textBuscar.Margin = new Padding(3, 2, 3, 2);
            textBuscar.MaxLength = 20;
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(270, 29);
            textBuscar.TabIndex = 12;
            textBuscar.TextChanged += textBuscar_TextChanged;
            // 
            // tabPageFormClientes
            // 
            tabPageFormClientes.Controls.Add(BtnConfirmar);
            tabPageFormClientes.Controls.Add(BtnCancelar);
            tabPageFormClientes.Controls.Add(BtnGuardar);
            tabPageFormClientes.Controls.Add(maskedtbTel);
            tabPageFormClientes.Controls.Add(textId);
            tabPageFormClientes.Controls.Add(lblsalario);
            tabPageFormClientes.Controls.Add(textNombre);
            tabPageFormClientes.Controls.Add(lblemail);
            tabPageFormClientes.Controls.Add(textApellido);
            tabPageFormClientes.Controls.Add(lbltelefono);
            tabPageFormClientes.Controls.Add(lblapellido);
            tabPageFormClientes.Controls.Add(textDireccion);
            tabPageFormClientes.Controls.Add(lblnombre);
            tabPageFormClientes.Controls.Add(textEmail);
            tabPageFormClientes.Controls.Add(lblcodigo);
            tabPageFormClientes.Location = new Point(4, 30);
            tabPageFormClientes.Name = "tabPageFormClientes";
            tabPageFormClientes.Padding = new Padding(3);
            tabPageFormClientes.Size = new Size(1191, 528);
            tabPageFormClientes.TabIndex = 1;
            tabPageFormClientes.Text = "Formulario Usuarios";
            tabPageFormClientes.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Anchor = AnchorStyles.None;
            BtnConfirmar.BackColor = Color.FromArgb(0, 64, 64);
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.ForeColor = Color.White;
            BtnConfirmar.Location = new Point(426, 388);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(153, 44);
            BtnConfirmar.TabIndex = 35;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = false;
            BtnConfirmar.Click += btnConfirmar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.None;
            BtnCancelar.BackColor = Color.Maroon;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(631, 388);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(153, 44);
            BtnCancelar.TabIndex = 34;
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
            BtnGuardar.Location = new Point(426, 388);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(153, 44);
            BtnGuardar.TabIndex = 33;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // maskedtbTel
            // 
            maskedtbTel.Location = new Point(712, 187);
            maskedtbTel.Mask = "0000-0000";
            maskedtbTel.Name = "maskedtbTel";
            maskedtbTel.Size = new Size(345, 29);
            maskedtbTel.TabIndex = 32;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
            Controls.Add(tabControl1);
            Name = "FrmCliente";
            Text = "Cliente";
            Load += FrmCliente_Load;
            tabControl1.ResumeLayout(false);
            tabpageListClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageFormClientes.ResumeLayout(false);
            tabPageFormClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textId;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDireccion;
        private TextBox textEmail;
        private Label lblcodigo;
        private Label lblnombre;
        private Label lblapellido;
        private Label lbltelefono;
        private Label lblemail;
        private Label lblsalario;
        private TabControl tabControl1;
        private TabPage tabpageListClientes;
        private TabPage tabPageFormClientes;
        private MaskedTextBox maskedtbTel;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton rbNombre;
        private RadioButton rbId;
        private TextBox textBuscar;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private Button BtnEstado;
        private Button BtnEditar;
        private Button BtnNuevo;
        private DataGridView dgvCliente;
        private Button BtnConfirmar;
    }
}