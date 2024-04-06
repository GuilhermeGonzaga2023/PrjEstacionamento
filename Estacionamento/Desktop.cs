using Microsoft.VisualBasic;
using RegradeNegocio;

namespace Estacionamento
{//joga um alert se o cliente atrasar recalcular com multa de atraso.
    //negociar com a equipe no site apenas pagar a entrada a saída vai der de acordo com a saída do cliente.
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }
        private void Desktop_Load(object sender, EventArgs e)
        {

        }
        private void acessarToolStripMenuItem_Click(object sender, EventArgs e)
        {//trocar acesso e mostrar opções limitadas a usarios comuns.
            Acesso telaAcesso = new Acesso();
            telaAcesso.MdiParent = this;
            telaAcesso.Show();
        }
        private void quantidadeDeVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {//armazenar número de vagas
            string qtdDeVaga = Interaction.InputBox("Nº de Vagas no local", " Valor numérico");
            if (qtdDeVaga == "")//completar para não deixar passar nennhum caracter
            {
                MessageBox.Show("por favor digite um valor numerico");
            }
            else
            {
                qtdDeVaga = qtdDeVaga.Replace(",", ".");
                VagaRN.QtdVaga = Convert.ToInt32(qtdDeVaga);

            }

        }
        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {//chamar a tela para o cadastro de funcionario.
            CadastroFunc telaCadastroFunc = new CadastroFunc();
            telaCadastroFunc.MdiParent = this;
            telaCadastroFunc.Show();
        }
        private void buscarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {// abre tela de buscade funcionario
            BuscaFuncionario telaBuscaFunc = new BuscaFuncionario();
            telaBuscaFunc.MdiParent = this;
            telaBuscaFunc.Show();
        }
        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {//abrir janela de relatorio
            Relatorio telaRelatorio = new Relatorio();
            telaRelatorio.MdiParent = this;
            telaRelatorio.Show();
        }
        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {//abrir janela de cadastro de cliente
            CadastroCliente telaCadastroCliente = new CadastroCliente();
            telaCadastroCliente.MdiParent = this;
            telaCadastroCliente.Show();
        }
        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {//abrir janela do cliente 
            txtBuscaCliente telaBuscaCliente = new txtBuscaCliente();
            telaBuscaCliente.MdiParent = this;
            telaBuscaCliente.Show();
        }
        private void novoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBuscaCliente bc = new txtBuscaCliente();
            bc.btAtualizar.Visible = false;
            bc.rbInativo.Visible = false;
            bc.Show();
        }
        private void saidaDeVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void valorDaHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //guardar o valor que sera multiplicado com o tempo que o cliente deixará o veiculo no estacionamento
            string valorHoraVaga = Interaction.InputBox("Valor que deve ser cobrado por hora", "Valor numerico");
            if (valorHoraVaga == "")
            {
                MessageBox.Show("por favor digite um valor numerico");
            }
            else
            {

            }
        }
        private void custoDaVagaReservadaToolStripMenuItem_Click(object sender, EventArgs e)
        { //guardar o valor que sera multiplicado com o tempo que o cliente deixará o veiculo no estacionamento
            string valorVaga = Interaction.InputBox("Valor da vaga agendada", "Valor em numerico");
            if (valorVaga == "")
            {
                MessageBox.Show("por favor digite um valor numerico");
            }
            else
            {

            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//abrir tela de acesso e apagar as informações do usuaario que está logado.
            Acesso A = new Acesso();
            A.Show();
        }


    }
}