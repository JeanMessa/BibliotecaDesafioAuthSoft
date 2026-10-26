using BibliotecaDesafioAuthSoft.DTO;
using BibliotecaDesafioAuthSoft.Models;
using BibliotecaDesafioAuthSoft.Repositories;
using BibliotecaDesafioAuthSoft.Util;
using BibliotecaDesafioAuthSoft.ViewModel;
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

            if(IsLivroEmprestadoParaLeitor(livroId, leitor.ToLower()))
            {
                return "O leitor já possui um empréstimo em aberto para este livro.";
            }

            _repository.Create(emprestimo);

            return String.Empty;
        }

        public string CheckErrorsAndRegistrarDevolucao(int emprestimoId, DateTime dataDevolucao)
        {
            Emprestimo emprestimo = _repository.GetEmprestimoById(emprestimoId);
            if(emprestimo == null)
            {
                return "O empréstimo não foi encontrado.";
            }

            if(dataDevolucao < emprestimo.DataEmprestimo)
            {
                return "A data de devolução não pode ser menor que a data de empréstimo.";
            }

            if (dataDevolucao > DateTime.Now)
            {
                return "A data de devolução não pode ser maior que a data atual.";
            }

            emprestimo.DataDevolucao = dataDevolucao;
            emprestimo.MultaCentavos = UtilMulta.CalculateMulta(emprestimo.DataPrevista, dataDevolucao);

            _repository.RegisterDevolucao(emprestimo);
            return String.Empty;
        }

        public List<EmprestimoAbertoDTO> GetEmprestimosEmAberto()
        {
            return _repository.GetEmprestimosEmAberto();
        }

        private bool IsLivroEmprestadoParaLeitor(int livroId, string leitor)
        {
            return _repository.IsLivroEmprestadoParaLeitor(livroId, leitor);
        }

        public List<EmprestimosEmAtrasoDTO> GetEmprestimosEmAtraso()
        {
            List<Emprestimo> emprestimos = _repository.GetEmprestimosEmAtraso();
            List<EmprestimosEmAtrasoDTO> dtos = new List<EmprestimosEmAtrasoDTO>();

            foreach (Emprestimo emprestimo in emprestimos)
            {
                dtos.Add(new EmprestimosEmAtrasoDTO
                {
                    Id = emprestimo.Id,
                    LivroTitulo = _livroService.GetLivroById(emprestimo.LivroId)?.Titulo,
                    Leitor = emprestimo.Leitor,
                    DiasAtraso = (DateTime.Now - emprestimo.DataPrevista).Days,
                    MultaPrevista = ((float)UtilMulta.CalculateMulta(emprestimo.DataPrevista, DateTime.Now)/100).ToString("C")
                });
            }

            return dtos;
        }

        public List<EmprestimosMultaDTO> GetEmprestimosComMulta(DateTime dataDevolucao)
        {
            return _repository.GetEmprestimosComMultaByDataDevolucao(dataDevolucao);
        }
    }
}
