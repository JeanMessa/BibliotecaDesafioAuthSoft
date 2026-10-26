using BibliotecaDesafioAuthSoft.Models;
using BibliotecaDesafioAuthSoft.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDesafioAuthSoft.Service
{
    public class LivroService
    {
        private readonly LivroRepository _repository = new LivroRepository();

        public string CheckErrorsAndCreate(Livro livro)
        {
            string error = CheckErrors(livro);

            if (error == null || error == "")
            {
                _repository.Create(livro);
            }

            return error;
        }

        public string CheckErrorsAndEdit(Livro livro)
        {
            string error = CheckErrors(livro);

            int exemplaresEmprestados = GetExemplaresEmprestados(livro.Id);

            if (exemplaresEmprestados > livro.Exemplares)
            {
                return $"Não é possível reduzir o número de exemplares para menos do que o número de exemplares emprestados. O número de exemplares deve ser maior que {exemplaresEmprestados}.";
            }

            if (error == null || error == "")
            {
                _repository.Update(livro);
            }
            return error;
        }

        private String CheckErrors(Livro livro)
        {
            if (string.IsNullOrWhiteSpace(livro.Titulo))
            {
                return "O título do livro é obrigatório.";
            }

            if (string.IsNullOrWhiteSpace(livro.Autor))
            {
                return "O autor do livro é obrigatório.";
            }

            int anoAtual = DateTime.Now.Year;
            if (livro.Ano < 1500 || livro.Ano > anoAtual)
            {
                return $"O ano deve estar entre 1500 e {anoAtual}.";
            }

            if (livro.Exemplares < 1 || livro.Exemplares > 99)
            {
                return "A quantidade de exemplares deve estar entre 1 e 99.";
            }

            return string.Empty;
        }

        public List<Livro> GetAllLivros()
        {
            return _repository.GetAll();
        }

        public Livro GetLivroById(int id)
        {
            return _repository.GetById(id);
        }

        public string CheckErrorsAndDeleteLivro(int id)
        {
            if(GetExemplaresEmprestados(id) > 0)
            {
               return "Não é possível excluir o livro, pois há exemplares emprestados.";
            }
            _repository.Delete(id);

            return String.Empty;
        }

        public int GetExemplaresDisponiveis(int livroId)
        {
            return _repository.GetExemplaresDisponiveis(livroId);
        }

        public int GetExemplaresEmprestados(int livroId)
        {
            Livro livro = _repository.GetById(livroId);
            int exemplaresEmprestados = livro.Exemplares - _repository.GetExemplaresDisponiveis(livroId);
            return exemplaresEmprestados;
        }

        public List<Livro> GetLivrosDisponiveis()
        {
            return _repository.GetLivrosDisponiveis();
        }

        public List<Livro> GetLivrosByTituloAndAutor(string titulo, string autor)
        {
            return _repository.GetLivrosByTituloAndAutor(titulo, autor);
        }
    }
}
