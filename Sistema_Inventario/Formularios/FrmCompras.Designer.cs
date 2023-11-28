namespace Sistema_Inventario.Formularios
{
    partial class FrmCompras
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
            lblnombreproducto = new Label();
            lblprecio = new Label();
            lblcantidad = new Label();
            lbltotalapagar = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnagregar = new Button();
            btnlimpiar = new Button();
            btnuevo = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            lblproductos = new Label();
            textBox8 = new TextBox();
            lBLIGV = new Label();
            textBox9 = new TextBox();
            lblimporte = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblnombreproducto
            // 
            lblnombreproducto.AutoSize = true;
            lblnombreproducto.Location = new Point(102, 53);
            lblnombreproducto.Name = "lblnombreproducto";
            lblnombreproducto.Size = new Size(109, 15);
            lblnombreproducto.TabIndex = 0;
            lblnombreproducto.Text = " Nombre Producto:";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(100, 106);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(43, 15);
            lblprecio.TabIndex = 1;
            lblprecio.Text = "Precio:";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(100, 167);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(58, 15);
            lblcantidad.TabIndex = 2;
            lblcantidad.Text = "Cantidad:";
            // 
            // lbltotalapagar
            // 
            lbltotalapagar.AutoSize = true;
            lbltotalapagar.Location = new Point(102, 124);
            lbltotalapagar.Name = "lbltotalapagar";
            lbltotalapagar.Size = new Size(77, 15);
            lbltotalapagar.TabIndex = 3;
            lbltotalapagar.Text = "Total a Pagar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(289, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(114, 236);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 14;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(301, 227);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 15;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnuevo
            // 
            btnuevo.Location = new Point(494, 227);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(75, 23);
            btnuevo.TabIndex = 16;
            btnuevo.Text = "Nuevo";
            btnuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblnombreproducto);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(lblprecio);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(lblcantidad);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(764, 209);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Datos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(lblproductos);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(lBLIGV);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(lblimporte);
            groupBox2.Controls.Add(lbltotalapagar);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(12, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 173);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultados";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(289, 16);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(244, 23);
            textBox7.TabIndex = 6;
            // 
            // lblproductos
            // 
            lblproductos.AutoSize = true;
            lblproductos.Location = new Point(102, 19);
            lblproductos.Name = "lblproductos";
            lblproductos.Size = new Size(67, 15);
            lblproductos.TabIndex = 0;
            lblproductos.Text = " Productos:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(289, 77);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 7;
            // 
            // lBLIGV
            // 
            lBLIGV.AutoSize = true;
            lBLIGV.Location = new Point(102, 80);
            lBLIGV.Name = "lBLIGV";
            lBLIGV.Size = new Size(53, 15);
            lBLIGV.TabIndex = 1;
            lBLIGV.Text = "IGV 18%:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(289, 45);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 8;
            // 
            // lblimporte
            // 
            lblimporte.AutoSize = true;
            lblimporte.Location = new Point(102, 48);
            lblimporte.Name = "lblimporte";
            lblimporte.Size = new Size(119, 15);
            lblimporte.TabIndex = 2;
            lblimporte.Text = "Importe de Compras:";
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnuevo);
            Controls.Add(btnlimpiar);
            Controls.Add(btnagregar);
            Name = "FrmCompras";
            Text = "FrmCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblnombreproducto;
        private Label lblprecio;
        private Label lblcantidad;
        private Label lbltotalapagar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnagregar;
        private Button btnlimpiar;
        private Button btnuevo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox7;
        private Label lblproductos;
        private TextBox textBox8;
        private Label lBLIGV;
        private TextBox textBox9;
        private Label lblimporte;
    }
}