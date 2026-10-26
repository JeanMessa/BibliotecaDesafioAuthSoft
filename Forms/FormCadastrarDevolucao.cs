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
    public partial class FormCadastrarDevolucao : Form
    {
        public FormCadastrarDevolucao()
        {
            InitializeComponent();
        }

        private void FormCadastrarDevolução_Load(object sender, EventArgs e)
        {
            AdjustGridViewColumns();
        }

        private void AdjustGridViewColumns()
        {
            if (dataGridViewEmprestimo.Columns.Count > 0)
            {
                dataGridViewEmprestimo.Columns["Id"].FillWeight = 40;
                dataGridViewEmprestimo.Columns["Livro"].FillWeight = 250;
                dataGridViewEmprestimo.Columns["Leitor"].FillWeight = 200;
                dataGridViewEmprestimo.Columns["DataEmprestimo"].FillWeight = 110;
                dataGridViewEmprestimo.Columns["DataDevolucao"].FillWeight = 110;
                dataGridViewEmprestimo.Columns["Multa"].FillWeight = 80;
            }
        }
    }
}
