using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDesafioAuthSoft.Util
{
    public static class UtilMulta
    {
        public static int CalculateMulta(DateTime dataPrevista, DateTime dataDevolucao)
        {
            if (dataDevolucao <= dataPrevista)
            {
                return 0;
            }
            else
            {
                int diasAtraso = (dataDevolucao - dataPrevista).Days;
                int multa = diasAtraso * 250;
                if(multa > 2500)
                {
                    multa = 2500;
                }
                return multa;
            }
        }
    }
}
