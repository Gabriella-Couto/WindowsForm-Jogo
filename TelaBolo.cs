using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoAdivinhacao
{
    public partial class TelaBolo : Form
    {
        public TelaBolo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoSim_Click(object sender, EventArgs e)
        {
            this.Close();
            var acerto = new TelaAcerto();
            acerto.Show();
        }

        private void BotaoNao_Click(object sender, EventArgs e)
        {
            this.Close();
            var input = new TelaInput();
            input.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
