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
    public partial class FrmUsuario : Form
    {
        Controladores.ClassRoles roles = new Controladores.ClassRoles();
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        Controladores.ClassValidaciones val = new Controladores.ClassValidaciones();
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        private Form activeForm;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        public void ValidadText()
        {
            val.ValidarText(errorProvider1, txtuser);
            val.ValidarText(errorProvider1, txtcontraseña);
            if (rbInactivo.Checked == false && rbActivo.Checked == false)
            {
                errorProvider1.SetError(gboxEstados, "Seleccione un Estado");
                val.contError++;
            }
            if (cmbRol.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbRol, "Seleccione un Rol");
                val.contError++;
            }

        }

        public void AlcargarListUsuario()
        {
            BtnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnConfirmar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEstado.Enabled = false;
            tabControl1.TabPages.Remove(tabPageFormUsuarios);
            dgvUsuario.Refresh();
        }


        private void getUsuarios()
        {
            DataTable dtUsuarios = new DataTable();
            String Query = "SELECT * FROM View_UsuariosRol";
            dtUsuarios = crud.getInfo(Query);
            dgvUsuario.DataSource = dtUsuarios;
            dgvUsuario.Refresh();

        }

        public void RolesTab()
        {
            String Query = "SELECT * from roles";
            DataTable dtRoles = new DataTable();
            dtRoles = crud.getInfo(Query);

            DataRow fila = dtRoles.NewRow();
            fila["rolcod"] = 0;
            fila["rolDescripcion"] = "Seleccione un Rol";
            fila["rolEst"] = "ACT";

            dtRoles.Rows.InsertAt(fila, 0);

            cmbRol.DataSource = dtRoles;
            cmbRol.DisplayMember = "rolDescripcion";
            cmbRol.ValueMember = "rolcod";

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            AlcargarListUsuario();
            roles.BotonesAccesos(BtnNuevo, BtnGuardar, BtnEditar, BtnEstado, BtnConfirmar, dgvUsuario);
            RolesTab();
            getUsuarios();
        }

        public void limpiar()
        {
            txtuser.Clear();
            txtcontraseña.Clear();
            txtuser.Focus();
        }

        public DataTable ExistenciaUsuario(TextBox userText)
        {
            List<SqlParameter> parametrosValidar = new List<SqlParameter>();
            parametrosValidar.Add(new SqlParameter("@nombre_usuario", userText.Text));
            string QueryValidar = "Select * from usuarios where nombre_usuario=@nombre_usuario";
            DataTable dtValidar = new DataTable();
            dtValidar = crud.getInfo(QueryValidar, parametrosValidar);
            return dtValidar;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            val.contError = 0;
            errorProvider1.Clear();
            ValidadText();
            string estadoRol = "";
            DateTime fecha = DateTime.Now;
            fecha.ToString("yyyy-MM-dd");
            if (val.contError == 0)
            {
                if (rbActivo.Checked == true)
                {
                    gboxEstados.Text = "ACT";
                }
                else
                {
                    gboxEstados.Text = "INA";
                }

                List<SqlParameter> estParametros = new List<SqlParameter>();
                estParametros.Add(new SqlParameter("@RolCod", cmbRol.SelectedValue));
                string estado = "Select * from roles where rolcod=@RolCod";
                DataTable dtroles = new DataTable();
                dtroles = crud.getInfo(estado, estParametros);
                if (dtroles.Rows.Count > 0)
                {
                    estadoRol = dtroles.Rows[0]["rolEst"].ToString();
                }

                if (estadoRol != "ACT")
                {
                    msj.Aviso("El Rol Seleccionado se encuentra Inactivo, por favor seleccione otro Rol");
                    return;
                }

                //Validar si el usuario ya existe

                if (ExistenciaUsuario(txtuser).Rows.Count > 0)
                {
                    msj.Aviso("El Usuario ya se encuentra Registrado");
                }
                else
                {
                    //Registrar Usuario
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("@nombre_usuario", txtuser.Text));
                    parametros.Add(new SqlParameter("@password", txtcontraseña.Text));
                    parametros.Add(new SqlParameter("@estado", gboxEstados.Text));
                    string Query = "INSERT INTO usuarios (nombre_usuario,pswd_usuario,estado_usuario)" +
                    "Values(@nombre_usuario,@password,@estado) ";
                    crud.executeQuery(Query, parametros, "");

                    //Obtener el codigo del usuario
                    List<SqlParameter> parametrosCodigo = new List<SqlParameter>();
                    parametrosCodigo.Add(new SqlParameter("@nombre_usuario", txtuser.Text));
                    string QueryCodigo = "Select * from usuarios where nombre_usuario=@nombre_usuario";
                    DataTable dtCodigo = new DataTable();
                    dtCodigo = crud.getInfo(QueryCodigo, parametrosCodigo);
                    string codigo = dtCodigo.Rows[0]["usercode"].ToString();

                    //Registrar Rol del Usuario
                    List<SqlParameter> parametrosRol = new List<SqlParameter>();
                    parametrosRol.Add(new SqlParameter("@UserCode", codigo));
                    parametrosRol.Add(new SqlParameter("@rolcode", cmbRol.SelectedValue));
                    parametrosRol.Add(new SqlParameter("@RolesEst", estadoRol));
                    parametrosRol.Add(new SqlParameter("@fecha", fecha));

                    string QueryRol = "INSERT INTO roles_Usuario(usercode,rolcod,rolesUserEst,fecha)" +
                       "Values(@UserCode,@rolcode,@RolesEst,@fecha)";

                    crud.executeQuery(QueryRol, parametrosRol, "Usuario Registrado Correctamente");
                    limpiar();
                    AlcargarListUsuario();
                    tabControl1.TabPages.Remove(tabPageFormUsuarios);
                    tabControl1.TabPages.Add(tabpageListUsuario);

                }


            }


        }

        private void SetFormulario(Form formulario, object btnSender, Color color)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPageFormUsuarios);
            tabControl1.TabPages.Remove(tabpageListUsuario);
            BtnGuardar.Enabled = true;
            BtnConfirmar.Visible = false;
            BtnCancelar.Enabled = true;

            txtuser.Focus();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_Click(object sender, EventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnEstado.Enabled = true;

            if (dgvUsuario.Rows.Count > 0)
            {
                if (dgvUsuario.CurrentRow.Cells["Estado"].Value.ToString() == "ACT")
                {
                    BtnEstado.Text = "Inactivar";
                }
                else
                {
                    BtnEstado.Text = "Activar";
                }
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            //validar que solo se permita actualizar, cuando el usuario sea el mismo o diferente a los que ya existen
            val.contError = 0;
            errorProvider1.Clear();
            ValidadText();

            if (val.contError == 0)
            {
                string userName = dgvUsuario.CurrentRow.Cells["Nombre_de_Usuario"].Value.ToString();
                string userData = "";
                if (ExistenciaUsuario(txtuser).Rows.Count > 0)
                {
                    userData = ExistenciaUsuario(txtuser).Rows[0]["nombre_usuario"].ToString();
                }

                if (userName == txtuser.Text || txtuser.Text != userData)
                {
                    if (msj.Confirmar("¿Desea Actualizar el usuario?") == true)
                    {
                        val.contError = 0;
                        ValidadText();
                        if (val.contError == 0)
                        {
                            if (rbActivo.Checked == true)
                            {
                                gboxEstados.Text = "ACT";
                            }
                            else
                            {
                                gboxEstados.Text = "INA";
                            }

                            List<SqlParameter> estParametros = new List<SqlParameter>();
                            estParametros.Add(new SqlParameter("@RolCod", cmbRol.SelectedValue));
                            string estado = "Select * from roles where rolcod=@RolCod";
                            DataTable dtroles = new DataTable();
                            dtroles = crud.getInfo(estado, estParametros);
                            string estadoRol = dtroles.Rows[0]["rolEst"].ToString();

                            if (estadoRol != "ACT")
                            {
                                msj.Aviso("El Rol Seleccionado se encuentra Inactivo, por favor seleccione otro Rol");
                                return;
                            }

                            List<SqlParameter> parametros = new List<SqlParameter>();
                            parametros.Add(new SqlParameter("@nombre_usuario", txtuser.Text));
                            parametros.Add(new SqlParameter("@password", txtcontraseña.Text));
                            parametros.Add(new SqlParameter("@estado", gboxEstados.Text));
                            parametros.Add(new SqlParameter("@usercode", dgvUsuario.CurrentRow.Cells["Codigo"].Value.ToString()));
                            string Query = "UPDATE usuarios SET nombre_usuario=@nombre_usuario,pswd_usuario=@password," +
                                "estado_usuario=@estado where usercode=@usercode";
                            crud.executeQuery(Query, parametros, "");

                            List<SqlParameter> parametrosRol = new List<SqlParameter>();
                            parametrosRol.Add(new SqlParameter("@UserCode", dgvUsuario.CurrentRow.Cells["Codigo"].Value.ToString()));
                            parametrosRol.Add(new SqlParameter("@rolcode", cmbRol.SelectedValue));
                            parametrosRol.Add(new SqlParameter("@RolesEst", estadoRol));

                            string QueryRol = "UPDATE roles_Usuario SET rolcod=@rolcode,rolesUserEst=@RolesEst where usercode=@UserCode";
                            crud.executeQuery(QueryRol, parametrosRol, "Usuario Actualizado Correctamente");
                            limpiar();
                            tabControl1.TabPages.Remove(tabPageFormUsuarios);
                            tabControl1.TabPages.Add(tabpageListUsuario);
                            AlcargarListUsuario();
                        }
                    }
                }
                else
                {
                    msj.Aviso("El Usuario ya se encuentra Registrado");
                    return;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (msj.Confirmar("¿Desea Cancelar el Registro?") == true)
            {
                limpiar();
                AlcargarListUsuario();
                tabControl1.TabPages.Remove(tabPageFormUsuarios);
                tabControl1.TabPages.Add(tabpageListUsuario);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPageFormUsuarios);
            tabControl1.TabPages.Remove(tabpageListUsuario);
            BtnConfirmar.Enabled = true;
            BtnConfirmar.BringToFront();


            txtuser.Text = dgvUsuario.CurrentRow.Cells["Nombre_de_Usuario"].Value.ToString();
            txtcontraseña.Text = dgvUsuario.CurrentRow.Cells["Contraseña"].Value.ToString();
            if (dgvUsuario.CurrentRow.Cells["Estado"].Value.ToString() == "ACT")
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }
            cmbRol.Text = dgvUsuario.CurrentRow.Cells["Rol"].Value.ToString();



        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.Rows.Count > 0)
            {
                if (msj.Confirmar("¿Desea Cambiar el Estado del Usuario?") == true)
                {
                    string estado = "";
                    if (dgvUsuario.CurrentRow.Cells["Estado"].Value.ToString() == "ACT")
                    {
                        estado = "INA";
                    }
                    else
                    {
                        estado = "ACT";
                    }

                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("@estado", estado));
                    parametros.Add(new SqlParameter("@usercode", dgvUsuario.CurrentRow.Cells["Codigo"].Value.ToString()));
                    string Query = "UPDATE usuarios SET estado_usuario=@estado where usercode=@usercode";
                    crud.executeQuery(Query, parametros, "Estado del Usuario Actualizado Correctamente");
                    getUsuarios();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string Query = "SELECT * FROM View_UsuariosRol where Nombre_de_Usuario like '%" + TxtBuscar.Text + "%'";
            dataTable = crud.getInfo(Query);
            dgvUsuario.DataSource = dataTable;
            dgvUsuario.Refresh();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(TxtBuscar.Text == "")
            {
                getUsuarios();
            }
        }
    }
}
