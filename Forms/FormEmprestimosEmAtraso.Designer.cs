namespace BibliotecaDesafioAuthSoft.Forms
{
    partial class FormEmprestimosEmAtraso
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasAtraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MultaPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LabelTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewEmprestimo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonVoltar, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LabelTitulo, 2);
            this.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.LabelTitulo.Location = new System.Drawing.Point(2, 0);
            this.LabelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Padding = new System.Windows.Forms.Padding(8);
            this.LabelTitulo.Size = new System.Drawing.Size(796, 90);
            this.LabelTitulo.TabIndex = 1;
            this.LabelTitulo.Text = "Empréstimos em Atraso";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewEmprestimo
            // 
            this.dataGridViewEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmprestimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Livro,
            this.Leitor,
            this.DiasAtraso,
            this.MultaPrevista});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewEmprestimo, 2);
            this.dataGridViewEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmprestimo.Location = new System.Drawing.Point(38, 92);
            this.dataGridViewEmprestimo.Margin = new System.Windows.Forms.Padding(38, 2, 38, 2);
            this.dataGridViewEmprestimo.MultiSelect = false;
            this.dataGridViewEmprestimo.Name = "dataGridViewEmprestimo";
            this.dataGridViewEmprestimo.RowHeadersVisible = false;
            this.dataGridViewEmprestimo.RowHeadersWidth = 51;
            this.dataGridViewEmprestimo.RowTemplate.Height = 24;
            this.dataGridViewEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmprestimo.Size = new System.Drawing.Size(724, 266);
            this.dataGridViewEmprestimo.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Livro
            // 
            this.Livro.DataPropertyName = "LivroTitulo";
            this.Livro.HeaderText = "Livro";
            this.Livro.Name = "Livro";
            this.Livro.ReadOnly = true;
            // 
            // Leitor
            // 
            this.Leitor.DataPropertyName = "Leitor";
            this.Leitor.HeaderText = "Leitor";
            this.Leitor.Name = "Leitor";
            this.Leitor.ReadOnly = true;
            // 
            // DiasAtraso
            // 
            this.DiasAtraso.DataPropertyName = "DiasAtraso";
            this.DiasAtraso.HeaderText = "Dias de Atraso";
            this.DiasAtraso.Name = "DiasAtraso";
            this.DiasAtraso.ReadOnly = true;
            // 
            // MultaPrevista
            // 
            this.MultaPrevista.DataPropertyName = "MultaPrevista";
            this.MultaPrevista.HeaderText = "Multa Prevista";
            this.MultaPrevista.Name = "MultaPrevista";
            this.MultaPrevista.ReadOnly = true;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVoltar.AutoSize = true;
            this.buttonVoltar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.buttonVoltar.ForeColor = System.Drawing.Color.White;
            this.buttonVoltar.Location = new System.Drawing.Point(533, 380);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.buttonVoltar.MaximumSize = new System.Drawing.Size(0, 65);
            this.buttonVoltar.MinimumSize = new System.Drawing.Size(0, 65);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Padding = new System.Windows.Forms.Padding(8);
            this.buttonVoltar.Size = new System.Drawing.Size(134, 65);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // FormEmprestimosEmAtraso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormEmprestimosEmAtraso";
            this.Text = "Empréstimos Em Atraso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEmprestimosEmAtraso_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimo;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasAtraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MultaPrevista;
    }
}