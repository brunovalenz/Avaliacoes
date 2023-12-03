using Avaliacoes.App.Base;

namespace Avaliacoes.App.Cadastros
{
    public partial class usMostraAval : UserControl
    {
        public usMostraAval()
        {
            InitializeComponent();

            this.MouseDoubleClick += usMostraAval_MouseDoubleClick;

            foreach (Control control in this.Controls)
            {
                control.MouseDoubleClick += usMostraAval_MouseDoubleClick;
            }
        }

        private void usMostraAval_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisualizarAvalBase mostrar = new VisualizarAvalBase(lTitulo.Text, lDataDaAva.Text, lNota.Text, ltextAva.Text, lDataDaAva.Text);
            mostrar.ShowDialog();
        }
    }
}
