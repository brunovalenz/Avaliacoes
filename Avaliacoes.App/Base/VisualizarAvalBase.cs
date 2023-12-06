using ReaLTaiizor.Forms;

namespace Avaliacoes.App.Base
{
    public partial class VisualizarAvalBase : MaterialForm
    {
        public VisualizarAvalBase(string titulo, string dataAval, string nota, string avaliacao, string descricao, string anoLanca, string classificacao, string dynamic1T, string dynamic1, string dynamic2T, string dynamic2)
        {
            InitializeComponent();
            this.Text += titulo;
            txtAvaliacao.Text = avaliacao;
            txtDataAval.Text = dataAval;
            txtNota.Text = nota;
            txtDescricao.Text = descricao;
            txtAnoLanca.Text = anoLanca;
            txtClassificacao.Text = classificacao;
            lDynamic1.Text = dynamic1T;
            txtDinamico1.Text = dynamic1;
            lDynamic2.Text = dynamic2T;
            txtDinamico2.Text = dynamic2;
        }
    }
}
