using Avaliacoes.App.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Service.Validators;

namespace Avaliacoes.App.Cadastros
{
    public partial class CadastroMusicas : CadastroBase
    {
        private readonly IBaseService<Musicas> _musicasService;
        private readonly IBaseService<Midias> _midiasService;

        private List<Musicas>? musicas;

        public CadastroMusicas(IBaseService<Musicas> musicasService, IBaseService<Midias> midiasService)
        {
            _musicasService = musicasService;
            _midiasService = midiasService;
            InitializeComponent();
        }

        private void PreencheObjeto(Musicas musicas)
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
