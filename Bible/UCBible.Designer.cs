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
            this.btnChapters = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnVerses = new System.Windows.Forms.Button();
            this.panelBibleMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBibleMenu
            // 
            this.panelBibleMenu.Controls.Add(this.btnVerses);
            this.panelBibleMenu.Controls.Add(this.btnChapters);
            this.panelBibleMenu.Controls.Add(this.btnBooks);
            this.panelBibleMenu.Location = new System.Drawing.Point(0, 0);
            this.panelBibleMenu.Name = "panelBibleMenu";
            this.panelBibleMenu.Size = new System.Drawing.Size(1080, 100);
            this.panelBibleMenu.TabIndex = 2;
            // 
            // btnChapters
            // 
            this.btnChapters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChapters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChapters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnChapters.FlatAppearance.BorderSize = 0;
            this.btnChapters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnChapters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.btnChapters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChapters.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChapters.Image = global::Bible.Properties.Resources.triangleUp;
            this.btnChapters.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChapters.Location = new System.Drawing.Point(227, 55);
            this.btnChapters.Name = "btnChapters";
            this.btnChapters.Size = new System.Drawing.Size(138, 42);
            this.btnChapters.TabIndex = 1;
            this.btnChapters.Text = "Capítulos";
            this.btnChapters.UseVisualStyleBackColor = true;
            this.btnChapters.Click += new System.EventHandler(this.btnChapters_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Impact", 20.25F);
            this.btnBooks.Image = global::Bible.Properties.Resources.triangleUp;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBooks.Location = new System.Drawing.Point(59, 56);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(138, 42);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "Livros";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnVerses
            // 
            this.btnVerses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnVerses.FlatAppearance.BorderSize = 0;
            this.btnVerses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnVerses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.btnVerses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerses.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerses.Image = global::Bible.Properties.Resources.triangleUp;
            this.btnVerses.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerses.Location = new System.Drawing.Point(384, 55);
            this.btnVerses.Name = "btnVerses";
            this.btnVerses.Size = new System.Drawing.Size(138, 42);
            this.btnVerses.TabIndex = 2;
            this.btnVerses.Text = "Versículos";
            this.btnVerses.UseVisualStyleBackColor = true;
            this.btnVerses.Click += new System.EventHandler(this.btnVerses_Click);
            // 
            // UCBible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.panelBibleMenu);
            this.Name = "UCBible";
            this.Size = new System.Drawing.Size(1080, 615);
            this.panelBibleMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBibleMenu;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnChapters;
        private System.Windows.Forms.Button btnVerses;
    }
}
