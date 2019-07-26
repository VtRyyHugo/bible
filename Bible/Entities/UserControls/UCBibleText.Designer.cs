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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBibleText));
            this.panelTextContainer = new System.Windows.Forms.Panel();
            this.panelTextVersesContainer = new System.Windows.Forms.Panel();
            this.panelPathMapperContainer = new System.Windows.Forms.Panel();
            this.labelPathMapper = new System.Windows.Forms.Label();
            this.panelFooterContainer = new System.Windows.Forms.Panel();
            this.expandScreenIcon = new System.Windows.Forms.PictureBox();
            this.panelTextContainer.SuspendLayout();
            this.panelPathMapperContainer.SuspendLayout();
            this.panelFooterContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expandScreenIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTextContainer
            // 
            this.panelTextContainer.BackColor = System.Drawing.Color.Black;
            this.panelTextContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTextContainer.Controls.Add(this.panelTextVersesContainer);
            this.panelTextContainer.Controls.Add(this.panelPathMapperContainer);
            this.panelTextContainer.Location = new System.Drawing.Point(236, 35);
            this.panelTextContainer.Name = "panelTextContainer";
            this.panelTextContainer.Size = new System.Drawing.Size(608, 444);
            this.panelTextContainer.TabIndex = 1;
            // 
            // panelTextVersesContainer
            // 
            this.panelTextVersesContainer.Location = new System.Drawing.Point(21, 65);
            this.panelTextVersesContainer.Name = "panelTextVersesContainer";
            this.panelTextVersesContainer.Size = new System.Drawing.Size(583, 375);
            this.panelTextVersesContainer.TabIndex = 1;
            // 
            // panelPathMapperContainer
            // 
            this.panelPathMapperContainer.Controls.Add(this.labelPathMapper);
            this.panelPathMapperContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPathMapperContainer.Location = new System.Drawing.Point(0, 0);
            this.panelPathMapperContainer.Name = "panelPathMapperContainer";
            this.panelPathMapperContainer.Size = new System.Drawing.Size(604, 65);
            this.panelPathMapperContainer.TabIndex = 0;
            // 
            // labelPathMapper
            // 
            this.labelPathMapper.AutoSize = true;
            this.labelPathMapper.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathMapper.ForeColor = System.Drawing.Color.White;
            this.labelPathMapper.Location = new System.Drawing.Point(210, 21);
            this.labelPathMapper.Name = "labelPathMapper";
            this.labelPathMapper.Size = new System.Drawing.Size(207, 29);
            this.labelPathMapper.TabIndex = 0;
            this.labelPathMapper.Text = "Bíblia Sagrada";
            // 
            // panelFooterContainer
            // 
            this.panelFooterContainer.Controls.Add(this.expandScreenIcon);
            this.panelFooterContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterContainer.Location = new System.Drawing.Point(0, 483);
            this.panelFooterContainer.Name = "panelFooterContainer";
            this.panelFooterContainer.Size = new System.Drawing.Size(1080, 32);
            this.panelFooterContainer.TabIndex = 2;
            // 
            // expandScreenIcon
            // 
            this.expandScreenIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandScreenIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandScreenIcon.Image = ((System.Drawing.Image)(resources.GetObject("expandScreenIcon.Image")));
            this.expandScreenIcon.Location = new System.Drawing.Point(1030, 0);
            this.expandScreenIcon.Name = "expandScreenIcon";
            this.expandScreenIcon.Size = new System.Drawing.Size(50, 32);
            this.expandScreenIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.expandScreenIcon.TabIndex = 0;
            this.expandScreenIcon.TabStop = false;
            this.expandScreenIcon.Click += new System.EventHandler(this.expandScreenIcon_Click);
            // 
            // UCBibleText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.panelFooterContainer);
            this.Controls.Add(this.panelTextContainer);
            this.Name = "UCBibleText";
            this.Size = new System.Drawing.Size(1080, 515);
            this.panelTextContainer.ResumeLayout(false);
            this.panelPathMapperContainer.ResumeLayout(false);
            this.panelPathMapperContainer.PerformLayout();
            this.panelFooterContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expandScreenIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTextContainer;
        private System.Windows.Forms.Panel panelTextVersesContainer;
        private System.Windows.Forms.Panel panelPathMapperContainer;
        private System.Windows.Forms.Label labelPathMapper;
        private System.Windows.Forms.Panel panelFooterContainer;
        private System.Windows.Forms.PictureBox expandScreenIcon;
    }
}
