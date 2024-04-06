using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Banco;
using ClienteI;
using FuncionarioI;

namespace RegradeNegocio
{
    public class ClienteRN
    {      
        public ClienteRN(){}               
        public static string Cadastro(ClienteInfo cliente)
        {           
            string result = ClienteBD.Cadastro(cliente);
            if (result == "C")
            {
                return result;
            }
            else
            {
                return result;
            }
        }
        public static string Atualizar(ClienteInfo cliente)
        {           
            string result = ClienteBD.Atualizar(cliente);
            if (result == "A")
            {
                return result = "Atualizado com Sucesso !";
            }
            else
            {
                return result;
            }
        }
        public static DataSet buscar(ClienteInfo cliente)
        {
            
            DataSet ds = ClienteBD.Buscar(cliente);
            return ds;
        }
        public static string AtualizarSenha(ClienteInfo cliente)
        {           
            string result = ClienteBD.AtualizarSenha(cliente);
            if (result == "A")
            {
                return result;
            }
            else
            {
                return result;
            }
        }
        public static string Acessar(ClienteInfo cliente)
        {
            string result = ClienteBD.Acessar(cliente);
            if (result == "OK")
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
