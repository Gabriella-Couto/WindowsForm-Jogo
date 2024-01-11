namespace JogoAdivinhacao
{
    public partial class TelaComplete : Form
    {
        public static string Prato = string.Empty;

        public TelaComplete()
        {
            Prato = TelaInput.pratoDigitado;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaComplete_Load(object sender, EventArgs e)
        {
            label1.Text = $"{Prato} é ________ mas lasanha não.";
        }

        private void BotaoOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Length > 0)
            {
                this.Close();
            }
            else
            {
                textBox1.BackColor = Color.LightCoral;
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
    }
}
