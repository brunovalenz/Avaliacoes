using Avaliacoes.App.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Extension;

namespace Avaliacoes.App.Cadastros
{
    public partial class CadastroFilme : CadastroBase
    {
        private readonly IBaseService<Filme> _filmeService;

        private readonly IBaseService<Midia> _midiaService;

        public CadastroFilme(IBaseService<Filme> filmeService, IBaseService<Midia> midiaService)
        {
            _filmeService = filmeService;
            _midiaService = midiaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Filme filme, int idMidia)
        {
            filme.Diretor = txtDiretor.Text;
            try
            {
                filme.Duracao = int.Parse(txtDuracao.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            filme.Midia = _midiaService.GetById<Midia>(idMidia);
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
                var filme = new Filme();
                PreencheObjeto(filme, idMidia);
                _filmeService.Add<Filme, Filme, FilmeValidator>(filme);
                MessageBox.Show($"Filme {txtTitulo.Text} foi cadastrado!", @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (FormPrincipal.instance != null) FormPrincipal.instance.CarregarMidias();
        }


    }
}
