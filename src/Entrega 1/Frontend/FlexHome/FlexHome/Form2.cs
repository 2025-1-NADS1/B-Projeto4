using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexHome
{
    public partial class Form2 : Form

    {
        string[] comodos = { "Quarto Casal", "Quarto Criança", "Sala de Estar", "Cozinha", "Banheiro" };
        enum Dispositivo { Luz = 0, Ar = 1, Seguranca = 2 }
        bool[,] dispositivos = new bool[5, 3]; // 5 cômodos, 3 dispositivos

        public Form2()
        {
            InitializeComponent();
            InicializarInterface();
            AtualizarGrid();
        }

        private void InicializarInterface()
        {
            this.Text = "Dashboard - Casa Inteligente";
            this.Size = new Size(800, 550);
            this.BackColor = Color.FromArgb(240, 248, 255);

            // Grade com status
            DataGridView dgv = new DataGridView();
            dgv.Name = "gridStatus";
            dgv.Size = new Size(740, 250);
            dgv.Location = new Point(20, 20);
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "Cômodo";
            dgv.Columns[1].Name = "Luz";
            dgv.Columns[2].Name = "Ar-condicionado";
            dgv.Columns[3].Name = "Segurança";
            this.Controls.Add(dgv);

            // Botões de controle dos dispositivos
            int y = 290;
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(200, 40);
                btn.Location = new Point(50 + (i * 230), y);
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.BackColor = Color.LightSteelBlue;

                if (i == 0) { btn.Text = "Alternar Luzes"; btn.Click += BtnLuz_Click; }
                if (i == 1) { btn.Text = "Alternar Ar"; btn.Click += BtnAr_Click; }
                if (i == 2) { btn.Text = "Alternar Segurança"; btn.Click += BtnSeguranca_Click; }

                this.Controls.Add(btn);
            }

            // Labels e TextBox para contas
            Label lblContaLuz = new Label();
            lblContaLuz.Text = "Conta de Luz (R$):";
            lblContaLuz.Location = new Point(50, 350);
            this.Controls.Add(lblContaLuz);

            TextBox txtContaLuz = new TextBox();
            txtContaLuz.Name = "txtContaLuz";
            txtContaLuz.Location = new Point(180, 347);
            this.Controls.Add(txtContaLuz);

            Label lblContaAgua = new Label();
            lblContaAgua.Text = "Conta de Água (R$):";
            lblContaAgua.Location = new Point(400, 350);
            this.Controls.Add(lblContaAgua);

            TextBox txtContaAgua = new TextBox();
            txtContaAgua.Name = "txtContaAgua";
            txtContaAgua.Location = new Point(530, 347);
            this.Controls.Add(txtContaAgua);

            // Botão para analisar consumo
            Button btnAnalisar = new Button();
            btnAnalisar.Text = "Analisar Consumo";
            btnAnalisar.Size = new Size(200, 40);
            btnAnalisar.Location = new Point(290, 390);
            btnAnalisar.BackColor = Color.MediumSeaGreen;
            btnAnalisar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAnalisar.Click += BtnAnalisar_Click;
            this.Controls.Add(btnAnalisar);

            // Label para mostrar dicas e recompensas
            Label lblDicas = new Label();
            lblDicas.Name = "lblDicas";
            lblDicas.Size = new Size(700, 70);
            lblDicas.Location = new Point(50, 440);
            lblDicas.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            lblDicas.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblDicas);
        }

        private void BtnLuz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comodos.Length; i++)
                dispositivos[i, (int)Dispositivo.Luz] = !dispositivos[i, (int)Dispositivo.Luz];

            AtualizarGrid();
        }

        private void BtnAr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comodos.Length; i++)
                dispositivos[i, (int)Dispositivo.Ar] = !dispositivos[i, (int)Dispositivo.Ar];

            AtualizarGrid();
        }

        private void BtnSeguranca_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comodos.Length; i++)
                dispositivos[i, (int)Dispositivo.Seguranca] = !dispositivos[i, (int)Dispositivo.Seguranca];

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            DataGridView dgv = (DataGridView)this.Controls["gridStatus"];
            dgv.Rows.Clear();
            for (int i = 0; i < comodos.Length; i++)
            {
                dgv.Rows.Add(
                    comodos[i],
                    dispositivos[i, (int)Dispositivo.Luz] ? "Ligado" : "Desligado",
                    dispositivos[i, (int)Dispositivo.Ar] ? "Ligado" : "Desligado",
                    dispositivos[i, (int)Dispositivo.Seguranca] ? "Seguro" : "Inseguro"
                );
            }
        }

        private void BtnAnalisar_Click(object sender, EventArgs e)
        {
            TextBox txtContaLuz = (TextBox)this.Controls["txtContaLuz"];
            TextBox txtContaAgua = (TextBox)this.Controls["txtContaAgua"];
            Label lblDicas = (Label)this.Controls["lblDicas"];

            if (double.TryParse(txtContaLuz.Text, out double contaLuz) &&
                double.TryParse(txtContaAgua.Text, out double contaAgua))
            {
                string dicaLuz = contaLuz > 150 ? "💡 Dica: Desligue luzes ao sair dos cômodos. " : "✅ Luz controlada! ";
                string dicaAgua = contaAgua > 100 ? "🚿 Dica: Evite banhos longos e conserte vazamentos. " : "✅ Água bem utilizada! ";

                int pontos = 0;
                if (contaLuz < 150) pontos += 10;
                if (contaAgua < 100) pontos += 10;

                string recompensa = pontos >= 20 ? "🏅 Medalha de Ouro em Economia!" :
                                    pontos >= 10 ? "🥈 Medalha de Prata em Economia!" :
                                    "🔸 Continue tentando economizar!";

                lblDicas.Text = $"{dicaLuz}\n{dicaAgua}\nRecompensa: {recompensa} (Pontos: {pontos})";
                lblDicas.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblDicas.Text = "❌ Por favor, insira valores válidos para as contas.";
                lblDicas.ForeColor = Color.Red;
            }
        }
    }
}
