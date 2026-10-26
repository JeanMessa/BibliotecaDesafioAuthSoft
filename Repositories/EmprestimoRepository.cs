using BibliotecaDesafioAuthSoft.Models;
using BibliotecaDesafioAuthSoft.ViewModel;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDesafioAuthSoft.Repositories
{
    public class EmprestimoRepository
    {
        private readonly string connectionString = @"Data Source=..\..\database\biblioteca.db;";

        public void Create(Emprestimo emprestimo)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    INSERT INTO emprestimo (livro_id, leitor, data_emprestimo, data_prevista,multa_centavos) 
                    VALUES (@livroId, @leitor, @dataEmprestimo, @dataPrevista, @multaCentavos);
                ";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@livroId", emprestimo.LivroId);
                    command.Parameters.AddWithValue("@leitor", emprestimo.Leitor);
                    command.Parameters.AddWithValue("@dataEmprestimo", emprestimo.DataEmprestimo.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@dataPrevista", emprestimo.DataPrevista.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@multaCentavos", emprestimo.MultaCentavos);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<EmprestimoAbertoDTO> GetEmprestimosEmAberto()
        {
            List<EmprestimoAbertoDTO> emprestimos = new List<EmprestimoAbertoDTO>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT e.id, l.titulo, e.leitor, e.data_emprestimo, e.data_prevista, e.data_devolucao, e.multa_centavos
                    FROM emprestimo e, livro l
                    WHERE e.livro_id = l.id AND e.data_devolucao IS NULL;
                ";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmprestimoAbertoDTO emprestimo = new EmprestimoAbertoDTO
                            {
                                Id = reader.GetInt32(0),
                                LivroTitulo = reader.GetString(1),
                                Leitor = reader.GetString(2),
                                DataEmprestimo = reader.GetDateTime(3).ToString("dd/MM/yyyy"),
                                DataPrevista = reader.GetDateTime(4).ToString("dd/MM/yyyy"),
                            };
                            emprestimos.Add(emprestimo);
                        }
                    }
                }
            }
            return emprestimos;
        }
    }
}
