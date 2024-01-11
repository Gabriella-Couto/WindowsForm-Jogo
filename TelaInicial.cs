namespace JogoAdivinhacao
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var tela = new TelaMassa();
            tela.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicial_Load_1(object sender, EventArgs e)
        {

        }
    }
}