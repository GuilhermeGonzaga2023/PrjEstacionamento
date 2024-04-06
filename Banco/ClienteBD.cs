using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ClienteI;

namespace Banco
{
    public class ClienteBD
    {
        public ClienteBD() { }
        //criando string de conexão e estanciando para todo o código
        private static SqlConnection conexao = new SqlConnection("Banco.Properties.Settings.EstacionamentoBD");
        private static SqlCommand command = new SqlCommand();
        //------------------------------------------------------
        public static string Cadastro(ClienteInfo cliente)
        {
            try
            {
                command.CommandText = "pi_Cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(cliente.Senha); //pegando a senha e transformandi em vetor de byte
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte); //computeHash é quem vai criptografar o vetorByte
                StringBuilder senhaCriptografado = new StringBuilder(); //
                for (int i = 0; i < vetorHash.Length; i = i + 1)
                {
                    senhaCriptografado.Append(vetorHash[i].ToString("X2")); //para usar o append tem que usar o StringBuilder
                    //cada vez que passar por aqui, vai aumentando
                }
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Apelido", cliente.Apelido.ToLower());
                command.Parameters.AddWithValue("Senha", senhaCriptografado.ToString());
                command.Parameters.AddWithValue("Nome", cliente.Nome.ToUpper());
                command.Parameters.AddWithValue("Placa", cliente.Placa.ToUpper());
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
            catch(FormatException eb)
            {
                return "Dados em branco!!! erro: " + eb.Message;
            }   
        }
        public static string Atualizar(ClienteInfo cliente)
        {
            try
            {
                command.CommandText = "pu_Cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("IdCliente", cliente.IdCliente);
                command.Parameters.AddWithValue("Nome", cliente.Nome.ToUpper());
                command.Parameters.AddWithValue("Placa", cliente.Placa.ToUpper());
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
        public static DataSet Buscar(ClienteInfo cliente)
        {
            command.CommandText = "ps_Cliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conexao;
            command.Parameters.AddWithValue("Nome", cliente.Nome.ToUpper());
            command.Parameters.AddWithValue("Status", cliente.Status);
            SqlDataAdapter adaptacao = new SqlDataAdapter(command);
            DataSet mostrarDados = new DataSet();
            adaptacao.Fill(mostrarDados);
            return mostrarDados;
        }
        public static string AtualizarSenha(ClienteInfo cliente)
        {
            try
            {
                command.CommandText = "pu_SenhaCliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(cliente.Senha); //pegando a senha e transformandi em vetor de byte
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte); //computeHash é quem vai criptografar o vetorByte
                StringBuilder senhaCriptografado = new StringBuilder(); //
                for (int i = 0; i < vetorHash.Length; i = i + 1)
                {
                    senhaCriptografado.Append(vetorHash[i].ToString("X2")); //para usar o append tem que usar o StringBuilder
                    //cada vez que passar por aqui, vai aumentando
                }
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Apelido", cliente.Apelido.ToLower());
                command.Parameters.AddWithValue("Senha", senhaCriptografado.ToString());
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
        public static string Acessar(ClienteInfo cliente)
        {
           
            try
            {
                SqlDataReader leitor;
                command.CommandText = "login_Cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(cliente.Senha); //pegando a senha e transformandi em vetor de byte
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte); //computeHash é quem vai criptografar o vetorByte
                StringBuilder senhaCriptografado = new StringBuilder(); //
                for (int i = 0; i < vetorHash.Length; i = i + 1)
                {
                    senhaCriptografado.Append(vetorHash[i].ToString("X2"));
                }
                command.Parameters.AddWithValue("apelido", cliente.Apelido.ToLower());
                command.Parameters.AddWithValue("senha", senhaCriptografado.ToString());
                conexao.Open();
                leitor = command.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    cliente.IdCliente = leitor.GetInt32(0);
                    cliente.Nome = leitor.GetString(3);
                    conexao.Close();
                    leitor.Close();
                    return "C";
                }
                else
                {
                    conexao.Close();
                    leitor.Close();
                    return "E";
                }
            }
            catch (SqlException ex)
            { 
                return "Erro" + ex.Message + ex.HResult;
            }
        }
    }

}
