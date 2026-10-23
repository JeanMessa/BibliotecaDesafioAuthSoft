namespace BibliotecaDesafioAuthSoft
{
    partial class TelaPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCadastrarLivros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastrarLivros
            // 
            this.buttonCadastrarLivros.Location = new System.Drawing.Point(381, 161);
            this.buttonCadastrarLivros.Name = "buttonCadastrarLivros";
            this.buttonCadastrarLivros.Size = new System.Drawing.Size(197, 23);
            this.buttonCadastrarLivros.TabIndex = 0;
            this.buttonCadastrarLivros.Text = "Cadastrar Livros";
            this.buttonCadastrarLivros.UseVisualStyleBackColor = true;
            this.buttonCadastrarLivros.Click += new System.EventHandler(this.buttonCadastrarLivros_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCadastrarLivros);
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrarLivros;
    }
}

