using CursosLibres.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursosLibres.Views
{
    public partial class FrmAlumnos : Form
    {

        private readonly List<Alumno> _alumnos = new();
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void CargarAlumnos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _alumnos;
        }

        public void AgregarAlumno(Alumno alumno)
        {
            _alumnos.Add(alumno);
            CargarAlumnos();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
