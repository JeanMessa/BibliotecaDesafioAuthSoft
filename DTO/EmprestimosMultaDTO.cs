using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDesafioAuthSoft.DTO
{
    public class EmprestimosMultaDTO
    {
        public int Id { get; set; }
        public string LivroTitulo { get; set; } = string.Empty;
        public string Leitor { get; set; } = string.Empty;
        public string DevolucaoPrevista { get; set; } = string.Empty;
        public string DataDevolucao { get; set; } = string.Empty;

        public string Multa { get; set; }
    }
}
