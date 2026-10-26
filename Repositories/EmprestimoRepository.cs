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

        public Emprestimo GetEmprestimoById(int emprestimoId)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT id, livro_id, leitor, data_emprestimo, data_prevista, data_devolucao, multa_centavos
                    FROM emprestimo
                    WHERE id = @id;
                ";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", emprestimoId);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Emprestimo emprestimo = new Emprestimo
                            {
                                Id = reader.GetInt32(0),
                                LivroId = reader.GetInt32(1),
                                Leitor = reader.GetString(2),
                                DataEmprestimo = reader.GetDateTime(3),
                                DataPrevista = reader.GetDateTime(4),
                                DataDevolucao = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                                MultaCentavos = reader.GetInt32(6)
                            };
                            return emprestimo;
                        }
                    }
                }
            }
            return null;
        }

        public void RegisterDevolucao(Emprestimo emprestimo)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE emprestimo 
                    SET data_devolucao = @dataDevolucao, multa_centavos = @multaCentavos
                    WHERE id = @id;
                ";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dataDevolucao", emprestimo.DataDevolucao?.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@multaCentavos", emprestimo.MultaCentavos);
                    command.Parameters.AddWithValue("@id", emprestimo.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
