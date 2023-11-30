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
    public partial class FrmMenu : Form
    {
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        private Button currentButton;
        private Form activeForm;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void panelIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            string dia, mes, anio, fecha;
            dia = DateTime.Now.ToString("dddd");
            fecha = DateTime.Now.ToString("dd");
            mes = DateTime.Now.ToString("MMMM");
            anio = DateTime.Now.ToString("yyyy");
            LblFecha.Text = dia + ", " + fecha + " de " + mes + " del " + anio;

        }

        private void ActivarButton(object btnsender, Color color)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DesactivarButton();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DesactivarButton()
        {
            foreach (Control previousBtn in panelIzquierdo.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(4, 41, 68);
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void MostrarForm(Form formulario, object btnsender, Color color)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            BtnInicio.Visible = true;
            ActivarButton(btnsender, color);
            activeForm = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.PanelCentral.Controls.Add(formulario);
            this.PanelCentral.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
            labelTitulo.Text = formulario.Text;
            labelTitulo.BackColor = color;
            BtnInicio.BackColor = color;
        }

        private void FrmMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if(msj.Confirmar("¿Desea salir del sistema?") == true)
                this.Close();
        }

        private void reset()
        {
            DesactivarButton();
            labelTitulo.Text = "MENÚ";
            labelTitulo.BackColor = Color.FromArgb(13, 93, 142);
            BtnInicio.BackColor = Color.FromArgb(13, 93, 142);
            currentButton = null;
            BtnInicio.Visible = false;
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if (msj.Confirmar("¿Desea volver al inicio?") == true)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                reset();
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarForm(new Formularios.FrmUsuario(), sender, Color.FromArgb(0, 122, 204));
        }
    }
}
