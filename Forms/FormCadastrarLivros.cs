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
        private readonly LivroService _service = new LivroService();

        public FormCadastrarLivros()
        {
            InitializeComponent();
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

            string error = _service.CheckErrosAndSave(livro);

            if (error != null && error != "")
            {
                MessageBox.Show(error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Livro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
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
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            telaPrincipal.Show();
            this.Close();
        }
    }

}
