namespace MinhaAplicacao
{
    partial class FormularioPrincipal
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // Adicione aqui o código para inicializar os controles

            // Exemplo: Adicionar um botão
            Button btnAbrirExibicao = new Button();
            btnAbrirExibicao.Text = "Abrir Exibição";
            btnAbrirExibicao.Location = new System.Drawing.Point(50, 50); // Defina a localização do botão conforme desejado
            btnAbrirExibicao.Click += BtnAbrirExibicao_Click; // Associe o evento de clique ao método BtnAbrirExibicao_Click
            this.Controls.Add(btnAbrirExibicao);

            this.ResumeLayout(false);
        }
    }
}
