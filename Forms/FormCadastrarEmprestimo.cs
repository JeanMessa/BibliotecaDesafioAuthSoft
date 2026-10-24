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

        public FormCadastrarEmprestimo()
        {
            InitializeComponent();
        }

        private void FormCadastrarEmprestimo_Load(object sender, EventArgs e)
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
            List<Livro> livros = _livroService.GetAllLivros();
            dataGridViewLivros.DataSource = livros;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
