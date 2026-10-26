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
    public partial class FormVisualizarLivros : Form
    {
        LivroService _livroService = new LivroService();
        public FormVisualizarLivros()
        {
            InitializeComponent();
        }

        private void FormVisualizarLivros_Load(object sender, EventArgs e)
        {
            AdjustGridViewColumns();
            LoadLivrosIntoGridView();
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
            try
            {
                List<Livro> livros = _livroService.GetAllLivros();
                dataGridViewLivros.DataSource = livros;
            }catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os livros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            telaPrincipal.Show();
            this.Close();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewLivros.SelectedRows[0];
            if(selectedRow == null)
            {
                MessageBox.Show("Selecione um livro na tabela para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                FormCadastrarLivros formCadastro = new FormCadastrarLivros(id);
                formCadastro.ShowDialog();

                LoadLivrosIntoGridView();
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridViewLivros.SelectedRows[0];
                if (selectedRow == null)
                {
                    MessageBox.Show("Selecione um livro na tabela para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o livro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                        string error = _livroService.CheckErrorsAndDeleteLivro(id);
                        if (!string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show(error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            LoadLivrosIntoGridView();
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao excluir o livro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
