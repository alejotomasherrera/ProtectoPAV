namespace ProyectoPAV
{
    partial class PrinicipalForm
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
            lblBienvenida = new Label();
            menuStrip1 = new MenuStrip();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            datosToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            alumnoToolStripMenuItem = new ToolStripMenuItem();
            personalToolStripMenuItem = new ToolStripMenuItem();
            personasToolStripMenuItem = new ToolStripMenuItem();
            altaPersonaToolStripMenuItem = new ToolStripMenuItem();
            bajaPersonaToolStripMenuItem = new ToolStripMenuItem();
            modificacionPersonaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(114, 150);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(109, 28);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";
            lblBienvenida.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, alumnoToolStripMenuItem, personasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaToolStripMenuItem, datosToolStripMenuItem, cerrarSesionToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(143, 22);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // datosToolStripMenuItem
            // 
            datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            datosToolStripMenuItem.Size = new Size(143, 22);
            datosToolStripMenuItem.Text = "Datos";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(143, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalToolStripMenuItem });
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new Size(62, 20);
            alumnoToolStripMenuItem.Text = "Alumno";
            alumnoToolStripMenuItem.Click += alumnoToolStripMenuItem_Click;
            // 
            // personalToolStripMenuItem
            // 
            personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            personalToolStripMenuItem.Size = new Size(119, 22);
            personalToolStripMenuItem.Text = "Personal";
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaPersonaToolStripMenuItem, bajaPersonaToolStripMenuItem, modificacionPersonaToolStripMenuItem });
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(66, 20);
            personasToolStripMenuItem.Text = "Personas";
            personasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // altaPersonaToolStripMenuItem
            // 
            altaPersonaToolStripMenuItem.Name = "altaPersonaToolStripMenuItem";
            altaPersonaToolStripMenuItem.Size = new Size(189, 22);
            altaPersonaToolStripMenuItem.Text = "Alta Persona";
            altaPersonaToolStripMenuItem.Click += altaPersonaToolStripMenuItem_Click;
            // 
            // bajaPersonaToolStripMenuItem
            // 
            bajaPersonaToolStripMenuItem.Name = "bajaPersonaToolStripMenuItem";
            bajaPersonaToolStripMenuItem.Size = new Size(189, 22);
            bajaPersonaToolStripMenuItem.Text = "Baja Persona";
            // 
            // modificacionPersonaToolStripMenuItem
            // 
            modificacionPersonaToolStripMenuItem.Name = "modificacionPersonaToolStripMenuItem";
            modificacionPersonaToolStripMenuItem.Size = new Size(189, 22);
            modificacionPersonaToolStripMenuItem.Text = "Modificacion Persona";
            // 
            // PrinicipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBienvenida);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PrinicipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prinicipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem datosToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem alumnoToolStripMenuItem;
        private ToolStripMenuItem personalToolStripMenuItem;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem altaPersonaToolStripMenuItem;
        private ToolStripMenuItem bajaPersonaToolStripMenuItem;
        private ToolStripMenuItem modificacionPersonaToolStripMenuItem;
    }
}