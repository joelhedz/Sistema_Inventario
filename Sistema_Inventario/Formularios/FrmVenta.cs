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
            string fechaInicio, fechaFinal;
            fechaInicio = dateTimePickerinicio.Value.ToString("yyyy-MM-dd");
            fechaFinal = dateTimePickerfinal.Value.ToString("yyyy-MM-dd");

            string Consulta = "Select * from View_Ventas where Fecha_Venta BETWEEN '" + fechaInicio + "'" +
                "and '" + fechaFinal + "'";
            DataTable dtVentas = new DataTable();
            dtVentas = crud.getInfo(Consulta);
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
            string Query = "Select * from View_Ventas where Codigo = @idVenta";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVenta", idVenta.ToString()));
            DataTable dtVentas = new DataTable();
            dtVentas = crud.getInfo(Query,parametros);

            DateTime FechaVenta = new DateTime();
            if (dtVentas.Rows.Count > 0)
            {
                FechaVenta = Convert.ToDateTime(dtVentas.Rows[0]["Fecha_Venta"].ToString());
            }
            if(fechaHoy.Date > FechaVenta.Date)
            {
                msj.Aviso("No se puede anular una venta de dias anteriores");
            }
            else
            {
                int stoks;
                string QueryVenta = "Sekect * from detalle_venta where idventa = @idVenta";
                List<SqlParameter> parametrosVentas = new List<SqlParameter>();
                parametrosVentas.Add(new SqlParameter("@idVenta", idVenta.ToString()));
                DataTable dtDetalleVenta = new DataTable();
                dtDetalleVenta = crud.getInfo(QueryVenta, parametrosVentas);

                for (int i = 0; i < dtDetalleVenta.Rows.Count; i++)
                {
                    stoks = 0;
                    string id_Articulo = dtDetalleVenta.Rows[i][1].ToString();
                    stoks = Convert.ToInt32(dtDetalleVenta.Rows[i][2].ToString());
                    string QueryStock = "Select * from articulo where IdArticulo = @IdArticulo";
                    List<SqlParameter> parametrosStock = new List<SqlParameter>();
                    parametrosStock.Add(new SqlParameter("@IdArticulo", id_Articulo));
                    DataTable dtStock = new DataTable();
                    dtStock = crud.getInfo(QueryStock, parametrosStock);

                    stoks  += Convert.ToInt32(dtStock.Rows[0][4].ToString());

                    string QueryUpdate = "Update articulo set Stock = @Stock where IdArticulo = @IdArticulo";
                    List<SqlParameter> parametrosUpdate = new List<SqlParameter>();
                    parametrosUpdate.Add(new SqlParameter("@Stock", stoks.ToString()));
                    parametrosUpdate.Add(new SqlParameter("@IdArticulo", id_Articulo));
                    crud.executeQuery(QueryUpdate, parametrosUpdate,"");
                } 
                string Query2 = "Update venta set estado_venta = 'INA' where IdVenta = @IdVenta";
                List<SqlParameter> parametrosUpdateVenta = new List<SqlParameter>();
                parametrosUpdateVenta.Add(new SqlParameter("@IdVenta", idVenta.ToString()));
                crud.executeQuery(Query2, parametrosUpdateVenta, "Venta Anulada");

                fechaHoy.ToString("yyyy-MM-dd");
                string Bitacora = "Insert into bitacora(fecha_hora,tipo_de_Evento,usercode)values(@fecha,@accion,@usuario)";
                List<SqlParameter> parametrosBitacora = new List<SqlParameter>();
                parametrosBitacora.Add(new SqlParameter("@fecha", fechaHoy));
                parametrosBitacora.Add(new SqlParameter("@accion", "Anulacion de Venta con el id '"+idVenta+"'"));
                parametrosBitacora.Add(new SqlParameter("@usuario", Controladores.ClassDatosUsuario.Usuario)); ;
                crud.executeQuery(Bitacora, parametrosBitacora, "");
                GetVentas();


            }
        }

        private void DgvVentas_Click(object sender, EventArgs e)
        {
            idVenta = Convert.ToInt32(DgvVentas.CurrentRow.Cells[0].Value.ToString());
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVenta", idVenta.ToString()));
            string Query = "Select * from View_Ventas where Codigo = @idVenta";
            DataTable dtVentas = new DataTable();
            dtVentas = crud.getInfo(Query, parametros);

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
    }
}
