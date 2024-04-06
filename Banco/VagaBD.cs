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
    public class VagaBD
    {
        //criando string de conexão e estanciando para todo o código
        private static SqlConnection conexao = new SqlConnection("Banco.Properties.Settings.EstacionamentoBD");
        private static SqlCommand command = new SqlCommand();
        //------------------------------------------------------
        public static bool Cadastrar(int vaga)
        {
            try
            {
                command.CommandText = "pi_Vaga";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("nVaga", vaga);
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }
        public static string Atualizar(int vaga, char situacao)
        {
            try
            {
                command.CommandText = "pu_Vaga";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("nVaga", vaga);
                command.Parameters.AddWithValue("Situacao", situacao);
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
        public static DataSet Buscar(int vaga, char situacao)
        {
            command.CommandText = "ps_Vaga";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conexao;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("nVaga", vaga);
            command.Parameters.AddWithValue("nVaga", situacao);
            SqlDataAdapter adaptacao = new SqlDataAdapter(command);
            DataSet mostrarDados = new DataSet();
            adaptacao.Fill(mostrarDados);
            return mostrarDados;
        }
        public static string[] Acessar(string apelido, string senha)
        {
            string[] dadosUser = new string[4];
            try
            {
                SqlDataReader leitor;
                command.CommandText = "login_Cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(senha); //pegando a senha e transformandi em vetor de byte
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte); //computeHash é quem vai criptografar o vetorByte
                StringBuilder senhaCriptografado = new StringBuilder(); //
                for (int i = 0; i < vetorHash.Length; i = i + 1)
                {
                    senhaCriptografado.Append(vetorHash[i].ToString("X2"));
                }
                command.Parameters.AddWithValue("apelido", apelido.ToLower());
                command.Parameters.AddWithValue("senha", senhaCriptografado.ToString());
                conexao.Open();
                leitor = command.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    dadosUser[1] = leitor.GetInt32(0).ToString();
                    dadosUser[2] = leitor.GetString(3);
                    conexao.Close();
                    leitor.Close();
                    dadosUser[0] = "OK";
                    return dadosUser;
                }
                else
                {
                    conexao.Close();
                    leitor.Close();
                    dadosUser[0] = "Usuario ou senha não encontrado";
                    return dadosUser;
                }
            }
            catch (SqlException ex)
            {
                dadosUser[0] = "Erro" + ex.Message + ex.HResult;
                return dadosUser;
            }
        }
    }
}
