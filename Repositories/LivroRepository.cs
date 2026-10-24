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

        public List<Livro> GetAll()
        {
            List<Livro> livros = new List<Livro>();

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, titulo, autor, ano, exemplares FROM livro";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Livro livro = new Livro
                            {
                                Id = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                Autor = reader.GetString(2),
                                Ano = reader.GetInt32(3),
                                Exemplares = reader.GetInt32(4)
                            };

                            livros.Add(livro);
                        }
                    }
                }
            }

            return livros;
        }

        public Livro GetById(int id)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, titulo, autor, ano, exemplares FROM livro WHERE id = @id";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Livro
                            {
                                Id = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                Autor = reader.GetString(2),
                                Ano = reader.GetInt32(3),
                                Exemplares = reader.GetInt32(4)
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
