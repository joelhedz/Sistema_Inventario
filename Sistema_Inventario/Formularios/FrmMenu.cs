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
        Controladores.ClassRoles roles = new Controladores.ClassRoles();
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
            roles.AlCargarForm(panelIzquierdo,BtnBitacora,BtnClientes,BtnCompras,BtnFactura,BtnProductos,BtnProveedores,BtnUsuarios,BtnVentas);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (msj.Confirmar("¿Desea salir del sistema?") == true)
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

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            MostrarForm(new Formularios.FrmProveedor(), sender, Color.Teal);
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            MostrarForm(new Formularios.FrmFactura(), sender, Color.FromArgb(196, 46, 69));
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            MostrarForm(new Formularios.FrmProductos(), sender, Color.FromArgb(91, 122, 140));
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            MostrarForm(new Formularios.FrmCliente(), sender, Color.FromArgb(60, 85, 189));
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            MostrarForm(new Formularios.FrmCompras(), sender, Color.FromArgb(161, 32, 89));
        }

        private void BtnBitacora_Click(object sender, EventArgs e)
        {
            MostrarForm(new Formularios.FrmBitacora(), sender, Color.FromArgb(54, 75, 93));
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            MostrarForm(new Formularios.FrmVentas(), sender, Color.FromArgb(119, 119, 255));
        }
    }
}
