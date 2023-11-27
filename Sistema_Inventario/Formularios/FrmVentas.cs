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
            label1 = new Label();
            txtidventas = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtidcliente = new TextBox();
            label3 = new Label();
            txtidusuario = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtestadodeventa = new TextBox();
            label6 = new Label();
            txtbuscar = new TextBox();
            btnbusacr = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Ventas";
            label1.Click += label1_Click;
            // 
            // txtidventas
            // 
            txtidventas.Location = new Point(84, 30);
            txtidventas.Name = "txtidventas";
            txtidventas.Size = new Size(100, 23);
            txtidventas.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 338);
            dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 81);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "ID Cliente";
            // 
            // txtidcliente
            // 
            txtidcliente.Location = new Point(84, 73);
            txtidcliente.Name = "txtidcliente";
            txtidcliente.Size = new Size(100, 23);
            txtidcliente.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 33);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "ID usuario";
            // 
            // txtidusuario
            // 
            txtidusuario.Location = new Point(302, 27);
            txtidusuario.Name = "txtidusuario";
            txtidusuario.Size = new Size(100, 23);
            txtidusuario.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 76);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha ventas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 33);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 9;
            label5.Text = "Estado de venta";
            // 
            // txtestadodeventa
            // 
            txtestadodeventa.Location = new Point(548, 30);
            txtestadodeventa.Name = "txtestadodeventa";
            txtestadodeventa.Size = new Size(100, 23);
            txtestadodeventa.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(573, 100);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Buscar";
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(621, 100);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(259, 23);
            txtbuscar.TabIndex = 12;
            // 
            // btnbusacr
            // 
            btnbusacr.Location = new Point(886, 100);
            btnbusacr.Name = "btnbusacr";
            btnbusacr.Size = new Size(75, 23);
            btnbusacr.TabIndex = 13;
            btnbusacr.Text = "Buscar";
            btnbusacr.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(204, 567);
            button2.Name = "button2";
            button2.Size = new Size(95, 40);
            button2.TabIndex = 14;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(353, 567);
            button3.Name = "button3";
            button3.Size = new Size(95, 40);
            button3.TabIndex = 15;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(490, 567);
            button4.Name = "button4";
            button4.Size = new Size(108, 40);
            button4.TabIndex = 16;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(897, 12);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "Menu";
            button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(302, 73);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // FrmVentas
            // 
            ClientSize = new Size(984, 661);
            Controls.Add(dateTimePicker1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnbusacr);
            Controls.Add(txtbuscar);
            Controls.Add(label6);
            Controls.Add(txtestadodeventa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtidusuario);
            Controls.Add(label3);
            Controls.Add(txtidcliente);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtidventas);
            Controls.Add(label1);
            Name = "FrmVentas";
            Load += FrmVentas_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
