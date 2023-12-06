namespace Avaliacoes.App
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            tabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabAvaliacoes = new TabPage();
            flowLayoutAva = new FlowLayoutPanel();
            tabNewAva = new TabPage();
            lbMidias = new ListBox();
            txtNota = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            lRating = new ReaLTaiizor.Controls.MaterialLabel();
            btnPublicar = new ReaLTaiizor.Controls.MaterialButton();
            cboTipoMidia = new ReaLTaiizor.Controls.MaterialComboBox();
            txtavaliacao = new ReaLTaiizor.Controls.MaterialRichTextBox();
            lTitleNewAval = new ReaLTaiizor.Controls.MaterialLabel();
            lHint1 = new ReaLTaiizor.Controls.MaterialLabel();
            imageList1 = new ImageList(components);
            tabControl.SuspendLayout();
            tabAvaliacoes.SuspendLayout();
            tabNewAva.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabAvaliacoes);
            tabControl.Controls.Add(tabNewAva);
            tabControl.Depth = 0;
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImageList = imageList1;
            tabControl.Location = new Point(3, 64);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1144, 693);
            tabControl.TabIndex = 0;
            // 
            // tabAvaliacoes
            // 
            tabAvaliacoes.Controls.Add(flowLayoutAva);
            tabAvaliacoes.ImageKey = "search.png";
            tabAvaliacoes.Location = new Point(4, 29);
            tabAvaliacoes.Name = "tabAvaliacoes";
            tabAvaliacoes.Padding = new Padding(3);
            tabAvaliacoes.RightToLeft = RightToLeft.Yes;
            tabAvaliacoes.Size = new Size(1136, 660);
            tabAvaliacoes.TabIndex = 0;
            tabAvaliacoes.Text = "Avaliações";
            tabAvaliacoes.UseVisualStyleBackColor = true;
            tabAvaliacoes.Enter += tabAvaliacoes_Enter;
            // 
            // flowLayoutAva
            // 
            flowLayoutAva.Dock = DockStyle.Fill;
            flowLayoutAva.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutAva.Location = new Point(3, 3);
            flowLayoutAva.Name = "flowLayoutAva";
            flowLayoutAva.Size = new Size(1130, 654);
            flowLayoutAva.TabIndex = 0;
            // 
            // tabNewAva
            // 
            tabNewAva.Controls.Add(lbMidias);
            tabNewAva.Controls.Add(txtNota);
            tabNewAva.Controls.Add(lRating);
            tabNewAva.Controls.Add(btnPublicar);
            tabNewAva.Controls.Add(cboTipoMidia);
            tabNewAva.Controls.Add(txtavaliacao);
            tabNewAva.Controls.Add(lTitleNewAval);
            tabNewAva.Controls.Add(lHint1);
            tabNewAva.ImageKey = "form.png";
            tabNewAva.Location = new Point(4, 29);
            tabNewAva.Name = "tabNewAva";
            tabNewAva.Padding = new Padding(3);
            tabNewAva.Size = new Size(1136, 660);
            tabNewAva.TabIndex = 1;
            tabNewAva.Text = "Escrever Avaliação";
            tabNewAva.UseVisualStyleBackColor = true;
            // 
            // lbMidias
            // 
            lbMidias.FormattingEnabled = true;
            lbMidias.ItemHeight = 20;
            lbMidias.Location = new Point(714, 118);
            lbMidias.Name = "lbMidias";
            lbMidias.Size = new Size(354, 504);
            lbMidias.TabIndex = 2;
            // 
            // txtNota
            // 
            txtNota.AllowPromptAsInput = true;
            txtNota.AnimateReadOnly = false;
            txtNota.AsciiOnly = false;
            txtNota.BackgroundImageLayout = ImageLayout.None;
            txtNota.BeepOnError = false;
            txtNota.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNota.Depth = 0;
            txtNota.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNota.HidePromptOnLeave = false;
            txtNota.HideSelection = true;
            txtNota.Hint = "0-10";
            txtNota.InsertKeyMode = InsertKeyMode.Default;
            txtNota.LeadingIcon = null;
            txtNota.Location = new Point(129, 593);
            txtNota.Mask = "";
            txtNota.MaxLength = 32767;
            txtNota.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNota.Name = "txtNota";
            txtNota.PasswordChar = '\0';
            txtNota.PrefixSuffixText = null;
            txtNota.PromptChar = '_';
            txtNota.ReadOnly = false;
            txtNota.RejectInputOnFirstFailure = false;
            txtNota.ResetOnPrompt = true;
            txtNota.ResetOnSpace = true;
            txtNota.RightToLeft = RightToLeft.No;
            txtNota.SelectedText = "";
            txtNota.SelectionLength = 0;
            txtNota.SelectionStart = 0;
            txtNota.ShortcutsEnabled = true;
            txtNota.Size = new Size(98, 48);
            txtNota.SkipLiterals = true;
            txtNota.TabIndex = 3;
            txtNota.TabStop = false;
            txtNota.TextAlign = HorizontalAlignment.Left;
            txtNota.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNota.TrailingIcon = null;
            txtNota.UseSystemPasswordChar = false;
            txtNota.ValidatingType = null;
            // 
            // lRating
            // 
            lRating.AutoSize = true;
            lRating.Depth = 0;
            lRating.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lRating.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            lRating.Location = new Point(33, 593);
            lRating.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lRating.Name = "lRating";
            lRating.Size = new Size(90, 41);
            lRating.TabIndex = 6;
            lRating.Text = "Nota: ";
            // 
            // btnPublicar
            // 
            btnPublicar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPublicar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPublicar.Depth = 0;
            btnPublicar.HighEmphasis = true;
            btnPublicar.Icon = null;
            btnPublicar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnPublicar.Location = new Point(476, 584);
            btnPublicar.Margin = new Padding(4, 6, 4, 6);
            btnPublicar.MinimumSize = new Size(180, 50);
            btnPublicar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPublicar.Name = "btnPublicar";
            btnPublicar.NoAccentTextColor = Color.Empty;
            btnPublicar.Size = new Size(180, 50);
            btnPublicar.TabIndex = 4;
            btnPublicar.Text = "Publicar Avaliação";
            btnPublicar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPublicar.UseAccentColor = false;
            btnPublicar.UseVisualStyleBackColor = true;
            btnPublicar.Click += btnPublicar_Click;
            // 
            // cboTipoMidia
            // 
            cboTipoMidia.AutoResize = false;
            cboTipoMidia.BackColor = Color.FromArgb(255, 255, 255);
            cboTipoMidia.Depth = 0;
            cboTipoMidia.DrawMode = DrawMode.OwnerDrawVariable;
            cboTipoMidia.DropDownHeight = 174;
            cboTipoMidia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoMidia.DropDownWidth = 121;
            cboTipoMidia.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTipoMidia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTipoMidia.FormattingEnabled = true;
            cboTipoMidia.Hint = "Qual Mídia?";
            cboTipoMidia.IntegralHeight = false;
            cboTipoMidia.ItemHeight = 43;
            cboTipoMidia.Items.AddRange(new object[] { "Filme", "Música", "Livro", "Série" });
            cboTipoMidia.Location = new Point(714, 32);
            cboTipoMidia.MaxDropDownItems = 4;
            cboTipoMidia.MinimumSize = new Size(180, 0);
            cboTipoMidia.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTipoMidia.Name = "cboTipoMidia";
            cboTipoMidia.Size = new Size(354, 49);
            cboTipoMidia.StartIndex = 0;
            cboTipoMidia.TabIndex = 1;
            cboTipoMidia.SelectedIndexChanged += cboTipoMidia_SelectedIndexChanged;
            // 
            // txtavaliacao
            // 
            txtavaliacao.BackColor = Color.FromArgb(255, 255, 255);
            txtavaliacao.BorderStyle = BorderStyle.None;
            txtavaliacao.Depth = 0;
            txtavaliacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtavaliacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtavaliacao.Hint = "";
            txtavaliacao.Location = new Point(33, 107);
            txtavaliacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtavaliacao.Name = "txtavaliacao";
            txtavaliacao.Size = new Size(623, 457);
            txtavaliacao.TabIndex = 0;
            txtavaliacao.Text = "";
            // 
            // lTitleNewAval
            // 
            lTitleNewAval.AutoSize = true;
            lTitleNewAval.Depth = 0;
            lTitleNewAval.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lTitleNewAval.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H2;
            lTitleNewAval.Location = new Point(33, 15);
            lTitleNewAval.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lTitleNewAval.Name = "lTitleNewAval";
            lTitleNewAval.Size = new Size(623, 72);
            lTitleNewAval.TabIndex = 0;
            lTitleNewAval.Text = "Escrever uma avaliação";
            // 
            // lHint1
            // 
            lHint1.AutoSize = true;
            lHint1.Cursor = Cursors.Hand;
            lHint1.Depth = 0;
            lHint1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lHint1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Body2;
            lHint1.ForeColor = SystemColors.ControlText;
            lHint1.Location = new Point(766, 98);
            lHint1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lHint1.Name = "lHint1";
            lHint1.Size = new Size(302, 17);
            lHint1.TabIndex = 4;
            lHint1.Text = "Não encontrou sua mídia? Clique para adicionar!";
            lHint1.Click += lHint1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "baseline_fingerprint_black_24dp.png");
            imageList1.Images.SetKeyName(1, "form.png");
            imageList1.Images.SetKeyName(2, "search.png");
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 760);
            Controls.Add(tabControl);
            DrawerTabControl = tabControl;
            IsMdiContainer = true;
            Name = "FormPrincipal";
            Text = "Sistema de Avaliações";
            FormClosing += FormPrincipal_FormClosing;
            tabControl.ResumeLayout(false);
            tabAvaliacoes.ResumeLayout(false);
            tabNewAva.ResumeLayout(false);
            tabNewAva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControl;
        private TabPage tabAvaliacoes;
        private TabPage tabNewAva;
        private ImageList imageList1;
        private FlowLayoutPanel flowLayoutAva;
        private ReaLTaiizor.Controls.MaterialLabel lTitleNewAval;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtavaliacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipoMidia;
        private ReaLTaiizor.Controls.MaterialLabel lRating;
        private ReaLTaiizor.Controls.MaterialButton btnPublicar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtNota;
        private ReaLTaiizor.Controls.MaterialLabel lHint1;
        private ListBox lbMidias;
    }
}