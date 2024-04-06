using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegradeNegocio
{
    public class PagamentoRN
    {
        public static int IdPagamento { get; set; } 
        public static char TipodePag { get; set; }
        public static double Valor { get; set; }
        public static char Bandeira { get; set; }
        public static double valorHora { get; set; }
        public PagamentoRN() { }
        public string Cadastrar()
        {
           string result = Banco.Pagamento.Cadastro(TipodePag, Valor, Bandeira);
            if (result == "C")
            {
                return result;
            }
            else
            {
                return result;
            }
        }
        

    }
}
