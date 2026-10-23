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
        public FormVisualizarLivros()
        {
            InitializeComponent();
        }

        private void FormVisualizarLivros_Load(object sender, EventArgs e)
        {
            AdjustGridViewColumns();
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
    }
}
