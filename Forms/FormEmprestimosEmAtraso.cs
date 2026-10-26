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
    public partial class FormEmprestimosEmAtraso : Form
    {
        public FormEmprestimosEmAtraso()
        {
            InitializeComponent();
        }

        private void FormEmprestimosEmAtraso_Load(object sender, EventArgs e)
        {
            AdjustGridViewColumns();
            LoadEmprestimosEmAtraso();
        }

        private void AdjustGridViewColumns()
        {
            if (dataGridViewEmprestimo.Columns.Count > 0)
            {
                dataGridViewEmprestimo.Columns["Id"].FillWeight = 50;
                dataGridViewEmprestimo.Columns["Livro"].FillWeight = 270;
                dataGridViewEmprestimo.Columns["Leitor"].FillWeight = 220;
                dataGridViewEmprestimo.Columns["DiasAtraso"].FillWeight = 120;
                dataGridViewEmprestimo.Columns["MultaPrevista"].FillWeight = 120;
            }
        }

        private void LoadEmprestimosEmAtraso()
        {
            EmprestimoService emprestimoService = new EmprestimoService();
            List<EmprestimosEmAtrasoDTO> emprestimosEmAtraso = emprestimoService.GetEmprestimosEmAtraso();
            dataGridViewEmprestimo.DataSource = emprestimosEmAtraso;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            telaPrincipal.Show();
            this.Close();
        }
    }
}
