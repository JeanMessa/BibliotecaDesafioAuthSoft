using BibliotecaDesafioAuthSoft.DTO;
using BibliotecaDesafioAuthSoft.Models;
using BibliotecaDesafioAuthSoft.ViewModel;
using System.Data.SQLite;
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
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    INSERT INTO emprestimo (livro_id, leitor, data_emprestimo, data_prevista,multa_centavos) 
                    VALUES (@livroId, @leitor, @dataEmprestimo, @dataPrevista, @multaCentavos);
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT e.id, l.titulo, e.leitor, e.data_emprestimo, e.data_prevista, e.data_devolucao, e.multa_centavos
                    FROM emprestimo e, livro l
                    WHERE e.livro_id = l.id AND e.data_devolucao IS NULL;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
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

        public List<Emprestimo> GetEmprestimosEmAtraso()
        {
            List<Emprestimo> emprestimos = new List<Emprestimo>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT e.id, e.livro_id, e.leitor, e.data_prevista
                    FROM emprestimo e
                    WHERE e.data_devolucao IS NULL AND e.data_prevista < Date('now');
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Emprestimo emprestimo = new Emprestimo
                            {
                                Id = reader.GetInt32(0),
                                LivroId = reader.GetInt32(1),
                                Leitor = reader.GetString(2),
                                DataPrevista = reader.GetDateTime(3)
                            };

                            emprestimos.Add(emprestimo);
                        }
                    }
                }
            }
            return emprestimos;  
        }

        public List<EmprestimosMultaDTO> GetEmprestimosComMultaByDataDevolucao(DateTime dataDevolucao)
        {
            List<EmprestimosMultaDTO> emprestimos = new List<EmprestimosMultaDTO>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT e.id, l.titulo, e.leitor, e.data_prevista, e.data_devolucao, e.multa_centavos
                    FROM emprestimo e, livro l
                    WHERE e.livro_id = l.id AND e.data_prevista < Date('now') AND e.data_devolucao = @dataDevolucao;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dataDevolucao", dataDevolucao.ToString("yyyy-MM-dd"));
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmprestimosMultaDTO emprestimo = new EmprestimosMultaDTO
                            {
                                Id = reader.GetInt32(0),
                                LivroTitulo = reader.GetString(1),
                                Leitor = reader.GetString(2),
                                DevolucaoPrevista = reader.GetDateTime(3).ToString("dd/MM/yyyy"),
                                DataDevolucao = reader.GetDateTime(4).ToString("dd/MM/yyyy"),
                                Multa = (reader.GetInt32(5) / 100.0).ToString("C")
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT id, livro_id, leitor, data_emprestimo, data_prevista, data_devolucao, multa_centavos
                    FROM emprestimo
                    WHERE id = @id;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", emprestimoId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
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
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE emprestimo 
                    SET data_devolucao = @dataDevolucao, multa_centavos = @multaCentavos
                    WHERE id = @id;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dataDevolucao", emprestimo.DataDevolucao?.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@multaCentavos", emprestimo.MultaCentavos);
                    command.Parameters.AddWithValue("@id", emprestimo.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsLivroEmprestadoParaLeitor(int livroId, string leitor)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT COUNT(*) 
                    FROM emprestimo 
                    WHERE livro_id = @livroId AND leitor = @leitor AND data_devolucao IS NULL;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@livroId", livroId);
                    command.Parameters.AddWithValue("@leitor", leitor);
                    long count = (long)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public int GetTotalMultaByDataDevolucao(DateTime dataDevolucao)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT SUM(multa_centavos) 
                    FROM emprestimo 
                    WHERE data_prevista < Date('now') AND data_devolucao = @dataDevolucao;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dataDevolucao", dataDevolucao.ToString("yyyy-MM-dd"));
                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }
    }
}
