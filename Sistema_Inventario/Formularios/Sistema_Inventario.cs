using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario.Formularios
{
    public partial class Sistema_Inventario : Form
    {
        public Sistema_Inventario()
        {
            InitializeComponent();
        }

        private void Sistema_Inventario_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetVentas", datos));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Inventario.ReporteVentas.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
