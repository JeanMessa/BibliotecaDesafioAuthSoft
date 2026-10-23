using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDesafioAuthSoft.Models;
using Microsoft.Data.Sqlite;

namespace BibliotecaDesafioAuthSoft.Repositories
{
    public class LivroRepository
    {
        private readonly string connectionString = @"Data Source=..\..\database\biblioteca.db;";
        public void Create(Livro livro)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO livro (titulo, autor, ano, exemplares) 
                    VALUES (@titulo, @autor, @ano, @exemplares);
                ";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@titulo", livro.Titulo);
                    command.Parameters.AddWithValue("@autor", livro.Autor);
                    command.Parameters.AddWithValue("@ano", livro.Ano);
                    command.Parameters.AddWithValue("@exemplares", livro.Exemplares);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
