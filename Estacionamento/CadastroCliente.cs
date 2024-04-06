using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteI;
using FuncionarioI;
using RegradeNegocio;

namespace Estacionamento
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }
        ClienteInfo cliente = new ClienteInfo();
        private void GuardaCliente()
        {
            cliente.Apelido = txtLogin.Text;
            cliente.Senha = txtSenha.Text;
            cliente.Nome = txtNome.Text;
            cliente.Placa = txtPlaca.Text;
        }
        private void btCadastro_Click(object sender, EventArgs e)
        {//chmar metodo cadastro
            GuardaCliente();
            lblErro.Text = ClienteRN.Cadastro(cliente);
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            GuardaCliente();
            if (cbStatus.Text == "Ativo")
            {
                cliente.Status = 'A';
            }
            else if (cbStatus.Text == "Inativo")
            {
                cliente.Status = 'I';
            }
            lblErro.Text = ClienteRN.Atualizar(cliente);
        }
    }
}
