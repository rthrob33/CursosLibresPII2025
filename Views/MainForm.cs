using CursosLibres.Views;

namespace CursosLibres
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoCursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmCursos { MdiParent = this }.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void nuevoCursoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void nuevoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*/*new FrmDocente { MdiParent = this }.Show();*/
        }
    }
}
