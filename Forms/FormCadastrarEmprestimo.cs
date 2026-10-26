using BibliotecaDesafioAuthSoft.Models;
using BibliotecaDesafioAuthSoft.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDesafioAuthSoft.Forms
{
    public partial class FormCadastrarEmprestimo : Form
    {
        LivroService _livroService = new LivroService();
        EmprestimoService _emprestimoService = new EmprestimoService();

        public FormCadastrarEmprestimo()
        {
            InitializeComponent();
        }

        private void FormCadastrarEmprestimo_Load(object sender, EventArgs e)
        {
            AdjustGridViewColumns();
            LoadLivrosIntoGridView();
            dateEmprestimo.Value = DateTime.Now;
            dateEmprestimo.MaxDate = DateTime.Now;
        }

        private void AdjustGridViewColumns()
        {
            if (dataGridViewLivros.Columns.Count > 0)
            {
                dataGridViewLivros.Columns["Id"].FillWeight = 10;
                dataGridViewLivros.Columns["Titulo"].FillWeight = 40;
                dataGridViewLivros.Columns["Autor"].FillWeight = 30;
                dataGridViewLivros.Columns["Ano"].FillWeight = 10;
                dataGridViewLivros.Columns["Exemplares"].FillWeight = 10;
            }
        }

        private void LoadLivrosIntoGridView()
        {
            List<Livro> livros = _livroService.GetLivrosDisponiveis();
            dataGridViewLivros.DataSource = livros;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            telaPrincipal.Show();
            this.Close();
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewLivros.SelectedRows[0];
            if (selectedRow == null)
            {
                MessageBox.Show("Selecione um livro na tabela para emprestar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idLivro = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string leitor = txtLeitor.Text;
                DateTime dataEmprestimo = dateEmprestimo.Value;
                string error = _emprestimoService.CheckErrorsAndCreate(idLivro, leitor, dataEmprestimo);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Empréstimo cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLeitor.Clear();
                    dateEmprestimo.Value = dateEmprestimo.Value;
                    LoadLivrosIntoGridView();
                }
            }
        }
    }
}
