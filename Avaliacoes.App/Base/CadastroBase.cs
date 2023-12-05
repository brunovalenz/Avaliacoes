using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace Avaliacoes.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações

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
            try
            {
                Salvar();
            }
            catch (DbUpdateException ex)
            {
                // Inspect the inner exception
                Exception innerException = ex.InnerException;

                while (innerException != null)
                {
                    Console.WriteLine(innerException.Message);
                    innerException = innerException.InnerException;
                }
            }

        }

        #endregion

        #region CRUD Methods
        /*
        protected void LimpaCampos()
        {
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
        */

        protected virtual void Salvar()
        {

        }

        #endregion


    }
}
