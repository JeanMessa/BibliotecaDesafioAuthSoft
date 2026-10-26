using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDesafioAuthSoft.Util
{
    public static class CSVExporter
    {
        public static void ExportDataGridViewToCsv(DataGridView grid, string fileDefaultName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Arquivo CSV (*.csv)|*.csv";
                sfd.FileName = $"{fileDefaultName}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                sfd.Title = "Exportar dados para CSV";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < grid.Columns.Count; i++)
                        {
                            if (grid.Columns[i].Visible)
                            {
                                string header = EscapeCsvField(grid.Columns[i].HeaderText);
                                sb.Append(header);

                                if (i < grid.Columns.Count - 1)
                                {
                                    sb.Append(";");
                                }
                            }
                        }
                        sb.AppendLine();

                        foreach (DataGridViewRow row in grid.Rows)
                        {
                            for (int j = 0; j < grid.Columns.Count; j++)
                            {
                                if (grid.Columns[j].Visible)
                                {
                                    object cellValue = row.Cells[j].Value;
                                    string cellText = cellValue != null ? cellValue.ToString() : "";

                                    sb.Append(EscapeCsvField(cellText));

                                    if (j < grid.Columns.Count - 1)
                                    {
                                        sb.Append(";");
                                    }
                                }
                            }
                            sb.AppendLine();
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));

                        MessageBox.Show("Dados exportados para CSV com sucesso!", "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao exportar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private static string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field)) return "";

            if (field.Contains(";") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r"))
            {
                field = field.Replace("\"", "\"\"");
                return $"\"{field}\"";
            }

            return field;
        }
    }
}
