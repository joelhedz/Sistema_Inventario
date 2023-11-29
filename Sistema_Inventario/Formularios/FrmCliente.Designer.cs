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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            dataGridView1 = new DataGridView();
            btnagregar = new Button();
            btnlimpiar = new Button();
            btnuevo = new Button();
            btnsalir = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            lblcodigo = new Label();
            lblnombre = new Label();
            lblapellido = new Label();
            lbltelefono = new Label();
            lblemail = new Label();
            lblsalario = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(206, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(527, 268);
            dataGridView1.TabIndex = 14;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(231, 416);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 15;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(355, 412);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 16;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnuevo
            // 
            btnuevo.Location = new Point(492, 412);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(75, 23);
            btnuevo.TabIndex = 17;
            btnuevo.Text = "Nuevo";
            btnuevo.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(658, 412);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 18;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(76, 329);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(76, 369);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(76, 420);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 25;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(2, 174);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(52, 15);
            lblcodigo.TabIndex = 26;
            lblcodigo.Text = " Codigo:";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(2, 226);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 15);
            lblnombre.TabIndex = 27;
            lblnombre.Text = "Nombre:";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(2, 273);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(54, 15);
            lblapellido.TabIndex = 28;
            lblapellido.Text = "Apellido:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(-1, 329);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(55, 15);
            lbltelefono.TabIndex = 29;
            lbltelefono.Text = "Telefono:";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(12, 369);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(39, 15);
            lblemail.TabIndex = 30;
            lblemail.Text = "Email:";
            // 
            // lblsalario
            // 
            lblsalario.AutoSize = true;
            lblsalario.Location = new Point(6, 420);
            lblsalario.Name = "lblsalario";
            lblsalario.Size = new Size(45, 15);
            lblsalario.TabIndex = 31;
            lblsalario.Text = "Salario:";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 491);
            Controls.Add(lblsalario);
            Controls.Add(lblemail);
            Controls.Add(lbltelefono);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Controls.Add(lblcodigo);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnsalir);
            Controls.Add(btnuevo);
            Controls.Add(btnlimpiar);
            Controls.Add(btnagregar);
            Controls.Add(dataGridView1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnagregar;
        private Button btnlimpiar;
        private Button btnuevo;
        private Button btnsalir;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label lblcodigo;
        private Label lblnombre;
        private Label lblapellido;
        private Label lbltelefono;
        private Label lblemail;
        private Label lblsalario;
    }
}