using BibliotecaDesafioAuthSoft.Models;
using BibliotecaDesafioAuthSoft.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDesafioAuthSoft.Service
{
    public class EmprestimoService
    {
        private readonly EmprestimoRepository _repository = new EmprestimoRepository();
        private readonly LivroService _livroService = new LivroService();

        public string CheckErrorsAndCreate(int livroId, string leitor, DateTime dataEmprestimo)
        {
            if(_livroService.GetLivroById(livroId) == null)
            {
                return "O livro não foi encontrado.";
            }

            if (string.IsNullOrWhiteSpace(leitor))
            {
                return "O nome do leitor não pode ser vazio.";
            }

            if(dataEmprestimo > DateTime.Now)
            {
                return "A data de empréstimo não pode ser maior que a data atual.";
            }

            if(_livroService.GetExemplaresDisponiveis(livroId) <= 0)
            {
                return "Não há exemplares disponíveis para empréstimo.";
            }

            Emprestimo emprestimo = new Emprestimo
            {
                LivroId = livroId,
                Leitor = leitor,
                DataEmprestimo = dataEmprestimo,
                DataPrevista = dataEmprestimo.AddDays(7)
            };

            _repository.Create(emprestimo);

            return String.Empty;
        }
    }
}
