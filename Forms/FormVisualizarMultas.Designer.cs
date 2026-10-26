namespace BibliotecaDesafioAuthSoft.Forms
{
    partial class FormVisualizarMultas
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
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.labelData = new System.Windows.Forms.Label();
            this.dateDevolucao = new System.Windows.Forms.DateTimePicker();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelMultaTotal = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevolucaoPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).BeginInit();
            this.tableLayoutPanelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LabelTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewEmprestimo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMultaTotal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonVoltar, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
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
            this.LabelTitulo.Size = new System.Drawing.Size(796, 79);
            this.LabelTitulo.TabIndex = 1;
            this.LabelTitulo.Text = "Visualizar Multas";
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
            this.DevolucaoPrevista,
            this.DataDevolucao,
            this.Multa});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewEmprestimo, 2);
            this.dataGridViewEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmprestimo.Location = new System.Drawing.Point(38, 186);
            this.dataGridViewEmprestimo.Margin = new System.Windows.Forms.Padding(38, 2, 38, 2);
            this.dataGridViewEmprestimo.MultiSelect = false;
            this.dataGridViewEmprestimo.Name = "dataGridViewEmprestimo";
            this.dataGridViewEmprestimo.RowHeadersVisible = false;
            this.dataGridViewEmprestimo.RowHeadersWidth = 51;
            this.dataGridViewEmprestimo.RowTemplate.Height = 24;
            this.dataGridViewEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmprestimo.Size = new System.Drawing.Size(724, 154);
            this.dataGridViewEmprestimo.TabIndex = 2;
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanelData, 2);
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.Controls.Add(this.labelData, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.dateDevolucao, 1, 0);
            this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelData.Location = new System.Drawing.Point(2, 81);
            this.tableLayoutPanelData.Margin = new System.Windows.Forms.Padding(2, 2, 40, 2);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 1;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(758, 101);
            this.tableLayoutPanelData.TabIndex = 6;
            // 
            // labelData
            // 
            this.labelData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelData.Location = new System.Drawing.Point(38, 31);
            this.labelData.Margin = new System.Windows.Forms.Padding(38, 0, 19, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(316, 39);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data da Devolução:";
            // 
            // dateDevolucao
            // 
            this.dateDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.dateDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDevolucao.Location = new System.Drawing.Point(375, 28);
            this.dateDevolucao.Margin = new System.Windows.Forms.Padding(2, 2, 38, 2);
            this.dateDevolucao.MaximumSize = new System.Drawing.Size(226, 200);
            this.dateDevolucao.Name = "dateDevolucao";
            this.dateDevolucao.Size = new System.Drawing.Size(226, 45);
            this.dateDevolucao.TabIndex = 3;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVoltar.AutoSize = true;
            this.buttonVoltar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.buttonVoltar.ForeColor = System.Drawing.Color.White;
            this.buttonVoltar.Location = new System.Drawing.Point(509, 363);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.buttonVoltar.MaximumSize = new System.Drawing.Size(0, 65);
            this.buttonVoltar.MinimumSize = new System.Drawing.Size(0, 65);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Padding = new System.Windows.Forms.Padding(8);
            this.buttonVoltar.Size = new System.Drawing.Size(182, 65);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            // 
            // labelMultaTotal
            // 
            this.labelMultaTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMultaTotal.AutoSize = true;
            this.labelMultaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelMultaTotal.Location = new System.Drawing.Point(38, 376);
            this.labelMultaTotal.Margin = new System.Windows.Forms.Padding(38, 0, 19, 0);
            this.labelMultaTotal.Name = "labelMultaTotal";
            this.labelMultaTotal.Size = new System.Drawing.Size(194, 39);
            this.labelMultaTotal.TabIndex = 4;
            this.labelMultaTotal.Text = "Multa Total:";
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
            // DevolucaoPrevista
            // 
            this.DevolucaoPrevista.DataPropertyName = "DataPrevista";
            this.DevolucaoPrevista.HeaderText = "Devolução Prevista";
            this.DevolucaoPrevista.Name = "DevolucaoPrevista";
            this.DevolucaoPrevista.ReadOnly = true;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.DataPropertyName = "DataDevolucao";
            this.DataDevolucao.HeaderText = "Data Devolução";
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.ReadOnly = true;
            // 
            // Multa
            // 
            this.Multa.DataPropertyName = "Multa";
            this.Multa.HeaderText = "Multa";
            this.Multa.Name = "Multa";
            this.Multa.ReadOnly = true;
            // 
            // FormVisualizarMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormVisualizarMultas";
            this.Text = "Visualizar Multas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisualizarMultas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmprestimo)).EndInit();
            this.tableLayoutPanelData.ResumeLayout(false);
            this.tableLayoutPanelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateDevolucao;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelMultaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevolucaoPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multa;
    }
}