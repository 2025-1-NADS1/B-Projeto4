using System;
using System.Windows.Forms;

namespace SmartHomeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RealizarLogin();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private void RealizarLogin()
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                FormAdmin adminForm = new FormAdmin();
                adminForm.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "usuario" && txtPassword.Text == "usuario")
            {
                FormUsuario userForm = new FormUsuario();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void btnSustentavel_Click(object sender, EventArgs e)
        {
            FormControleSustentavel formSustentavel = new FormControleSustentavel();
            formSustentavel.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
