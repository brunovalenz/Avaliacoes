using Avaliacoes.App.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;

namespace Avaliacoes.App.Cadastros
{
    public partial class CadastroFilmes : CadastroBase
    {
        private readonly IBaseService<Filmes> _filmesService;
        private readonly IBaseService<Midias> _midiasService;

        private List<Filmes>? filmes;

        public CadastroFilmes(IBaseService<Filmes> filmesService, IBaseService<Midias> midiasService)
        {
            _filmesService = filmesService;
            _midiasService = midiasService;
            InitializeComponent();
        }

        private void PreencheObjeto(Filmes filmes)
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
