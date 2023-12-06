using Sistema_Inventario.Controladores;
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
            row.Cells[1].Value = txtArticulo.Text;
            row.Cells[2].Value = txtCantidad.Text;
            row.Cells[3].Value = txtPrecio.Text;
            row.Cells[4].Value = total;

            dataGridView1.Update();


        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnRVenta_Click(object sender, EventArgs e)
        {
            string Fecha_ = dtFecha.Value.ToString("yyyy-MM-dd");
            string Query = "Insert into venta(idcliente,idusuario,fecha_venta)values" +
                "(" + txtIdCliente.Text + ",'" + ClassDatosUsuario.IdUsuario + "','" + Fecha_ + "')";
            crud.Sistema(Query, "");


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string idArticulo, precio;
                idArticulo = row.Cells[0].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells[2].Value);
                precio = row.Cells[3].Value.ToString();

                string Articulo = "Select * from articulo where IdArticulo ='" + idArticulo + "'";
                DataTable Recordser = crud.getInfo(Articulo);
                int stoks = 0;
                if (Recordser.Rows.Count > 0)
                {
                    stoks = Convert.ToInt32(Recordser.Rows[0][4]);
                    stoks -= cantidad;
                    string updateStok = "Update articulo set Stock='" + stoks + "' " +
                        "where IdArticulo='" + idArticulo + "'";
                    crud.Sistema(updateStok, "");
                }

                string Query2 = "Insert into detalle_venta(idventa,idarticulo,cantidad,precio)values" +
                    "(" + idventa() + "," + idArticulo + "," + cantidad + "," + precio + ")";
                crud.Sistema(Query2, "");
            }

            MessageBox.Show("Venta realizada!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarText();
            alcargarForm();
            dataGridView1.Rows.Clear();
            if (MessageBox.Show("Desea mostrar Factura?", "Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmReporteFactura factura = new FrmReporteFactura(idventa());
                factura.Show();

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            val.contError = 0;
            validarText();
            if (val.contError == 0)
            {
                agregarDatosgrid();
                txtIdArticulo.Clear();
                txtCantidad.Value = 0;
                txtArticulo.Clear();
                txtPrecio.Clear();
                txtTotal.Text = total().ToString();
                btnRVenta.Enabled = true;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                rol.dgvAccesos(dataGridView1, btnNueva, btnAgregar, btnModificar, btnCancelar, btnEliminar);
                txtIdArticulo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtArticulo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
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
                    row.Cells[1].Value = txtArticulo.Text;
                    row.Cells[2].Value = txtCantidad.Text;
                    row.Cells[3].Value = txtPrecio.Text;
                    row.Cells[4].Value = total;
                    txtIdArticulo.Clear();
                    txtCantidad.Value = 0;
                    txtArticulo.Clear();
                    txtPrecio.Clear();
                    rol.nuevo(btnNueva, btnAgregar, btnModificar, btnCancelar, btnEliminar);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el siguiente producto '" + txtArticulo.Text + "'", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                txtTotal.Text = total().ToString();
                txtIdArticulo.Clear();
                txtCantidad.Value = 0;
                txtArticulo.Clear();
                txtPrecio.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(msj.Confirmar("Desea cancelar la operacion?") == true)
            {
                limpiarText();
                alcargarForm();
                dataGridView1.Rows.Clear();
            }
        }
    }
}
