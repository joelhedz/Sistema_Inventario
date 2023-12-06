namespace Sistema_Inventario
{
    public partial class FrmLoanding : Form
    {
        public FrmLoanding()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 800)
            {
                timer1.Stop();
                Formularios.FrmMenu menu = new Formularios.FrmMenu();
                menu.Show();
                this.Hide();
            }
        }
    }
}