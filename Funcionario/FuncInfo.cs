using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;

namespace FuncionarioI
{
    public class FuncInfo
    {
        public  string Apelido { get; set; }
        public  string Senha { get; set; }
        public  string Nome { get; set; }
        public  string Condicao { get; set; }
        public  int IdFunc { get; set; }
        public string Telefone { get; set; }
        public FuncInfo() { }
    }
}