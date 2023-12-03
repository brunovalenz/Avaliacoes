namespace Avaliacoes.App.Cadastros
{
    partial class CadastroMusicas
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
            txtArtista = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDuracao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // txtArtista
            // 
            txtArtista.AnimateReadOnly = false;
            txtArtista.AutoCompleteMode = AutoCompleteMode.None;
            txtArtista.AutoCompleteSource = AutoCompleteSource.None;
            txtArtista.BackgroundImageLayout = ImageLayout.None;
            txtArtista.CharacterCasing = CharacterCasing.Normal;
            txtArtista.Depth = 0;
            txtArtista.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtArtista.HideSelection = true;
            txtArtista.Hint = "Artista";
            txtArtista.LeadingIcon = null;
            txtArtista.Location = new Point(24, 224);
            txtArtista.MaxLength = 32767;
            txtArtista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtArtista.Name = "txtArtista";
            txtArtista.PasswordChar = '\0';
            txtArtista.PrefixSuffixText = null;
            txtArtista.ReadOnly = false;
            txtArtista.RightToLeft = RightToLeft.No;
            txtArtista.SelectedText = "";
            txtArtista.SelectionLength = 0;
            txtArtista.SelectionStart = 0;
            txtArtista.ShortcutsEnabled = true;
            txtArtista.Size = new Size(423, 48);
            txtArtista.TabIndex = 4;
            txtArtista.TabStop = false;
            txtArtista.TextAlign = HorizontalAlignment.Left;
            txtArtista.TrailingIcon = null;
            txtArtista.UseSystemPasswordChar = false;
            // 
            // txtDuracao
            // 
            txtDuracao.AllowPromptAsInput = true;
            txtDuracao.AnimateReadOnly = false;
            txtDuracao.AsciiOnly = false;
            txtDuracao.BackgroundImageLayout = ImageLayout.None;
            txtDuracao.BeepOnError = false;
            txtDuracao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDuracao.Depth = 0;
            txtDuracao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDuracao.HidePromptOnLeave = false;
            txtDuracao.HideSelection = true;
            txtDuracao.Hint = "Duração (min)";
            txtDuracao.InsertKeyMode = InsertKeyMode.Default;
            txtDuracao.LeadingIcon = null;
            txtDuracao.Location = new Point(453, 224);
            txtDuracao.Mask = "9999/";
            txtDuracao.MaxLength = 32767;
            txtDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.PasswordChar = '\0';
            txtDuracao.PrefixSuffixText = null;
            txtDuracao.PromptChar = '_';
            txtDuracao.ReadOnly = false;
            txtDuracao.RejectInputOnFirstFailure = false;
            txtDuracao.ResetOnPrompt = true;
            txtDuracao.ResetOnSpace = true;
            txtDuracao.RightToLeft = RightToLeft.No;
            txtDuracao.SelectedText = "";
            txtDuracao.SelectionLength = 0;
            txtDuracao.SelectionStart = 0;
            txtDuracao.ShortcutsEnabled = true;
            txtDuracao.Size = new Size(173, 48);
            txtDuracao.SkipLiterals = true;
            txtDuracao.TabIndex = 5;
            txtDuracao.TabStop = false;
            txtDuracao.Text = "    /";
            txtDuracao.TextAlign = HorizontalAlignment.Left;
            txtDuracao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDuracao.TrailingIcon = null;
            txtDuracao.UseSystemPasswordChar = false;
            txtDuracao.ValidatingType = null;
            // 
            // CadastroMusicas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 358);
            Controls.Add(txtDuracao);
            Controls.Add(txtArtista);
            Location = new Point(0, 0);
            Name = "CadastroMusicas";
            Text = "Cadastro Musica";
            Controls.SetChildIndex(txtArtista, 0);
            Controls.SetChildIndex(txtDuracao, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtArtista;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDuracao;
    }
}