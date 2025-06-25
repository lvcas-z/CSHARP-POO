namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lwElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string elemTexto = txtNombre.Text;
            lwElementos.Items.Add(elemTexto);

        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string chocolate = ckbChocolate.Checked == true ? "Si le gusta el chocolate" : "No le gusta el chocolate";

            string radioRes;

            if (radioMasculino.Checked == true)
            {
                radioRes = "Masculino";
            }
            else if (radioFemenino.Checked == true)
            {
                radioRes = "Femenino";
            }
            else
            {
                radioRes = "Sin genero";
            }
            string colorFav = cBoxColor.SelectedItem.ToString();
            string numeroSeleccionado = numUpDown.Value.ToString();

            string msj = "Nombre" + nombre + ", Fecha de nacimiento :" + fecha + ", Le gusta el chocolate?: " + chocolate + ", Genero:" + radioRes + ", Color Fav:"+ colorFav + ",  Numero seleccionado: " + numeroSeleccionado;
            MessageBox.Show(msj);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxColor.Items.Add("Azul");
            cBoxColor.Items.Add("Rojo");
            cBoxColor.Items.Add("Amarillo");
            cBoxColor.Items.Add("Verde");
        }
    }
}
