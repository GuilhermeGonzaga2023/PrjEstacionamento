using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegradeNegocio;
using FuncionarioI;

namespace Estacionamento
{
    public partial class BuscaFuncionario : Form
    {
        public BuscaFuncionario()
        {
            InitializeComponent();
        }
        FuncInfo func = new FuncInfo();
        private void btBuscar_Click(object sender, EventArgs e)
        {
            dgvDadosFunc.DataSource = FuncionarioRN.Buscar(func);
        }
        private void dgvDadosFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {// selecionar a linha
            //CadastroFunc func = new CadastroFunc();
            //FuncInfo.IdFunc = 0;
            //func.txtLogin.Text = "";
            //func.txtSenha.Text = "";
            //func.txtNome.Text = "";
            //func.txtTelefone.Text = "";
            //func.cbCondicao.Text = "";
        }
        private void btAtualizar_Click(object sender, EventArgs e)
        {//abrir janela cadastro
            //CadastroFunc func = new CadastroFunc();
            //func.txtLogin.Enabled = false;
            //func.btCadastro.Visible = false;
            //func.cbCondicao.Visible = true;
            //func.btAtualizar.Visible = true;
            //func.lblPerm.Visible = true;
            //func.Show();
        }
    }
}
