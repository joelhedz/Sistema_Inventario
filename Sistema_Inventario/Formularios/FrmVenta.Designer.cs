namespace Sistema_Inventario.Formularios
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BtnReporte = new Button();
            DgvVentas = new DataGridView();
            BtnAnular = new Button();
            groupBox1 = new GroupBox();
            BtnBuscar = new Button();
            label1 = new Label();
            dateTimePickerfinal = new DateTimePicker();
            btnEliminarFiltro = new Button();
            label4 = new Label();
            dateTimePickerinicio = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DgvVentas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnReporte
            // 
            BtnReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnReporte.BackColor = Color.FromArgb(38, 56, 78);
            BtnReporte.FlatStyle = FlatStyle.Flat;
            BtnReporte.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnReporte.ForeColor = Color.White;
            BtnReporte.Image = (Image)resources.GetObject("BtnReporte.Image");
            BtnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReporte.Location = new Point(1018, 219);
            BtnReporte.Margin = new Padding(3, 2, 3, 2);
            BtnReporte.Name = "BtnReporte";
            BtnReporte.Size = new Size(168, 50);
            BtnReporte.TabIndex = 67;
            BtnReporte.Text = "    Reporte ";
            BtnReporte.UseVisualStyleBackColor = false;
            BtnReporte.Click += BtnReporte_Click;
            // 
            // DgvVentas
            // 
            DgvVentas.AllowUserToAddRows = false;
            DgvVentas.AllowUserToDeleteRows = false;
            DgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvVentas.BackgroundColor = Color.White;
            DgvVentas.BorderStyle = BorderStyle.None;
            DgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvVentas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            DgvVentas.EnableHeadersVisualStyles = false;
            DgvVentas.GridColor = Color.FromArgb(234, 219, 240);
            DgvVentas.Location = new Point(37, 295);
            DgvVentas.Name = "DgvVentas";
            DgvVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvVentas.RowHeadersVisible = false;
            DgvVentas.RowTemplate.Height = 25;
            DgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvVentas.Size = new Size(1149, 365);
            DgvVentas.TabIndex = 66;
            DgvVentas.Click += DgvVentas_Click;
            // 
            // BtnAnular
            // 
            BtnAnular.BackColor = Color.FromArgb(38, 56, 78);
            BtnAnular.FlatStyle = FlatStyle.Flat;
            BtnAnular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAnular.ForeColor = Color.White;
            BtnAnular.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAnular.Location = new Point(37, 219);
            BtnAnular.Margin = new Padding(3, 2, 3, 2);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(168, 50);
            BtnAnular.TabIndex = 65;
            BtnAnular.Text = "Anular Venta";
            BtnAnular.UseVisualStyleBackColor = false;
            BtnAnular.Click += BtnAnular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerfinal);
            groupBox1.Controls.Add(btnEliminarFiltro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePickerinicio);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(37, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1149, 150);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Venta";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.FromArgb(255, 128, 0);
            BtnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(808, 56);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(237, 43);
            BtnBuscar.TabIndex = 28;
            BtnBuscar.Text = "   Buscar";
            BtnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1405, 37);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 19;
            label1.Text = "Fecha Final";
            // 
            // dateTimePickerfinal
            // 
            dateTimePickerfinal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerfinal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerfinal.Format = DateTimePickerFormat.Short;
            dateTimePickerfinal.Location = new Point(441, 61);
            dateTimePickerfinal.Name = "dateTimePickerfinal";
            dateTimePickerfinal.Size = new Size(331, 29);
            dateTimePickerfinal.TabIndex = 20;
            // 
            // btnEliminarFiltro
            // 
            btnEliminarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarFiltro.Location = new Point(15, 104);
            btnEliminarFiltro.Name = "btnEliminarFiltro";
            btnEliminarFiltro.Size = new Size(367, 32);
            btnEliminarFiltro.TabIndex = 13;
            btnEliminarFiltro.Text = "Eliminar Filtro";
            btnEliminarFiltro.UseVisualStyleBackColor = true;
            btnEliminarFiltro.Click += btnEliminarFiltro_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 37);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 7;
            label4.Text = "Fecha Inicio";
            // 
            // dateTimePickerinicio
            // 
            dateTimePickerinicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerinicio.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerinicio.Format = DateTimePickerFormat.Short;
            dateTimePickerinicio.Location = new Point(15, 61);
            dateTimePickerinicio.Name = "dateTimePickerinicio";
            dateTimePickerinicio.Size = new Size(367, 29);
            dateTimePickerinicio.TabIndex = 18;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 693);
            Controls.Add(groupBox1);
            Controls.Add(BtnReporte);
            Controls.Add(DgvVentas);
            Controls.Add(BtnAnular);
            Name = "FrmVenta";
            Text = "FrmVenta";
            Load += FrmVenta_Load_1;
            ((System.ComponentModel.ISupportInitialize)DgvVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnReporte;
        private DataGridView DgvVentas;
        private Button BtnAnular;
        private GroupBox groupBox1;
        private Button BtnBuscar;
        private Label label1;
        private DateTimePicker dateTimePickerfinal;
        private Button btnEliminarFiltro;
        private Label label4;
        private DateTimePicker dateTimePickerinicio;
    }
}