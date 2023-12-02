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
        Controladores.ClassRoles roles = new Controladores.ClassRoles();
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        private Form activeForm;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private  void getUsuarios()
        {
            DataTable dtUsuarios = new DataTable();
            String Query= "SELECT usu.usercode as Codigo, usu.nombre_usuario as Nombre_de_Usuario," +
                "usu.pswd_usuario as Contraseña, usu.estado_usuario as Estado FROM usuarios as usu";
            dtUsuarios =  crud.getInfo(Query);
            dataGridView1.DataSource = dtUsuarios;
            dataGridView1.Refresh();



        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            roles.BotonesAccesos(BtnNuevo,BtnEstado,BtnGuardar,dataGridView1);
            getUsuarios();
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
