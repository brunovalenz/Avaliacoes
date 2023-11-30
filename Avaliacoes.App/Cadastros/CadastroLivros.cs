using Avaliacoes.App.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;

namespace Avaliacoes.App.Cadastros
{
    public partial class CadastroLivros : CadastroBase
    {
        private readonly IBaseService<Livros> _livrosService;
        private readonly IBaseService<Midias> _midiasService;

        private List<Livros>? livros;

        public CadastroLivros(IBaseService<Livros> livrosService, IBaseService<Midias> midiasService)
        {
            _livrosService = livrosService;
            _midiasService = midiasService;
            InitializeComponent();
        }

        private void PreencheObjeto(Livros livros)
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
