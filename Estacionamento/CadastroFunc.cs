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
using FuncionarioI;

namespace Estacionamento
{
    public partial class CadastroFunc : Form
    {

        public CadastroFunc()
        {
            InitializeComponent();      
        }
        FuncInfo func = new FuncInfo();
        private void guardaFunc()
        {
            func.Apelido = txtLogin.Text;
            func.Senha = txtSenha.Text;
            func.Nome = txtNome.Text;
            func.Condicao = cbCondicao.Text;
            func.Telefone = txtTelefone.Text;
        }
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            guardaFunc();
            lblErro.Text = FuncionarioRN.Atualizar(func);
        }
        private void btCadastro_Click(object sender, EventArgs e)
        {
            guardaFunc();  
            lblErro.Text = FuncionarioRN.Cadastro(func);
        }
    }
}
