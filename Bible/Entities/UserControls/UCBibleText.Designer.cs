namespace Bible.Entities.UserControls
{
    partial class UCBibleText
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
            this.panelTextContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTextContainer
            // 
            this.panelTextContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTextContainer.Location = new System.Drawing.Point(236, 35);
            this.panelTextContainer.Name = "panelTextContainer";
            this.panelTextContainer.Size = new System.Drawing.Size(608, 444);
            this.panelTextContainer.TabIndex = 1;
            // 
            // UCBibleText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.panelTextContainer);
            this.Name = "UCBibleText";
            this.Size = new System.Drawing.Size(1080, 515);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTextContainer;
    }
}
