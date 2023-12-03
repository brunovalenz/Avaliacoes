namespace Avaliacoes.App.Cadastros
{
    partial class CadastroLivros
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
            txtAutor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTotalPag = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // txtAutor
            // 
            txtAutor.AnimateReadOnly = false;
            txtAutor.AutoCompleteMode = AutoCompleteMode.None;
            txtAutor.AutoCompleteSource = AutoCompleteSource.None;
            txtAutor.BackgroundImageLayout = ImageLayout.None;
            txtAutor.CharacterCasing = CharacterCasing.Normal;
            txtAutor.Depth = 0;
            txtAutor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAutor.HideSelection = true;
            txtAutor.Hint = "Autor";
            txtAutor.LeadingIcon = null;
            txtAutor.Location = new Point(24, 221);
            txtAutor.MaxLength = 32767;
            txtAutor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAutor.Name = "txtAutor";
            txtAutor.PasswordChar = '\0';
            txtAutor.PrefixSuffixText = null;
            txtAutor.ReadOnly = false;
            txtAutor.RightToLeft = RightToLeft.No;
            txtAutor.SelectedText = "";
            txtAutor.SelectionLength = 0;
            txtAutor.SelectionStart = 0;
            txtAutor.ShortcutsEnabled = true;
            txtAutor.Size = new Size(423, 48);
            txtAutor.TabIndex = 4;
            txtAutor.TabStop = false;
            txtAutor.TextAlign = HorizontalAlignment.Left;
            txtAutor.TrailingIcon = null;
            txtAutor.UseSystemPasswordChar = false;
            // 
            // txtTotalPag
            // 
            txtTotalPag.AllowPromptAsInput = true;
            txtTotalPag.AnimateReadOnly = false;
            txtTotalPag.AsciiOnly = false;
            txtTotalPag.BackgroundImageLayout = ImageLayout.None;
            txtTotalPag.BeepOnError = false;
            txtTotalPag.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalPag.Depth = 0;
            txtTotalPag.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalPag.HidePromptOnLeave = false;
            txtTotalPag.HideSelection = true;
            txtTotalPag.Hint = "Total de Páginas";
            txtTotalPag.InsertKeyMode = InsertKeyMode.Default;
            txtTotalPag.LeadingIcon = null;
            txtTotalPag.Location = new Point(453, 221);
            txtTotalPag.Mask = "99999/";
            txtTotalPag.MaxLength = 32767;
            txtTotalPag.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalPag.Name = "txtTotalPag";
            txtTotalPag.PasswordChar = '\0';
            txtTotalPag.PrefixSuffixText = null;
            txtTotalPag.PromptChar = '_';
            txtTotalPag.ReadOnly = false;
            txtTotalPag.RejectInputOnFirstFailure = false;
            txtTotalPag.ResetOnPrompt = true;
            txtTotalPag.ResetOnSpace = true;
            txtTotalPag.RightToLeft = RightToLeft.No;
            txtTotalPag.SelectedText = "";
            txtTotalPag.SelectionLength = 0;
            txtTotalPag.SelectionStart = 0;
            txtTotalPag.ShortcutsEnabled = true;
            txtTotalPag.Size = new Size(173, 48);
            txtTotalPag.SkipLiterals = true;
            txtTotalPag.TabIndex = 5;
            txtTotalPag.TabStop = false;
            txtTotalPag.Text = "     /";
            txtTotalPag.TextAlign = HorizontalAlignment.Left;
            txtTotalPag.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalPag.TrailingIcon = null;
            txtTotalPag.UseSystemPasswordChar = false;
            txtTotalPag.ValidatingType = null;
            // 
            // CadastroLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 358);
            Controls.Add(txtTotalPag);
            Controls.Add(txtAutor);
            Location = new Point(0, 0);
            Name = "CadastroLivros";
            Text = "Cadastro Livro";
            Controls.SetChildIndex(txtAutor, 0);
            Controls.SetChildIndex(txtTotalPag, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAutor;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTotalPag;
    }
}