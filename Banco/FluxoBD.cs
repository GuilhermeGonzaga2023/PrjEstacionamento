using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class FluxoBD
    {
        //criando string de conexão e estanciando para todo o código
        private static SqlConnection conexao = new SqlConnection("Banco.Properties.Settings.EstacionamentoBD");
        private static SqlCommand command = new SqlCommand();
        //------------------------------------------------------
        public static string Cadastrar(int idCliente, int nVaga, DateTime entrada)
        {
            try
            {
                command.CommandText = "pi_Fluxo";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("IdCliente", idCliente);
                command.Parameters.AddWithValue("nVaga", nVaga);
                command.Parameters.AddWithValue("Entrada", entrada);
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
        public static string Atualizar(int idFluxo, int idPagamento, DateTime saida)
        {
            try
            {
                command.CommandText = "pu_Fluxo";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("IdFluxo", idFluxo);
                command.Parameters.AddWithValue("IdPagamento", idPagamento);
                command.Parameters.AddWithValue("Saida", saida);
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
                return "A";
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
        //fazer dois método para inserir a entrada do veiculo e depois atualizar quando o veículo sair.

    }
}
