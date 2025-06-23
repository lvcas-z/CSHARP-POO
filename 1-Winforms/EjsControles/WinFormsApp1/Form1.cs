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
    }
}
