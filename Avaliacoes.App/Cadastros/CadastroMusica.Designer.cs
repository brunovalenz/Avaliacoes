namespace Avaliacoes.App.Cadastros
{
    partial class CadastroMusica
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
            txtDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // txtAnoLanca
            // 
            txtAnoLanca.TabIndex = 1;
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
            txtDuracao.Location = new Point(452, 224);
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
            // CadastroMusica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 358);
            Controls.Add(txtDuracao);
            Controls.Add(txtArtista);
            Location = new Point(0, 0);
            Name = "CadastroMusica";
            Text = "Cadastro Musica";
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(txtTitulo, 0);
            Controls.SetChildIndex(txtDescricao, 0);
            Controls.SetChildIndex(cboClassificacao, 0);
            Controls.SetChildIndex(txtAnoLanca, 0);
            Controls.SetChildIndex(txtArtista, 0);
            Controls.SetChildIndex(txtDuracao, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtArtista;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDuracao;
    }
}