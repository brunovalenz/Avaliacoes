using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace Avaliacoes.App.Base
{
    public partial class CadastroBase : MaterialForm
    {

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        #endregion

        #region CRUD Methods

        protected virtual void Salvar()
        {

        }

        #endregion


    }
}
