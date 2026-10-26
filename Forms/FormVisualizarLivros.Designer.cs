namespace BibliotecaDesafioAuthSoft.Forms
{
    partial class FormVisualizarLivros
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
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutFilter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.labelTituloLivro = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.tableLayoutAutor = new System.Windows.Forms.TableLayoutPanel();
            this.labelAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exemplares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutFilter.SuspendLayout();
            this.tableLayoutTitulo.SuspendLayout();
            this.tableLayoutAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LabelTitulo, 3);
            this.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.LabelTitulo.Location = new System.Drawing.Point(2, 0);
            this.LabelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Padding = new System.Windows.Forms.Padding(8);
            this.LabelTitulo.Size = new System.Drawing.Size(598, 74);
            this.LabelTitulo.TabIndex = 1;
            this.LabelTitulo.Text = "Visualizar Livros";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.LabelTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutFilter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewLivros, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEditar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonExcluir, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancelar, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 372);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutFilter
            // 
            this.tableLayoutFilter.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutFilter, 3);
            this.tableLayoutFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFilter.Controls.Add(this.tableLayoutTitulo, 0, 0);
            this.tableLayoutFilter.Controls.Add(this.tableLayoutAutor, 1, 0);
            this.tableLayoutFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFilter.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutFilter.Name = "tableLayoutFilter";
            this.tableLayoutFilter.RowCount = 1;
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutFilter.Size = new System.Drawing.Size(596, 68);
            this.tableLayoutFilter.TabIndex = 6;
            // 
            // tableLayoutTitulo
            // 
            this.tableLayoutTitulo.ColumnCount = 2;
            this.tableLayoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutTitulo.Controls.Add(this.labelTituloLivro, 0, 0);
            this.tableLayoutTitulo.Controls.Add(this.txtTitulo, 1, 0);
            this.tableLayoutTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTitulo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutTitulo.Name = "tableLayoutTitulo";
            this.tableLayoutTitulo.RowCount = 1;
            this.tableLayoutTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTitulo.Size = new System.Drawing.Size(292, 62);
            this.tableLayoutTitulo.TabIndex = 7;
            // 
            // labelTituloLivro
            // 
            this.labelTituloLivro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTituloLivro.AutoSize = true;
            this.labelTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelTituloLivro.Location = new System.Drawing.Point(38, 11);
            this.labelTituloLivro.Margin = new System.Windows.Forms.Padding(38, 0, 19, 0);
            this.labelTituloLivro.Name = "labelTituloLivro";
            this.labelTituloLivro.Size = new System.Drawing.Size(110, 39);
            this.labelTituloLivro.TabIndex = 3;
            this.labelTituloLivro.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtTitulo.Location = new System.Drawing.Point(169, 12);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(152, 45);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // tableLayoutAutor
            // 
            this.tableLayoutAutor.ColumnCount = 2;
            this.tableLayoutAutor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutAutor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutAutor.Controls.Add(this.labelAutor, 0, 0);
            this.tableLayoutAutor.Controls.Add(this.txtAutor, 1, 0);
            this.tableLayoutAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAutor.Location = new System.Drawing.Point(301, 3);
            this.tableLayoutAutor.Name = "tableLayoutAutor";
            this.tableLayoutAutor.RowCount = 1;
            this.tableLayoutAutor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAutor.Size = new System.Drawing.Size(292, 62);
            this.tableLayoutAutor.TabIndex = 8;
            // 
            // labelAutor
            // 
            this.labelAutor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelAutor.Location = new System.Drawing.Point(38, 11);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(38, 0, 19, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(107, 39);
            this.labelAutor.TabIndex = 4;
            this.labelAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtAutor.Location = new System.Drawing.Point(166, 12);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2, 10, 38, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(152, 45);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            // 
            // dataGridViewLivros
            // 
            this.dataGridViewLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.Ano,
            this.Exemplares});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewLivros, 3);
            this.dataGridViewLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLivros.Location = new System.Drawing.Point(38, 150);
            this.dataGridViewLivros.Margin = new System.Windows.Forms.Padding(38, 2, 38, 2);
            this.dataGridViewLivros.MultiSelect = false;
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.RowHeadersVisible = false;
            this.dataGridViewLivros.RowHeadersWidth = 51;
            this.dataGridViewLivros.RowTemplate.Height = 24;
            this.dataGridViewLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLivros.Size = new System.Drawing.Size(526, 144);
            this.dataGridViewLivros.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.MinimumWidth = 6;
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // Exemplares
            // 
            this.Exemplares.DataPropertyName = "Exemplares";
            this.Exemplares.HeaderText = "Exemplares";
            this.Exemplares.MinimumWidth = 6;
            this.Exemplares.Name = "Exemplares";
            this.Exemplares.ReadOnly = true;
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonEditar.AutoSize = true;
            this.ButtonEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ButtonEditar.ForeColor = System.Drawing.Color.White;
            this.ButtonEditar.Location = new System.Drawing.Point(33, 316);
            this.ButtonEditar.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.ButtonEditar.MaximumSize = new System.Drawing.Size(0, 65);
            this.ButtonEditar.MinimumSize = new System.Drawing.Size(0, 65);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Padding = new System.Windows.Forms.Padding(8);
            this.ButtonEditar.Size = new System.Drawing.Size(134, 65);
            this.ButtonEditar.TabIndex = 3;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = false;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExcluir.AutoSize = true;
            this.buttonExcluir.BackColor = System.Drawing.Color.Red;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(226, 316);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.buttonExcluir.MaximumSize = new System.Drawing.Size(0, 65);
            this.buttonExcluir.MinimumSize = new System.Drawing.Size(0, 65);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Padding = new System.Windows.Forms.Padding(8);
            this.buttonExcluir.Size = new System.Drawing.Size(148, 65);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(410, 316);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.buttonCancelar.MaximumSize = new System.Drawing.Size(0, 65);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(0, 65);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(8);
            this.buttonCancelar.Size = new System.Drawing.Size(182, 65);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormVisualizarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "FormVisualizarLivros";
            this.Text = "Visualizar Livros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisualizarLivros_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutFilter.ResumeLayout(false);
            this.tableLayoutTitulo.ResumeLayout(false);
            this.tableLayoutTitulo.PerformLayout();
            this.tableLayoutAutor.ResumeLayout(false);
            this.tableLayoutAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.Button ButtonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exemplares;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAutor;
        private System.Windows.Forms.Label labelTituloLivro;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
    }
}