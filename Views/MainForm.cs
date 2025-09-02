using CursosLibres.Views;
using CursosLibres.Views.Alumnos;
using CursosLibres.Views.Docentes;

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

        private void alumnosActualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmExistente = Application.OpenForms
            .OfType<FrmAlumnos>()
            .FirstOrDefault();

            if (frmExistente == null)
            {
                FrmAlumnos frm = new FrmAlumnos();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frmExistente.Activate();
            }
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmExistente = Application.OpenForms
            .OfType<FrmNuevoAlumno>()
            .FirstOrDefault();

            if (frmExistente == null)
            {
                FrmNuevoAlumno frm = new FrmNuevoAlumno();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frmExistente.Activate();
            }
        }
    }

}
