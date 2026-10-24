namespace BibliotecaDesafioAuthSoft.Forms
{
    partial class FormCadastrarEmprestimo
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
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exemplares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelLeitor = new System.Windows.Forms.Label();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelLeitor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.labelData = new System.Windows.Forms.Label();
            this.dateEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.tableLayoutPanelLeitor.SuspendLayout();
            this.tableLayoutPanelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LabelTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewLivros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSalvar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancelar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelLeitor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelData, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LabelTitulo, 2);
            this.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.LabelTitulo.Location = new System.Drawing.Point(3, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.LabelTitulo.Size = new System.Drawing.Size(794, 86);
            this.LabelTitulo.TabIndex = 1;
            this.LabelTitulo.Text = "Cadastar Empréstimo";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewLivros, 2);
            this.dataGridViewLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLivros.Location = new System.Drawing.Point(50, 89);
            this.dataGridViewLivros.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.dataGridViewLivros.MultiSelect = false;
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.RowHeadersVisible = false;
            this.dataGridViewLivros.RowHeadersWidth = 51;
            this.dataGridViewLivros.RowTemplate.Height = 24;
            this.dataGridViewLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLivros.Size = new System.Drawing.Size(700, 166);
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
            // ButtonSalvar
            // 
            this.ButtonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSalvar.AutoSize = true;
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ButtonSalvar.ForeColor = System.Drawing.Color.White;
            this.ButtonSalvar.Location = new System.Drawing.Point(113, 369);
            this.ButtonSalvar.Margin = new System.Windows.Forms.Padding(10, 25, 10, 25);
            this.ButtonSalvar.MaximumSize = new System.Drawing.Size(0, 80);
            this.ButtonSalvar.MinimumSize = new System.Drawing.Size(0, 80);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.ButtonSalvar.Size = new System.Drawing.Size(173, 80);
            this.ButtonSalvar.TabIndex = 3;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(489, 369);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(10, 25, 10, 25);
            this.buttonCancelar.MaximumSize = new System.Drawing.Size(0, 80);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(0, 80);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.buttonCancelar.Size = new System.Drawing.Size(221, 80);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // labelLeitor
            // 
            this.labelLeitor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLeitor.AutoSize = true;
            this.labelLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelLeitor.Location = new System.Drawing.Point(50, 16);
            this.labelLeitor.Margin = new System.Windows.Forms.Padding(50, 0, 25, 0);
            this.labelLeitor.Name = "labelLeitor";
            this.labelLeitor.Size = new System.Drawing.Size(137, 48);
            this.labelLeitor.TabIndex = 2;
            this.labelLeitor.Text = "Leitor:";
            // 
            // txtLeitor
            // 
            this.txtLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtLeitor.Location = new System.Drawing.Point(215, 17);
            this.txtLeitor.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(177, 55);
            this.txtLeitor.TabIndex = 3;
            // 
            // tableLayoutPanelLeitor
            // 
            this.tableLayoutPanelLeitor.ColumnCount = 2;
            this.tableLayoutPanelLeitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLeitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLeitor.Controls.Add(this.labelLeitor, 0, 0);
            this.tableLayoutPanelLeitor.Controls.Add(this.txtLeitor, 1, 0);
            this.tableLayoutPanelLeitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeitor.Location = new System.Drawing.Point(3, 261);
            this.tableLayoutPanelLeitor.Name = "tableLayoutPanelLeitor";
            this.tableLayoutPanelLeitor.RowCount = 1;
            this.tableLayoutPanelLeitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLeitor.Size = new System.Drawing.Size(394, 80);
            this.tableLayoutPanelLeitor.TabIndex = 5;
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.ColumnCount = 2;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelData.Controls.Add(this.labelData, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.dateEmprestimo, 1, 0);
            this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelData.Location = new System.Drawing.Point(403, 261);
            this.tableLayoutPanelData.Margin = new System.Windows.Forms.Padding(3, 3, 53, 3);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 1;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(344, 80);
            this.tableLayoutPanelData.TabIndex = 6;
            // 
            // labelData
            // 
            this.labelData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelData.Location = new System.Drawing.Point(50, 16);
            this.labelData.Margin = new System.Windows.Forms.Padding(50, 0, 25, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(120, 48);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data:";
            // 
            // dateEmprestimo
            // 
            this.dateEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.dateEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEmprestimo.Location = new System.Drawing.Point(198, 12);
            this.dateEmprestimo.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.dateEmprestimo.MaximumSize = new System.Drawing.Size(300, 200);
            this.dateEmprestimo.Name = "dateEmprestimo";
            this.dateEmprestimo.Size = new System.Drawing.Size(200, 55);
            this.dateEmprestimo.TabIndex = 3;
            // 
            // FormCadastrarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCadastrarEmprestimo";
            this.Text = "FormCadastrarEmprestimo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.tableLayoutPanelLeitor.ResumeLayout(false);
            this.tableLayoutPanelLeitor.PerformLayout();
            this.tableLayoutPanelData.ResumeLayout(false);
            this.tableLayoutPanelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exemplares;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelLeitor;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeitor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateEmprestimo;
    }
}