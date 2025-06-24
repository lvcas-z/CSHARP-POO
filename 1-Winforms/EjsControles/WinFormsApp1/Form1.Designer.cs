namespace WinFormsApp1
{
    partial class Form1
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
            lwElementos = new ListView();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblFecha = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            ckbChocolate = new CheckBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lblPerfil = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnPerfil = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lwElementos
            // 
            lwElementos.Location = new Point(104, 288);
            lwElementos.Name = "lwElementos";
            lwElementos.Size = new Size(546, 141);
            lwElementos.TabIndex = 2;
            lwElementos.UseCompatibleStateImageBehavior = false;
            lwElementos.View = View.List;
            lwElementos.SelectedIndexChanged += lwElementos_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(656, 406);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged_1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(69, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(69, 79);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            lblFecha.Click += label1_Click_1;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(138, 73);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // ckbChocolate
            // 
            ckbChocolate.AutoSize = true;
            ckbChocolate.Location = new Point(138, 117);
            ckbChocolate.Name = "ckbChocolate";
            ckbChocolate.Size = new Size(141, 19);
            ckbChocolate.TabIndex = 9;
            ckbChocolate.Text = "Te gusta el chocolate?";
            ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(78, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 53);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(338, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(185, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(43, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 20F);
            lblPerfil.Location = new Point(600, 57);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(76, 37);
            lblPerfil.TabIndex = 11;
            lblPerfil.Text = "Perfil";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(286, 236);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // btnPerfil
            // 
            btnPerfil.Location = new Point(493, 236);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(75, 23);
            btnPerfil.TabIndex = 14;
            btnPerfil.Text = "Ver Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPerfil);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(lblPerfil);
            Controls.Add(groupBox1);
            Controls.Add(ckbChocolate);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(lwElementos);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lwElementos;
        private Button btnAgregar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblFecha;
        private DateTimePicker dtpFechaNacimiento;
        private CheckBox ckbChocolate;
        private GroupBox groupBox1;
        private Label lblPerfil;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button btnPerfil;
    }
}
