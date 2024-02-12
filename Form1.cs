using System;
using System.Drawing;
using System.Windows.Forms;
using MinhaAplicacao.Models;
using MinhaAplicacao.Services; 

public partial class Form1 : Form
{
    private CrudService _crudService;

    // Adicionar controles para brinquedos
    private Label lblNomeBrinquedo;
    private TextBox txtNomeBrinquedo;
    private Button btnSalvarBrinquedo;

    public Form1()
    {
        InitializeComponent();
        _crudService = new CrudService();

        // Inicializar controles para brinquedos
        InitializeBrinquedoControls();
    }

    private void InitializeBrinquedoControls()
    {
        lblNomeBrinquedo = new Label();
        lblNomeBrinquedo.Text = "Nome do Brinquedo:";
        lblNomeBrinquedo.Location = new Point(20, 100);
        this.Controls.Add(lblNomeBrinquedo);

        txtNomeBrinquedo = new TextBox();
        txtNomeBrinquedo.Location = new Point(150, 100);
        this.Controls.Add(txtNomeBrinquedo);

        btnSalvarBrinquedo = new Button();
        btnSalvarBrinquedo.Text = "Salvar Brinquedo";
        btnSalvarBrinquedo.Location = new Point(20, 140);
        btnSalvarBrinquedo.Click += BtnSalvarBrinquedo_Click;
        this.Controls.Add(btnSalvarBrinquedo);
    }

    private void BtnSalvarBrinquedo_Click(object sender, EventArgs e)
    {
        // Validar os dados antes de salvar
        if (string.IsNullOrEmpty(txtNomeBrinquedo.Text))
        {
            MessageBox.Show("Por favor, preencha o nome do brinquedo.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Criar um novo brinquedo com base nos dados inseridos
        Brinquedo novoBrinquedo = new Brinquedo
        {
            Nome = txtNomeBrinquedo.Text,
            // Atribuir outras propriedades conforme necessário
        };

        // Chamar o método CriarBrinquedo da classe CrudService para adicionar o novo brinquedo
        try
        {
            _crudService.CriarBrinquedo(novoBrinquedo);
            MessageBox.Show("Brinquedo salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCamposBrinquedo();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao salvar o brinquedo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Método para limpar os campos de brinquedo
    private void LimparCamposBrinquedo()
    {
        // Limpar o campo de texto do nome do brinquedo
        txtNomeBrinquedo.Text = "";
        // Limpar outros campos de brinquedo, se necessário
    }
}
