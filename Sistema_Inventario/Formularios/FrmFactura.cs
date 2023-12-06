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

        private int idventa()
        {
            int idventa;
            string Query = "Select MAX(idventa) from venta";
            DataTable dt = crud.getInfo(Query);
            idventa = Convert.ToInt32(dt.Rows[0][0]);

            return idventa;
        }

        private void btnRVenta_Click(object sender, EventArgs e)
        {
            string Fecha_ = dtFecha.Value.ToString("yyyy-MM-dd");
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@IdCliente", txtIdCliente.Text));
            Parametros.Add(new SqlParameter("@IdUsuario", ClassDatosUsuario.IdUsuario));
            Parametros.Add(new SqlParameter("@Fecha_Venta", Fecha_));
            string Query = "INSERT INTO venta(IdCliente, IdUsuario, Fecha_Venta) VALUES " +
                "(@IdCliente, @IdUsuario, @Fecha_Venta)";
            
            crud.executeQuery(Query,Parametros, "");


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string idArticulo, precio;
                idArticulo = row.Cells[0].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells[2].Value);
                precio = row.Cells[3].Value.ToString();

                List<SqlParameter> Parametros2 = new List<SqlParameter>();
                Parametros2.Add(new SqlParameter("@IdArticulo", idArticulo));

                string Articulo = "Select * from articulo where IdArticulo =@IdArticulo";
                DataTable Recordser = crud.getInfo(Articulo,Parametros2);
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
                    crud.executeQuery(updateStok,Parametros3, "");
                }

                List<SqlParameter> Parametros4 = new List<SqlParameter>();  
                Parametros4.Add(new SqlParameter("@IdArticulo", idArticulo));
                Parametros4.Add(new SqlParameter("@Cantidad", cantidad));
                Parametros4.Add(new SqlParameter("@Precio", precio));
                Parametros4.Add(new SqlParameter("@IdVenta", idventa()));

                string Query2 = "Insert into detalle_venta(idventa,idarticulo,cantidad,precio)values" +
                    "(@IdVenta, @IdArticulo, @Cantidad, @Precio)";
                crud.executeQuery(Query2,Parametros4, "");
            }
            bitacora.InsertarBitacora("Venta Realizada");
            msj.Exito("Venta Realizada");
            limpiarText();
            alcargarForm();
            dataGridView1.Rows.Clear();
            
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
