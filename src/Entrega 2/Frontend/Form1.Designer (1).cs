namespace SmartHomeApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnSustentavel;

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnSustentavel = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.Navy;
            txtUsername.Location = new Point(295, 213);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Usuário";
            txtUsername.Size = new Size(381, 25);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.Navy;
            txtPassword.Location = new Point(296, 257);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Senha";
            txtPassword.Size = new Size(381, 25);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(875, 515);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(10, 10);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Entrar";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSustentavel
            // 
            btnSustentavel.Location = new Point(-1, 515);
            btnSustentavel.Name = "btnSustentavel";
            btnSustentavel.Size = new Size(10, 10);
            btnSustentavel.TabIndex = 3;
            btnSustentavel.Text = "➡️";
            btnSustentavel.Click += btnSustentavel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(315, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 150);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 81);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 6;
            label1.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGIN__59_4_x_42_cm__removebg_preview;
            pictureBox2.Location = new Point(198, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(563, 302);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(924, 518);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnSustentavel);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
