namespace ProyectoPAV
{
    partial class AltaPersona
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            fechaNacimiento = new MaskedTextBox();
            label5 = new Label();
            btnHombreSexo = new RadioButton();
            panel1 = new Panel();
            btnNoDefinido = new RadioButton();
            btnMujerSexo = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            nroDoc = new TextBox();
            nroTipoDoc = new NumericUpDown();
            label8 = new Label();
            nombreCalle = new TextBox();
            label9 = new Label();
            lblNroCasa = new Label();
            nroCasa = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nroTipoDoc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 103);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 133);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 180);
            label3.Name = "label3";
            label3.Size = new Size(229, 30);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento";
            label3.Click += label3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(210, 142);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(236, 23);
            txtApellido.TabIndex = 4;
            txtApellido.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(103, 22);
            label4.Name = "label4";
            label4.Size = new Size(215, 30);
            label4.TabIndex = 6;
            label4.Text = "Añadir una persona";
            label4.Click += label4_Click;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Location = new Point(292, 187);
            fechaNacimiento.Mask = "00/00/0000";
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(39, 23);
            fechaNacimiento.TabIndex = 7;
            fechaNacimiento.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(59, 243);
            label5.Name = "label5";
            label5.Size = new Size(62, 30);
            label5.TabIndex = 8;
            label5.Text = "Sexo";
            label5.Click += label5_Click;
            // 
            // btnHombreSexo
            // 
            btnHombreSexo.AutoSize = true;
            btnHombreSexo.Location = new Point(23, 16);
            btnHombreSexo.Name = "btnHombreSexo";
            btnHombreSexo.Size = new Size(69, 19);
            btnHombreSexo.TabIndex = 9;
            btnHombreSexo.TabStop = true;
            btnHombreSexo.Text = "Hombre";
            btnHombreSexo.UseVisualStyleBackColor = true;
            btnHombreSexo.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNoDefinido);
            panel1.Controls.Add(btnMujerSexo);
            panel1.Controls.Add(btnHombreSexo);
            panel1.Location = new Point(179, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 117);
            panel1.TabIndex = 10;
            // 
            // btnNoDefinido
            // 
            btnNoDefinido.AutoSize = true;
            btnNoDefinido.Location = new Point(23, 90);
            btnNoDefinido.Name = "btnNoDefinido";
            btnNoDefinido.Size = new Size(88, 19);
            btnNoDefinido.TabIndex = 11;
            btnNoDefinido.TabStop = true;
            btnNoDefinido.Text = "No definido";
            btnNoDefinido.UseVisualStyleBackColor = true;
            btnNoDefinido.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // btnMujerSexo
            // 
            btnMujerSexo.AutoSize = true;
            btnMujerSexo.Location = new Point(23, 52);
            btnMujerSexo.Name = "btnMujerSexo";
            btnMujerSexo.Size = new Size(56, 19);
            btnMujerSexo.TabIndex = 10;
            btnMujerSexo.TabStop = true;
            btnMujerSexo.Text = "Mujer";
            btnMujerSexo.UseVisualStyleBackColor = true;
            btnMujerSexo.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 356);
            label6.Name = "label6";
            label6.Size = new Size(217, 30);
            label6.TabIndex = 12;
            label6.Text = "Tipo de Documento";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(59, 409);
            label7.Name = "label7";
            label7.Size = new Size(178, 30);
            label7.TabIndex = 13;
            label7.Text = "Nro Documento";
            // 
            // nroDoc
            // 
            nroDoc.Location = new Point(277, 416);
            nroDoc.Name = "nroDoc";
            nroDoc.Size = new Size(236, 23);
            nroDoc.TabIndex = 14;
            // 
            // nroTipoDoc
            // 
            nroTipoDoc.Location = new Point(311, 363);
            nroTipoDoc.Name = "nroTipoDoc";
            nroTipoDoc.Size = new Size(120, 23);
            nroTipoDoc.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(59, 463);
            label8.Name = "label8";
            label8.Size = new Size(69, 30);
            label8.TabIndex = 16;
            label8.Text = "Calle:";
            // 
            // nombreCalle
            // 
            nombreCalle.Location = new Point(277, 470);
            nombreCalle.Name = "nombreCalle";
            nombreCalle.Size = new Size(236, 23);
            nombreCalle.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(379, 269);
            label9.Name = "label9";
            label9.Size = new Size(69, 30);
            label9.TabIndex = 18;
            label9.Text = "Calle:";
            // 
            // lblNroCasa
            // 
            lblNroCasa.AutoSize = true;
            lblNroCasa.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroCasa.Location = new Point(59, 509);
            lblNroCasa.Name = "lblNroCasa";
            lblNroCasa.Size = new Size(137, 30);
            lblNroCasa.TabIndex = 19;
            lblNroCasa.Text = "nro de casa:";
            // 
            // nroCasa
            // 
            nroCasa.Location = new Point(277, 516);
            nroCasa.Name = "nroCasa";
            nroCasa.Size = new Size(236, 23);
            nroCasa.TabIndex = 20;
            // 
            // AltaPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 749);
            Controls.Add(nroCasa);
            Controls.Add(lblNroCasa);
            Controls.Add(label9);
            Controls.Add(nombreCalle);
            Controls.Add(label8);
            Controls.Add(nroTipoDoc);
            Controls.Add(nroDoc);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(fechaNacimiento);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaPersona";
            Text = "AltaPersona";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nroTipoDoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label4;
        private MaskedTextBox fechaNacimiento;
        private Label label5;
        private RadioButton btnHombreSexo;
        private Panel panel1;
        private RadioButton btnNoDefinido;
        private RadioButton btnMujerSexo;
        private Label label6;
        private Label label7;
        private TextBox nroDoc;
        private NumericUpDown nroTipoDoc;
        private Label label8;
        private TextBox nombreCalle;
        private Label label9;
        private Label lblNroCasa;
        private TextBox nroCasa;
    }
}