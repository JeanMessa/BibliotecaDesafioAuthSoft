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
    public partial class FormVisualizarMultas : Form
    {
        public FormVisualizarMultas()
        {
            InitializeComponent();
        }

        private void FormVisualizarMultas_Load(object sender, EventArgs e)
        {
            AdjustGridViewColumns();
        }

        private void AdjustGridViewColumns()
        {
            if (dataGridViewEmprestimo.Columns.Count > 0)
            {
                dataGridViewEmprestimo.Columns["Id"].FillWeight = 40;
                dataGridViewEmprestimo.Columns["Livro"].FillWeight = 240;
                dataGridViewEmprestimo.Columns["Leitor"].FillWeight = 190;
                dataGridViewEmprestimo.Columns["DevolucaoPrevista"].FillWeight = 110;
                dataGridViewEmprestimo.Columns["DataDevolucao"].FillWeight = 110;
                dataGridViewEmprestimo.Columns["Multa"].FillWeight = 80;
            }
        }
    }
}
