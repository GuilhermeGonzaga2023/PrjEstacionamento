using Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteI;
using System.Data;

namespace RegradeNegocio
{
    public class FluxoRN
    {
        public static int IdFluxo;
        public FluxoRN() { }
        public string Cadastrar()
        {
            ClienteInfo cliente = new ClienteInfo();
            string result = FluxoBD.Cadastrar(cliente.IdCliente, VagaRN.IdVaga, DateTime.Now);
            if (result == "C")
            {
                return result;
            }
            else 
            {
                return result;
            }
        }
        public string Atualizar()
        {
            string result = FluxoBD.Atualizar(IdFluxo, PagamentoRN.IdPagamento, DateTime.Now);
            if (result == "C")
            {
                return result;
            }
            else
            {
                return result;
            }
        }
        public DataSet Buscar() 
        {
            DataSet ds = new DataSet(); 
            return ds;
        }
    }
}
