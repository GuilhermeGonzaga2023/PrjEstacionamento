using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegradeNegocio
{ 
    public class CalcHora
    {        
         public static double subtracaodaHora(DateTime horaEntrada, DateTime horaSaida, double pHora )
           {
            double result;
            int hora;
            TimeSpan calculoTempo = horaSaida.Subtract(horaEntrada);
            hora = calculoTempo.Hours;
            return result = pHora * hora;      
           } 
         //retornar valor da hora e tempo que o cliente vai ficar.
    }
}
