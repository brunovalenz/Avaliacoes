using ReaLTaiizor.Forms;

namespace Avaliacoes.App.Base
{
    public partial class VisualizarAvalBase : MaterialForm
    {
        public VisualizarAvalBase(string titulo, string dataAval, string nota, string avaliacao, string? dataLanca)
        {
            InitializeComponent();
            this.Text += titulo;
            txtAvaliacao.Text = avaliacao;
            txtDataAval.Text = dataAval;
            txtNota.Text = nota;
        }
    }
}
