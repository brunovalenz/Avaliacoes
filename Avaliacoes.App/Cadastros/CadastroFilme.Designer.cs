namespace Avaliacoes.App.Cadastros
{
    partial class CadastroFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDiretor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // txtAnoLanca
            // 
            txtAnoLanca.TabIndex = 1;
            // 
            // txtDiretor
            // 
            txtDiretor.AnimateReadOnly = false;
            txtDiretor.AutoCompleteMode = AutoCompleteMode.None;
            txtDiretor.AutoCompleteSource = AutoCompleteSource.None;
            txtDiretor.BackgroundImageLayout = ImageLayout.None;
            txtDiretor.CharacterCasing = CharacterCasing.Normal;
            txtDiretor.Depth = 0;
            txtDiretor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDiretor.HideSelection = true;
            txtDiretor.Hint = "Diretor";
            txtDiretor.LeadingIcon = null;
            txtDiretor.Location = new Point(24, 220);
            txtDiretor.MaxLength = 32767;
            txtDiretor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDiretor.Name = "txtDiretor";
            txtDiretor.PasswordChar = '\0';
            txtDiretor.PrefixSuffixText = null;
            txtDiretor.ReadOnly = false;
            txtDiretor.RightToLeft = RightToLeft.No;
            txtDiretor.SelectedText = "";
            txtDiretor.SelectionLength = 0;
            txtDiretor.SelectionStart = 0;
            txtDiretor.ShortcutsEnabled = true;
            txtDiretor.Size = new Size(423, 48);
            txtDiretor.TabIndex = 4;
            txtDiretor.TabStop = false;
            txtDiretor.TextAlign = HorizontalAlignment.Left;
            txtDiretor.TrailingIcon = null;
            txtDiretor.UseSystemPasswordChar = false;
            // 
            // txtDuracao
            // 
            txtDuracao.AnimateReadOnly = false;
            txtDuracao.AutoCompleteMode = AutoCompleteMode.None;
            txtDuracao.AutoCompleteSource = AutoCompleteSource.None;
            txtDuracao.BackgroundImageLayout = ImageLayout.None;
            txtDuracao.CharacterCasing = CharacterCasing.Normal;
            txtDuracao.Depth = 0;
            txtDuracao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDuracao.HideSelection = true;
            txtDuracao.Hint = "Duração (min)";
            txtDuracao.LeadingIcon = null;
            txtDuracao.Location = new Point(453, 220);
            txtDuracao.MaxLength = 32767;
            txtDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.PasswordChar = '\0';
            txtDuracao.PrefixSuffixText = null;
            txtDuracao.ReadOnly = false;
            txtDuracao.RightToLeft = RightToLeft.No;
            txtDuracao.SelectedText = "";
            txtDuracao.SelectionLength = 0;
            txtDuracao.SelectionStart = 0;
            txtDuracao.ShortcutsEnabled = true;
            txtDuracao.Size = new Size(174, 48);
            txtDuracao.TabIndex = 5;
            txtDuracao.TabStop = false;
            txtDuracao.TextAlign = HorizontalAlignment.Left;
            txtDuracao.TrailingIcon = null;
            txtDuracao.UseSystemPasswordChar = false;
            // 
            // CadastroFilmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 358);
            Controls.Add(txtDuracao);
            Controls.Add(txtDiretor);
            Location = new Point(0, 0);
            Name = "CadastroFilmes";
            Text = "Cadastro Filme";
            Controls.SetChildIndex(txtDiretor, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(txtTitulo, 0);
            Controls.SetChildIndex(txtDescricao, 0);
            Controls.SetChildIndex(cboClassificacao, 0);
            Controls.SetChildIndex(txtAnoLanca, 0);
            Controls.SetChildIndex(txtDuracao, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDiretor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDuracao;
    }
}