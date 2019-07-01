namespace Bible
{
    partial class UCBibleChapters
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
            this.panelChaptersContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelChaptersContainer
            // 
            this.panelChaptersContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelChaptersContainer.Location = new System.Drawing.Point(245, 24);
            this.panelChaptersContainer.Name = "panelChaptersContainer";
            this.panelChaptersContainer.Size = new System.Drawing.Size(400, 474);
            this.panelChaptersContainer.TabIndex = 0;
            // 
            // UCBibleChapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.panelChaptersContainer);
            this.Name = "UCBibleChapters";
            this.Size = new System.Drawing.Size(1080, 515);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChaptersContainer;
    }
}
