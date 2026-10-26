namespace BibliotecaDesafioAuthSoft.Forms
{
    partial class FormCadastrarDevolucao
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
            this.labelEmpréstimosAbertos = new System.Windows.Forms.Label();
            this.dataGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.labelData = new System.Windows.Forms.Label();
            this.dateDevolucao = new System.Windows.Forms.DateTimePicker();
            this.ButtonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.Controls.Add(this.labelEmpréstimosAbertos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewEmprestimo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelData, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonRegistrar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancelar, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.LabelTitulo.Size = new System.Drawing.Size(796, 67);
            this.LabelTitulo.TabIndex = 1;
            this.LabelTitulo.Text = "Cadastar Devolução";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmpréstimosAbertos
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.labelEmpréstimosAbertos, 2);
            this.labelEmpréstimosAbertos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmpréstimosAbertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelEmpréstimosAbertos.Location = new System.Drawing.Point(2, 67);
            this.labelEmpréstimosAbertos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmpréstimosAbertos.Name = "labelEmpréstimosAbertos";
            this.labelEmpréstimosAbertos.Padding = new System.Windows.Forms.Padding(8);
            this.labelEmpréstimosAbertos.Size = new System.Drawing.Size(796, 67);
            this.labelEmpréstimosAbertos.TabIndex = 7;
            this.labelEmpréstimosAbertos.Text = "Empréstimos em Aberto";
            this.labelEmpréstimosAbertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DataEmprestimo,
            this.DataPrevista});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewEmprestimo, 2);
            this.dataGridViewEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmprestimo.Location = new System.Drawing.Point(38, 136);
            this.dataGridViewEmprestimo.Margin = new System.Windows.Forms.Padding(38, 2, 38, 2);
            this.dataGridViewEmprestimo.MultiSelect = false;
            this.dataGridViewEmprestimo.Name = "dataGridViewEmprestimo";
            this.dataGridViewEmprestimo.RowHeadersVisible = false;
            this.dataGridViewEmprestimo.RowHeadersWidth = 51;
            this.dataGridViewEmprestimo.RowTemplate.Height = 24;
            this.dataGridViewEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmprestimo.Size = new System.Drawing.Size(724, 131);
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
            this.tableLayoutPanelData.Location = new System.Drawing.Point(2, 271);
            this.tableLayoutPanelData.Margin = new System.Windows.Forms.Padding(2, 2, 40, 2);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 1;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(758, 86);
            this.tableLayoutPanelData.TabIndex = 6;
            // 
            // labelData
            // 
            this.labelData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelData.Location = new System.Drawing.Point(38, 23);
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
            this.dateDevolucao.Location = new System.Drawing.Point(375, 20);
            this.dateDevolucao.Margin = new System.Windows.Forms.Padding(2, 2, 38, 2);
            this.dateDevolucao.MaximumSize = new System.Drawing.Size(226, 200);
            this.dateDevolucao.Name = "dateDevolucao";
            this.dateDevolucao.Size = new System.Drawing.Size(226, 45);
            this.dateDevolucao.TabIndex = 3;
            // 
            // ButtonRegistrar
            // 
            this.ButtonRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonRegistrar.AutoSize = true;
            this.ButtonRegistrar.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ButtonRegistrar.ForeColor = System.Drawing.Color.White;
            this.ButtonRegistrar.Location = new System.Drawing.Point(108, 379);
            this.ButtonRegistrar.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.ButtonRegistrar.MaximumSize = new System.Drawing.Size(0, 65);
            this.ButtonRegistrar.MinimumSize = new System.Drawing.Size(0, 65);
            this.ButtonRegistrar.Name = "ButtonRegistrar";
            this.ButtonRegistrar.Padding = new System.Windows.Forms.Padding(8);
            this.ButtonRegistrar.Size = new System.Drawing.Size(183, 65);
            this.ButtonRegistrar.TabIndex = 3;
            this.ButtonRegistrar.Text = "Registrar";
            this.ButtonRegistrar.UseVisualStyleBackColor = false;
            this.ButtonRegistrar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(509, 379);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.buttonCancelar.MaximumSize = new System.Drawing.Size(0, 65);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(0, 65);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(8);
            this.buttonCancelar.Size = new System.Drawing.Size(182, 65);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
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
            // DataEmprestimo
            // 
            this.DataEmprestimo.DataPropertyName = "DataEmprestimo";
            this.DataEmprestimo.HeaderText = "Data Empréstimo";
            this.DataEmprestimo.Name = "DataEmprestimo";
            this.DataEmprestimo.ReadOnly = true;
            // 
            // DataPrevista
            // 
            this.DataPrevista.DataPropertyName = "DataPrevista";
            this.DataPrevista.HeaderText = "Devolução Prevista";
            this.DataPrevista.Name = "DataPrevista";
            this.DataPrevista.ReadOnly = true;
            // 
            // FormCadastrarDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCadastrarDevolucao";
            this.Text = "FormCadastrarDevolução";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCadastrarDevolução_Load);
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
        private System.Windows.Forms.Label labelEmpréstimosAbertos;
        private System.Windows.Forms.DataGridView dataGridViewEmprestimo;
        private System.Windows.Forms.Button ButtonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPrevista;
    }
}