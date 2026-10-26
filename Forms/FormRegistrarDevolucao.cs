using BibliotecaDesafioAuthSoft.Service;
using BibliotecaDesafioAuthSoft.ViewModel;
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
    public partial class FormRegistrarDevolucao : Form
    {
        EmprestimoService _emprestimoService = new EmprestimoService();
        public FormRegistrarDevolucao()
        {
            InitializeComponent();
        }

        private void FormRegistrarDevolução_Load(object sender, EventArgs e)
        {
            AdjustGridViewColumns();
            LoadEmprestimosEmAberto();
            dateDevolucao.Value = DateTime.Now;
            dateDevolucao.MaxDate = DateTime.Now;
        }

        private void AdjustGridViewColumns()
        {
            if (dataGridViewEmprestimo.Columns.Count > 0)
            {
                dataGridViewEmprestimo.Columns["Id"].FillWeight = 40;
                dataGridViewEmprestimo.Columns["Livro"].FillWeight = 250;
                dataGridViewEmprestimo.Columns["Leitor"].FillWeight = 200;
                dataGridViewEmprestimo.Columns["DataEmprestimo"].FillWeight = 110;
                dataGridViewEmprestimo.Columns["DataPrevista"].FillWeight = 110;
            }
        }

        private void LoadEmprestimosEmAberto()
        {
            try
            {
                List<EmprestimoAbertoDTO> emprestimosEmAberto = _emprestimoService.GetEmprestimosEmAberto();
                dataGridViewEmprestimo.DataSource = emprestimosEmAberto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empréstimos em aberto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            telaPrincipal.Show();
            this.Close();
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewEmprestimo.SelectedRows.Count > 0)
                {
                    int emprestimoId = Convert.ToInt32(dataGridViewEmprestimo.SelectedRows[0].Cells["Id"].Value);
                    DateTime dataDevolucao = dateDevolucao.Value;

                    String error = _emprestimoService.CheckErrorsAndRegistrarDevolucao(emprestimoId, dataDevolucao);
                    if (string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Devolução registrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmprestimosEmAberto();
                    }
                    else
                    {
                        MessageBox.Show(error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecione um empréstimo para registrar a devolução.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar devolução: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
