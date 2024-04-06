using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Net.Cache;
using System.Runtime.ConstrainedExecution;
using System.IO;

namespace RegradeNegocio
{
    public class VerificarPlaca
    {
        
        private static char ValidarPlaca(string placa)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.qualveiculo.net/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if (ChecaServidor.StatusCode != HttpStatusCode.OK)//verificar conexão com o servidor
            {               
                return 'f'; // não ouve conexão com o servidor
            }
            else
            {
                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            
                            return 'c';
                        }
                    }
                    else
                    {

                        return 'f';

                    }
                }

            }
           

        }
    }
}


