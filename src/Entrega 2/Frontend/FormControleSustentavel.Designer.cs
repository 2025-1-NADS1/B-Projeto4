namespace SmartHomeApp
{
    partial class FormControleSustentavel
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnVerSimulacao;
        private Button btnHome;

        private void InitializeComponent()
        {
            btnVerSimulacao = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // btnVerSimulacao
            // 
            btnVerSimulacao.Location = new Point(80, 50);
            btnVerSimulacao.Name = "btnVerSimulacao";
            btnVerSimulacao.Size = new Size(200, 40);
            btnVerSimulacao.TabIndex = 0;
            btnVerSimulacao.Text = "Simular Dados Sustentáveis";
            btnVerSimulacao.Click += btnVerSimulacao_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(140, 120);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 30);
            btnHome.TabIndex = 1;
            btnHome.Text = "🏠";
            btnHome.Click += btnHome_Click;
            // 
            // FormControleSustentavel
            // 
            ClientSize = new Size(360, 200);
            Controls.Add(btnVerSimulacao);
            Controls.Add(btnHome);
            Name = "FormControleSustentavel";
            Text = "Controle Sustentável";
            Load += FormControleSustentavel_Load;
            ResumeLayout(false);
        }
    }
}
