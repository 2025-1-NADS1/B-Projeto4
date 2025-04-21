using System.Net.Mail;

namespace FlexHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            if (usuario == "pedro@gmail.com" &&  senha == "12345")
            {
                this.Hide();

                // Abre o Form2
                Form2 form2 = new Form2();
                form2.ShowDialog();

                // Fecha o Form1 depois que o Form2 for fechado (opcional)
                this.Close();
            }

            else
            {
                MessageBox.Show("Email e senha inválidos", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
