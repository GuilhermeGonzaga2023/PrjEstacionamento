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
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }
        FuncInfo func = new FuncInfo();
        private void btAcesso_Click(object sender, EventArgs e)
        {
            Desktop menu = new Desktop();            
            if (txtLogin.Text == "admin" && txtSenha.Text == "adm")
            {
                menu.buscarFuncionárioToolStripMenuItem.Visible = false;
                this.Close();
            }
            else
            {                
                string dados = FuncionarioRN.Acessar(func);
                if (func.Condicao == "func")
                {//habilitar menus para o uso do funcionario
                    menu.funcionarioToolStripMenuItem.Visible = true;
                    this.Close();
                }
                else if (func.Condicao == "admin")
                {//abrir desktop e abilitar apenas o cadastro para funcionario e administrador

                    menu.buscarFuncionárioToolStripMenuItem.Visible = true;
                    menu.relatorioToolStripMenuItem.Visible = true;
                    menu.clienteToolStripMenuItem.Visible = true;
                    menu.quantidadeDeVagaToolStripMenuItem.Visible = true;
                    menu.novoVeículoToolStripMenuItem.Visible = true;
                    menu.valorDaHoraToolStripMenuItem.Visible = true;
                    menu.custoDaVagaReservadaToolStripMenuItem.Visible = true;
                    menu.funcionarioToolStripMenuItem.Visible = true;
                    this.Close();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show(dados);
                }
            } 
            
        }
    }
}
