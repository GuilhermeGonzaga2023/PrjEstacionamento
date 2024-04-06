using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco;
using ClienteI;
using RegradeNegocio;

namespace Estacionamento
{
    public partial class txtBuscaCliente : Form
    {
        public txtBuscaCliente()
        {
            InitializeComponent();
        }
        ClienteInfo cliente = new ClienteInfo();
        private void btBuscar_Click(object sender, EventArgs e)
        {//mostrar clientes do banco de dados e abilitar botão atualizar e botão pagamento.
            if (rbInativo.Checked == true)
            {
                cliente.Status = 'I';
            }
            else if (rbAgendado.Checked == true)
            {
                cliente.Status = 'R';
            }
            else
            {
                cliente.Status = 'A';
            }
            cliente.Nome = txtBusca.Text;
            dgvDadosCliente.DataSource = ClienteRN.buscar(cliente);
        }
        private void btAtualizar_Click(object sender, EventArgs e)
        {// abrir cadastro do cliente e esconder botão cadastro e mostrasr drop dowlist e botão atualizar
            CadastroCliente cl = new CadastroCliente();
            cl.txtLogin.Text = cliente.Apelido;
            cl.txtLogin.Enabled = false;
            cl.txtSenha.Enabled = false;
            cl.txtNome.Text = cliente.Nome;
            cl.txtPlaca.Text = cliente.Placa;
            this.Close();
            cl.Show();
        }
        private void btSlPagamento_Click(object sender, EventArgs e)
        {// armazenar o id, nome e a placa do cliente e passar para a pagina pagamento. 
            Pagamento pg = new Pagamento();
            pg.lblNomeCliente.Text = cliente.Nome;
            pg.lblPlaca.Text = cliente.Placa;
            this.Close();
            pg.Show();
        }
        private void dgvDadosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente.IdCliente = Convert.ToInt32(dgvDadosCliente.Rows[e.RowIndex].Cells[0].Value);
            cliente.Apelido = dgvDadosCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            cliente.Nome = dgvDadosCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            cliente.Placa = dgvDadosCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            cliente.Status = Convert.ToChar(dgvDadosCliente.Rows[e.RowIndex].Cells[5].Value);
            lblCliente.Text = "Cliente selecionado: " + cliente.Nome;
        }
    }
}
