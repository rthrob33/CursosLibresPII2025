namespace CursosLibres.Views.Alumnos
{
    partial class FrmNuevoAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            label1 = new Label();
            lbNombre = new Label();
            lbCorreo = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(345, 276);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 20);
            label1.Name = "label1";
            label1.Size = new Size(363, 37);
            label1.TabIndex = 1;
            label1.Text = "Registro de Nuevo Alumno";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(153, 101);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(64, 20);
            lbNombre.TabIndex = 2;
            lbNombre.Text = "Nombre";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCorreo.Location = new Point(153, 167);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(54, 20);
            lbCorreo.TabIndex = 3;
            lbCorreo.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(262, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese Su Nombre";
            txtNombre.Size = new Size(276, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(262, 168);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese Su Correo ELectronico";
            txtCorreo.Size = new Size(276, 23);
            txtCorreo.TabIndex = 5;
            // 
            // FrmNuevoAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lbCorreo);
            Controls.Add(lbNombre);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Name = "FrmNuevoAlumno";
            Text = "FrmNuevoAlumno";
            Load += FrmNuevoAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label1;
        private Label lbNombre;
        private Label lbCorreo;
        private TextBox txtNombre;
        private TextBox txtCorreo;
    }
}