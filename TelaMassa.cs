namespace JogoAdivinhacao
{
    public partial class TelaMassa : Form
    {
        public TelaMassa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var lasanha = new TelaLasanha();
            lasanha.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var bolo = new TelaBolo();
            bolo.Show();
        }

        private void TelaMassa_Load(object sender, EventArgs e)
        {

        }
    }
}
