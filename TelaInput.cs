namespace JogoAdivinhacao
{
    public partial class TelaInput : Form
    {
        public static string pratoDigitado = string.Empty;
        public TelaInput()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoSim_Click(object sender, EventArgs e)
        {
            pratoDigitado = textBox1.Text;

            if(pratoDigitado != null && pratoDigitado.Length > 0)
            {
                this.Close();
                var complete = new TelaComplete();
                complete.Show();
            }
            else
            {
                textBox1.BackColor = Color.LightCoral;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaInput_Load(object sender, EventArgs e)
        {

        }
    }
}
