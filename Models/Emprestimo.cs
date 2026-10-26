using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDesafioAuthSoft.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        public int LivroId { get; set; }

        public string Leitor { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public DateTime DataPrevista { get; set; }

        public DateTime? DataDevolucao { get; set; }

        public int MultaCentavos { get; set; } = 0;
    }
}
