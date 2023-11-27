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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FrmVentas
            // 
            ClientSize = new Size(984, 661);
            Name = "FrmVentas";
            Load += FrmVentas_Load;
            ResumeLayout(false);
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
        }
    }
}
