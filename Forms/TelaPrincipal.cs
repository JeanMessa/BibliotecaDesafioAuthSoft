using BibliotecaDesafioAuthSoft.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDesafioAuthSoft
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            using (FormCadastrarLivros formCadastro = new FormCadastrarLivros())
            {
                formCadastro.ShowDialog();
                this.Hide();
            }
        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            using (FormVisualizarLivros formVisualizarLivros = new FormVisualizarLivros())
            {
                formVisualizarLivros.ShowDialog();
                this.Hide();
            }
        }

        private void buttonCadastrarEmprestimo_Click(object sender, EventArgs e)
        {
            using (FormCadastrarEmprestimo formCadastrarEmprestimo = new FormCadastrarEmprestimo())
            {
                formCadastrarEmprestimo.ShowDialog();
                this.Hide();
            }
        }

        private void buttonCadastrarDevolucao_Click(object sender, EventArgs e)
        {
            using (FormRegistrarDevolucao formCadastrarDevolucao = new FormRegistrarDevolucao())
            {
                formCadastrarDevolucao.ShowDialog();
                this.Hide();
            }
        }

        private void buttonVisualizarAtrasos_Click(object sender, EventArgs e)
        {
            using (FormEmprestimosEmAtraso formEmprestimosEmAtraso = new FormEmprestimosEmAtraso())
            {
                formEmprestimosEmAtraso.ShowDialog();
                this.Hide();
            }
        }

        private void buttonVisualizarMultas_Click(object sender, EventArgs e)
        {
            using (FormVisualizarMultas formVisualizarMultas = new FormVisualizarMultas())
            {
                formVisualizarMultas.ShowDialog();
                this.Hide();
            }
        }
    }
}
