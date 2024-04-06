using RegradeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class BuscarVeiculos : Form
    {
        public BuscarVeiculos()
        {
            InitializeComponent();
        }

        private void btEEstadia_Click(object sender, EventArgs e)
        {
            Pagamento pg = new Pagamento();
            pg.lblPg.Visible = true;
            pg.cbPagamento.Visible = true;
            pg.cbBandeira.Visible = true;
            pg.btEntrada.Visible = false;
            pg.btSaida.Visible = true;
            PagamentoRN.Valor = CalcHora.subtracaodaHora(DateTime.Now, DateTime.Now, VagaRN.VHoraVaga);
            pg.lblTotalPg.Text = PagamentoRN.Valor.ToString();
        }
    }
}
