namespace Bible
{
    partial class UCBible
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
            this.panelBibleMenu = new System.Windows.Forms.Panel();
            this.panelBibleContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBibleMenu
            // 
            this.panelBibleMenu.Location = new System.Drawing.Point(0, 0);
            this.panelBibleMenu.Name = "panelBibleMenu";
            this.panelBibleMenu.Size = new System.Drawing.Size(1080, 100);
            this.panelBibleMenu.TabIndex = 2;
            // 
            // panelBibleContainer
            // 
            this.panelBibleContainer.Location = new System.Drawing.Point(0, 100);
            this.panelBibleContainer.Name = "panelBibleContainer";
            this.panelBibleContainer.Size = new System.Drawing.Size(1080, 515);
            this.panelBibleContainer.TabIndex = 3;
            // 
            // UCBible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.panelBibleContainer);
            this.Controls.Add(this.panelBibleMenu);
            this.Name = "UCBible";
            this.Size = new System.Drawing.Size(1080, 615);
            this.Load += new System.EventHandler(this.UCBible_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBibleMenu;
        private System.Windows.Forms.Panel panelBibleContainer;
    }
}
