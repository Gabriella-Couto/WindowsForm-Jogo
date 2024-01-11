namespace JogoAdivinhacao
{
    public partial class TelaLasanha : Form
    {
        public TelaLasanha()
        {
            InitializeComponent();
        }

        private void TelaLasanha_Load(object sender, EventArgs e)
        {

        }

        private void BotaoNao_Click(object sender, EventArgs e)
        {
            this.Close();
            var input = new TelaInput();
            input.Show();
        }

        private void BotaoSim_Click(object sender, EventArgs e)
        {
            this.Close();
            var acerto = new TelaAcerto();
            acerto.Show();
        }
    }
}
