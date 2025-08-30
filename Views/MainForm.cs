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
	}
}
