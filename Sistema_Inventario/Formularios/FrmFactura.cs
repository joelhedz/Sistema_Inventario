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
    public partial class FrmFactura : Form
    {
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        Controladores.ClassValidaciones val = new Controladores.ClassValidaciones();
        Controladores.ClassRoles rol = new Controladores.ClassRoles();
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        BaseDatos.ClassBitacora bitacora = new BaseDatos.ClassBitacora();
        public FrmFactura()
        {
            InitializeComponent();
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

        private void alcargarForm()
        {
            gbCliente.Enabled = false;
            gbDetalles.Enabled = false;
            txtTotal.Enabled = false;
            txtDevolucion.Enabled = false;
            txtEfectivo.Enabled = false;
            btnRVenta.Enabled = false;

            btnNueva.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnRVenta.Enabled = true;

        }

        private void limpiarText()
        {
            foreach (Control control in gbCliente.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";

                }
            }
            foreach (Control control in gbDetalles.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";

                }
            }
            txtCantidad.Value = 0;
            txtTotal.Clear();
            txtDevolucion.Clear();
            txtEfectivo.Clear();
        }
        private void validarText()
        {
            val.ValidarText(errorProvider1, txtIdArticulo);
            val.ValidarText(errorProvider1, txtPrecio);
            if (txtCantidad.Value == 0)
            {
                errorProvider1.SetError(txtCantidad, "Campo Obligatorio!");
                val.contError++;
                return;
            }
        }
        private void activarText()
        {
            gbCliente.Enabled = true;
            gbDetalles.Enabled = true;
            txtPrecio.Enabled = false;
            txtEfectivo.Enabled = true;


        }

        private void agregarDatosgrid()
        {

            errorProvider1.Clear();
            dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Count - 1];

            double total, cant, prec;
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "0";
            }
            if (txtPrecio.Text == "") { txtPrecio.Text = "0"; }
            cant = Convert.ToDouble(txtCantidad.Text);
            prec = Convert.ToDouble(txtPrecio.Text);
            total = cant * prec;

            row.Cells[0].Value = txtIdArticulo.Text;
            row.Cells[1].Value = cmbArticulo.Text;
            row.Cells[2].Value = txtCantidad.Text;
            row.Cells[3].Value = txtPrecio.Text;
            row.Cells[4].Value = total;

            dataGridView1.Update();


        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            alcargarForm();
            getClientes();
            getArticulo();
        }

        private int idventa()
        {
            int idventa;
            DataTable dt = new DataTable();
            string Query = "Select MAX(idventa) from venta";
            dt = crud.getInfo(Query);
            idventa = Convert.ToInt32(dt.Rows[0][0]);

            return idventa;
        }

        private void getArticulo()
        {
            DataTable dt = new DataTable();
            string Query = "Select ar.IdArticulo,ar.Nombre_Articulo,ar.Precio_Venta from articulo as ar";
            dt = crud.getInfo(Query);

            DataRow row = dt.NewRow();
            row["Nombre_Articulo"] = "Seleccione un Articulo";
            row["IdArticulo"] = -1;
            row["Precio_Venta"] = 0;
            dt.Rows.InsertAt(row, 0);

            cmbArticulo.DataSource = dt;
            cmbArticulo.DisplayMember = "Nombre_Articulo";
            cmbArticulo.ValueMember = "IdArticulo";

        }

        private void getClientes()
        {
            DataTable dt = new DataTable();
            string Query = "Select cl.idcliente,cl.nombre_cliente from cliente as cl";
            dt = crud.getInfo(Query);

            DataRow row = dt.NewRow();
            row["nombre_cliente"] = "Seleccione un Cliente";
            row["idcliente"] = -1;
            dt.Rows.InsertAt(row, 0);

            cmbCliente.DataSource = dt;
            cmbCliente.DisplayMember = "nombre_cliente";
            cmbCliente.ValueMember = "idcliente";

        }

        private void btnRVenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                msj.Aviso("No hay productos en la lista");
                return;
            }
            string Fecha_ = dtFecha.Value.ToString("yyyy-MM-dd");
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@IdCliente", cmbCliente.SelectedValue));
            Parametros.Add(new SqlParameter("@IdUsuario", ClassDatosUsuario.IdUsuario));
            Parametros.Add(new SqlParameter("@Fecha_Venta", Fecha_));
            string Query = "INSERT INTO venta(IdCliente, IdUsuario, Fecha_Venta) VALUES " +
                "(@IdCliente, @IdUsuario, @Fecha_Venta)";

            crud.executeQuery(Query, Parametros, "");


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string idArticulo, precio;
                idArticulo = row.Cells[0].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells[2].Value);
                precio = row.Cells[3].Value.ToString();

                List<SqlParameter> Parametros2 = new List<SqlParameter>();
                Parametros2.Add(new SqlParameter("@IdArticulo", idArticulo));

                string Articulo = "Select * from articulo where IdArticulo =@IdArticulo";
                DataTable Recordser = crud.getInfo(Articulo, Parametros2);
                int stoks = 0;
                if (Recordser.Rows.Count > 0)
                {
                    stoks = Convert.ToInt32(Recordser.Rows[0][4]);
                    stoks -= cantidad;
                    List<SqlParameter> Parametros3 = new List<SqlParameter>();
                    Parametros3.Add(new SqlParameter("@IdArticulo", idArticulo));
                    Parametros3.Add(new SqlParameter("@Stock", stoks));

                    string updateStok = "Update articulo set Stock=@Stock " +
                        "where IdArticulo=@IdArticulo ";
                    crud.executeQuery(updateStok, Parametros3, "");
                }

                List<SqlParameter> Parametros4 = new List<SqlParameter>();
                Parametros4.Add(new SqlParameter("@IdArticulo", idArticulo));
                Parametros4.Add(new SqlParameter("@Cantidad", cantidad));
                Parametros4.Add(new SqlParameter("@Precio", precio));
                Parametros4.Add(new SqlParameter("@IdVenta", idventa()));

                string Query2 = "Insert into detalle_venta(idventa,idarticulo,cantidad,precio)values" +
                    "(@IdVenta, @IdArticulo, @Cantidad, @Precio)";
                crud.executeQuery(Query2, Parametros4, "");
            }
            bitacora.InsertarBitacora("Venta Realizada");
            msj.Exito("Venta Realizada");
            limpiarText();
            alcargarForm();
            dataGridView1.Rows.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblStoks.Visible = false;
            val.contError = 0;
            validarText();
            if (val.contError == 0)
            {
                agregarDatosgrid();
                txtIdArticulo.Clear();
                txtCantidad.Value = 0;
                cmbArticulo.SelectedIndex = 0;
                txtPrecio.Clear();
                txtTotal.Text = total().ToString();
                btnRVenta.Enabled = true;
            }
        }

        private double total()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells[4].Value);
            }
            return total;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnNueva.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
                btnRVenta.Enabled = false;
                txtIdArticulo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cmbArticulo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            val.contError = 0;
            validarText();
            if (val.contError == 0)
            {
                if (MessageBox.Show("Desea Guardar los cambios", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int fila = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow row = dataGridView1.Rows[fila];

                    double total = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);

                    row.Cells[0].Value = txtIdArticulo.Text;
                    row.Cells[1].Value = cmbArticulo.Text;
                    row.Cells[2].Value = txtCantidad.Text;
                    row.Cells[3].Value = txtPrecio.Text;
                    row.Cells[4].Value = total;
                    txtIdArticulo.Clear();
                    txtCantidad.Value = 0;
                    cmbArticulo.SelectedIndex = 0;
                    txtPrecio.Clear();

                    btnNueva.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = false;

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el siguiente producto '" + cmbArticulo.Text + "'", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                txtTotal.Text = total().ToString();
                txtIdArticulo.Clear();
                txtCantidad.Value = 0;
                cmbArticulo.SelectedIndex = 0;
                txtPrecio.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (msj.Confirmar("Desea cancelar la operacion?") == true)
            {
                limpiarText();
                alcargarForm();
                dataGridView1.Rows.Clear();
            }
        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulo.SelectedIndex > 0)
            {
                DataTable dataTable = new DataTable();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IdArt", cmbArticulo.SelectedValue));
                string Query = "Select ar.IdArticulo,ar.Nombre_Articulo,ar.Precio_Venta,ar.Stock from articulo as ar " +
                    "where IdArticulo = @IdArt";
                dataTable = crud.getInfo(Query, parametros);
                int Stoks = 0;
                if (dataTable.Rows.Count > 0)
                {
                    Stoks = Convert.ToInt32(dataTable.Rows[0][3]);
                    txtCantidad.Maximum = Stoks;
                    txtIdArticulo.Text = dataTable.Rows[0][0].ToString();
                    txtPrecio.Text = dataTable.Rows[0][2].ToString();

                    if (Stoks == 0)
                    {
                        btnAgregar.Enabled = false;
                        lblStoks.Visible = true;
                        lblStoks.Text = "No disponible por el momento";
                        lblStoks.ForeColor = Color.Red;
                        return;
                    }
                    if (Stoks <= 10)
                    {
                        lblStoks.Visible = true;
                        lblStoks.Text = "Solo quedan " + Stoks + " Unidades Disponibles";
                        lblStoks.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblStoks.Visible = false;
                    }
                }
                else
                {
                    cmbArticulo.SelectedIndex = 0;
                    txtIdArticulo.Text = "";
                    txtPrecio.Text = "";
                    lblStoks.Visible = false;
                }
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            activarText();
            btnNueva.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnRVenta.Enabled = true;
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (txtEfectivo.Text == "")
            {
                txtEfectivo.Text = "0";
            }
            double efec = 0, cambio = 0;
            efec = Convert.ToDouble(txtEfectivo.Text);
            cambio = total() - efec;
            txtDevolucion.Text = Convert.ToString(cambio);
        }
    }
}
