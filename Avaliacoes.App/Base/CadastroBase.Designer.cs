using Avaliacoes.App.Cadastros;

namespace Avaliacoes.App.Base
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            imageList = new ImageList(components);
            btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboClassificacao = new ReaLTaiizor.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "baseline_fingerprint_black_24dp.png");
            imageList.Images.SetKeyName(1, "form.png");
            imageList.Images.SetKeyName(2, "search.png");
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdd.Location = new Point(528, 315);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(98, 36);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Adicionar";
            btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancel.Location = new Point(424, 315);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(96, 36);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancelar";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.AutoCompleteMode = AutoCompleteMode.None;
            txtTitulo.AutoCompleteSource = AutoCompleteSource.None;
            txtTitulo.BackgroundImageLayout = ImageLayout.None;
            txtTitulo.CharacterCasing = CharacterCasing.Normal;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.HideSelection = true;
            txtTitulo.Hint = "Título";
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(24, 88);
            txtTitulo.MaxLength = 32767;
            txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PasswordChar = '\0';
            txtTitulo.PrefixSuffixText = null;
            txtTitulo.ReadOnly = false;
            txtTitulo.RightToLeft = RightToLeft.No;
            txtTitulo.SelectedText = "";
            txtTitulo.SelectionLength = 0;
            txtTitulo.SelectionStart = 0;
            txtTitulo.ShortcutsEnabled = true;
            txtTitulo.Size = new Size(423, 48);
            txtTitulo.TabIndex = 0;
            txtTitulo.TabStop = false;
            txtTitulo.TextAlign = HorizontalAlignment.Left;
            txtTitulo.TrailingIcon = null;
            txtTitulo.UseSystemPasswordChar = false;
            // 
            // txtData
            // 
            txtData.AllowPromptAsInput = true;
            txtData.AnimateReadOnly = false;
            txtData.AsciiOnly = false;
            txtData.BackgroundImageLayout = ImageLayout.None;
            txtData.BeepOnError = false;
            txtData.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtData.Depth = 0;
            txtData.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtData.HidePromptOnLeave = false;
            txtData.HideSelection = true;
            txtData.Hint = "Data de lançamento";
            txtData.InsertKeyMode = InsertKeyMode.Default;
            txtData.LeadingIcon = null;
            txtData.Location = new Point(453, 88);
            txtData.Mask = "99/99/9999";
            txtData.MaxLength = 32767;
            txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtData.Name = "txtData";
            txtData.PasswordChar = '\0';
            txtData.PrefixSuffixText = null;
            txtData.PromptChar = '_';
            txtData.ReadOnly = false;
            txtData.RejectInputOnFirstFailure = false;
            txtData.ResetOnPrompt = true;
            txtData.ResetOnSpace = true;
            txtData.RightToLeft = RightToLeft.No;
            txtData.SelectedText = "";
            txtData.SelectionLength = 0;
            txtData.SelectionStart = 0;
            txtData.ShortcutsEnabled = true;
            txtData.Size = new Size(173, 48);
            txtData.SkipLiterals = true;
            txtData.TabIndex = 1;
            txtData.TabStop = false;
            txtData.Text = "  /  /";
            txtData.TextAlign = HorizontalAlignment.Left;
            txtData.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtData.TrailingIcon = null;
            txtData.UseSystemPasswordChar = false;
            txtData.ValidatingType = null;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(24, 155);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(423, 48);
            txtDescricao.TabIndex = 2;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // cboClassificacao
            // 
            cboClassificacao.AutoResize = false;
            cboClassificacao.BackColor = Color.FromArgb(255, 255, 255);
            cboClassificacao.Depth = 0;
            cboClassificacao.DrawMode = DrawMode.OwnerDrawVariable;
            cboClassificacao.DropDownHeight = 174;
            cboClassificacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClassificacao.DropDownWidth = 121;
            cboClassificacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboClassificacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboClassificacao.FormattingEnabled = true;
            cboClassificacao.Hint = "Classificação";
            cboClassificacao.IntegralHeight = false;
            cboClassificacao.ItemHeight = 43;
            cboClassificacao.Items.AddRange(new object[] { "Livre", "10 Anos", "12 Anos", "14 Anos", "16 Anos", "18 Anos" });
            cboClassificacao.Location = new Point(453, 154);
            cboClassificacao.MaxDropDownItems = 4;
            cboClassificacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboClassificacao.Name = "cboClassificacao";
            cboClassificacao.Size = new Size(174, 49);
            cboClassificacao.StartIndex = 0;
            cboClassificacao.TabIndex = 3;
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 358);
            Controls.Add(cboClassificacao);
            Controls.Add(txtDescricao);
            Controls.Add(txtData);
            Controls.Add(txtTitulo);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroBase";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroBase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialComboBox cboClassificacao;
    }
}