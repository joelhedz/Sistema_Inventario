using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario.Formularios
{
    public partial class FrmLogin : Form
    {
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        Controladores.ClassValidaciones val = new Controladores.ClassValidaciones();

        private int iduser; 
        private  string usuario;
        private string rol;
        public FrmLogin()
        {
            InitializeComponent();
        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {

            txtUsuario.Focus();
            BtnOcultar.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            if (txtUsuario.Text == "")
            {
                msj.Aviso("Ingrese el usuario");
                txtUsuario.Focus();
                return;
            }

            if (txtPaswd.Text == "")
            {
                msj.Aviso("Ingrese la contraseña");
                txtPaswd.Focus();
                return;
            }

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@NomUsu", txtUsuario.Text));
            lst.Add(new SqlParameter("@PasUsu", txtPaswd.Text));
            string ValUsu = "Select usu.usercode, usu.nombre_usuario, usu.pswd_usuario, usu.estado_usuario, rolUser.rolcod " +
                "From usuarios as usu " +
                "INNER JOIN roles_Usuario as rolUser on usu.usercode=rolUser.usercode " +
                " where nombre_usuario=@NomUsu and pswd_usuario=@PasUsu";
            DataTable dtValUser = new DataTable();
            dtValUser = crud.getInfo(ValUsu, lst);

            if (dtValUser.Rows.Count > 0)
            {
                string userCode = dtValUser.Rows[0]["usercode"].ToString();
                string estado = dtValUser.Rows[0]["estado_usuario"].ToString();

                if (estado == "INA")
                {
                    msj.Aviso("Usuario fuera de servicio o deshabilitado");
                    return;
                }
                iduser = Convert.ToInt32(dtValUser.Rows[0]["usercode"].ToString());
                usuario = dtValUser.Rows[0]["nombre_usuario"].ToString();
                rol = dtValUser.Rows[0]["rolcod"].ToString();
                Controladores.ClassDatosUsuario objUser = new Controladores.ClassDatosUsuario(iduser,usuario, rol);
                FrmLoanding cargar = new FrmLoanding();
                cargar.Show();
                this.Hide();

            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Usuario o clave incorrecta";
            }



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.txtPaswd.PasswordChar = Convert.ToChar("\0");
            btnVer.Visible = false;
            btnVer.Visible = false;
            BtnOcultar.Visible = true;
            BtnOcultar.Enabled = true;
            txtPaswd.Focus();
        }

        private void BtnOcultar_Click(object sender, EventArgs e)
        {
            this.txtPaswd.PasswordChar = Convert.ToChar("*");
            btnVer.Visible = true;
            BtnOcultar.Visible = false;
            BtnOcultar.Enabled = false;
            btnVer.Enabled = true;
            txtPaswd.Focus();
             
        }
    }
}
