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
    public partial class FrmUsuario : Form
    {
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        private Form activeForm;
        public FrmUsuario()
        {
            InitializeComponent();
        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {


        }

        private void SetFormulario(Form formulario, object btnSender, Color color)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

        }
    }
}
