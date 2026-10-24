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

        public string CheckErrosAndSave(Livro livro)
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

            _repository.Create(livro);

            return string.Empty;
        }

        public List<Livro> GetAllLivros()
        {
            return _repository.GetAll();
        }
    }
}
