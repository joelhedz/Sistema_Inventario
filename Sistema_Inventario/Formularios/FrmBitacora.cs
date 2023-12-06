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
    public partial class FrmBitacora : Form
    {
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                txtUsuario.Enabled = true;
            }
            else
            {
                txtUsuario.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                datetimeFecha.Enabled = true;
            }
            else
            {
                datetimeFecha.Enabled = false;
            }
        }

        private void Getbitacora()
        {
            string Query = "SELECT * FROM View_Bitacora";
            DataTable Recordset = new DataTable();
            Recordset = crud.getInfo(Query);
            dataGridView1.DataSource = Recordset;
            dataGridView1.Refresh();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
            datetimeFecha.Enabled = false;
            Getbitacora();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@Usuario", txtUsuario.Text));
            string Query = "SELECT * FROM View_Bitacora WHERE Usuario LIKE % @Usuario %";
            DataTable Recordset = new DataTable();
            Recordset = crud.getInfo(Query, Parameters);
            dataGridView1.DataSource = Recordset;
            dataGridView1.Refresh();

        }

        private void datetimeFecha_ValueChanged(object sender, EventArgs e)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Fecha", datetimeFecha.Value.ToString("yyyy-MM-dd")));
            string Query = "SELECT * FROM View_Bitacora WHERE Fecha LIKE % @Fecha %";
            DataTable Recordset = new DataTable();
            Recordset = crud.getInfo(Query, parameters);
            dataGridView1.DataSource = Recordset;
            dataGridView1.Refresh();

        }
    }
}
