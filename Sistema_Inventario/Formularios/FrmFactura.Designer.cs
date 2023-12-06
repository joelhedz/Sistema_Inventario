namespace Sistema_Inventario.Formularios
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            btnNueva = new Button();
            btnCancelar = new Button();
            btnRVenta = new Button();
            txtDevolucion = new TextBox();
            txtEfectivo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTotal = new TextBox();
            dataGridView1 = new DataGridView();
            IdArticulo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            gbDetalles = new GroupBox();
            cmbArticulo = new ComboBox();
            txtCantidad = new NumericUpDown();
            lblStoks = new Label();
            txtPrecio = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            rbPendiente = new RadioButton();
            rbCompletada = new RadioButton();
            dtFecha = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtIdArticulo = new TextBox();
            btnModificar = new Button();
            gbCliente = new GroupBox();
            cmbCliente = new ComboBox();
            txtCliente = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            btnAgregar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnNueva
            // 
            btnNueva.BackColor = Color.FromArgb(83, 126, 179);
            btnNueva.FlatStyle = FlatStyle.Flat;
            btnNueva.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNueva.ForeColor = Color.White;
            btnNueva.Location = new Point(1012, 28);
            btnNueva.Margin = new Padding(3, 2, 3, 2);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(154, 40);
            btnNueva.TabIndex = 30;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(83, 126, 179);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1012, 261);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 40);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRVenta
            // 
            btnRVenta.BackColor = Color.FromArgb(49, 84, 172);
            btnRVenta.FlatStyle = FlatStyle.Flat;
            btnRVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRVenta.ForeColor = Color.White;
            btnRVenta.Image = (Image)resources.GetObject("btnRVenta.Image");
            btnRVenta.Location = new Point(980, 622);
            btnRVenta.Margin = new Padding(3, 2, 3, 2);
            btnRVenta.Name = "btnRVenta";
            btnRVenta.Size = new Size(186, 46);
            btnRVenta.TabIndex = 37;
            btnRVenta.Text = "Realizar Venta";
            btnRVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRVenta.UseVisualStyleBackColor = false;
            btnRVenta.Click += btnRVenta_Click;
            // 
            // txtDevolucion
            // 
            txtDevolucion.Enabled = false;
            txtDevolucion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDevolucion.Location = new Point(189, 632);
            txtDevolucion.Margin = new Padding(3, 2, 3, 2);
            txtDevolucion.Multiline = true;
            txtDevolucion.Name = "txtDevolucion";
            txtDevolucion.Size = new Size(228, 29);
            txtDevolucion.TabIndex = 44;
            // 
            // txtEfectivo
            // 
            txtEfectivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEfectivo.Location = new Point(189, 590);
            txtEfectivo.Margin = new Padding(3, 2, 3, 2);
            txtEfectivo.Multiline = true;
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(228, 29);
            txtEfectivo.TabIndex = 36;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(74, 635);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 43;
            label7.Text = "Devolución:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(69, 590);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 42;
            label6.Text = "Efectivo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 554);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 41;
            label5.Text = "Total a pagar:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(189, 551);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(228, 29);
            txtTotal.TabIndex = 40;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdArticulo, Nombre, Cantidad, Precio, Total });
            dataGridView1.Location = new Point(54, 352);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1112, 189);
            dataGridView1.TabIndex = 39;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // IdArticulo
            // 
            IdArticulo.HeaderText = "IdArticulo";
            IdArticulo.MinimumWidth = 6;
            IdArticulo.Name = "IdArticulo";
            IdArticulo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // gbDetalles
            // 
            gbDetalles.Controls.Add(cmbArticulo);
            gbDetalles.Controls.Add(txtCantidad);
            gbDetalles.Controls.Add(lblStoks);
            gbDetalles.Controls.Add(txtPrecio);
            gbDetalles.Controls.Add(label10);
            gbDetalles.Controls.Add(label9);
            gbDetalles.Controls.Add(label8);
            gbDetalles.Controls.Add(rbPendiente);
            gbDetalles.Controls.Add(rbCompletada);
            gbDetalles.Controls.Add(dtFecha);
            gbDetalles.Controls.Add(label3);
            gbDetalles.Controls.Add(label4);
            gbDetalles.Controls.Add(txtIdArticulo);
            gbDetalles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDetalles.Location = new Point(54, 143);
            gbDetalles.Margin = new Padding(3, 2, 3, 2);
            gbDetalles.Name = "gbDetalles";
            gbDetalles.Padding = new Padding(3, 2, 3, 2);
            gbDetalles.Size = new Size(911, 179);
            gbDetalles.TabIndex = 38;
            gbDetalles.TabStop = false;
            gbDetalles.Text = "Detalles";
            // 
            // cmbArticulo
            // 
            cmbArticulo.FormattingEnabled = true;
            cmbArticulo.Location = new Point(350, 63);
            cmbArticulo.Name = "cmbArticulo";
            cmbArticulo.Size = new Size(355, 29);
            cmbArticulo.TabIndex = 15;
            cmbArticulo.SelectedIndexChanged += cmbArticulo_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(99, 112);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(175, 29);
            txtCantidad.TabIndex = 8;
            // 
            // lblStoks
            // 
            lblStoks.AutoSize = true;
            lblStoks.Location = new Point(99, 140);
            lblStoks.Name = "lblStoks";
            lblStoks.Size = new Size(19, 21);
            lblStoks.TabIndex = 30;
            lblStoks.Text = "...";
            lblStoks.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(414, 118);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(140, 23);
            txtPrecio.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(350, 118);
            label10.Name = "label10";
            label10.Size = new Size(56, 21);
            label10.TabIndex = 27;
            label10.Text = "Precio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 118);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 26;
            label9.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 66);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 25;
            label8.Text = "IdArticulo:";
            // 
            // rbPendiente
            // 
            rbPendiente.AutoSize = true;
            rbPendiente.Location = new Point(564, 18);
            rbPendiente.Name = "rbPendiente";
            rbPendiente.Size = new Size(96, 25);
            rbPendiente.TabIndex = 5;
            rbPendiente.TabStop = true;
            rbPendiente.Text = "Pendiente";
            rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbCompletada
            // 
            rbCompletada.AutoSize = true;
            rbCompletada.Location = new Point(442, 18);
            rbCompletada.Name = "rbCompletada";
            rbCompletada.Size = new Size(112, 25);
            rbCompletada.TabIndex = 4;
            rbCompletada.TabStop = true;
            rbCompletada.Text = "Completada";
            rbCompletada.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(99, 15);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(175, 29);
            dtFecha.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 20);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 14;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 21);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 15;
            label4.Text = "Estado:";
            // 
            // txtIdArticulo
            // 
            txtIdArticulo.Enabled = false;
            txtIdArticulo.Location = new Point(99, 64);
            txtIdArticulo.Margin = new Padding(3, 2, 3, 2);
            txtIdArticulo.Multiline = true;
            txtIdArticulo.Name = "txtIdArticulo";
            txtIdArticulo.Size = new Size(175, 23);
            txtIdArticulo.TabIndex = 6;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(83, 126, 179);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(1012, 143);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(154, 40);
            btnModificar.TabIndex = 32;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(cmbCliente);
            gbCliente.Controls.Add(txtCliente);
            gbCliente.Controls.Add(label2);
            gbCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbCliente.Location = new Point(54, 38);
            gbCliente.Margin = new Padding(3, 2, 3, 2);
            gbCliente.Name = "gbCliente";
            gbCliente.Padding = new Padding(3, 2, 3, 2);
            gbCliente.Size = new Size(911, 88);
            gbCliente.TabIndex = 33;
            gbCliente.TabStop = false;
            gbCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(114, 37);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(418, 29);
            cmbCliente.TabIndex = 14;
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(159, 37);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Multiline = true;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(356, 23);
            txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(83, 126, 179);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1012, 201);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 39);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(83, 126, 179);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1012, 86);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(154, 40);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1223, 693);
            Controls.Add(btnNueva);
            Controls.Add(btnCancelar);
            Controls.Add(btnRVenta);
            Controls.Add(txtDevolucion);
            Controls.Add(txtEfectivo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(dataGridView1);
            Controls.Add(gbDetalles);
            Controls.Add(btnModificar);
            Controls.Add(gbCliente);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Name = "FrmFactura";
            Text = "Factura";
            Load += FrmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbDetalles.ResumeLayout(false);
            gbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNueva;
        private Button btnCancelar;
        private Button btnRVenta;
        private TextBox txtDevolucion;
        private TextBox txtEfectivo;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtTotal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private GroupBox gbDetalles;
        private NumericUpDown txtCantidad;
        private Label lblStoks;
        private TextBox txtPrecio;
        private Label label10;
        private Label label9;
        private Label label8;
        private RadioButton rbPendiente;
        private RadioButton rbCompletada;
        private DateTimePicker dtFecha;
        private Label label3;
        private Label label4;
        private TextBox txtIdArticulo;
        private Button btnModificar;
        private GroupBox gbCliente;
        private TextBox txtCliente;
        private Label label2;
        private Button btnEliminar;
        private Button btnAgregar;
        private ErrorProvider errorProvider1;
        private ComboBox cmbCliente;
        private ComboBox cmbArticulo;
    }
}