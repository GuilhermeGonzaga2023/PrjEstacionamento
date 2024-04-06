using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace estacionamentoPrjIntegrador
{

    public partial class estacionamento : System.Web.UI.Page
    {
        double parkingFee;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime entrada = DateTime.ParseExact(txtEntrada.Text, "HH:mm", CultureInfo.InvariantCulture);
                DateTime saida = DateTime.ParseExact(txtSaida.Text, "HH:mm", CultureInfo.InvariantCulture);

                TimeSpan timeDifference = saida - entrada;

                if (timeDifference<TimeSpan.Zero)
                {
                    txtSaida.Text=String.Empty;
                    lblResultadoFinal.Text=String.Empty;
                    msgErro.Text = "horario de saida inferior ao de entrada";
                }
                else
                {
                    string timeDiffString = string.Format("{0:%h} horas, {0:%m} minutos", timeDifference);
                    lblResultadoFinal.Text = timeDiffString;

                    if (timeDifference.TotalMinutes<=15)
                    {
                        parkingFee = 10;
                    }
                    else if (timeDifference.TotalMinutes > 15 && timeDifference.TotalMinutes <= 30)
                    {
                        parkingFee = 20;
                    }
                    else if (timeDifference.TotalMinutes > 30 && timeDifference.TotalHours <= 1)
                    {
                        parkingFee = 35;
                    }
                    else if (timeDifference.TotalHours > 1 && timeDifference.TotalHours <= 2)
                    {
                        parkingFee = 50;
                    }
                    else if( timeDifference.TotalHours > 2 && timeDifference.TotalHours <= 3)
                    {
                        parkingFee = 60;
                    }
                    else if( timeDifference.TotalHours > 3 && timeDifference.TotalHours <= 4)
                    {
                        parkingFee = 70;
                    }
                    else if( timeDifference.TotalHours > 4 && timeDifference.TotalHours <= 5)
                    {
                        parkingFee = 80;
                    }
                    else
                    {
                        parkingFee = 100;
                    }
                    msgErro.Text = string.Format(": R${0:F2}", parkingFee);
                }
            }
            catch (Exception)
            {
                msgErro.Text = "Digite valores corretos";
                txtEntrada.Text=String.Empty;
                txtSaida.Text=String.Empty;
            }
        }
    }
}