namespace Sistema_Inventario.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            BtnAgregar = new Button();
            txtPaswd = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblError = new Label();
            btnVer = new Button();
            label4 = new Label();
            BtnOcultar = new Button();
            label6 = new Label();
            btnSalir = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 93, 142);
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(137, 282);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(347, 39);
            BtnAgregar.TabIndex = 11;
            BtnAgregar.Text = "Ingresar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // txtPaswd
            // 
            txtPaswd.BackColor = Color.FromArgb(4, 41, 68);
            txtPaswd.BorderStyle = BorderStyle.None;
            txtPaswd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPaswd.ForeColor = Color.White;
            txtPaswd.Location = new Point(271, 189);
            txtPaswd.Name = "txtPaswd";
            txtPaswd.PasswordChar = '*';
            txtPaswd.Size = new Size(264, 22);
            txtPaswd.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(4, 41, 68);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(271, 127);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(264, 22);
            txtUsuario.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 192);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 8;
            label2.Text = "Contraseña :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 130);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 7;
            label1.Text = "Usuario :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 398);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 41, 68);
            panel2.Controls.Add(lblError);
            panel2.Controls.Add(btnVer);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BtnOcultar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(BtnAgregar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPaswd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(258, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 398);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(255, 128, 128);
            lblError.Location = new Point(263, 239);
            lblError.Name = "lblError";
            lblError.Size = new Size(24, 19);
            lblError.TabIndex = 18;
            lblError.Text = ".....";
            lblError.Visible = false;
            lblError.Click += label5_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.Transparent;
            btnVer.BackgroundImage = (Image)resources.GetObject("btnVer.BackgroundImage");
            btnVer.BackgroundImageLayout = ImageLayout.Zoom;
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.ImeMode = ImeMode.NoControl;
            btnVer.Location = new Point(508, 193);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(26, 23);
            btnVer.TabIndex = 15;
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Gainsboro;
            label4.ForeColor = Color.White;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(271, 153);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(264, 3);
            label4.TabIndex = 17;
            // 
            // BtnOcultar
            // 
            BtnOcultar.BackColor = Color.Transparent;
            BtnOcultar.BackgroundImage = (Image)resources.GetObject("BtnOcultar.BackgroundImage");
            BtnOcultar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnOcultar.FlatAppearance.BorderSize = 0;
            BtnOcultar.FlatStyle = FlatStyle.Flat;
            BtnOcultar.ImeMode = ImeMode.NoControl;
            BtnOcultar.Location = new Point(508, 193);
            BtnOcultar.Name = "BtnOcultar";
            BtnOcultar.Size = new Size(26, 23);
            BtnOcultar.TabIndex = 16;
            BtnOcultar.UseVisualStyleBackColor = false;
            BtnOcultar.Click += BtnOcultar_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Gainsboro;
            label6.ForeColor = Color.White;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(271, 218);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(264, 3);
            label6.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(41, 59, 79);
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.ImeMode = ImeMode.NoControl;
            btnSalir.Location = new Point(576, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(30, 33);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(263, 23);
            label3.Name = "label3";
            label3.Size = new Size(95, 41);
            label3.TabIndex = 12;
            label3.Text = "Login";
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(865, 398);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAgregar;
        private TextBox txtPaswd;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label6;
        private Button btnSalir;
        private Label label3;
        private Button BtnOcultar;
        private Button btnVer;
        private Label label4;
        private Label lblError;
    }
}