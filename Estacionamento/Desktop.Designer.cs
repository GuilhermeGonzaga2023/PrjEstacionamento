namespace Estacionamento
{
    partial class Desktop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblErro = new Label();
            acessarToolStripMenuItem = new ToolStripMenuItem();
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            buscarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClienteToolStripMenuItem = new ToolStripMenuItem();
            buscarClientesToolStripMenuItem = new ToolStripMenuItem();
            novoVeículoToolStripMenuItem = new ToolStripMenuItem();
            quantidadeDeVagaToolStripMenuItem = new ToolStripMenuItem();
            valorDaHoraToolStripMenuItem = new ToolStripMenuItem();
            custoDaVagaReservadaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            saidaDeVeiculoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(303, 366);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(107, 15);
            lblErro.TabIndex = 7;
            lblErro.Text = "mensagens de erro";
            // 
            // acessarToolStripMenuItem
            // 
            acessarToolStripMenuItem.Name = "acessarToolStripMenuItem";
            acessarToolStripMenuItem.Size = new Size(59, 20);
            acessarToolStripMenuItem.Text = "Acessar";
            acessarToolStripMenuItem.Click += acessarToolStripMenuItem_Click;
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFuncionárioToolStripMenuItem, buscarFuncionárioToolStripMenuItem });
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(82, 20);
            funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            cadastrarFuncionárioToolStripMenuItem.Size = new Size(190, 22);
            cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            cadastrarFuncionárioToolStripMenuItem.Click += cadastrarFuncionárioToolStripMenuItem_Click;
            // 
            // buscarFuncionárioToolStripMenuItem
            // 
            buscarFuncionárioToolStripMenuItem.Name = "buscarFuncionárioToolStripMenuItem";
            buscarFuncionárioToolStripMenuItem.Size = new Size(190, 22);
            buscarFuncionárioToolStripMenuItem.Text = "Buscar funcionário";
            buscarFuncionárioToolStripMenuItem.Click += buscarFuncionárioToolStripMenuItem_Click;
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(66, 20);
            relatorioToolStripMenuItem.Text = "Relatorio";
            relatorioToolStripMenuItem.Click += relatorioToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeClienteToolStripMenuItem, buscarClientesToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 20);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            cadastroDeClienteToolStripMenuItem.Size = new Size(177, 22);
            cadastroDeClienteToolStripMenuItem.Text = "Cadastro de Cliente";
            cadastroDeClienteToolStripMenuItem.Click += cadastroDeClienteToolStripMenuItem_Click;
            // 
            // buscarClientesToolStripMenuItem
            // 
            buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            buscarClientesToolStripMenuItem.Size = new Size(177, 22);
            buscarClientesToolStripMenuItem.Text = "Buscar clientes";
            buscarClientesToolStripMenuItem.Click += buscarClientesToolStripMenuItem_Click;
            // 
            // novoVeículoToolStripMenuItem
            // 
            novoVeículoToolStripMenuItem.Name = "novoVeículoToolStripMenuItem";
            novoVeículoToolStripMenuItem.Size = new Size(116, 20);
            novoVeículoToolStripMenuItem.Text = "Entrada de Veículo";
            novoVeículoToolStripMenuItem.Click += novoVeículoToolStripMenuItem_Click;
            // 
            // quantidadeDeVagaToolStripMenuItem
            // 
            quantidadeDeVagaToolStripMenuItem.Name = "quantidadeDeVagaToolStripMenuItem";
            quantidadeDeVagaToolStripMenuItem.Size = new Size(125, 20);
            quantidadeDeVagaToolStripMenuItem.Text = "Quantidade de Vaga";
            quantidadeDeVagaToolStripMenuItem.Click += quantidadeDeVagaToolStripMenuItem_Click;
            // 
            // valorDaHoraToolStripMenuItem
            // 
            valorDaHoraToolStripMenuItem.Name = "valorDaHoraToolStripMenuItem";
            valorDaHoraToolStripMenuItem.Size = new Size(90, 20);
            valorDaHoraToolStripMenuItem.Text = "Valor da Hora";
            valorDaHoraToolStripMenuItem.Click += valorDaHoraToolStripMenuItem_Click;
            // 
            // custoDaVagaReservadaToolStripMenuItem
            // 
            custoDaVagaReservadaToolStripMenuItem.Name = "custoDaVagaReservadaToolStripMenuItem";
            custoDaVagaReservadaToolStripMenuItem.Size = new Size(150, 20);
            custoDaVagaReservadaToolStripMenuItem.Text = "Custo da Vaga Reservada";
            custoDaVagaReservadaToolStripMenuItem.Click += custoDaVagaReservadaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acessarToolStripMenuItem, funcionarioToolStripMenuItem, relatorioToolStripMenuItem, clienteToolStripMenuItem, novoVeículoToolStripMenuItem, saidaDeVeiculoToolStripMenuItem, quantidadeDeVagaToolStripMenuItem, valorDaHoraToolStripMenuItem, custoDaVagaReservadaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(931, 24);
            menuStrip1.TabIndex = 2;
            // 
            // saidaDeVeiculoToolStripMenuItem
            // 
            saidaDeVeiculoToolStripMenuItem.Name = "saidaDeVeiculoToolStripMenuItem";
            saidaDeVeiculoToolStripMenuItem.Size = new Size(104, 20);
            saidaDeVeiculoToolStripMenuItem.Text = "Saida de Veiculo";
            saidaDeVeiculoToolStripMenuItem.Click += saidaDeVeiculoToolStripMenuItem_Click;
            // 
            // Desktop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(931, 603);
            Controls.Add(lblErro);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Desktop";
            Text = "Juquinha Park";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblErro;
        public ToolStripMenuItem acessarToolStripMenuItem;
        public ToolStripMenuItem funcionarioToolStripMenuItem;
        public ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        public ToolStripMenuItem buscarFuncionárioToolStripMenuItem;
        public ToolStripMenuItem relatorioToolStripMenuItem;
        public ToolStripMenuItem clienteToolStripMenuItem;
        public ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
        public ToolStripMenuItem buscarClientesToolStripMenuItem;
        public ToolStripMenuItem novoVeículoToolStripMenuItem;
        public ToolStripMenuItem quantidadeDeVagaToolStripMenuItem;
        public ToolStripMenuItem valorDaHoraToolStripMenuItem;
        public ToolStripMenuItem custoDaVagaReservadaToolStripMenuItem;
        public ToolStripMenuItem sairToolStripMenuItem;
        public MenuStrip menuStrip1;
        private ToolStripMenuItem saidaDeVeiculoToolStripMenuItem;
    }
}