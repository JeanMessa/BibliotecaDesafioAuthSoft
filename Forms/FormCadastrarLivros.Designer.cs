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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.LabelAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.LabelAno = new System.Windows.Forms.Label();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.LabelExemplares = new System.Windows.Forms.Label();
            this.numExemplares = new System.Windows.Forms.NumericUpDown();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExemplares)).BeginInit();
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
            this.LabelTitulo.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.LabelTitulo.Size = new System.Drawing.Size(882, 99);
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
            this.tableLayoutPanel1.Controls.Add(this.txtTitulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelAutor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAutor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelAno, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numAno, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelExemplares, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numExemplares, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSalvar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ButtonCancelar, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 622);
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
            // txtTitulo
            // 
            this.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtTitulo.Location = new System.Drawing.Point(403, 124);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(25, 25, 100, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(385, 55);
            this.txtTitulo.TabIndex = 2;
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
            // txtAutor
            // 
            this.txtAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtAutor.Location = new System.Drawing.Point(403, 223);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(25, 25, 100, 25);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(385, 55);
            this.txtAutor.TabIndex = 4;
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
            // numAno
            // 
            this.numAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.numAno.Location = new System.Drawing.Point(403, 322);
            this.numAno.Margin = new System.Windows.Forms.Padding(25, 25, 100, 25);
            this.numAno.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numAno.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(120, 55);
            this.numAno.TabIndex = 6;
            this.numAno.Value = new decimal(new int[] {
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
            // numExemplares
            // 
            this.numExemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.numExemplares.Location = new System.Drawing.Point(403, 421);
            this.numExemplares.Margin = new System.Windows.Forms.Padding(25, 25, 100, 25);
            this.numExemplares.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numExemplares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExemplares.Name = "numExemplares";
            this.numExemplares.Size = new System.Drawing.Size(120, 55);
            this.numExemplares.TabIndex = 8;
            this.numExemplares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numExemplares.Value = new decimal(new int[] {
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
            this.ButtonSalvar.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.ButtonSalvar.Size = new System.Drawing.Size(173, 77);
            this.ButtonSalvar.TabIndex = 2;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
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
            this.ButtonCancelar.Location = new System.Drawing.Point(467, 520);
            this.ButtonCancelar.Margin = new System.Windows.Forms.Padding(25, 25, 200, 25);
            this.ButtonCancelar.MaximumSize = new System.Drawing.Size(0, 80);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.ButtonCancelar.Size = new System.Drawing.Size(221, 77);
            this.ButtonCancelar.TabIndex = 9;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = false;
            // 
            // FormCadastrarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastrarLivros";
            this.Text = "FormCadastrarLivros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCadastrarLivros_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExemplares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelTítuloLivro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label LabelAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label LabelAno;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.Label LabelExemplares;
        private System.Windows.Forms.NumericUpDown numExemplares;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonCancelar;
    }
}