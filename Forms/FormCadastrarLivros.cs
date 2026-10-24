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
    public partial class FormCadastrarLivros : Form
    {
        private int? _idLivro = null;
        private readonly LivroService _service = new LivroService();

        public FormCadastrarLivros()
        {
            InitializeComponent();
        }

        public FormCadastrarLivros(int id)
        {
            InitializeComponent();
            _idLivro = id;
            LoadLivroToEdit(id);
            ConfigLayoutToEdit();
        }

        private void FormCadastrarLivros_Load(object sender, EventArgs e)
        {
            numAno.Maximum = DateTime.Now.Year;
            numAno.Value = DateTime.Now.Year;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Ano = (int)numAno.Value,
                Exemplares = (int)numExemplares.Value
            };

            string error;

            if (_idLivro == null)
            {
                error = _service.CheckErrorsAndCreate(livro);
            }
            else
            {
                livro.Id = _idLivro.Value;
                error = _service.CheckErrorsAndEdit(livro);
            }
            

            if (error != null && error != "")
            {
                MessageBox.Show(error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(_idLivro == null)
            {
                MessageBox.Show("Livro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Livro editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void ClearFields()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            numAno.Value = DateTime.Now.Year;
            numExemplares.Value = 1;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (_idLivro == null)
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Show();
            }

            this.Close();
        }

        private void LoadLivroToEdit(int id)
        {
            Livro livro = _service.GetLivroById(id);

            if (livro != null)
            {
                txtTitulo.Text = livro.Titulo;
                txtAutor.Text = livro.Autor;
                numAno.Value = livro.Ano;
                numExemplares.Value = livro.Exemplares;
            }
        }

        private void ConfigLayoutToEdit()
        {
            this.Text = "Editar Livro";
            LabelTitulo.Text = "Editar Livro";
        }
    }
}
