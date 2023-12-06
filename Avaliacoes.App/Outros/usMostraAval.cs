using Avaliacoes.App.Base;
using Avaliacoes.Domain.Entities;

namespace Avaliacoes.App.Cadastros
{
    public partial class usMostraAval : UserControl
    {
        private string titulo, avaliacao, descricao, classificacao, dinamico1Title, dinamico1, dinamico2Title, dinamico2;
        private DateTime? dataAvaliacao;
        private int nota;
        private int? anoLancamento;
        public usMostraAval(string titulo, DateTime? dataAvaliacao, int nota, string avaliacao, string descricao, int? anoLancamento, string classificacao, string dinamico1Title, string dinamico1, string dinamico2Title, string dinamico2)
        {
            InitializeComponent();
            lTitulo.Text = titulo;
            ltextAva.Text = avaliacao;
            lDataDaAva.Text = dataAvaliacao.ToString().Split(" ")[0];
            lNota.Text = nota.ToString();

            this.titulo = titulo;
            this.dataAvaliacao = dataAvaliacao;
            this.nota = nota;
            this.avaliacao = avaliacao;
            this.descricao = descricao;
            this.anoLancamento = anoLancamento;
            this.classificacao = classificacao;
            this.dinamico1Title = dinamico1Title;
            this.dinamico1 = dinamico1;
            this.dinamico2Title = dinamico2Title;
            this.dinamico2 = dinamico2;

            this.MouseDoubleClick += usMostraAval_MouseDoubleClick;

            foreach (Control control in this.Controls)
            {
                control.MouseDoubleClick += usMostraAval_MouseDoubleClick;
            }

        }

        private void usMostraAval_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisualizarAvalBase mostrar = new VisualizarAvalBase(titulo, dataAvaliacao.ToString().Split(" ")[0], nota.ToString(),avaliacao,descricao,anoLancamento.ToString(),classificacao,dinamico1Title,dinamico1,dinamico2Title,dinamico2);
            mostrar.ShowDialog();
        }
    }
}
