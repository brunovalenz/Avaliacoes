namespace Avaliacoes.App.Cadastros
{
    partial class CadastroSeries
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
            txtQntEps = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            SuspendLayout();
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
            txtDiretor.Location = new Point(24, 225);
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
            // txtQntEps
            // 
            txtQntEps.AllowPromptAsInput = true;
            txtQntEps.AnimateReadOnly = false;
            txtQntEps.AsciiOnly = false;
            txtQntEps.BackgroundImageLayout = ImageLayout.None;
            txtQntEps.BeepOnError = false;
            txtQntEps.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtQntEps.Depth = 0;
            txtQntEps.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQntEps.HidePromptOnLeave = false;
            txtQntEps.HideSelection = true;
            txtQntEps.Hint = "Quantidade de Episódios";
            txtQntEps.InsertKeyMode = InsertKeyMode.Default;
            txtQntEps.LeadingIcon = null;
            txtQntEps.Location = new Point(453, 225);
            txtQntEps.Mask = "999/";
            txtQntEps.MaxLength = 32767;
            txtQntEps.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQntEps.Name = "txtQntEps";
            txtQntEps.PasswordChar = '\0';
            txtQntEps.PrefixSuffixText = null;
            txtQntEps.PromptChar = '_';
            txtQntEps.ReadOnly = false;
            txtQntEps.RejectInputOnFirstFailure = false;
            txtQntEps.ResetOnPrompt = true;
            txtQntEps.ResetOnSpace = true;
            txtQntEps.RightToLeft = RightToLeft.No;
            txtQntEps.SelectedText = "";
            txtQntEps.SelectionLength = 0;
            txtQntEps.SelectionStart = 0;
            txtQntEps.ShortcutsEnabled = true;
            txtQntEps.Size = new Size(173, 48);
            txtQntEps.SkipLiterals = true;
            txtQntEps.TabIndex = 5;
            txtQntEps.TabStop = false;
            txtQntEps.Text = "   /";
            txtQntEps.TextAlign = HorizontalAlignment.Left;
            txtQntEps.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtQntEps.TrailingIcon = null;
            txtQntEps.UseSystemPasswordChar = false;
            txtQntEps.ValidatingType = null;
            // 
            // CadastroSeries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 358);
            Controls.Add(txtQntEps);
            Controls.Add(txtDiretor);
            Location = new Point(0, 0);
            Name = "CadastroSeries";
            Text = "Cadastro Série";
            Controls.SetChildIndex(txtDiretor, 0);
            Controls.SetChildIndex(txtQntEps, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDiretor;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtQntEps;
    }
}