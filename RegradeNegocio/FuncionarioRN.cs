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
using FuncionarioI;

namespace RegradeNegocio
{
    public class FuncionarioRN
    {
        //primeiro criamos os atributos para armazenar os items que serão passados por parametro
        //(SEMPRE COMEÇANDO COM LETRAS MAIUSCULAS)   
        public FuncionarioRN()  {  }              

        public static string Cadastro(FuncInfo func)
        {           
            string result = FuncionarioBD.Cadastro(func);
            if (result == "C")
            {
                return result;
            }
            else
            {
                return result;
            }
        }
        public static string Atualizar(FuncInfo func)
        {
            string result = FuncionarioBD.Atualizar(func);
            if (result == "A")
            {
                return result = "Atualizado com Sucesso !";
            }
            else
            {
                return result;
            }
        }
        public static DataSet Buscar(FuncInfo func)
        {        
            DataSet ds = FuncionarioBD.Buscar(func);
            return ds;
        }
        
        public static string Acessar(FuncInfo func)
        {
            string dados = FuncionarioBD.Acessar(func);
            if (dados == "OK")
            {
                return dados;
            }
            else
            {
                return dados;
            }    
        }
    }
        
}   
