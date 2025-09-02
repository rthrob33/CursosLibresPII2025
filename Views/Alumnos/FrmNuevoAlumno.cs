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

namespace CursosLibres.Views.Alumnos
{
    public partial class FrmNuevoAlumno : Form
    {
        public Alumno AlumnoCreado { get; private set; }

        public FrmNuevoAlumno()
        {
            InitializeComponent();
        }

        private void FrmNuevoAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AlumnoCreado = new Alumno
            {
                Nombre = txtNombre.Text,
                Email = txtCorreo.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
