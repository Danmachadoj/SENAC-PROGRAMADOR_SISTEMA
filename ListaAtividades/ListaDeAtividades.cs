using ListaAtividades.Dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        private Atividade? atividadeEmAndamento;

        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            
            labelErro.Text = string.Empty;

            CarregarAtividadeEmAndamento();
            CarregarListaDeAtividades();
            
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento == null)
            {
                labelErro.Text = "N�o h� atividade em andamento.";
                return;
            }

            if (!atividadeEmAndamento.AtualizarSituacao())
            {
                labelErro.Text = "N�o foi possivel finalizar a atividade.";
                return;
            }

            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione uma atividade.";
                return;
            }

            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];

            Atividade atividade = new Atividade()
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value
            };

            if (!atividade.AtualizarSituacao())

            {
                labelErro.Text = "N�o foi possivel atualizar a atividade.";
                return;
            }

            labelErro.Text = string.Empty;
            CarregarListaDeAtividades();
            CarregarAtividadeEmAndamento();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
           var resultado = new CriarAtividade().ShowDialog();

            if (resultado != DialogResult.OK)
            {
                labelErro.Text = "A cria��o da atividade n�o foi conclu�da.";
                return;
            }

            labelErro.Text = "Atividade criada com sucesso.";
            CarregarListaDeAtividades();
        }
        private void CarregarListaDeAtividades()
        {
            Atividade atividade = new Atividade();
            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesPendentes;
        }

        private void CarregarAtividadeEmAndamento()
        {
            Atividade atividade = new();
            atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            string textoAtividade = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            textBoxAtividadeEmAndamento.Text = atividadeEmAndamento.Id> 0 ? textoAtividade : string.Empty;
        }
    }

}
