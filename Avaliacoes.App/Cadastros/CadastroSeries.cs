using Avaliacoes.App.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;

namespace Avaliacoes.App.Cadastros
{
    public partial class CadastroSeries : CadastroBase
    {
        private readonly IBaseService<Series> _seriesService;
        private readonly IBaseService<Midias> _midiasService;

        private List<Series>? series;

        public CadastroSeries(IBaseService<Series> seriesService, IBaseService<Midias> midiasService)
        {
            _seriesService = seriesService;
            _midiasService = midiasService;
            InitializeComponent();
        }

        private void PreencheObjeto(Series series)
        {

        }

        protected override void Salvar()
        {

        }

        protected override void Deletar(int id)
        {

        }










    }
}
