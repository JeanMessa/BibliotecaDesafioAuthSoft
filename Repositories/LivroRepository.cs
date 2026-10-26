using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDesafioAuthSoft.Models;
using System.Data.SQLite;

namespace BibliotecaDesafioAuthSoft.Repositories
{
    public class LivroRepository
    {
        private readonly string connectionString = @"Data Source=..\..\database\biblioteca.db;";
        public void Create(Livro livro)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO livro (titulo, autor, ano, exemplares) 
                    VALUES (@titulo, @autor, @ano, @exemplares);
                ";

                using (var command = new SQLiteCommand(query, connection))
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

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, titulo, autor, ano, exemplares FROM livro";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
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

        public List<Livro> GetLivrosByTituloAndAutor(string titulo, string autor)
        {
            List<Livro> livros = new List<Livro>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, titulo, autor, ano, exemplares FROM livro WHERE titulo LIKE @titulo AND autor LIKE @autor;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@titulo", $"%{titulo}%");
                    command.Parameters.AddWithValue("@autor", $"%{autor}%");

                    using (SQLiteDataReader reader = command.ExecuteReader())
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, titulo, autor, ano, exemplares FROM livro WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
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

        public int GetExemplaresDisponiveis(int livroId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT l.exemplares - (
                        SELECT COUNT(*) 
                        FROM emprestimo e 
                        WHERE e.livro_id = l.id AND e.data_devolucao IS NULL
                    ) AS exemplares_disponiveis
                    FROM livro l
                    WHERE l.id = @livroId;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@livroId", livroId);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public List<Livro> GetLivrosDisponiveis()
        {
            List<Livro> livros = new List<Livro>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT l.id, l.titulo, l.autor, l.ano,l.exemplares - (
                        SELECT COUNT(*) 
                        FROM emprestimo e 
                        WHERE e.livro_id = l.id AND e.data_devolucao IS NULL
                    ) AS exemplares_disponiveis
                    FROM livro l
                    WHERE exemplares_disponiveis>0;
                ";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
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

        public void Update(Livro livro)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    UPDATE livro 
                    SET titulo = @titulo, autor = @autor, ano = @ano, exemplares = @exemplares 
                    WHERE id = @id;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@titulo", livro.Titulo);
                    command.Parameters.AddWithValue("@autor", livro.Autor);
                    command.Parameters.AddWithValue("@ano", livro.Ano);
                    command.Parameters.AddWithValue("@exemplares", livro.Exemplares);
                    command.Parameters.AddWithValue("@id", livro.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM livro WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
