using Stimulsoft.Controls.Win.DotNetBar.Validator;
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
    public partial class FrmProductos : Form
    {
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        Controladores.ClassValidaciones val = new Controladores.ClassValidaciones();
        Controladores.ClassRoles rol = new Controladores.ClassRoles();
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        BaseDatos.ClassBitacora bitacora = new BaseDatos.ClassBitacora();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void ValidarText()
        {
            val.ValidarText(errorProvider1, txtNombreArticulo);
            val.ValidarText(errorProvider1, TxtPrecioVenta);
            val.ValidarText(errorProvider1, TxtDescripcion);

            if (CmbCategorias.SelectedIndex == 0)
            {
                msj.Aviso("Seleccione una categoria");
                val.contError++;
                return;
            }

        }

        private void alcargarCompras()
        {
            BtnEditar.Enabled = false;
            BtnEstado.Enabled = false;
            BtnReporte.Enabled = true;

            tabControl1.TabPages.Remove(FormProducto);
            dataGridView1.Refresh();
        }

        private void Limpiar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            CmbCategorias.SelectedIndex = 0;
        }

        private void getCategorias()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM categoria";
            dt = crud.getInfo(query);

            DataRow dataRow = dt.NewRow();
            dataRow["idcategoria"] = -1;
            dataRow["nombre"] = "Seleccione una categoria";
            dataRow["estado"] = "ACT";

            dt.Rows.InsertAt(dataRow, 0);

            CmbCategorias.DataSource = dt;
            CmbCategorias.DisplayMember = "nombre";
            CmbCategorias.ValueMember = "idcategoria";


        }

        private void getProductos()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM View_Productos";
            dataTable = crud.getInfo(query);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            alcargarCompras();
            getProductos();
            getCategorias();
            Button buttonnuevo = new Button();
            Button botonConfirmar = new Button();
            rol.BotonesAccesos(buttonnuevo, BtnGuardar, BtnEditar, BtnEstado, botonConfirmar, dataGridView1, BtnReporte);
        }

        private bool isProductVent(int idArticulo)
        {
            bool isVent = false;
            DataTable dataTable = new DataTable();

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@idArticulo", idArticulo));
            string query = "SELECT art.IdArticulo, art.Nombre_Articulo  FROM articulo as art " +
             "INNER JOIN detalle_venta as detVent on detVent.idarticulo = art.IdArticulo " +
             "where art.IdArticulo = @idArticulo";

            dataTable = crud.getInfo(query, lst);
            if (dataTable.Rows.Count > 0)
            {
                isVent = true;
            }

            return isVent;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                BtnEditar.Enabled = true;
                int idArticulo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (isProductVent(idArticulo) == false)
                {
                    BtnEstado.Enabled = true;
                    BtnEliminar.Visible = true;
                }
                else
                {
                    BtnEliminar.Visible = false;
                    BtnEstado.Enabled = true;
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tabControl1.TabPages.Add(FormProducto);
                tabControl1.TabPages.Remove(ListProductos);
                BtnGuardar.Visible = true;

                txtNombreArticulo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtPrecioVenta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtDescripcion.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                CmbCategorias.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                PbFoto.ImageLocation = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int idArticulo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string estado = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string query = "";

                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@idArticulo", idArticulo));
                if (estado == "ACT")
                {
                    query = "UPDATE articulo SET Estado_Articulo = 'INA' WHERE IdArticulo = @idArticulo";
                }
                else
                {
                    query = "UPDATE articulo SET Estado_Articulo = 'ACT' WHERE IdArticulo = @idArticulo";
                }

                crud.executeQuery(query, lst, "Se cambio el estado del producto");
                bitacora.InsertarBitacora("Se cambio el estado del producto");
                Limpiar();
                getProductos();
                alcargarCompras();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int idArticulo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string query = "";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@idArticulo", idArticulo));
                query = "DELETE FROM articulo WHERE IdArticulo = @idArticulo";
                crud.executeQuery(query, lst, "Se elimino el producto");
                bitacora.InsertarBitacora("Se elimino el producto");
                Limpiar();
                getProductos();
                alcargarCompras();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            val.contError = 0;
            ValidarText();
            errorProvider1.Clear();
            if (val.contError > 0)
            {
                string dirFoto;
                if (PbFoto.ImageLocation == null)
                {
                    dirFoto = "";
                }
                else
                {
                    dirFoto = PbFoto.ImageLocation;
                }

                string query = "";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@nombre", txtNombreArticulo.Text));
                lst.Add(new SqlParameter("@idcategoria", CmbCategorias.SelectedValue));
                lst.Add(new SqlParameter("@precio_venta", TxtPrecioVenta.Text));
                lst.Add(new SqlParameter("@descripcion", TxtDescripcion.Text));
                lst.Add(new SqlParameter("@imagen", dirFoto));

                query = "INSERT INTO articulo (IdCategoria, Nombre_Articulo, Precio_Venta, Descripcion, Imagen) " +
                    "VALUES (@nombre, @idcategoria, @precio_venta, @descripcion, @imagen)";
                crud.executeQuery(query, lst, "Se guardo el producto");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (msj.Confirmar("Desea cancelar la operacion") == true)
            {
                Limpiar();
                alcargarCompras();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            textBox1.Visible = true;
            if (textBox1.Text == "")
            {
                getProductos();
            }
            else
            {
                DataTable dataTable = new DataTable();
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@nombreArticulo", textBox1.Text));
                string query = "SELECT * FROM View_Productos WHERE Nombre_Articulo LIKE '%' + @nombreArticulo + '%'";
                dataTable = crud.getInfo(query);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            getCategorias();
            textBox1.Visible = false;
            if (textBox1.Text == "")
            {
                getProductos();
            }
            else
            {
                DataTable dataTable = new DataTable();
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@categoria", comboBox1.Text));
                string query = "SELECT * FROM View_Productos WHERE Categoria LIKE '%' + @categoria + '%'";
                dataTable = crud.getInfo(query);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
           

        }

        
    }
}
