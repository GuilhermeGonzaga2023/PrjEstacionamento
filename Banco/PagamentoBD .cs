using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Banco
{
    public class Pagamento
    {

        //criando string de conexão e estanciando para todo o código
        private static SqlConnection conexao = new SqlConnection("Banco.Properties.Settings.EstacionamentoBD");
        private static SqlCommand command = new SqlCommand();
        //------------------------------------------------------
        public static string Cadastro(char tpPagamento, double valor, char bandeira)
        {
            try
            {
                command.CommandText = "pi_Pagamento";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;               
                command.Parameters.Clear();
                command.Parameters.AddWithValue("TipodePag", tpPagamento);
                command.Parameters.AddWithValue("Valor", valor);
                command.Parameters.AddWithValue("Bandeira", bandeira);
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
                return "C";
            }
            catch (SqlException ex)
            {
                return "Erro: " + ex.HResult + " " + ex.Message;
            }
            catch (NullReferenceException es)
            {
                return "Problemas com a string de conexão do banco de dados!!! erro: " + es.Message;
            }
        }
        public static string PegarID(string apelido, string senha)
        {
            
            try
            {
                SqlDataReader leitor;
                command.CommandText = "";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                conexao.Open();
                leitor = command.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    conexao.Close();
                    leitor.Close();                    
                    return leitor.GetInt32(0).ToString(); ;
                }
                else
                {
                    conexao.Close();
                    leitor.Close();
                    return "usuario não encontrado";
                }
            }
            catch (SqlException ex)
            {
                return "Erro" + ex.Message + ex.HResult; ;
            }
        }

    }

}
