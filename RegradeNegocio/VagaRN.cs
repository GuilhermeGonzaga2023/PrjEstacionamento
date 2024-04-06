using Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegradeNegocio
{
    public class VagaRN
    {
        public static int IdVaga { get; set; }
        public static int QtdVaga { get; set; }
        public static double VHoraVaga { get; set; }
        public static double ValorVaga { get; set; }
        public static char Situacao { get; set; }
        VagaRN() { }
        public static bool Cadastrar()
        {
            if (QtdVaga == 0) // verificar linhas se o número de vagas for maior que zero e maior que o número
                              // armazenado pegar a ultima linha e fazer uma contagem dela para o número digitado
                              //caso seja um número menor fazer um update e um for para deixar as outras vagas ocupadas
            {
                return false;
            }
            else 
            {
                //for (int i = 0; i = this.QtdVaga; i++)
                //{
                //    bool result = VagaBD.Cadastrar(i);

                //}
            }

            return true;
        }
        public static string Atualizar()
        {
            string result = VagaBD.Atualizar(IdVaga, Situacao);
            if (result == "A")
            {
                return result;
            }
            else
            {
                return result;
            }
            
        }
        public static DataTable Buscar() 
        {
            // return DataTable ds = VagaBD.Buscar(this.QtdVaga, this.Situacao);
            DataTable ds = new DataTable();
            return ds;
        }
    }
}

