namespace JogoAdivinhacao
{
    public partial class TelaAcerto : Form
    {
        public TelaAcerto()
        {
            InitializeComponent();
        }

        private void TelaAcerto_Load(object sender, EventArgs e)
        {

        }

        private void TelaAcerto_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            this.Close();
            var inicio = new TelaInicial();
            inicio.Show();
        }
    }
}
