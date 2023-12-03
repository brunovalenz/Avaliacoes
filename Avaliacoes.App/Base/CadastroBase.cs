using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace Avaliacoes.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

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
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
        protected virtual void Salvar()
        {

        }

        #endregion


    }
}
