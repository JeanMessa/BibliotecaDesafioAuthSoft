using BibliotecaDesafioAuthSoft.Models;
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
    }
}
