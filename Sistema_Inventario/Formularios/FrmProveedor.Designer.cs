namespace Sistema_Inventario.Formularios
{
    partial class FrmProveedor
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            tabControl1 = new TabControl();
            ListProveedores = new TabPage();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtBuscar = new TextBox();
            BtnEstado = new Button();
            BtnEditar = new Button();
            BtnNuevo = new Button();
            btnReporte = new Button();
            FormProveedor = new TabPage();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            groupBox1 = new GroupBox();
            txtTelefono = new MaskedTextBox();
            txtEmail = new TextBox();
            txtRtn = new TextBox();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            ListProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            FormProveedor.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ListProveedores);
            tabControl1.Controls.Add(FormProveedor);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1223, 693);
            tabControl1.TabIndex = 15;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ListProveedores
            // 
            ListProveedores.Controls.Add(dataGridView1);
            ListProveedores.Controls.Add(label1);
            ListProveedores.Controls.Add(txtBuscar);
            ListProveedores.Controls.Add(BtnEstado);
            ListProveedores.Controls.Add(BtnEditar);
            ListProveedores.Controls.Add(BtnNuevo);
            ListProveedores.Controls.Add(btnReporte);
            ListProveedores.Location = new Point(4, 30);
            ListProveedores.Name = "ListProveedores";
            ListProveedores.Padding = new Padding(3);
            ListProveedores.Size = new Size(1215, 659);
            ListProveedores.TabIndex = 0;
            ListProveedores.Text = "Proveedores";
            ListProveedores.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(234, 219, 240);
            dataGridView1.Location = new Point(54, 124);
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
            dataGridView1.Size = new Size(903, 481);
            dataGridView1.TabIndex = 70;
            dataGridView1.Click += dataGridView1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 67;
            label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(135, 58);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(387, 29);
            txtBuscar.TabIndex = 68;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // BtnEstado
            // 
            BtnEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEstado.BackColor = Color.Firebrick;
            BtnEstado.FlatStyle = FlatStyle.Flat;
            BtnEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEstado.ForeColor = SystemColors.ButtonHighlight;
            BtnEstado.Location = new Point(1000, 238);
            BtnEstado.Name = "BtnEstado";
            BtnEstado.Size = new Size(168, 49);
            BtnEstado.TabIndex = 66;
            BtnEstado.Text = "Eliminar";
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
            BtnEditar.Location = new Point(1000, 177);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(168, 49);
            BtnEditar.TabIndex = 65;
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
            BtnNuevo.Location = new Point(1000, 116);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(168, 49);
            BtnNuevo.TabIndex = 64;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // btnReporte
            // 
            btnReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReporte.BackColor = Color.FromArgb(38, 56, 78);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporte.ForeColor = Color.White;
            btnReporte.Image = (Image)resources.GetObject("btnReporte.Image");
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(1000, 303);
            btnReporte.Margin = new Padding(3, 2, 3, 2);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(168, 50);
            btnReporte.TabIndex = 63;
            btnReporte.Text = "    Reporte ";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // FormProveedor
            // 
            FormProveedor.Controls.Add(BtnConfirmar);
            FormProveedor.Controls.Add(BtnCancelar);
            FormProveedor.Controls.Add(BtnGuardar);
            FormProveedor.Controls.Add(groupBox1);
            FormProveedor.Location = new Point(4, 30);
            FormProveedor.Name = "FormProveedor";
            FormProveedor.Padding = new Padding(3);
            FormProveedor.Size = new Size(1215, 659);
            FormProveedor.TabIndex = 1;
            FormProveedor.Text = "Proveedor";
            FormProveedor.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Anchor = AnchorStyles.None;
            BtnConfirmar.BackColor = Color.FromArgb(0, 64, 64);
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.ForeColor = Color.White;
            BtnConfirmar.Location = new Point(428, 437);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(153, 44);
            BtnConfirmar.TabIndex = 15;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = false;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.None;
            BtnCancelar.BackColor = Color.Maroon;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(633, 437);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(153, 44);
            BtnCancelar.TabIndex = 16;
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
            BtnGuardar.Location = new Point(428, 437);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(153, 44);
            BtnGuardar.TabIndex = 35;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtRtn);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(80, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 306);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(579, 137);
            txtTelefono.Mask = "0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(401, 29);
            txtTelefono.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(579, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(401, 29);
            txtEmail.TabIndex = 14;
            // 
            // txtRtn
            // 
            txtRtn.Location = new Point(57, 66);
            txtRtn.Name = "txtRtn";
            txtRtn.Size = new Size(348, 29);
            txtRtn.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(57, 210);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(444, 29);
            txtDireccion.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(579, 186);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(444, 29);
            txtNombre.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 113);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 186);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 42);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 1;
            label2.Text = "RTN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 113);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 5;
            label6.Text = "Telefono";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 693);
            Controls.Add(tabControl1);
            Name = "FrmProveedor";
            Text = "Proveedor";
            Load += FrmProveedor_Load;
            tabControl1.ResumeLayout(false);
            ListProveedores.ResumeLayout(false);
            ListProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            FormProveedor.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ListProveedores;
        private TabPage FormProveedor;
        private GroupBox groupBox1;
        private MaskedTextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private TextBox txtRtn;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BtnEstado;
        private Button BtnEditar;
        private Button BtnNuevo;
        private Button btnReporte;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private Label label1;
        private TextBox txtBuscar;
        private Button BtnConfirmar;
        private ErrorProvider errorProvider1;
        private DataGridView dataGridView1;
    }
}