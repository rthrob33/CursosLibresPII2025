namespace CursosLibres
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            nuevoCursoToolStripMenuItem = new ToolStripMenuItem();
            nuevoCursoToolStripMenuItem1 = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            alumnosActualesToolStripMenuItem = new ToolStripMenuItem();
            nuevoAlumnoToolStripMenuItem = new ToolStripMenuItem();
            inscripcionesToolStripMenuItem = new ToolStripMenuItem();
            inscribirseAAlumnoToolStripMenuItem = new ToolStripMenuItem();
            sesionesToolStripMenuItem = new ToolStripMenuItem();
            docentesActualesToolStripMenuItem = new ToolStripMenuItem();
            nuevoDocenteToolStripMenuItem = new ToolStripMenuItem();
            cursosPorDocenteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cursosToolStripMenuItem, alumnosToolStripMenuItem, inscripcionesToolStripMenuItem, sesionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1594, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoCursoToolStripMenuItem, nuevoCursoToolStripMenuItem1 });
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(93, 34);
            cursosToolStripMenuItem.Text = "Cursos";
            // 
            // nuevoCursoToolStripMenuItem
            // 
            nuevoCursoToolStripMenuItem.Name = "nuevoCursoToolStripMenuItem";
            nuevoCursoToolStripMenuItem.Size = new Size(315, 40);
            nuevoCursoToolStripMenuItem.Text = "Cursos Actuales";
            nuevoCursoToolStripMenuItem.Click += nuevoCursoToolStripMenuItem_Click_1;
            // 
            // nuevoCursoToolStripMenuItem1
            // 
            nuevoCursoToolStripMenuItem1.Name = "nuevoCursoToolStripMenuItem1";
            nuevoCursoToolStripMenuItem1.Size = new Size(315, 40);
            nuevoCursoToolStripMenuItem1.Text = "Nuevo Curso";
            nuevoCursoToolStripMenuItem1.Click += nuevoCursoToolStripMenuItem1_Click;
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alumnosActualesToolStripMenuItem, nuevoAlumnoToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(113, 34);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // alumnosActualesToolStripMenuItem
            // 
            alumnosActualesToolStripMenuItem.Name = "alumnosActualesToolStripMenuItem";
            alumnosActualesToolStripMenuItem.Size = new Size(298, 40);
            alumnosActualesToolStripMenuItem.Text = "Alumnos Actuales";
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            nuevoAlumnoToolStripMenuItem.Size = new Size(298, 40);
            nuevoAlumnoToolStripMenuItem.Text = "Nuevo Alumno";
            // 
            // inscripcionesToolStripMenuItem
            // 
            inscripcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inscribirseAAlumnoToolStripMenuItem });
            inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            inscripcionesToolStripMenuItem.Size = new Size(151, 34);
            inscripcionesToolStripMenuItem.Text = "Inscripciones";
            // 
            // inscribirseAAlumnoToolStripMenuItem
            // 
            inscribirseAAlumnoToolStripMenuItem.Name = "inscribirseAAlumnoToolStripMenuItem";
            inscribirseAAlumnoToolStripMenuItem.Size = new Size(320, 40);
            inscribirseAAlumnoToolStripMenuItem.Text = "Inscribirse a Alumno";
            // 
            // sesionesToolStripMenuItem
            // 
            sesionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { docentesActualesToolStripMenuItem, nuevoDocenteToolStripMenuItem, cursosPorDocenteToolStripMenuItem });
            sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
            sesionesToolStripMenuItem.Size = new Size(118, 34);
            sesionesToolStripMenuItem.Text = "Docentes";
            // 
            // docentesActualesToolStripMenuItem
            // 
            docentesActualesToolStripMenuItem.Name = "docentesActualesToolStripMenuItem";
            docentesActualesToolStripMenuItem.Size = new Size(315, 40);
            docentesActualesToolStripMenuItem.Text = "Docentes Actuales";
            // 
            // nuevoDocenteToolStripMenuItem
            // 
            nuevoDocenteToolStripMenuItem.Name = "nuevoDocenteToolStripMenuItem";
            nuevoDocenteToolStripMenuItem.Size = new Size(315, 40);
            nuevoDocenteToolStripMenuItem.Text = "Nuevo Docente";
            nuevoDocenteToolStripMenuItem.Click += nuevoDocenteToolStripMenuItem_Click;
            // 
            // cursosPorDocenteToolStripMenuItem
            // 
            cursosPorDocenteToolStripMenuItem.Name = "cursosPorDocenteToolStripMenuItem";
            cursosPorDocenteToolStripMenuItem.Size = new Size(315, 40);
            cursosPorDocenteToolStripMenuItem.Text = "Cursos por Docente";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1594, 675);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Menú";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
		private ToolStripMenuItem cursosToolStripMenuItem;
		private ToolStripMenuItem alumnosToolStripMenuItem;
		private ToolStripMenuItem inscripcionesToolStripMenuItem;
		private ToolStripMenuItem nuevoCursoToolStripMenuItem;
		private ToolStripMenuItem nuevoCursoToolStripMenuItem1;
		private ToolStripMenuItem alumnosActualesToolStripMenuItem;
		private ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
		private ToolStripMenuItem inscribirseAAlumnoToolStripMenuItem;
		private ToolStripMenuItem sesionesToolStripMenuItem;
		private ToolStripMenuItem docentesActualesToolStripMenuItem;
		private ToolStripMenuItem nuevoDocenteToolStripMenuItem;
		private ToolStripMenuItem cursosPorDocenteToolStripMenuItem;
	}
}
