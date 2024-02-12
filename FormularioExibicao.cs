using System;
using System.Windows.Forms;

namespace MinhaAplicacao
{
    public partial class FormularioExibicao : Form
    {
        private DataGridView dataGridViewDados;

        public FormularioExibicao()
        {
            InitializeComponent();
        }

        private void FormularioExibicao_Load(object sender, EventArgs e)
        {
            // Carregar os dados no DataGridView quando o formulário for carregado
            CarregarDados();
        }

        private void CarregarDados()
        {
            // Limpar os dados existentes
            dataGridViewDados.Rows.Clear();

            // Adicionar linhas de exemplo
            dataGridViewDados.Rows.Add(1, "Livro 1", "Autor 1", 2000);
            dataGridViewDados.Rows.Add(2, "Livro 2", "Autor 2", 2005);
            dataGridViewDados.Rows.Add(3, "Livro 3", "Autor 3", 2010);
        }

        private void InitializeComponent()
        {
            this.dataGridViewDados = new DataGridView();
            this.SuspendLayout();

            // FormularioExibicao
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormularioExibicao";
            this.Text = "Formulário de Exibição";
            this.Load += new System.EventHandler(this.FormularioExibicao_Load);

            // Configuração do DataGridView
            this.dataGridViewDados.Location = new System.Drawing.Point(50, 50);
            this.dataGridViewDados.Size = new System.Drawing.Size(700, 300);
            this.Controls.Add(dataGridViewDados);

            this.ResumeLayout(false);
        }
    }
}
