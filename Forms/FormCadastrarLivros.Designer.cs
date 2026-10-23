namespace BibliotecaDesafioAuthSoft.Forms
{
    partial class FormCadastrarLivros
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
            this.LabelTítuloLivro = new System.Windows.Forms.Label();
            this.TextBoxTituloLivro = new System.Windows.Forms.TextBox();
            this.LabelAutor = new System.Windows.Forms.Label();
            this.TextBoxAutor = new System.Windows.Forms.TextBox();
            this.LabelAno = new System.Windows.Forms.Label();
            this.NumericUpDownAno = new System.Windows.Forms.NumericUpDown();
            this.LabelExemplares = new System.Windows.Forms.Label();
            this.numericUpDownExemplares = new System.Windows.Forms.NumericUpDown();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LabelTitulo, 2);
            this.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.LabelTitulo.Location = new System.Drawing.Point(3, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Padding = new System.Windows.Forms.Padding(10);
            this.LabelTitulo.Size = new System.Drawing.Size(840, 99);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "Cadastrar Livros";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.LabelTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelTítuloLivro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxTituloLivro, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelAutor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxAutor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelAno, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NumericUpDownAno, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelExemplares, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownExemplares, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSalvar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ButtonCancelar, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 621);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LabelTítuloLivro
            // 
            this.LabelTítuloLivro.AutoSize = true;
            this.LabelTítuloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LabelTítuloLivro.Location = new System.Drawing.Point(100, 124);
            this.LabelTítuloLivro.Margin = new System.Windows.Forms.Padding(100, 25, 25, 25);
            this.LabelTítuloLivro.Name = "LabelTítuloLivro";
            this.LabelTítuloLivro.Size = new System.Drawing.Size(136, 48);
            this.LabelTítuloLivro.TabIndex = 1;
            this.LabelTítuloLivro.Text = "Título:";
            // 
            // TextBoxTituloLivro
            // 
            this.TextBoxTituloLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TextBoxTituloLivro.Location = new System.Drawing.Point(403, 124);
            this.TextBoxTituloLivro.Margin = new System.Windows.Forms.Padding(25, 25, 100, 25);
            this.TextBoxTituloLivro.Name = "TextBoxTituloLivro";
            this.TextBoxTituloLivro.Size = new System.Drawing.Size(343, 55);
            this.TextBoxTituloLivro.TabIndex = 2;
            // 
            // LabelAutor
            // 
            this.LabelAutor.AutoSize = true;
            this.LabelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LabelAutor.Location = new System.Drawing.Point(100, 223);
            this.LabelAutor.Margin = new System.Windows.Forms.Padding(100, 25, 25, 25);
            this.LabelAutor.Name = "LabelAutor";
            this.LabelAutor.Size = new System.Drawing.Size(132, 48);
            this.LabelAutor.TabIndex = 3;
            this.LabelAutor.Text = "Autor:";
            // 
            // TextBoxAutor
            // 
            this.TextBoxAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TextBoxAutor.Location = new System.Drawing.Point(403, 223);
            this.TextBoxAutor.Margin = new System.Windows.Forms.Padding(25, 25, 100, 25);
            this.TextBoxAutor.Name = "TextBoxAutor";
            this.TextBoxAutor.Size = new System.Drawing.Size(343, 55);
            this.TextBoxAutor.TabIndex = 4;
            // 
            // LabelAno
            // 
            this.LabelAno.AutoSize = true;
            this.LabelAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LabelAno.Location = new System.Drawing.Point(100, 322);
            this.LabelAno.Margin = new System.Windows.Forms.Padding(100, 25, 25, 25);
            this.LabelAno.Name = "LabelAno";
            this.LabelAno.Size = new System.Drawing.Size(106, 48);
            this.LabelAno.TabIndex = 5;
            this.LabelAno.Text = "Ano:";
            // 
            // NumericUpDownAno
            // 
            this.NumericUpDownAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.NumericUpDownAno.Location = new System.Drawing.Point(403, 322);
            this.NumericUpDownAno.Margin = new System.Windows.Forms.Padding(25, 25, 100, 25);
            this.NumericUpDownAno.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.NumericUpDownAno.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.NumericUpDownAno.Name = "NumericUpDownAno";
            this.NumericUpDownAno.Size = new System.Drawing.Size(120, 55);
            this.NumericUpDownAno.TabIndex = 6;
            this.NumericUpDownAno.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // LabelExemplares
            // 
            this.LabelExemplares.AutoSize = true;
            this.LabelExemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LabelExemplares.Location = new System.Drawing.Point(100, 421);
            this.LabelExemplares.Margin = new System.Windows.Forms.Padding(100, 25, 25, 25);
            this.LabelExemplares.Name = "LabelExemplares";
            this.LabelExemplares.Size = new System.Drawing.Size(253, 48);
            this.LabelExemplares.TabIndex = 7;
            this.LabelExemplares.Text = "Exemplares:";
            // 
            // numericUpDownExemplares
            // 
            this.numericUpDownExemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.numericUpDownExemplares.Location = new System.Drawing.Point(403, 421);
            this.numericUpDownExemplares.Margin = new System.Windows.Forms.Padding(25, 25, 100, 25);
            this.numericUpDownExemplares.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownExemplares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExemplares.Name = "numericUpDownExemplares";
            this.numericUpDownExemplares.Size = new System.Drawing.Size(120, 55);
            this.numericUpDownExemplares.TabIndex = 8;
            this.numericUpDownExemplares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownExemplares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSalvar.AutoSize = true;
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumBlue;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ButtonSalvar.ForeColor = System.Drawing.Color.White;
            this.ButtonSalvar.Location = new System.Drawing.Point(100, 520);
            this.ButtonSalvar.Margin = new System.Windows.Forms.Padding(100, 25, 100, 25);
            this.ButtonSalvar.MaximumSize = new System.Drawing.Size(0, 80);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Padding = new System.Windows.Forms.Padding(10);
            this.ButtonSalvar.Size = new System.Drawing.Size(171, 76);
            this.ButtonSalvar.TabIndex = 2;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancelar.AutoSize = true;
            this.ButtonCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ButtonCancelar.ForeColor = System.Drawing.Color.White;
            this.ButtonCancelar.Location = new System.Drawing.Point(427, 520);
            this.ButtonCancelar.Margin = new System.Windows.Forms.Padding(25, 25, 200, 25);
            this.ButtonCancelar.MaximumSize = new System.Drawing.Size(0, 80);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Padding = new System.Windows.Forms.Padding(10);
            this.ButtonCancelar.Size = new System.Drawing.Size(219, 76);
            this.ButtonCancelar.TabIndex = 9;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = false;
            // 
            // FormCadastrarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCadastrarLivros";
            this.Text = "FormCadastrarLivros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCadastrarLivros_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExemplares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelTítuloLivro;
        private System.Windows.Forms.TextBox TextBoxTituloLivro;
        private System.Windows.Forms.Label LabelAutor;
        private System.Windows.Forms.TextBox TextBoxAutor;
        private System.Windows.Forms.Label LabelAno;
        private System.Windows.Forms.NumericUpDown NumericUpDownAno;
        private System.Windows.Forms.Label LabelExemplares;
        private System.Windows.Forms.NumericUpDown numericUpDownExemplares;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonCancelar;
    }
}