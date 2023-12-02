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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            lblcodigo = new Label();
            lblnombre = new Label();
            lblapellido = new Label();
            lbltelefono = new Label();
            lblemail = new Label();
            lblsalario = new Label();
            tabControl1 = new TabControl();
            listUsuario = new TabPage();
            dataGridView1 = new DataGridView();
            BtnEstado = new Button();
            BtnEditar = new Button();
            BtnNuevo = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            rbNombre = new RadioButton();
            rbId = new RadioButton();
            textBox4 = new TextBox();
            formUsuarios = new TabPage();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            maskedTextBox1 = new MaskedTextBox();
            tabControl1.SuspendLayout();
            listUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            formUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 29);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 29);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(712, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(345, 29);
            textBox3.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(204, 246);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(853, 29);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(204, 187);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 29);
            textBox6.TabIndex = 25;
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
            tabControl1.Controls.Add(listUsuario);
            tabControl1.Controls.Add(formUsuarios);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(10, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1223, 693);
            tabControl1.TabIndex = 32;
            // 
            // listUsuario
            // 
            listUsuario.Controls.Add(dataGridView1);
            listUsuario.Controls.Add(BtnEstado);
            listUsuario.Controls.Add(BtnEditar);
            listUsuario.Controls.Add(BtnNuevo);
            listUsuario.Controls.Add(button2);
            listUsuario.Controls.Add(groupBox1);
            listUsuario.Location = new Point(4, 30);
            listUsuario.Name = "listUsuario";
            listUsuario.Padding = new Padding(3);
            listUsuario.Size = new Size(1215, 659);
            listUsuario.TabIndex = 0;
            listUsuario.Text = "Lista Usuarios";
            listUsuario.UseVisualStyleBackColor = true;
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
            dataGridView1.Location = new Point(83, 153);
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
            dataGridView1.Size = new Size(910, 478);
            dataGridView1.TabIndex = 62;
            // 
            // BtnEstado
            // 
            BtnEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEstado.BackColor = Color.Maroon;
            BtnEstado.FlatStyle = FlatStyle.Flat;
            BtnEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEstado.ForeColor = SystemColors.ButtonHighlight;
            BtnEstado.Location = new Point(1022, 275);
            BtnEstado.Name = "BtnEstado";
            BtnEstado.Size = new Size(168, 49);
            BtnEstado.TabIndex = 61;
            BtnEstado.Text = "Estado";
            BtnEstado.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditar.BackColor = Color.Teal;
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEditar.ForeColor = SystemColors.ButtonHighlight;
            BtnEditar.Location = new Point(1022, 214);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(168, 49);
            BtnEditar.TabIndex = 60;
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
            BtnNuevo.Location = new Point(1022, 153);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(168, 49);
            BtnNuevo.TabIndex = 59;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = false;
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
            button2.Location = new Point(1022, 340);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(168, 50);
            button2.TabIndex = 58;
            button2.Text = "    Reporte ";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(rbNombre);
            groupBox1.Controls.Add(rbId);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(83, 53);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(910, 80);
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
            // textBox4
            // 
            textBox4.Location = new Point(6, 30);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.MaxLength = 20;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 29);
            textBox4.TabIndex = 12;
            // 
            // formUsuarios
            // 
            formUsuarios.Controls.Add(BtnCancelar);
            formUsuarios.Controls.Add(BtnGuardar);
            formUsuarios.Controls.Add(maskedTextBox1);
            formUsuarios.Controls.Add(textBox1);
            formUsuarios.Controls.Add(lblsalario);
            formUsuarios.Controls.Add(textBox2);
            formUsuarios.Controls.Add(lblemail);
            formUsuarios.Controls.Add(textBox3);
            formUsuarios.Controls.Add(lbltelefono);
            formUsuarios.Controls.Add(lblapellido);
            formUsuarios.Controls.Add(textBox5);
            formUsuarios.Controls.Add(lblnombre);
            formUsuarios.Controls.Add(textBox6);
            formUsuarios.Controls.Add(lblcodigo);
            formUsuarios.Location = new Point(4, 30);
            formUsuarios.Name = "formUsuarios";
            formUsuarios.Padding = new Padding(3);
            formUsuarios.Size = new Size(1215, 659);
            formUsuarios.TabIndex = 1;
            formUsuarios.Text = "Formulario Usuarios";
            formUsuarios.UseVisualStyleBackColor = true;
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
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(712, 187);
            maskedTextBox1.Mask = "0000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(345, 29);
            maskedTextBox1.TabIndex = 32;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 693);
            Controls.Add(tabControl1);
            Name = "FrmCliente";
            Text = "Cliente";
            tabControl1.ResumeLayout(false);
            listUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            formUsuarios.ResumeLayout(false);
            formUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label lblcodigo;
        private Label lblnombre;
        private Label lblapellido;
        private Label lbltelefono;
        private Label lblemail;
        private Label lblsalario;
        private TabControl tabControl1;
        private TabPage listUsuario;
        private TabPage formUsuarios;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton rbNombre;
        private RadioButton rbId;
        private TextBox textBox4;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private Button BtnEstado;
        private Button BtnEditar;
        private Button BtnNuevo;
        private DataGridView dataGridView1;
    }
}