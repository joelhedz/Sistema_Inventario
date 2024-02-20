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
    public partial class FrmVenta : Form
    {
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        Controladores.ClassMensajes msj = new Controladores.ClassMensajes();
        int idVenta;
        public FrmVenta()
        {
            InitializeComponent();
        }

        public void GetVentas()
        {
            string Consulta = "Select * from View_Ventas";
            DataTable dtVentas = new DataTable();
            dtVentas = crud.getInfo(Consulta);
            DgvVentas.DataSource = dtVentas;
            DgvVentas.Refresh();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminarFiltro.BackColor = Color.Teal;
            btnEliminarFiltro.ForeColor = Color.White;

            DateTime fechaInicio = dateTimePickerinicio.Value.Date;
            DateTime fechaFinal = dateTimePickerfinal.Value.Date;

            string consulta = "SELECT * FROM venta WHERE Fecha_Venta BETWEEN @FechaInicio AND @FechaFinal";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@FechaInicio", fechaInicio));
            parametros.Add(new SqlParameter("@FechaFinal", fechaFinal.AddDays(1).AddSeconds(-1))); // Ajuste para incluir toda la fecha final

            DataTable dtVentas = new DataTable();
            dtVentas = crud.getInfo(consulta, parametros);
            DgvVentas.DataSource = dtVentas;
            DgvVentas.Refresh();
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            GetVentas();
            btnEliminarFiltro.BackColor = Control.DefaultBackColor;
            btnEliminarFiltro.ForeColor = Color.Black;
        }



        private void BtnAnular_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            string queryVenta = "Select * from venta where NombreColumna = @idVenta";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVenta", idVenta.ToString()));
            DataTable dtVentas = crud.getInfo(queryVenta, parametros);

            if (dtVentas.Rows.Count > 0)
            {
                DateTime FechaVenta = Convert.ToDateTime(dtVentas.Rows[0]["Fecha_Venta"]);

                if (fechaHoy.Date > FechaVenta.Date)
                {
                    msj.Aviso("No se puede anular una venta de días anteriores");
                }
                else
                {
                    string queryDetalleVenta = "Select * from detalle_venta where idventa = @idVenta";
                    List<SqlParameter> parametrosDetalleVenta = new List<SqlParameter>();
                    parametrosDetalleVenta.Add(new SqlParameter("@idVenta", idVenta.ToString()));
                    DataTable dtDetalleVenta = crud.getInfo(queryDetalleVenta, parametrosDetalleVenta);

                    foreach (DataRow detalleVentaRow in dtDetalleVenta.Rows)
                    {
                        int stocks = 0;
                        string id_Articulo = detalleVentaRow[1].ToString();
                        stocks = Convert.ToInt32(detalleVentaRow[2].ToString());

                        string queryStock = "Select * from articulo where IdArticulo = @IdArticulo";
                        List<SqlParameter> parametrosStock = new List<SqlParameter>();
                        parametrosStock.Add(new SqlParameter("@IdArticulo", id_Articulo));
                        DataTable dtStock = crud.getInfo(queryStock, parametrosStock);

                        stocks += Convert.ToInt32(dtStock.Rows[0][4].ToString());

                        string queryUpdateStock = "Update articulo set Stock = @Stock where IdArticulo = @IdArticulo";
                        List<SqlParameter> parametrosUpdateStock = new List<SqlParameter>();
                        parametrosUpdateStock.Add(new SqlParameter("@Stock", stocks.ToString()));
                        parametrosUpdateStock.Add(new SqlParameter("@IdArticulo", id_Articulo));
                        crud.executeQuery(queryUpdateStock, parametrosUpdateStock, "");
                    }

                    string queryAnularVenta = "Update venta set estado_venta = 'INA' where IdVenta = @IdVenta";
                    List<SqlParameter> parametrosUpdateVenta = new List<SqlParameter>();
                    parametrosUpdateVenta.Add(new SqlParameter("@IdVenta", idVenta.ToString()));
                    crud.executeQuery(queryAnularVenta, parametrosUpdateVenta, "Venta Anulada");

                    string fechaHoyFormato = fechaHoy.ToString("yyyy-MM-dd");
                    string queryBitacora = "Insert into bitacora(fecha_hora,tipo_de_Evento,usercode)values(@fecha,@accion,@usuario)";
                    List<SqlParameter> parametrosBitacora = new List<SqlParameter>();
                    parametrosBitacora.Add(new SqlParameter("@fecha", fechaHoyFormato));
                    parametrosBitacora.Add(new SqlParameter("@accion", "Anulacion de Venta con el id '" + idVenta + "'"));
                    parametrosBitacora.Add(new SqlParameter("@usuario", Controladores.ClassDatosUsuario.Usuario));
                    crud.executeQuery(queryBitacora, parametrosBitacora, "");
                    GetVentas();
                }
            }
        }

        private void DgvVentas_Click(object sender, EventArgs e)
        {

            if (DgvVentas.Rows.Count > 0 && DgvVentas.CurrentRow != null && DgvVentas.CurrentRow.Cells[0].Value != null)
            {
                idVenta = Convert.ToInt32(DgvVentas.CurrentRow.Cells[0].Value.ToString());
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@idVenta", idVenta.ToString()));
                string Query = "SELECT * FROM venta WHERE Codigo = @idVenta";
                DataTable dtVentas = new DataTable();
                dtVentas = crud.getInfo(Query, parametros);

                if (dtVentas.Rows.Count > 0) // Verificar si hay filas en el DataTable
                {
                    string Estado = dtVentas.Rows[0]["Estado"].ToString();
                    if (Estado == "ACT")
                    {
                        BtnAnular.Enabled = false;
                    }
                    else
                    {
                        BtnAnular.Enabled = true;
                    }
                }
                else
                {


                }
            }
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmVenta_Load_1(object sender, EventArgs e)
        {
            GetVentas();
        }
    }

}

