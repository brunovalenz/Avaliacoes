namespace Avaliacoes.App.Cadastros
{
    partial class CadastroSerie
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
            txtQntEps = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            txtDiretor.Size = new Size(392, 48);
            txtDiretor.TabIndex = 4;
            txtDiretor.TabStop = false;
            txtDiretor.TextAlign = HorizontalAlignment.Left;
            txtDiretor.TrailingIcon = null;
            txtDiretor.UseSystemPasswordChar = false;
            // 
            // txtQntEps
            // 
            txtQntEps.AnimateReadOnly = false;
            txtQntEps.AutoCompleteMode = AutoCompleteMode.None;
            txtQntEps.AutoCompleteSource = AutoCompleteSource.None;
            txtQntEps.BackgroundImageLayout = ImageLayout.None;
            txtQntEps.CharacterCasing = CharacterCasing.Normal;
            txtQntEps.Depth = 0;
            txtQntEps.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQntEps.HideSelection = true;
            txtQntEps.Hint = "Quantidade de Episódios";
            txtQntEps.LeadingIcon = null;
            txtQntEps.Location = new Point(422, 225);
            txtQntEps.MaxLength = 32767;
            txtQntEps.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQntEps.Name = "txtQntEps";
            txtQntEps.PasswordChar = '\0';
            txtQntEps.PrefixSuffixText = null;
            txtQntEps.ReadOnly = false;
            txtQntEps.RightToLeft = RightToLeft.No;
            txtQntEps.SelectedText = "";
            txtQntEps.SelectionLength = 0;
            txtQntEps.SelectionStart = 0;
            txtQntEps.ShortcutsEnabled = true;
            txtQntEps.Size = new Size(204, 48);
            txtQntEps.TabIndex = 5;
            txtQntEps.TabStop = false;
            txtQntEps.TextAlign = HorizontalAlignment.Left;
            txtQntEps.TrailingIcon = null;
            txtQntEps.UseSystemPasswordChar = false;
            // 
            // CadastroSerie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 358);
            Controls.Add(txtQntEps);
            Controls.Add(txtDiretor);
            Location = new Point(0, 0);
            Name = "CadastroSerie";
            Text = "Cadastro Série";
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(txtTitulo, 0);
            Controls.SetChildIndex(txtDescricao, 0);
            Controls.SetChildIndex(cboClassificacao, 0);
            Controls.SetChildIndex(txtAnoLanca, 0);
            Controls.SetChildIndex(txtDiretor, 0);
            Controls.SetChildIndex(txtQntEps, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDiretor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQntEps;
    }
}