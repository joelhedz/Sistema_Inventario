using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario.Formularios
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmVentas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label4 = new Label();
            btnbusacr = new Button();
            dateTimePicker = new DateTimePicker();
            button2 = new Button();
            groupBox1 = new GroupBox();
            BtnBuscar = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            BtnAnular = new Button();
            this.dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)this.dataGridView2).BeginInit();
            SuspendLayout();
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
            // btnbusacr
            // 
            btnbusacr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnbusacr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnbusacr.Location = new Point(15, 104);
            btnbusacr.Name = "btnbusacr";
            btnbusacr.Size = new Size(367, 32);
            btnbusacr.TabIndex = 13;
            btnbusacr.Text = "Eliminar Filtro";
            btnbusacr.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(15, 61);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(367, 29);
            dateTimePicker.TabIndex = 18;
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
            button2.Location = new Point(1018, 218);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(168, 50);
            button2.TabIndex = 59;
            button2.Text = "    Reporte ";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnbusacr);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(37, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1149, 150);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Venta";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.FromArgb(255, 128, 0);
            BtnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(811, 56);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(237, 43);
            BtnBuscar.TabIndex = 28;
            BtnBuscar.Text = "   Buscar";
            BtnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(456, 37);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 19;
            label1.Text = "Fecha Final";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(456, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(321, 29);
            dateTimePicker1.TabIndex = 20;
            // 
            // BtnAnular
            // 
            BtnAnular.BackColor = Color.FromArgb(38, 56, 78);
            BtnAnular.FlatStyle = FlatStyle.Flat;
            BtnAnular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAnular.ForeColor = Color.White;
            BtnAnular.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAnular.Location = new Point(37, 216);
            BtnAnular.Margin = new Padding(3, 2, 3, 2);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(168, 50);
            BtnAnular.TabIndex = 61;
            BtnAnular.Text = "Anular Venta";
            BtnAnular.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = Color.White;
            this.dataGridView2.BorderStyle = BorderStyle.None;
            this.dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = Color.FromArgb(234, 219, 240);
            this.dataGridView2.Location = new Point(37, 292);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new Size(1149, 365);
            this.dataGridView2.TabIndex = 62;
            // 
            // FrmVentas
            // 
            ClientSize = new Size(1223, 693);
            Controls.Add(this.dataGridView2);
            Controls.Add(BtnAnular);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Name = "FrmVentas";
            Text = "Ventas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)this.dataGridView2).EndInit();
            ResumeLayout(false);
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
