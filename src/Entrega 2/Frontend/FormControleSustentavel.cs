using System;
using System.Windows.Forms;

namespace SmartHomeApp
{
    public partial class FormControleSustentavel : Form
    {
        public FormControleSustentavel()
        {
            InitializeComponent();
        }

        private void btnVerSimulacao_Click(object sender, EventArgs e)
        {
            FormSimulacao simulacao = new FormSimulacao();
            simulacao.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormUsuario home = new FormUsuario();
            home.Show();
            this.Hide();
        }

        private void FormControleSustentavel_Load(object sender, EventArgs e)
        {

        }
    }
}
