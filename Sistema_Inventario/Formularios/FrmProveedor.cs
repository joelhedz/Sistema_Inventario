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

namespace Sistema_Inventario.Formularios
{
    public partial class FrmProveedor : Form
    {
        private int IdProveedor = 0;
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        Controladores.ClassRoles rol = new Controladores.ClassRoles();
        Controladores.ClassValidaciones val = new Controladores.ClassValidaciones();
        public FrmProveedor()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";

                }
            }
        }


        private void ValidarCampos()
        {
            val.ValidarText(errorProvider1, txtRtn);
            val.ValidarText(errorProvider1, txtNombre);
            val.validarTel(errorProvider1, txtTelefono);
            val.validarEmail(errorProvider1, txtEmail);

        }

        private void AlcargarFormulario()
        {
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnConfirmar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEstado.Enabled = false;
            btnReporte.Enabled = true;
            BtnGuardar.Enabled = false;
            tabControl1.Controls.Remove(FormProveedor);
            dataGridView1.Refresh();
        }

        private void GetProveedores()
        {
            DataTable dt = new DataTable();
            string query = "select * from proveedores";
            dt = crud.getInfo(query);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


        }
        //List<SqlParameter> parametros = new List<SqlParameter>();
        //parametros.Add(new SqlParameter("@Rtn", txtRtn.Text));
        //    parametros.Add(new SqlParameter("@Nombre", txtNombre.Text));
        //    parametros.Add(new SqlParameter("@Direccion", txtDireccion.Text));
        //    parametros.Add(new SqlParameter("@Telefono", txtTelefono.Text));
        //    parametros.Add(new SqlParameter("@Email", txtEmail.Text));
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            AlcargarFormulario();
            rol.BotonesAccesos(BtnNuevo, BtnGuardar, BtnEditar, BtnEstado, BtnConfirmar, dataGridView1);
            GetProveedores();
        }

        private void btnlmpiar_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(FormProveedor);
            tabControl1.TabPages.Remove(ListProveedores);
            BtnGuardar.Enabled = true;
            BtnGuardar.BringToFront();
            BtnConfirmar.Visible = false;
            BtnCancelar.Enabled = true;

            txtRtn.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(FormProveedor);
            tabControl1.TabPages.Remove(ListProveedores);
            BtnConfirmar.Enabled = true;
            BtnConfirmar.BringToFront();
            BtnConfirmar.BringToFront();

            IdProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idproveedores"].Value.ToString());
            txtRtn.Text = dataGridView1.CurrentRow.Cells["RTN"].Value.ToString();
            txtRtn.Enabled = false;
            txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre_Proveedor"].Value.ToString();
            txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion_Proveedor"].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (BtnEstado.Text == "Eliminar")
                {
                    if (msj.Confirmar("¿Desea Eliminar el Proveedor?") == true)
                    {
                        List<SqlParameter> parametros = new List<SqlParameter>();
                        parametros.Add(new SqlParameter("@idProveedor", IdProveedor));
                        string Query = "delete from proveedores where idproveedores=@idProveedor";
                        crud.executeQuery(Query, parametros, "Proveedor Eliminado Correctamente");
                        GetProveedores();
                    }
                }
                else
                {
                    if (msj.Confirmar("¿Desea Cambiar el Estado del Proveedor?") == true)
                    {
                        string estado = "";
                        if (dataGridView1.CurrentRow.Cells["Estado"].Value.ToString() == "ACT")
                        {
                            estado = "INA";
                        }
                        else
                        {
                            estado = "ACT";
                        }

                        List<SqlParameter> parametros = new List<SqlParameter>();
                        parametros.Add(new SqlParameter("@estado", estado));
                        parametros.Add(new SqlParameter("@idProveedor", IdProveedor));
                        string Query = "update proveedores set Estado=@estado where idproveedores=@idProveedor";
                        crud.executeQuery(Query, parametros, "Estado Actualizado Correctamente");
                        GetProveedores();
                    }
                }
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            DataTable dtProveedor = new DataTable();
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
               new SqlParameter("@idProveedor", IdProveedor)
            };
            string query = "select from proveedores INNER JOIN ingreso.idproveedores=proveedores.idproveedores " +
                "where idproveedores=@idProveedor";

            if (dataGridView1.Rows.Count > 0)
            {
                if (dtProveedor.Rows.Count > 0)
                {
                    BtnEstado.Text = "Eliminar";
                }
                if (dataGridView1.CurrentRow.Cells["Estado"].Value.ToString() == "ACT")
                {
                    BtnEstado.Text = "Desactivar";
                }
                else
                {
                    BtnEstado.Text = "Activar";
                }
                BtnEditar.Enabled = true;
                BtnEstado.Enabled = true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            txtRtn.Enabled = true;
            val.contError = 0;
            errorProvider1.Clear();
            ValidarCampos();
            string estadoRol = "ACT";

            if (val.contError == 0)
            {
                List<SqlParameter> ProvParametros = new List<SqlParameter>();
                ProvParametros.Add(new SqlParameter("@RTN", txtRtn.Text));


                string QuerySelc = "Select * from proveedores where RTN=@RTN";
                DataTable dt = new DataTable();
                dt = crud.getInfo(QuerySelc, ProvParametros);

                //Validar si el proveedor ya existe

                if (dt.Rows.Count > 0)
                {
                    msj.Aviso("Ya se encuentra un registrado con el mismo RTN");
                }
                else
                {
                    //Registrar Proveedor
                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@RTN", txtRtn.Text));
                    Parametros.Add(new SqlParameter("@Nombre", txtNombre.Text));
                    Parametros.Add(new SqlParameter("@Direccion", txtDireccion.Text));
                    Parametros.Add(new SqlParameter("@Telefono", txtTelefono.Text));
                    Parametros.Add(new SqlParameter("@Email", txtEmail.Text));

                    String QueryInsert = "INSERT INTO proveedores(Nombre_Proveedor,RTN,Direccion_Proveedor,Email,Telefono)" +
                        "Values(@Nombre,@RTN,@Direccion,@Email,@Telefono)";
                    crud.executeQuery(QueryInsert, Parametros, "Proveedor Registrado Correctamente");

                    Limpiar();
                    AlcargarFormulario();
                    tabControl1.TabPages.Remove(FormProveedor);
                    tabControl1.TabPages.Add(ListProveedores);

                }


            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            val.contError = 0;
            errorProvider1.Clear();
            ValidarCampos();
            if (val.contError == 0)
            {
                if (msj.Confirmar("¿Desea Actualizar el Proveedor?") == true)
                {
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("@Rtn", txtRtn.Text));
                    parametros.Add(new SqlParameter("@Nombre", txtNombre.Text));
                    parametros.Add(new SqlParameter("@Direccion", txtDireccion.Text));
                    parametros.Add(new SqlParameter("@Telefono", txtTelefono.Text));
                    parametros.Add(new SqlParameter("@Email", txtEmail.Text));
                    parametros.Add(new SqlParameter("@idProveedor", IdProveedor));

                    string Query = "update proveedores set Nombre_Proveedor=@Nombre, " +
                        "Direccion_Proveedor=@Direccion,Email=@Email,Telefono=@Telefono where idproveedores=@idProveedor";
                    crud.executeQuery(Query, parametros, "Proveedor Actualizado Correctamente");
                    Limpiar();
                    GetProveedores();
                    AlcargarFormulario();
                    tabControl1.TabPages.Remove(FormProveedor);
                    tabControl1.TabPages.Add(ListProveedores);
                    txtRtn.Enabled = true;
                }

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                GetProveedores();
            }
            else
            {
                DataTable dt = new DataTable();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@buscar", txtBuscar.Text));
                string query = "select * from proveedores where Nombre_Proveedor like @buscar + '%' or RTN like @buscar + '%'";
                dt = crud.getInfo(query, parametros);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (msj.Confirmar("¿Desea Cancelar?") == true)
            {
                Limpiar();
                AlcargarFormulario();
                tabControl1.TabPages.Remove(FormProveedor);
                tabControl1.TabPages.Add(ListProveedores);
                txtRtn.Enabled = true;
            }
        }

       

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "ReporteProveedores.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document pdf = new Document(PageSize.A4);
                    PdfWriter.GetInstance(pdf, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    pdf.Open();

                    PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                    // Agregar encabezados de columna
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
                    }

                    // Agregar filas y celdas
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value?.ToString()));
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
    }
}
