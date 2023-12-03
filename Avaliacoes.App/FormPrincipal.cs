using Avaliacoes.App.Cadastros;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;

namespace Avaliacoes.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

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
                    CadastroFilmes filmes = new CadastroFilmes();
                    filmes.ShowDialog();
                    break;

                case 1:
                    CadastroMusicas musicas = new CadastroMusicas();
                    musicas.ShowDialog();
                    break;

                case 2:
                    CadastroLivros livros = new CadastroLivros();
                    livros.ShowDialog();
                    break;

                case 3:
                    CadastroSeries series = new CadastroSeries();
                    series.ShowDialog();
                    break;
            }
        }

    }
}
