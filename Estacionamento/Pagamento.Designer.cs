namespace Estacionamento
{
    partial class Pagamento
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
            lblNomeCliente = new Label();
            cbVaga = new ComboBox();
            lblPlaca = new Label();
            lblPg = new Label();
            cbPagamento = new ComboBox();
            cbBandeira = new ComboBox();
            btEntrada = new Button();
            btSaida = new Button();
            label2 = new Label();
            lblTotalPg = new Label();
            SuspendLayout();
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(25, 43);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(95, 15);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "Nome do cliente";
            // 
            // cbVaga
            // 
            cbVaga.FormattingEnabled = true;
            cbVaga.Location = new Point(156, 78);
            cbVaga.Name = "cbVaga";
            cbVaga.Size = new Size(121, 23);
            cbVaga.TabIndex = 1;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(156, 43);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(90, 15);
            lblPlaca.TabIndex = 2;
            lblPlaca.Text = "Placa do cliente";
            // 
            // lblPg
            // 
            lblPg.AutoSize = true;
            lblPg.Location = new Point(25, 155);
            lblPg.Name = "lblPg";
            lblPg.Size = new Size(68, 15);
            lblPg.TabIndex = 3;
            lblPg.Text = "Pagamento";
            lblPg.Visible = false;
            // 
            // cbPagamento
            // 
            cbPagamento.FormattingEnabled = true;
            cbPagamento.Items.AddRange(new object[] { "Dinheiro", "Pix", "Débito", "Crédito" });
            cbPagamento.Location = new Point(12, 193);
            cbPagamento.Name = "cbPagamento";
            cbPagamento.Size = new Size(121, 23);
            cbPagamento.TabIndex = 4;
            cbPagamento.Visible = false;
            // 
            // cbBandeira
            // 
            cbBandeira.FormattingEnabled = true;
            cbBandeira.Items.AddRange(new object[] { "MasterCard", "Visa", "Elo", "American Express", "HiperCard", "Alelo" });
            cbBandeira.Location = new Point(12, 222);
            cbBandeira.Name = "cbBandeira";
            cbBandeira.Size = new Size(121, 23);
            cbBandeira.TabIndex = 5;
            cbBandeira.Visible = false;
            // 
            // btEntrada
            // 
            btEntrada.Location = new Point(12, 286);
            btEntrada.Name = "btEntrada";
            btEntrada.Size = new Size(152, 23);
            btEntrada.TabIndex = 6;
            btEntrada.Text = "Entrada de Veículo";
            btEntrada.UseVisualStyleBackColor = true;
            btEntrada.Click += btEntrada_Click;
            // 
            // btSaida
            // 
            btSaida.Location = new Point(12, 325);
            btSaida.Name = "btSaida";
            btSaida.Size = new Size(152, 23);
            btSaida.TabIndex = 7;
            btSaida.Text = "Saída de Veículo";
            btSaida.UseVisualStyleBackColor = true;
            btSaida.Visible = false;
            btSaida.Click += btSaida_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 86);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Vaga";
            // 
            // lblTotalPg
            // 
            lblTotalPg.AutoSize = true;
            lblTotalPg.Location = new Point(12, 258);
            lblTotalPg.Name = "lblTotalPg";
            lblTotalPg.RightToLeft = RightToLeft.No;
            lblTotalPg.Size = new Size(89, 15);
            lblTotalPg.TabIndex = 9;
            lblTotalPg.Text = "Total a ser pago";
            // 
            // Pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalPg);
            Controls.Add(label2);
            Controls.Add(btSaida);
            Controls.Add(btEntrada);
            Controls.Add(cbBandeira);
            Controls.Add(cbPagamento);
            Controls.Add(lblPg);
            Controls.Add(lblPlaca);
            Controls.Add(cbVaga);
            Controls.Add(lblNomeCliente);
            Name = "Pagamento";
            Text = "Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        public Label lblNomeCliente;
        public ComboBox cbVaga;
        public Label lblPlaca;
        public ComboBox cbPagamento;
        public ComboBox cbBandeira;
        public Label lblPg;
        public Button btEntrada;
        public Button btSaida;
        public Label lblTotalPg;
    }
}