using BibliotecaDesafioAuthSoft.DTO;
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
    public partial class FormVisualizarMultas : Form
    {
        EmprestimoService _emprestimoService = new EmprestimoService();
        public FormVisualizarMultas()
        {
            InitializeComponent();
        }

        private void FormVisualizarMultas_Load(object sender, EventArgs e)
        {
            AdjustGridViewColumns();
            dateDevolucao.Value = DateTime.Now;
            dateDevolucao.MaxDate = DateTime.Now;
            LoadEmprestimosIntoGridView();
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

        private void LoadEmprestimosIntoGridView()
        {
            try {
                DateTime dateTimeDevolucao = dateDevolucao.Value.Date;
                List<EmprestimosMultaDTO> emprestimos = _emprestimoService.GetEmprestimosComMulta(dateTimeDevolucao);
                dataGridViewEmprestimo.DataSource = emprestimos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empréstimos com multa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateMultaTotal();
        }

        private void dateDevolucao_ValueChanged(object sender, EventArgs e)
        {
            LoadEmprestimosIntoGridView();
        }

        private void UpdateMultaTotal()
        {
            try
            {
                labelMultaTotal.Text = $"Multa Total: {_emprestimoService.GetMultaTotalByDataDevolucao(dateDevolucao.Value.Date)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular multa total: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            telaPrincipal.Show();
            this.Close();
        }
    }
}
