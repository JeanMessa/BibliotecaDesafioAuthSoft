using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDesafioAuthSoft.ViewModel
{
    public class EmprestimoAbertoDTO
    {
        public int Id { get; set; }
        public string LivroTitulo { get; set; } = string.Empty;
        public string Leitor { get; set; } = string.Empty;
        public string DataEmprestimo { get; set; } = string.Empty;
        public string DataPrevista { get; set; } = string.Empty;
    }
}
