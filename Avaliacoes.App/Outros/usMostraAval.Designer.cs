namespace Avaliacoes.App.Cadastros
{
    partial class usMostraAval
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lTitulo = new ReaLTaiizor.Controls.MaterialLabel();
            lNota = new ReaLTaiizor.Controls.MaterialLabel();
            lDataDaAva = new ReaLTaiizor.Controls.MaterialLabel();
            ltextAva = new ReaLTaiizor.Controls.MaterialLabel();
            lRating = new ReaLTaiizor.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // lTitulo
            // 
            lTitulo.BackColor = Color.DarkGray;
            lTitulo.Depth = 0;
            lTitulo.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lTitulo.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            lTitulo.Location = new Point(12, 15);
            lTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(541, 51);
            lTitulo.TabIndex = 0;
            lTitulo.Text = "*titulo*";
            // 
            // lNota
            // 
            lNota.AutoSize = true;
            lNota.Depth = 0;
            lNota.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lNota.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H3;
            lNota.Location = new Point(494, 195);
            lNota.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lNota.Name = "lNota";
            lNota.Size = new Size(28, 58);
            lNota.TabIndex = 1;
            lNota.Text = "1";
            // 
            // lDataDaAva
            // 
            lDataDaAva.AutoSize = true;
            lDataDaAva.Depth = 0;
            lDataDaAva.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lDataDaAva.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            lDataDaAva.Location = new Point(12, 212);
            lDataDaAva.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lDataDaAva.Name = "lDataDaAva";
            lDataDaAva.Size = new Size(156, 41);
            lDataDaAva.TabIndex = 2;
            lDataDaAva.Text = "*dataAva*";
            // 
            // ltextAva
            // 
            ltextAva.Depth = 0;
            ltextAva.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ltextAva.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
            ltextAva.Location = new Point(12, 66);
            ltextAva.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ltextAva.Name = "ltextAva";
            ltextAva.Size = new Size(541, 135);
            ltextAva.TabIndex = 3;
            ltextAva.Text = "*A propria avaliacao*";
            // 
            // lRating
            // 
            lRating.AutoSize = true;
            lRating.Depth = 0;
            lRating.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lRating.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H3;
            lRating.Location = new Point(372, 195);
            lRating.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lRating.Name = "lRating";
            lRating.Size = new Size(116, 58);
            lRating.TabIndex = 4;
            lRating.Text = "Nota:";
            // 
            // usMostraAval
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lRating);
            Controls.Add(ltextAva);
            Controls.Add(lDataDaAva);
            Controls.Add(lNota);
            Controls.Add(lTitulo);
            Margin = new Padding(5);
            Name = "usMostraAval";
            Size = new Size(556, 258);
            MouseDoubleClick += usMostraAval_MouseDoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ReaLTaiizor.Controls.MaterialLabel lTitulo;
        public ReaLTaiizor.Controls.MaterialLabel lNota;
        public ReaLTaiizor.Controls.MaterialLabel lDataDaAva;
        public ReaLTaiizor.Controls.MaterialLabel ltextAva;
        public ReaLTaiizor.Controls.MaterialLabel lRating;
    }
}
