using Avaliacoes.App.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Extension;

namespace Avaliacoes.App.Cadastros
{
    public partial class CadastroMusica : CadastroBase
    {
        private readonly IBaseService<Musica> _musicaService;

        private readonly IBaseService<Midia> _midiaService;
        public CadastroMusica(IBaseService<Musica> musicaService, IBaseService<Midia> midiaService)
        {
            _musicaService = musicaService;
            _midiaService = midiaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Musica musica, int idMidia)
        {
            musica.Artista = txtArtista.Text;
            try
            {
                musica.Duracao = int.Parse(txtDuracao.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            musica.Midia = _midiaService.GetById<Midia>(idMidia);
        }
        private int PreencheMidia(Midia midia)
        {
            midia.Titulo = txtTitulo.Text;
            midia.Descricao = txtDescricao.Text;
            midia.Classificacao = cboClassificacao.Text;
            try
            {
                midia.AnoLancamento = int.Parse(txtAnoLanca.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _midiaService.Add<Midia, Midia, MidiaValidator>(midia);

            var idMidia = _midiaService.Get<Midia>().FirstOrDefault(x => x.Titulo == midia.Titulo && x.Descricao == midia.Descricao && x.Classificacao == midia.Classificacao && x.AnoLancamento == midia.AnoLancamento);

            return idMidia.Id;
        }

        protected override void Salvar()
        {
            try
            {
                var midia = new Midia();
                var idMidia = PreencheMidia(midia);
                var musica = new Musica();
                PreencheObjeto(musica, idMidia);
                _musicaService.Add<Musica, Musica, MusicaValidator>(musica);
                MessageBox.Show($"Musica {txtTitulo.Text} foi cadastrada!", @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
