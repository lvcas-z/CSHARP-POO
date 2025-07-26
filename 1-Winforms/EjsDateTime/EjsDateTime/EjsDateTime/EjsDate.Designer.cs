namespace EjsDateTime
{
    partial class EjsDate
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(159, 71);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(159, 121);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 1;
            this.calFecha.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calFecha_DateChanged);
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Location = new System.Drawing.Point(463, 71);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba1.TabIndex = 2;
            this.btnPrueba1.Text = "Prueba 1";
            this.btnPrueba1.UseVisualStyleBackColor = true;
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Location = new System.Drawing.Point(463, 163);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba2.TabIndex = 3;
            this.btnPrueba2.Text = "Prueba 2";
            this.btnPrueba2.UseVisualStyleBackColor = true;
            // 
            // EjsDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrueba2);
            this.Controls.Add(this.btnPrueba1);
            this.Controls.Add(this.calFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "EjsDate";
            this.Text = "EjsDate";
            this.Load += new System.EventHandler(this.EjsDate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MonthCalendar calFecha;
        private System.Windows.Forms.Button btnPrueba1;
        private System.Windows.Forms.Button btnPrueba2;
    }
}