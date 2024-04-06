using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FuncionarioI;




namespace Banco
{
    public class FuncionarioBD
    {
        
        public FuncionarioBD() { }
        //criando string de conexão e estanciando para todo o código
        private static SqlConnection conexao = new SqlConnection("Banco.Properties.Settings.EstacionamentoBD");
        private static SqlCommand command = new SqlCommand();
        //------------------------------------------------------
        public static string Cadastro(FuncInfo func)
        {
            try
            {
                command.CommandText = "pi_Funcionario";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;              
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Apelido", func.Apelido.ToLower());
                command.Parameters.AddWithValue("Senha", func.Senha);
                command.Parameters.AddWithValue("Nome", func.Nome.ToUpper());
                command.Parameters.AddWithValue("Telefone",func.Telefone);
                command.Parameters.AddWithValue("Condicao", func.Condicao);
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
        public static string Atualizar(FuncInfo func)
        {
            try
            {
                command.CommandText = "pu_Funcionario";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("IdFunc", func.IdFunc);
                command.Parameters.AddWithValue("Nome", func.Nome.ToUpper());
                command.Parameters.AddWithValue("Senha", func.Senha);
                command.Parameters.AddWithValue("Telefone", func.Telefone);
                command.Parameters.AddWithValue("Condicao", func.Condicao);
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
        public static DataSet Buscar(FuncInfo func)
        {
            command.CommandText = "ps_Funcionario";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conexao;
            command.Parameters.AddWithValue("Telefone", func.Telefone);
            command.Parameters.AddWithValue("Nome", func.Nome.ToUpper());
            command.Parameters.AddWithValue("Status", func.Condicao);
            SqlDataAdapter adaptacao = new SqlDataAdapter(command);
            DataSet mostrarDados = new DataSet();
            adaptacao.Fill(mostrarDados);
            return mostrarDados;
        }
        public static string Acessar(FuncInfo func)
        {
            
            try
            {
                SqlDataReader leitor;
                command.CommandText = "login_Funcionario";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;                
                command.Parameters.AddWithValue("apelido", func.Apelido.ToLower());
                command.Parameters.AddWithValue("senha", func.Senha);
                conexao.Open();
                leitor = command.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    func.IdFunc  = leitor.GetInt32(0);
                    func.Nome  = leitor.GetString(3);
                    func.Condicao = leitor.GetString(5);
                    conexao.Close();
                    leitor.Close();
                    return  "OK";
                }
                else
                {
                    return "Usuario ou senha não encontrado";
                }
            }
            catch (SqlException ex)
            {
                return "Erro" + ex.Message + ex.HResult;
            }
        }
    }
}
