using Avaliacoes.App.Cadastros;
using Avaliacoes.App.Infra;
using Avaliacoes.Domain.Base;
using Avaliacoes.App.Models;
using Avaliacoes.Domain.Entities;
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

        public FormPrincipal(IBaseService<Filme> filmeService, IBaseService<Musica> musicaService, IBaseService<Livro> livroService, IBaseService<Serie> serieService)
        {
            _filmeService = filmeService;
            _musicaService = musicaService;
            _livroService = livroService;
            _serieService = serieService;
            InitializeComponent();
            CarregarCombo();

            usMostraAval user = new usMostraAval();
            flowLayoutAva.Controls.Add(user);
            user.lTitulo.Text = "Primeiro filme";
            user.lDataDaAva.Text = "02/12/2023";
            user.lNota.Text = "10";
            user.ltextAva.Text = "Uma descricao qualquer";
            usMostraAval user2 = new usMostraAval();
            user2.lTitulo.Text = "Segunda Musica";
            user2.lDataDaAva.Text = "15/12/2023";
            user2.lNota.Text = "8";
            test(user2);
            flowLayoutAva.Controls.Add(user2);

        }

        private void test(usMostraAval a)
        {
            for (int i = 0; i < 100; i++)
            {
                a.ltextAva.Text += " Champson";
            }
        }

        private void CarregarCombo()
        {
            switch (cboTipoMidia.SelectedIndex)
            {
                case 0: // filme
                    cboTipoMidia.ValueMember = "Id";
                    cboTipoMidia.DisplayMember = "Titulo";
                    cboTipoMidia.DataSource = _filmeService.Get<FilmeModel>().ToList();
                    break;

                case 1: // musica
                    cboTipoMidia.ValueMember = "Id";
                    cboTipoMidia.DisplayMember = "Titulo";
                    cboTipoMidia.DataSource = _musicaService.Get<MusicaModel>().ToList();
                    break;

                case 2: // livro
                    cboTipoMidia.ValueMember = "Id";
                    cboTipoMidia.DisplayMember = "Titulo";
                    cboTipoMidia.DataSource = _livroService.Get<LivroModel>().ToList();
                    break;

                case 3: // serie
                    cboTipoMidia.ValueMember = "Id";
                    cboTipoMidia.DisplayMember = "Titulo";
                    cboTipoMidia.DataSource = _serieService.Get<SerieModel>().ToList();
                    break;
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




    }
}
