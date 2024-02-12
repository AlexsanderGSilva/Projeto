using System;
using System.Windows.Forms;
using MinhaAplicacao.Models;
using MinhaAplicacao.Services; 

namespace MinhaAplicacao
{
    public partial class FormularioPrincipal : Form
    {
        // Constantes para posicionamento dos controles
        private const int BotaoX = 50;
        private const int BotaoY = 50;

        private CrudService _crudService;

        public FormularioPrincipal()
        {
            InitializeComponent();
            _crudService = new CrudService();

            // Adicionar controles
            AdicionarControles();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            // Código a ser executado quando o formulário é carregado
        }

        private void AdicionarControles()
        {
            // Adicionar um botão
            Button btnAbrirExibicao = new Button();
            btnAbrirExibicao.Text = "Abrir Exibição";
            btnAbrirExibicao.Location = new System.Drawing.Point(BotaoX, BotaoY); // Posicionamento do botão
            btnAbrirExibicao.Click += BtnAbrirExibicao_Click; // Associação do evento de clique
            this.Controls.Add(btnAbrirExibicao);
        }

        // Método chamado quando o botão "Abrir Exibição" é clicado
        private void BtnAbrirExibicao_Click(object sender, EventArgs e)
        {
            try
            {
                // Crie uma instância do FormularioExibicao e exiba-o
                FormularioExibicao formularioExibicao = new FormularioExibicao();
                formularioExibicao.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao abrir a tela de exibição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
