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
            gbGenero = new GroupBox();
            radioSinGenero = new RadioButton();
            radioFemenino = new RadioButton();
            radioMasculino = new RadioButton();
            lblPerfil = new Label();
            cBoxColor = new ComboBox();
            numUpDown = new NumericUpDown();
            btnPerfil = new Button();
            lblColor = new Label();
            lblNumero = new Label();
            gbGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown).BeginInit();
            SuspendLayout();
            // 
            // lwElementos
            // 
            lwElementos.Location = new Point(106, 430);
            lwElementos.Name = "lwElementos";
            lwElementos.Size = new Size(546, 141);
            lwElementos.TabIndex = 2;
            lwElementos.UseCompatibleStateImageBehavior = false;
            lwElementos.View = View.List;
            lwElementos.SelectedIndexChanged += lwElementos_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(658, 548);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(249, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged_1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(115, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(115, 119);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            lblFecha.Click += label1_Click_1;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(184, 113);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // ckbChocolate
            // 
            ckbChocolate.AutoSize = true;
            ckbChocolate.Location = new Point(184, 157);
            ckbChocolate.Name = "ckbChocolate";
            ckbChocolate.Size = new Size(141, 19);
            ckbChocolate.TabIndex = 9;
            ckbChocolate.Text = "Te gusta el chocolate?";
            ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(radioSinGenero);
            gbGenero.Controls.Add(radioFemenino);
            gbGenero.Controls.Add(radioMasculino);
            gbGenero.Location = new Point(124, 197);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(487, 53);
            gbGenero.TabIndex = 10;
            gbGenero.TabStop = false;
            gbGenero.Text = "Genero:";
            // 
            // radioSinGenero
            // 
            radioSinGenero.AutoSize = true;
            radioSinGenero.Location = new Point(338, 22);
            radioSinGenero.Name = "radioSinGenero";
            radioSinGenero.Size = new Size(82, 19);
            radioSinGenero.TabIndex = 12;
            radioSinGenero.TabStop = true;
            radioSinGenero.Text = "Sin Genero";
            radioSinGenero.UseVisualStyleBackColor = true;
            // 
            // radioFemenino
            // 
            radioFemenino.AutoSize = true;
            radioFemenino.Location = new Point(185, 22);
            radioFemenino.Name = "radioFemenino";
            radioFemenino.Size = new Size(78, 19);
            radioFemenino.TabIndex = 12;
            radioFemenino.TabStop = true;
            radioFemenino.Text = "Femenino";
            radioFemenino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            radioMasculino.AutoSize = true;
            radioMasculino.Location = new Point(43, 23);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(80, 19);
            radioMasculino.TabIndex = 0;
            radioMasculino.TabStop = true;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 20F);
            lblPerfil.Location = new Point(113, 9);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(146, 37);
            lblPerfil.TabIndex = 11;
            lblPerfil.Text = "Crear Perfil";
            // 
            // cBoxColor
            // 
            cBoxColor.FormattingEnabled = true;
            cBoxColor.Location = new Point(196, 280);
            cBoxColor.Name = "cBoxColor";
            cBoxColor.Size = new Size(137, 23);
            cBoxColor.TabIndex = 12;
            // 
            // numUpDown
            // 
            numUpDown.Location = new Point(492, 280);
            numUpDown.Name = "numUpDown";
            numUpDown.Size = new Size(96, 23);
            numUpDown.TabIndex = 13;
            // 
            // btnPerfil
            // 
            btnPerfil.Location = new Point(701, 101);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(113, 51);
            btnPerfil.TabIndex = 14;
            btnPerfil.Text = "Ver Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(123, 284);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(67, 15);
            lblColor.TabIndex = 15;
            lblColor.Text = "Elige Color:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(374, 284);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(103, 15);
            lblNumero.TabIndex = 16;
            lblNumero.Text = "Elige Numero Fav:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 612);
            Controls.Add(lblNumero);
            Controls.Add(lblColor);
            Controls.Add(btnPerfil);
            Controls.Add(numUpDown);
            Controls.Add(cBoxColor);
            Controls.Add(lblPerfil);
            Controls.Add(gbGenero);
            Controls.Add(ckbChocolate);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(lwElementos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown).EndInit();
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
        private GroupBox gbGenero;
        private Label lblPerfil;
        private RadioButton radioSinGenero;
        private RadioButton radioFemenino;
        private RadioButton radioMasculino;
        private ComboBox cBoxColor;
        private NumericUpDown numUpDown;
        private Button btnPerfil;
        private Label lblColor;
        private Label lblNumero;
    }
}
