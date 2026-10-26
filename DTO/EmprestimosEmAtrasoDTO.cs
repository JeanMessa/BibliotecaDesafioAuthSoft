using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDesafioAuthSoft.DTO
{
    public class EmprestimosEmAtrasoDTO
    {
        public int Id { get; set; }
        public string LivroTitulo { get; set; } = string.Empty;
        public string Leitor { get; set; } = string.Empty;
        public int DiasAtraso { get; set; }
        public string MultaPrevista { get; set; } = string.Empty;
    }
}
