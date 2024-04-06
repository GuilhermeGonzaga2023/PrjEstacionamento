namespace Estacionamento
{
    partial class CadastroCliente
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
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtPlaca = new TextBox();
            cbStatus = new ComboBox();
            btCadastro = new Button();
            btAtualizar = new Button();
            lblErro = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(109, 81);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "LoginCliente";
            txtLogin.Size = new Size(125, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(109, 110);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha Cliente";
            txtSenha.Size = new Size(125, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(109, 139);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do cliente";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 2;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(109, 168);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PlaceholderText = "Placa do Cliente";
            txtPlaca.Size = new Size(125, 23);
            txtPlaca.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cbStatus.Location = new Point(109, 201);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(125, 23);
            cbStatus.TabIndex = 4;
            // 
            // btCadastro
            // 
            btCadastro.Location = new Point(109, 239);
            btCadastro.Name = "btCadastro";
            btCadastro.Size = new Size(125, 23);
            btCadastro.TabIndex = 5;
            btCadastro.Text = "Cadastrar";
            btCadastro.UseVisualStyleBackColor = true;
            btCadastro.Click += btCadastro_Click;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(109, 268);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Size = new Size(125, 23);
            btAtualizar.TabIndex = 6;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += btAtualizar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(109, 307);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(116, 15);
            lblErro.TabIndex = 7;
            lblErro.Text = "Respotas do metodo";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErro);
            Controls.Add(btAtualizar);
            Controls.Add(btCadastro);
            Controls.Add(cbStatus);
            Controls.Add(txtPlaca);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Name = "CadastroCliente";
            Text = "CadastroCleinte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbStatus;
        private Label lblErro;
        public TextBox txtLogin;
        public TextBox txtSenha;
        public TextBox txtNome;
        public TextBox txtPlaca;
        public Button btCadastro;
        public Button btAtualizar;
    }
}