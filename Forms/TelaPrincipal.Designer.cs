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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelLivros = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            this.labelEmprestimo = new System.Windows.Forms.Label();
            this.buttonCadastrarEmprestimo = new System.Windows.Forms.Button();
            this.buttonCadastrarDevolucao = new System.Windows.Forms.Button();
            this.buttonVisualizarAtrasos = new System.Windows.Forms.Button();
            this.buttonVisualizarMultas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LabelLivros, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCadastrar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonVisualizar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEmprestimo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCadastrarEmprestimo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCadastrarDevolucao, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonVisualizarAtrasos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonVisualizarMultas, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 800);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 673);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LabelLivros
            // 
            this.LabelLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLivros.AutoSize = true;
            this.LabelLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.LabelLivros.Location = new System.Drawing.Point(169, 43);
            this.LabelLivros.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LabelLivros.Name = "LabelLivros";
            this.LabelLivros.Size = new System.Drawing.Size(165, 58);
            this.LabelLivros.TabIndex = 1;
            this.LabelLivros.Text = "Livros";
            this.LabelLivros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCadastrar.AutoSize = true;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCadastrar.Location = new System.Drawing.Point(185, 176);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(20);
            this.buttonCadastrar.MaximumSize = new System.Drawing.Size(0, 800);
            this.buttonCadastrar.MinimumSize = new System.Drawing.Size(0, 50);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(133, 50);
            this.buttonCadastrar.TabIndex = 2;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonVisualizar
            // 
            this.buttonVisualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVisualizar.AutoSize = true;
            this.buttonVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonVisualizar.Location = new System.Drawing.Point(184, 310);
            this.buttonVisualizar.Margin = new System.Windows.Forms.Padding(20);
            this.buttonVisualizar.MinimumSize = new System.Drawing.Size(0, 50);
            this.buttonVisualizar.Name = "buttonVisualizar";
            this.buttonVisualizar.Size = new System.Drawing.Size(134, 50);
            this.buttonVisualizar.TabIndex = 3;
            this.buttonVisualizar.Text = "Visualizar";
            this.buttonVisualizar.UseVisualStyleBackColor = true;
            this.buttonVisualizar.Click += new System.EventHandler(this.buttonVisualizar_Click);
            // 
            // labelEmprestimo
            // 
            this.labelEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmprestimo.AutoSize = true;
            this.labelEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.labelEmprestimo.Location = new System.Drawing.Point(603, 43);
            this.labelEmprestimo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelEmprestimo.Name = "labelEmprestimo";
            this.labelEmprestimo.Size = new System.Drawing.Size(303, 58);
            this.labelEmprestimo.TabIndex = 4;
            this.labelEmprestimo.Text = "Empréstimo";
            this.labelEmprestimo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCadastrarEmprestimo
            // 
            this.buttonCadastrarEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCadastrarEmprestimo.AutoSize = true;
            this.buttonCadastrarEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCadastrarEmprestimo.Location = new System.Drawing.Point(616, 176);
            this.buttonCadastrarEmprestimo.Margin = new System.Windows.Forms.Padding(20);
            this.buttonCadastrarEmprestimo.MaximumSize = new System.Drawing.Size(0, 800);
            this.buttonCadastrarEmprestimo.MinimumSize = new System.Drawing.Size(0, 50);
            this.buttonCadastrarEmprestimo.Name = "buttonCadastrarEmprestimo";
            this.buttonCadastrarEmprestimo.Size = new System.Drawing.Size(277, 50);
            this.buttonCadastrarEmprestimo.TabIndex = 5;
            this.buttonCadastrarEmprestimo.Text = "Cadastrar Empréstimo";
            this.buttonCadastrarEmprestimo.UseVisualStyleBackColor = true;
            this.buttonCadastrarEmprestimo.Click += new System.EventHandler(this.buttonCadastrarEmprestimo_Click);
            // 
            // buttonCadastrarDevolucao
            // 
            this.buttonCadastrarDevolucao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCadastrarDevolucao.AutoSize = true;
            this.buttonCadastrarDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCadastrarDevolucao.Location = new System.Drawing.Point(624, 310);
            this.buttonCadastrarDevolucao.Margin = new System.Windows.Forms.Padding(20);
            this.buttonCadastrarDevolucao.MaximumSize = new System.Drawing.Size(0, 800);
            this.buttonCadastrarDevolucao.MinimumSize = new System.Drawing.Size(0, 50);
            this.buttonCadastrarDevolucao.Name = "buttonCadastrarDevolucao";
            this.buttonCadastrarDevolucao.Size = new System.Drawing.Size(260, 50);
            this.buttonCadastrarDevolucao.TabIndex = 6;
            this.buttonCadastrarDevolucao.Text = "Cadastrar Devolução";
            this.buttonCadastrarDevolucao.UseVisualStyleBackColor = true;
            // 
            // buttonVisualizarAtrasos
            // 
            this.buttonVisualizarAtrasos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVisualizarAtrasos.AutoSize = true;
            this.buttonVisualizarAtrasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonVisualizarAtrasos.Location = new System.Drawing.Point(641, 444);
            this.buttonVisualizarAtrasos.Margin = new System.Windows.Forms.Padding(20);
            this.buttonVisualizarAtrasos.MaximumSize = new System.Drawing.Size(0, 800);
            this.buttonVisualizarAtrasos.MinimumSize = new System.Drawing.Size(0, 50);
            this.buttonVisualizarAtrasos.Name = "buttonVisualizarAtrasos";
            this.buttonVisualizarAtrasos.Size = new System.Drawing.Size(227, 50);
            this.buttonVisualizarAtrasos.TabIndex = 7;
            this.buttonVisualizarAtrasos.Text = "Visualizar Atrasos";
            this.buttonVisualizarAtrasos.UseVisualStyleBackColor = true;
            // 
            // buttonVisualizarMultas
            // 
            this.buttonVisualizarMultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVisualizarMultas.AutoSize = true;
            this.buttonVisualizarMultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonVisualizarMultas.Location = new System.Drawing.Point(646, 579);
            this.buttonVisualizarMultas.Margin = new System.Windows.Forms.Padding(20);
            this.buttonVisualizarMultas.MaximumSize = new System.Drawing.Size(0, 800);
            this.buttonVisualizarMultas.MinimumSize = new System.Drawing.Size(0, 50);
            this.buttonVisualizarMultas.Name = "buttonVisualizarMultas";
            this.buttonVisualizarMultas.Size = new System.Drawing.Size(216, 50);
            this.buttonVisualizarMultas.TabIndex = 8;
            this.buttonVisualizarMultas.Text = "Visualizar Multas";
            this.buttonVisualizarMultas.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelLivros;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonVisualizar;
        private System.Windows.Forms.Label labelEmprestimo;
        private System.Windows.Forms.Button buttonCadastrarEmprestimo;
        private System.Windows.Forms.Button buttonCadastrarDevolucao;
        private System.Windows.Forms.Button buttonVisualizarAtrasos;
        private System.Windows.Forms.Button buttonVisualizarMultas;
    }
}

