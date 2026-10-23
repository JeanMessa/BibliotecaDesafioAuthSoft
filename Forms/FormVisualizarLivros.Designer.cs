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
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exemplares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LabelTitulo, 3);
            this.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.LabelTitulo.Location = new System.Drawing.Point(3, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.LabelTitulo.Size = new System.Drawing.Size(794, 78);
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
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewLivros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEditar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonExcluir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.dataGridViewLivros.Location = new System.Drawing.Point(50, 81);
            this.dataGridViewLivros.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.RowHeadersWidth = 51;
            this.dataGridViewLivros.RowTemplate.Height = 24;
            this.dataGridViewLivros.Size = new System.Drawing.Size(700, 267);
            this.dataGridViewLivros.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.MinimumWidth = 6;
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // Exemplares
            // 
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
            this.ButtonEditar.Location = new System.Drawing.Point(51, 376);
            this.ButtonEditar.Margin = new System.Windows.Forms.Padding(10, 25, 10, 25);
            this.ButtonEditar.MaximumSize = new System.Drawing.Size(0, 80);
            this.ButtonEditar.MinimumSize = new System.Drawing.Size(0, 80);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.ButtonEditar.Size = new System.Drawing.Size(164, 80);
            this.ButtonEditar.TabIndex = 3;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExcluir.AutoSize = true;
            this.buttonExcluir.BackColor = System.Drawing.Color.Red;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(308, 376);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(10, 25, 10, 25);
            this.buttonExcluir.MaximumSize = new System.Drawing.Size(0, 80);
            this.buttonExcluir.MinimumSize = new System.Drawing.Size(0, 80);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.buttonExcluir.Size = new System.Drawing.Size(181, 80);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(555, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 25, 10, 25);
            this.button1.MaximumSize = new System.Drawing.Size(0, 80);
            this.button1.MinimumSize = new System.Drawing.Size(0, 80);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.button1.Size = new System.Drawing.Size(221, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormVisualizarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormVisualizarLivros";
            this.Text = "Visualizar Livros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisualizarLivros_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exemplares;
        private System.Windows.Forms.Button ButtonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button button1;
    }
}