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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            btnHombreSexo = new RadioButton();
            panel1 = new Panel();
            btnMujerSexo = new RadioButton();
            btnNoDefinido = new RadioButton();
            panel1.SuspendLayout();
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
            label2.Location = new Point(56, 161);
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
            label3.Location = new Point(56, 232);
            label3.Name = "label3";
            label3.Size = new Size(229, 30);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(291, 239);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(61, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(90, 321);
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
            panel1.Location = new Point(210, 291);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 130);
            panel1.TabIndex = 10;
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
            // AltaPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaPersona";
            Text = "AltaPersona";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private RadioButton btnHombreSexo;
        private Panel panel1;
        private RadioButton btnNoDefinido;
        private RadioButton btnMujerSexo;
    }
}