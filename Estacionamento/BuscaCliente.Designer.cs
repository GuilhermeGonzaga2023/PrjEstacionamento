namespace Estacionamento
{
    partial class txtBuscaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBusca = new TextBox();
            btBuscar = new Button();
            dgvDadosCliente = new DataGridView();
            btAtualizar = new Button();
            btSlPagamento = new Button();
            rbInativo = new RadioButton();
            lblCliente = new Label();
            rbAgendado = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvDadosCliente).BeginInit();
            SuspendLayout();
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(255, 12);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Nome do Cliente ou Placa";
            txtBusca.Size = new Size(213, 23);
            txtBusca.TabIndex = 0;
            txtBusca.TextAlign = HorizontalAlignment.Center;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(474, 11);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 1;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // dgvDadosCliente
            // 
            dgvDadosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosCliente.Location = new Point(60, 132);
            dgvDadosCliente.Name = "dgvDadosCliente";
            dgvDadosCliente.RowTemplate.Height = 25;
            dgvDadosCliente.Size = new Size(564, 150);
            dgvDadosCliente.TabIndex = 2;
            dgvDadosCliente.CellClick += dgvDadosCliente_CellClick;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(255, 41);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Size = new Size(75, 23);
            btAtualizar.TabIndex = 3;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += btAtualizar_Click;
            // 
            // btSlPagamento
            // 
            btSlPagamento.Location = new Point(336, 41);
            btSlPagamento.Name = "btSlPagamento";
            btSlPagamento.Size = new Size(213, 23);
            btSlPagamento.TabIndex = 4;
            btSlPagamento.Text = "Selecionar para Pagamento";
            btSlPagamento.UseVisualStyleBackColor = true;
            btSlPagamento.Click += btSlPagamento_Click;
            // 
            // rbInativo
            // 
            rbInativo.AutoSize = true;
            rbInativo.Location = new Point(326, 70);
            rbInativo.Name = "rbInativo";
            rbInativo.Size = new Size(101, 19);
            rbInativo.TabIndex = 6;
            rbInativo.TabStop = true;
            rbInativo.Text = "Cliente Inativo";
            rbInativo.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(72, 101);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(114, 15);
            lblCliente.TabIndex = 7;
            lblCliente.Text = "Cliente Selecionado:";
            // 
            // rbAgendado
            // 
            rbAgendado.AutoSize = true;
            rbAgendado.Location = new Point(448, 70);
            rbAgendado.Name = "rbAgendado";
            rbAgendado.Size = new Size(120, 19);
            rbAgendado.TabIndex = 8;
            rbAgendado.TabStop = true;
            rbAgendado.Text = "Cliente Agendado";
            rbAgendado.UseVisualStyleBackColor = true;
            // 
            // txtBuscaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(rbAgendado);
            Controls.Add(lblCliente);
            Controls.Add(rbInativo);
            Controls.Add(btSlPagamento);
            Controls.Add(btAtualizar);
            Controls.Add(dgvDadosCliente);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Name = "txtBuscaCliente";
            Text = "BuscaCliente";
            ((System.ComponentModel.ISupportInitialize)dgvDadosCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusca;
        private Button btBuscar;
        private Button btSlPagamento;
        private Label lblCliente;
        public Button btAtualizar;
        public RadioButton rbInativo;
        public RadioButton rbAgendado;
        public DataGridView dgvDadosCliente;
    }
}