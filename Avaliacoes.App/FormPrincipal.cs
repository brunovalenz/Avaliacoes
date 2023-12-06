using Avaliacoes.App.Cadastros;
using Avaliacoes.App.Infra;
using Avaliacoes.Domain.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;


namespace Avaliacoes.App
{
    public partial class FormPrincipal : MaterialForm
    {
        private readonly IBaseService<Filme> _filmeService;
        private readonly IBaseService<Musica> _musicaService;
        private readonly IBaseService<Livro> _livroService;
        private readonly IBaseService<Serie> _serieService;
        private readonly IBaseService<Midia> _midiaService;
        private readonly IBaseService<Avaliacao> _avaliacaoService;

        public static FormPrincipal instance = null;

        public FormPrincipal(IBaseService<Filme> filmeService, IBaseService<Musica> musicaService, IBaseService<Livro> livroService, IBaseService<Serie> serieService, IBaseService<Midia> midiaService, IBaseService<Avaliacao> avaliacaoService)
        {
            _filmeService = filmeService;
            _musicaService = musicaService;
            _livroService = livroService;
            _serieService = serieService;
            _midiaService = midiaService;
            _avaliacaoService = avaliacaoService;
            InitializeComponent();
            CarregarMidias();
            instance = this;

            var firme = _filmeService.Get<FilmeModel>(new List<String>() { "Midia" }).FirstOrDefault(x => x.IdMidia == 1);
            flowLayoutAva.Controls.Add(new usMostraAval(firme.Titulo, DateTime.Now, 5, "tester deu certo", "a descricao deu certo",firme.AnoLancamento, firme.Classificacao, "Diretor", firme.Diretor, "Duração:", firme.Duracao.ToString()));
        }

        public void CarregarMidias()
        {
            switch (cboTipoMidia.SelectedIndex)
            {
                case 0: // filme
                    lbMidias.ValueMember = "Titulo";
                    lbMidias.DisplayMember = "Titulo";
                    lbMidias.DataSource = _filmeService.Get<FilmeModel>(new List<String>() { "Midia" }).ToList();
                    break;

                case 1: // musica
                    lbMidias.ValueMember = "Titulo";
                    lbMidias.DisplayMember = "Titulo";
                    lbMidias.DataSource = _musicaService.Get<MusicaModel>(new List<String>() { "Midia" }).ToList();
                    break;

                case 2: // livro
                    lbMidias.ValueMember = "Titulo";
                    lbMidias.DisplayMember = "Titulo";
                    lbMidias.DataSource = _livroService.Get<LivroModel>(new List<String>() { "Midia" }).ToList();
                    break;

                case 3: // serie
                    lbMidias.ValueMember = "Titulo";
                    lbMidias.DisplayMember = "Titulo";
                    lbMidias.DataSource = _serieService.Get<SerieModel>(new List<String>() { "Midia" }).ToList();
                    break;
            }

        }

        private void PreencheObjeto(Avaliacao avaliacao)
        {
            avaliacao.Avaliacao2 = txtavaliacao.Text;
            try
            {
                avaliacao.Nota = float.Parse(txtNota.Text);
                avaliacao.DataAvaliacao = DateTime.Now;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var midia = _midiaService.Get<Midia>().FirstOrDefault(x => x.Titulo == lbMidias.SelectedValue.ToString());
            avaliacao.Midia = midia;
        }

        private void CarregaAvaliacoes()
        {
            flowLayoutAva.Controls.Clear();
            foreach (var aval in _avaliacaoService.Get<AvaliacaoModel>(new List<String>() { "Midia" }).ToList())
            {
                var midia = _midiaService.GetById<Midia>(aval.IdMidia);
                var filme = _filmeService.Get<FilmeModel>(new List<String>() { "Midia" }).FirstOrDefault(x => x.IdMidia == midia.Id);
                var livro = _livroService.Get<LivroModel>(new List<String>() { "Midia" }).FirstOrDefault(x => x.IdMidia == midia.Id);
                var musica = _musicaService.Get<MusicaModel>(new List<String>() { "Midia" }).FirstOrDefault(x => x.IdMidia == midia.Id);
                var serie = _serieService.Get<SerieModel>(new List<String>() { "Midia" }).FirstOrDefault(x => x.IdMidia == midia.Id);

                if (filme != null) flowLayoutAva.Controls.Add(new usMostraAval(aval.Titulo, aval.DataAvaliacao, aval.Nota, aval.Avaliacao2, filme.Descricao, filme.AnoLancamento, filme.Classificacao,"Diretor",filme.Diretor,"Duração -",filme.Duracao.ToString()));
                if (livro != null) flowLayoutAva.Controls.Add(new usMostraAval(aval.Titulo, aval.DataAvaliacao, aval.Nota, aval.Avaliacao2, livro.Descricao, livro.AnoLancamento, livro.Classificacao, "Autor", livro.Autor, "Total pag. -", livro.TotalPag.ToString()));
                if (musica != null) flowLayoutAva.Controls.Add(new usMostraAval(aval.Titulo, aval.DataAvaliacao, aval.Nota, aval.Avaliacao2, musica.Descricao, musica.AnoLancamento, musica.Classificacao, "Artista", musica.Artista, "Duração -", musica.Duracao.ToString()));
                if (serie != null) flowLayoutAva.Controls.Add(new usMostraAval(aval.Titulo, aval.DataAvaliacao, aval.Nota, aval.Avaliacao2, serie.Descricao, serie.AnoLancamento, serie.Classificacao, "Diretor", serie.Diretor, "Quantidade Ep. -", serie.QntEps.ToString()));
            }
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.Show();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        protected void LimpaCampos()
        {
            txtavaliacao.Clear();
            txtNota.Clear();
        }

        private void lHint1_Click(object sender, EventArgs e)
        {
            switch (cboTipoMidia.SelectedIndex)
            {
                case 0:
                    Exibeformulario<CadastroFilme>();
                    break;

                case 1:
                    Exibeformulario<CadastroMusica>();
                    break;

                case 2:
                    Exibeformulario<CadastroLivro>();
                    break;

                case 3:
                    Exibeformulario<CadastroSerie>();
                    break;
            }
        }

        private void cboTipoMidia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarMidias();
        }

        private void lbMidias_MouseEnter(object sender, EventArgs e)
        {
            CarregarMidias();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            try
            {
                Avaliacao avaliacao = new Avaliacao();
                PreencheObjeto(avaliacao);
                _avaliacaoService.Add<Avaliacao, Avaliacao, AvaliacaoValidator>(avaliacao);
                MessageBox.Show($"A sua avaliação foi cadastrada!", @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabAvaliacoes_Enter(object sender, EventArgs e)
        {
            CarregaAvaliacoes();
        }
    }
}
