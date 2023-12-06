using iTextSharp.text.pdf;
using iTextSharp.text;
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
using Sistema_Inventario.BaseDatos;

namespace Sistema_Inventario.Formularios
{
    public partial class FrmCliente : Form
    {
        Controladores.ClassRoles roles = new Controladores.ClassRoles();
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        Controladores.ClassValidaciones val = new Controladores.ClassValidaciones();
        ClassBitacora bitacora = new ClassBitacora();
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        private Form activeForm;


        public FrmCliente()
        {
            InitializeComponent();
        }

        public void ValidadText()
        {



        }
        public void AlcargarListClientes()
        {
            BtnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnConfirmar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEstado.Enabled = false;
            tabControl1.TabPages.Remove(tabPageFormClientes);
            dgvCliente.Refresh();
        }

        private void getClientes()
        {
            DataTable dtClientes = new DataTable();
            String Query = "SELECT * FROM cliente";
            dtClientes = crud.getInfo(Query);
            dgvCliente.DataSource = dtClientes;
            dgvCliente.Refresh();

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            AlcargarListClientes();
            getClientes();

        }

        public void limpiar()
        {
            textId.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textEmail.Clear();
            maskedtbTel.Clear();
            textDireccion.Clear();
            textId.Focus();
        }

        public DataTable ExistenciaUsuario(TextBox userText)
        {
            List<SqlParameter> parametrosValidar = new List<SqlParameter>();
            parametrosValidar.Add(new SqlParameter("@nombre_cliente", userText.Text));
            string QueryValidar = "Select * from cliente where nombre_cliente=@nombre_cliente";
            DataTable dtValidar = new DataTable();
            dtValidar = crud.getInfo(QueryValidar, parametrosValidar);
            return dtValidar;
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
            tabControl1.TabPages.Add(tabPageFormClientes);
            tabControl1.TabPages.Remove(tabpageListClientes);
            BtnGuardar.Enabled = true;
            BtnConfirmar.Enabled = false;
            BtnCancelar.Enabled = true;
            textId.Enabled = true;
            BtnGuardar.BringToFront();

            textId.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPageFormClientes);
            tabControl1.TabPages.Remove(tabpageListClientes);
            BtnConfirmar.Enabled = true;
            textId.Enabled = false;
            BtnConfirmar.BringToFront();


            textId.Text = dgvCliente.CurrentRow.Cells["idcliente"].Value.ToString();
            textNombre.Text = dgvCliente.CurrentRow.Cells["nombre_cliente"].Value.ToString();
            textApellido.Text = dgvCliente.CurrentRow.Cells["apellidos_cliente"].Value.ToString();
            textEmail.Text = dgvCliente.CurrentRow.Cells["correo_Electronico"].Value.ToString();
            maskedtbTel.Text = dgvCliente.CurrentRow.Cells["telefono_cliente"].Value.ToString();
            textDireccion.Text = dgvCliente.CurrentRow.Cells["direccion_cliente"].Value.ToString();

        }

        private void dgvCliente_Click(object sender, EventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnEstado.Enabled = true;


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (msj.Confirmar("¿Desea Cancelar el Registro?") == true)
            {
                limpiar();
                AlcargarListClientes();
                tabControl1.TabPages.Remove(tabPageFormClientes);
                tabControl1.TabPages.Add(tabpageListClientes);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            //Validar si el usuario ya existe

            if (ExistenciaUsuario(textNombre).Rows.Count > 0)
            {
                msj.Aviso("El Usuario ya se encuentra Registrado");
            }
            else
            {
                //Registrar Usuario
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@idcliente", textId.Text));
                parametros.Add(new SqlParameter("@nombre_cliente", textNombre.Text));
                parametros.Add(new SqlParameter("@apellidos_cliente", textApellido.Text));
                parametros.Add(new SqlParameter("@correo_Electronico", textEmail.Text));
                parametros.Add(new SqlParameter("@telefono_cliente", maskedtbTel.Text));
                parametros.Add(new SqlParameter("@direccion_cliente", textDireccion.Text));
                string Query = "INSERT INTO cliente (idcliente,nombre_cliente,apellidos_cliente,direccion_cliente,telefono_cliente,correo_Electronico)" +
                "Values(@idcliente,@nombre_cliente,@apellidos_cliente,@direccion_cliente,@telefono_cliente,@correo_Electronico) ";
                crud.executeQuery(Query, parametros, "Usuario Registrado Correctamente");

                bitacora.InsertarBitacora(" Se registro un cliente");

                limpiar();
                tabControl1.TabPages.Remove(tabPageFormClientes);
                tabControl1.TabPages.Add(tabpageListClientes);
                AlcargarListClientes();


            }



        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text == "")
            {
                getClientes();
            }
            else
            {
                if (rbId.Checked == true && rbNombre.Checked == false)
                {
                    DataTable dataTable = new DataTable();
                    string Query = "SELECT * FROM cliente where idcliente like '%" + textBuscar.Text + "%'";
                    dataTable = crud.getInfo(Query);
                    dgvCliente.DataSource = dataTable;
                    dgvCliente.Refresh();
                }
                if (rbId.Checked == false && rbNombre.Checked == true)
                {
                    DataTable dataTable = new DataTable();
                    string Query = "SELECT * FROM cliente where nombre_cliente like '%" + textBuscar.Text + "%'";
                    dataTable = crud.getInfo(Query);
                    dgvCliente.DataSource = dataTable;
                    dgvCliente.Refresh();
                }




            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (msj.Confirmar("¿Desea Actualizar el usuario?") == true)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@idcliente", textId.Text));
                parametros.Add(new SqlParameter("@nombre_cliente", textNombre.Text));
                parametros.Add(new SqlParameter("@apellidos_cliente", textApellido.Text));
                parametros.Add(new SqlParameter("@correo_Electronico", textEmail.Text));
                parametros.Add(new SqlParameter("@telefono_cliente", maskedtbTel.Text));
                parametros.Add(new SqlParameter("@direccion_cliente", textDireccion.Text));

                string Query = "UPDATE cliente SET idcliente=@idcliente,nombre_cliente=@nombre_cliente," +
                    "apellidos_cliente=@apellidos_cliente,correo_Electronico=@correo_Electronico,telefono_cliente=@telefono_cliente," +
                    "direccion_cliente=@direccion_cliente where idcliente=@idcliente";
                crud.executeQuery(Query, parametros, "");

                limpiar();

                bitacora.InsertarBitacora(" Se actualizo un cliente");
                tabControl1.TabPages.Remove(tabPageFormClientes);
                tabControl1.TabPages.Add(tabpageListClientes);
                getClientes();
                AlcargarListClientes();


            }

            else
            {
                msj.Aviso("El Usuario ya se encuentra Registrado");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "ReporteClientes.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document pdf = new Document(PageSize.A4);
                    PdfWriter.GetInstance(pdf, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    pdf.Open();

                    PdfPTable table = new PdfPTable(dgvCliente.Columns.Count);

                    // Agregar encabezados de columna
                    for (int i = 0; i < dgvCliente.Columns.Count; i++)
                    {
                        table.AddCell(new Phrase(dgvCliente.Columns[i].HeaderText));
                    }

                    // Agregar filas y celdas
                    for (int i = 0; i < dgvCliente.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvCliente.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvCliente.Rows[i].Cells[j].Value?.ToString()));
                        }
                    }

                    pdf.Add(table);
                    pdf.Close();

                    MessageBox.Show("Archivo PDF generado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el archivo PDF: " + ex.Message);
            }
        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if(msj.Confirmar("¿Desea Eliminar el cliente?")==true)
            {
                //List<SqlParameter> parametros = new List<SqlParameter>();
                //parametros.Add(new SqlParameter("@idcliente", textId.Text));
                //string Query = "UPDATE cliente SET estado_cliente=0 where idcliente=@idcliente";
                //crud.executeQuery(Query, parametros, "");
                //bitacora.InsertarBitacora(" Se cambio el estado de un cliente");
                //getClientes();
                //AlcargarListClientes();
            }
        }
    }
}
