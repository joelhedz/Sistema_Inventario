using Sistema_Inventario.Controladores;
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
    public partial class FrmCompras : Form
    {
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        Controladores.ClassValidaciones val = new Controladores.ClassValidaciones();
        Controladores.ClassRoles rol = new Controladores.ClassRoles();
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void ValidarText()
        {
            val.ValidarText(errorProvider1, TxtCantidad);
            val.ValidarText(errorProvider1, TxtPrecio);
            val.ValidarText(errorProvider1, TxtProducto);
            val.ValidarText(errorProvider1, TxtDescripcion);
            if (rbNuevo.Checked == false && rbExistente.Checked == false)
            {
                LblError.Visible = true;
                LblError.Text = "Seleccione una opcion";
                val.contError++;
                return;
            }

            if (cmbProveedores.SelectedIndex == 0)
            {
                msj.Aviso("Seleccione un proveedor");
                val.contError++;
                return;
            }
            if (rbExistente.Checked == true && CmbProductos.SelectedIndex == 0)
            {
                msj.Aviso("Seleccione un articulo");
                val.contError++;
                return;
            }

            if (CmbCategoria.SelectedIndex == 0)
            {
                msj.Aviso("Seleccione una categoria");
                val.contError++;
                return;
            }

        }

        private void alcargarCompras()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEstado.Enabled = false;
            BtnReportes.Enabled = true;
            TxtIdArticulo.Enabled = false;


            tabControl1.TabPages.Remove(FormCompra);
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
            cmbProveedores.SelectedIndex = 0;
            CmbCategoria.SelectedIndex = 0;
        }

        private void GetCompras()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT * FROM View_Compras";
            dt = crud.getInfo(Query);

            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString(),
                    dr[7].ToString(),
                    dr[8].ToString()
                    );
            }

        }

        private void GetProveedores()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT proveedores.idproveedores,proveedores.Nombre_Proveedor FROM proveedores";
            dt = crud.getInfo(Query);

            DataRow row = dt.NewRow();
            row["idproveedores"] = -1;
            row["Nombre_Proveedor"] = "Seleccione un proveedor";
            dt.Rows.InsertAt(row, 0);

            cmbProveedores.DataSource = dt;
            cmbProveedores.DisplayMember = "Nombre_Proveedor";
            cmbProveedores.ValueMember = "idproveedores";
        }

        private void GetCategorias()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT categoria.idcategoria,categoria.nombre FROM categoria";
            dt = crud.getInfo(Query);

            DataRow row = dt.NewRow();
            row["idcategoria"] = -1;
            row["nombre"] = "Seleccione una categoria";
            dt.Rows.InsertAt(row, 0);

            CmbCategoria.DataSource = dt;
            CmbCategoria.DisplayMember = "nombre";
            CmbCategoria.ValueMember = "idcategoria";
        }

        private void btnimagen_Click(object sender, EventArgs e)
        {
            OPDFoto.ShowDialog();
            PbFoto.ImageLocation = OPDFoto.FileName;
        }


        private void FrmCompras_Load(object sender, EventArgs e)
        {
            alcargarCompras();
            GetCompras();
            GetProveedores();
            GetCategorias();
            rol.BotonesAccesos(BtnNuevo, BtnGuardar, BtnEditar, BtnEstado, BtnConfirmar, dataGridView1 );

        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                msj.Aviso("Solo valores numericos");
                e.Handled = true;
                return;
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                msj.Aviso("Solo valores numericos");
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                BtnEditar.Enabled = true;
                BtnEstado.Enabled = true;
                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "ACT")
                {
                    BtnEstado.Text = "Cancelar";
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(ListCompra);
            tabControl1.TabPages.Add(FormCompra);
            BtnConfirmar.Enabled = false;
            BtnGuardar.Enabled = true;
            BtnGuardar.BringToFront();
        }

        private int StockArticulo(TextBox idarticulo)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@IdArticulo", idarticulo.Text));
            int stock = 0;
            string Query = "SELECT Stock FROM articulo WHERE IdArticulo = @IdArticulo ";
            DataTable dt = new DataTable();
            dt = crud.getInfo(Query, Parametros);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr[0].ToString());
            }
            return stock;
        }

        private void GetArticulo()
        {

            string Query = "SELECT articulo.IdArticulo, articulo.Nombre_Articulo FROM articulo ";
            DataTable dt = new DataTable();
            dt = crud.getInfo(Query);

            DataRow row = dt.NewRow();
            row["IdArticulo"] = -1;
            row["Nombre_Articulo"] = "Seleccione un articulo";
            dt.Rows.InsertAt(row, 0);

            CmbProductos.DataSource = dt;
            CmbProductos.DisplayMember = "Nombre_Articulo";
            CmbProductos.ValueMember = "IdArticulo";

        }

        private int IdIngreso()
        {
            int id = 0;
            string Query = "SELECT MAX(idingreso) FROM ingreso";
            DataTable dt = new DataTable();
            dt = crud.getInfo(Query);
            foreach (DataRow dr in dt.Rows)
            {
                id = Convert.ToInt32(dr[0].ToString());
            }
            return id;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (msj.Confirmar("Desea cancelar la operacion?") == true)
            {
                tabControl1.TabPages.Remove(FormCompra);
                tabControl1.TabPages.Add(ListCompra);
                Limpiar();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            val.contError = 0;
            ValidarText();
            errorProvider1.Clear();
            if (val.contError == 0)
            {
                int IdArticulo = 0;
                string FotoDir;
                if (PbFoto.ImageLocation == null)
                {
                    FotoDir = "";
                }
                else
                {
                    FotoDir = PbFoto.ImageLocation.ToString();
                }
                int Id_Categoria = Convert.ToInt32(CmbCategoria.SelectedValue);

                if (rbNuevo.Checked == true)
                {
                    string consultaArticulo = "Select * from articulo where Nombre_Articulo=@ProductoName";
                    List<SqlParameter> ParametrosArticulo = new List<SqlParameter>();
                    ParametrosArticulo.Add(new SqlParameter("@ProductoName", TxtProducto.Text));
                    DataTable Recordset = new DataTable();
                    Recordset = crud.getInfo(consultaArticulo, ParametrosArticulo);

                    if (Recordset.Rows.Count > 0)
                    {
                        MessageBox.Show("Ya existe un articulo con ese nombre");
                        return;
                    }
                    else
                    {
                        List<SqlParameter> Parametros = new List<SqlParameter>();
                        Parametros.Add(new SqlParameter("@IdCategoria", Id_Categoria));
                        Parametros.Add(new SqlParameter("@NombreProducto", TxtProducto.Text));
                        Parametros.Add(new SqlParameter("@Precio", TxtPrecio.Text));
                        Parametros.Add(new SqlParameter("@Stokc", TxtCantidad.Text));
                        Parametros.Add(new SqlParameter("@Descrip", TxtDescripcion.Text));
                        Parametros.Add(new SqlParameter("@foto", FotoDir));
                        string Query0 = "Insert into articulo(IdCategoria,Nombre_Articulo,Precio_Venta," +
                            "Stock,Descripcion,foto)values(@IdCategoria,@NombreProducto,@Precio, " +
                            "@Stokc, @Descrip, @foto)";
                        crud.executeQuery(Query0, Parametros, "");

                        
                        string Query = "SELECT MAX(IdArticulo) FROM articulo";
                        DataTable dt = new DataTable();
                        dt = crud.getInfo(Query);
                        foreach (DataRow dr in dt.Rows)
                        {
                            IdArticulo = Convert.ToInt32(dr[0].ToString());
                        }
                    }
                }
                else if (rbExistente.Checked == true)
                {
                    int StockIngresar = Convert.ToInt32(TxtCantidad.Text);
                    List<SqlParameter> ParametrosUpdtArticulo = new List<SqlParameter>();
                    ParametrosUpdtArticulo.Add(new SqlParameter("@IdCategoria", Id_Categoria));
                    ParametrosUpdtArticulo.Add(new SqlParameter("@NombreProducto", CmbProductos.Text));
                    ParametrosUpdtArticulo.Add(new SqlParameter("@Precio", TxtPrecio.Text));
                    ParametrosUpdtArticulo.Add(new SqlParameter("@Stokc", StockIngresar += StockArticulo(TxtIdArticulo)));
                    ParametrosUpdtArticulo.Add(new SqlParameter("@Descrip", TxtDescripcion.Text));
                    ParametrosUpdtArticulo.Add(new SqlParameter("@foto", FotoDir));
                    ParametrosUpdtArticulo.Add(new SqlParameter("@IdArticulo", TxtIdArticulo.Text));

                    string Query = "Update articulo Set IdCategoria =@IdCategoria," +
                    "Nombre_Articulo=@NombreProducto, Precio_Venta=@Precio, Stock=@Stokc," +
                    "Descripcion=@Descrip ,foto=@foto where IdArticulo= @IdArticulo";
                    crud.executeQuery(Query, ParametrosUpdtArticulo, "");
                    IdArticulo = Convert.ToInt32(TxtIdArticulo.Text);
                }

                string dtFecha_ = dtFecha.Value.ToString("yyyy-MM-dd");
                List<SqlParameter> ParametrosIngreso = new List<SqlParameter>();
                ParametrosIngreso.Add(new SqlParameter("@IdProveedor", cmbProveedores.SelectedValue));
                ParametrosIngreso.Add(new SqlParameter("@IdUsuario", ClassDatosUsuario.IdUsuario));
                ParametrosIngreso.Add(new SqlParameter("@FechaIngreso", dtFecha_));

                string Query2 = "Insert into ingreso(idproveedores,idusuario,fecha_ingreso)" +
                    "values(@IdProveedor,@IdUsuario,@FechaIngreso)";
                crud.executeQuery(Query2, ParametrosIngreso, "");

                List<SqlParameter> ParametrosDetalleIngreso = new List<SqlParameter>();
                ParametrosDetalleIngreso.Add(new SqlParameter("@IdArticulo", IdArticulo));
                ParametrosDetalleIngreso.Add(new SqlParameter("@Cantidad", TxtCantidad.Text));
                ParametrosDetalleIngreso.Add(new SqlParameter("@Precio", TxtPrecio.Text));
                ParametrosDetalleIngreso.Add(new SqlParameter("@IdIngreso", IdIngreso()));

                string Query3 = "Insert into detalle_ingreso(idingreso,idarticulo,cantidad,precio)" +
                    "values(@IdIngreso,@IdArticulo,@Cantidad,@Precio)";
                crud.executeQuery(Query3, ParametrosDetalleIngreso, "Compra Realizada!");

                DateTime fecha = DateTime.Now.Date;
                string fechanow = fecha.ToString("yyyy-MM-dd");
                List<SqlParameter> ParametrosBitacora = new List<SqlParameter>();
                ParametrosBitacora.Add(new SqlParameter("@Iduser", ClassDatosUsuario.IdUsuario));
                ParametrosBitacora.Add(new SqlParameter("@fecha", fechanow));

                string Bitacora = "Insert into bitacora(fecha_hora,tipo_de_Evento,usercode)" +
                    "values(@fecha,'Nueva Compra',@Iduser)";
                crud.executeQuery(Bitacora, ParametrosBitacora, "");
                Limpiar();
                GetCompras();
                tabControl1.TabPages.Remove(FormCompra);
                tabControl1.TabPages.Add(ListCompra);
                alcargarCompras();
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            val.contError = 0;
            ValidarText();
            errorProvider1.Clear();
            if (val.contError == 0)
            {
                if (msj.Confirmar("Desea confirmar los cambios?") == true)
                {
                    string FotoDir;
                    if (PbFoto.ImageLocation == null)
                    {
                        FotoDir = "";
                    }
                    else
                    {
                        FotoDir = PbFoto.ImageLocation.ToString();
                    }
                    int Id_Categoria = Convert.ToInt32(CmbCategoria.SelectedValue);
                    int idCompra = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    int cantidad = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);

                    List<SqlParameter> ParametrosIngreso = new List<SqlParameter>();
                    ParametrosIngreso.Add(new SqlParameter("@IdProveedor", cmbProveedores.SelectedValue));
                    ParametrosIngreso.Add(new SqlParameter("@IdUsuario", ClassDatosUsuario.IdUsuario));
                    ParametrosIngreso.Add(new SqlParameter("@FechaIngreso", dtFecha.Value.ToString("yyyy-MM-dd")));
                    ParametrosIngreso.Add(new SqlParameter("@IdIngreso", idCompra));

                    string Query0 = "Update ingreso set idproveedores=@IdProveedor, idusuario=@IdUsuario," +
                        "fecha_ingreso=@FechaIngreso where idingreso=@IdIngreso";
                    crud.executeQuery(Query0, ParametrosIngreso, "");

                    List<SqlParameter> ParametrosDetalleIngreso = new List<SqlParameter>();
                    ParametrosDetalleIngreso.Add(new SqlParameter("@IdArticulo", TxtIdArticulo.Text));
                    ParametrosDetalleIngreso.Add(new SqlParameter("@Cantidad", TxtCantidad.Text));
                    ParametrosDetalleIngreso.Add(new SqlParameter("@Precio", TxtPrecio.Text));
                    ParametrosDetalleIngreso.Add(new SqlParameter("@IdIngreso", idCompra));

                    string Query1 = "Update detalle_ingreso set idarticulo=@IdArticulo, cantidad=@Cantidad," +
                        "precio=@Precio where idingreso=@IdIngreso";
                    crud.executeQuery(Query1, ParametrosDetalleIngreso, "");

                    string Query;
                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@IdCategoria", Id_Categoria));
                    Parametros.Add(new SqlParameter("@NombreProducto", TxtProducto.Text));
                    Parametros.Add(new SqlParameter("@Precio", TxtPrecio.Text));
                    Parametros.Add(new SqlParameter("@Stokc", TxtCantidad.Text));
                    Parametros.Add(new SqlParameter("@Descrip", TxtDescripcion.Text));
                    Parametros.Add(new SqlParameter("@foto", FotoDir));
                    Parametros.Add(new SqlParameter("@IdArticulo", TxtIdArticulo.Text));

                    Query = "Update articulo Set IdCategoria =@IdCategoria," +
                        "Nombre_Articulo=@NombreProducto, Precio_Venta=@Precio, Stock=@Stokc," +
                        "Descripcion=@Descrip ,foto=@foto where IdArticulo= @IdArticulo";
                    crud.executeQuery(Query, Parametros, "Compra Actualizada Correctamente");


                    BaseDatos.ClassBitacora bitacora = new BaseDatos.ClassBitacora();
                    bitacora.InsertarBitacora("Modifico una compra");
                    Limpiar();
                    GetCompras();
                    tabControl1.TabPages.Remove(FormCompra);
                    tabControl1.TabPages.Add(ListCompra);
                    alcargarCompras();
                }
            }
        }

        private void rbIngresar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            TxtDescripcion.Enabled = true;
            CmbCategoria.Enabled = true;
            TxtProducto.Enabled = true;
            TxtProducto.BringToFront();
            CmbProductos.Enabled = false;
            TxtIdArticulo.Clear();
            TxtProducto.Clear();
            TxtPrecio.Clear();
            TxtDescripcion.Clear();
            PbFoto.ImageLocation = null;

        }



        private void CmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbProductos.SelectedItem = CmbProductos.Text;
            if (CmbProductos.SelectedIndex > 0)
            {
                TxtDescripcion.Enabled = false;
                CmbCategoria.Enabled = false;
                int IdArticulo = Convert.ToInt32(CmbProductos.SelectedValue);
                List<SqlParameter> Parametros = new List<SqlParameter>();
                Parametros.Add(new SqlParameter("@IdArticulo", IdArticulo));
                string Query = "Select * from articulo where IdArticulo=@IdArticulo";
                DataTable dt = new DataTable();
                dt = crud.getInfo(Query, Parametros);
                foreach (DataRow dr in dt.Rows)
                {
                    TxtIdArticulo.Text = dr[0].ToString();
                    CmbCategoria.SelectedValue = dr[1].ToString();
                    TxtProducto.Text = dr[2].ToString();
                    TxtPrecio.Text = dr[3].ToString();
                    TxtDescripcion.Text = dr[5].ToString();
                    PbFoto.ImageLocation = dr[6].ToString();
                }
            }
            else
            {
                Limpiar();
            }
        }

        private void TxtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbExistente_CheckedChanged(object sender, EventArgs e)
        {
            GetArticulo();
            TxtProducto.Enabled = false;
            TxtProducto.SendToBack();
            CmbProductos.Enabled = true;
            CmbProductos.BringToFront();
            TxtPrecio.Clear();
            TxtDescripcion.Clear();
            PbFoto.ImageLocation = null;

        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string Query = "SELECT * FROM View_Compras where proveedor like @buscar";
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@buscar", "%" + txtBuscar.Text + "%"));
            dataTable = crud.getInfo(Query, Parametros);
            dataGridView1.DataSource = dataTable;

        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string Query = "SELECT * FROM View_Compras where Articulo like @buscar";
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@buscar", "%" + txtBuscar.Text + "%"));
            dataTable = crud.getInfo(Query, Parametros);
            dataGridView1.DataSource = dataTable;

        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DateTime fecha = DateTime.Now.Date;
                string fechanow = fecha.ToString("yyyy-MM-dd");
                //Validar que no hayan pasado 24 horas desde la compra
                if (Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString()) < Convert.ToDateTime(fechanow))
                {
                    msj.Aviso("No se puede cancelar una compra despues de 24 horas");
                    return;
                }
                else
                {
                    TxtIdArticulo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int cant = Convert.ToInt32(TxtCantidad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    if (StockArticulo(TxtIdArticulo) == 0 && cant > StockArticulo(TxtIdArticulo))
                    {
                        msj.Aviso("No se puede cancelar una compra si el articulo no tiene stock");
                    }
                    else
                    {
                        int idCompra = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        if (msj.Confirmar("Desea cancelar la compra?") == true)
                        {
                            List<SqlParameter> Parametros = new List<SqlParameter>();
                            Parametros.Add(new SqlParameter("@IdArticulo", TxtIdArticulo.Text));
                            Parametros.Add(new SqlParameter("@Cantidad", TxtCantidad.Text));
                            Parametros.Add(new SqlParameter("@IdIngreso", idCompra));

                            string Query = "Update articulo set Stock=Stock-@Cantidad where IdArticulo=@IdArticulo";
                            crud.executeQuery(Query, Parametros, "");

                            string Query2 = "Update ingreso set estado='INA' where idingreso=@IdIngreso";
                            crud.executeQuery(Query2, Parametros, "");

                            BaseDatos.ClassBitacora bitacora = new BaseDatos.ClassBitacora();
                            bitacora.InsertarBitacora("Cancelo una compra");
                            Limpiar();
                            GetCompras();
                            alcargarCompras();
                        }
                    }
                }

            }


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "INA")
                {
                    msj.Aviso("No se puede editar una compra cancelada");
                    return;
                }
                else
                {
                    tabControl1.TabPages.Remove(ListCompra);
                    tabControl1.TabPages.Add(FormCompra);
                    BtnGuardar.Enabled = false;
                    BtnConfirmar.Enabled = true;
                    BtnConfirmar.BringToFront();
                    TxtIdArticulo.Enabled = false;
                    rbExistente.Checked = true;
                    TxtProducto.Enabled = false;
                    TxtProducto.SendToBack();
                    CmbProductos.Enabled = false;
                    TxtIdArticulo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    CmbCategoria.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    TxtProducto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    TxtPrecio.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    TxtCantidad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    cmbProveedores.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dtFecha.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                }
            }
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
           
        }
    }
}
