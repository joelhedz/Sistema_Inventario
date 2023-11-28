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
            BtnNuevo = new Button();
            SuspendLayout();
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(343, 205);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(114, 40);
            BtnNuevo.TabIndex = 25;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnNuevo);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnNuevo;
    }
}