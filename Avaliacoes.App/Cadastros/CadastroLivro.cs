using Avaliacoes.App.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Extension;

namespace Avaliacoes.App.Cadastros
{
    public partial class CadastroLivro : CadastroBase
    {
        private readonly IBaseService<Livro> _livroService;

        private readonly IBaseService<Midia> _midiaService;
        public CadastroLivro(IBaseService<Livro> livroService, IBaseService<Midia> midiaService)
        {
            _livroService = livroService;
            _midiaService = midiaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Livro livro, int idMidia)
        {
            livro.Autor = txtAutor.Text;
            try
            {
                livro.TotalPag = int.Parse(txtTotalPag.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            livro.Midia = _midiaService.GetById<Midia>(idMidia);
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
                var livro = new Livro();
                PreencheObjeto(livro, idMidia);
                _livroService.Add<Livro, Livro, LivroValidator>(livro);
                MessageBox.Show($"Livro {txtTitulo.Text} foi cadastrado!", @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
