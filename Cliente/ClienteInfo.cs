using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClienteI
{
    public class ClienteInfo
    {
        public string Apelido { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public char Status { get; set; }
        public int IdCliente { get; set; }
        public ClienteInfo() { }
    }
}