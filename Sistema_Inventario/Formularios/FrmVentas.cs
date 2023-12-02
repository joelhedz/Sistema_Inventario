using Sistema_Inventario.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario.Formularios
{
    public partial class FrmVentas : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataTable venta;

        public FrmVentas()
        {
            InitializeComponent();
            conexion = new SqlConnection(ClassConexion.ConnectionString);
            string connectionString = "Server=LAPTOP-NGSPQNQG\\CRISTOPHERNUÑEZ;Database=alphaInventary;User id=criss;Password=12345;";

        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmVentas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label4 = new Label();
            btnbusacr = new Button();
            dateTimePickerinicio = new DateTimePicker();
            button2 = new Button();
            groupBox1 = new GroupBox();
            BtnBuscar = new Button();
            label1 = new Label();
            dateTimePickerfinal = new DateTimePicker();
            BtnAnular = new Button();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)dataGridView2).BeginInit();
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
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerfinal);
            groupBox1.Controls.Add(btnbusacr);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePickerinicio);
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
            BtnBuscar.Click += BtnBuscar_Click;
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
            // dateTimePickerfinal
            // 
            dateTimePickerfinal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerfinal.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerfinal.Format = DateTimePickerFormat.Short;
            dateTimePickerfinal.Location = new Point(456, 61);
            dateTimePickerfinal.Name = "dateTimePickerfinal";
            dateTimePickerfinal.Size = new Size(321, 29);
            dateTimePickerfinal.TabIndex = 20;
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
            BtnAnular.Click += BtnAnular_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 216, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.FromArgb(234, 219, 240);
            dataGridView2.Location = new Point(37, 292);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1149, 365);
            dataGridView2.TabIndex = 62;
            // 
            // FrmVentas
            // 
            ClientSize = new Size(1223, 693);
            Controls.Add(dataGridView2);
            Controls.Add(BtnAnular);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Name = "FrmVentas";
            Text = "Ventas";
            Load += FrmVentas_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmVentas_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerinicio.Value;
            DateTime fechaFinal = dateTimePickerfinal.Value;

            conexion.Open();
            string consulta = "SELECT * FROM venta WHERE fecha_venta BETWEEN @FechaInicio AND @FechaFinal";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@FechaFinal", fechaFinal);

            adaptador = new SqlDataAdapter(comando);
            venta = new DataTable();
            adaptador.Fill(venta);

            dataGridView2.DataSource = venta;
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
               
                int idVenta = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id_venta"].Value);

                
                string consulta = "UPDATE venta SET estado_de_venta = 'Anulada' WHERE id_venta = @IdVenta";

                try
                {
                    
                    conexion.Open();

                    
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@IdVenta", idVenta);
                    int filasActualizadas = comando.ExecuteNonQuery();

                    if (filasActualizadas > 0)
                    {
                        MessageBox.Show("Venta anulada correctamente.");

                        
                        BtnBuscar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular la venta.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al anular la venta: " + ex.Message);
                }
                finally
                {
                    
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una venta para anular.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteFormulario reporteForm = new ReporteFormulario();
            reporteForm.ReporteVentas(dataGridView2.DataSource as DataTable);
            reporteForm.Show();
        }
    }
}

