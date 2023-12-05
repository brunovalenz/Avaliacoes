using Avaliacoes.App.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Extension;

namespace Avaliacoes.App.Cadastros
{
    public partial class CadastroSerie : CadastroBase
    {
        private readonly IBaseService<Serie> _serieService;

        private readonly IBaseService<Midia> _midiaService;
        public CadastroSerie(IBaseService<Serie> serieService, IBaseService<Midia> midiaService)
        {
            _serieService = serieService;
            _midiaService = midiaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Serie serie, int idMidia)
        {
            serie.Diretor = txtDiretor.Text;
            try
            {
                serie.QntEps = int.Parse(txtQntEps.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            serie.Midia = _midiaService.GetById<Midia>(idMidia);
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
                var serie = new Serie();
                PreencheObjeto(serie, idMidia);
                _serieService.Add<Serie, Serie, SerieValidator>(serie);
                MessageBox.Show($"Serie {txtTitulo.Text} foi cadastrada!", @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Avaliações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
