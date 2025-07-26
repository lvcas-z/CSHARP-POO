using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///EVITAR REPETICION DE VENTANAS

            foreach (var item in Application.OpenForms) {
                if (item.GetType() == typeof(Form1))
                {
                    return;
                }
            }


            /// navegacion
            Form1 ventana = new Form1();
            ventana.MdiParent = this; /// instancio ventana , hago referencia a esta con this, es padre
            ventana.Show();


        }
    }
}
