namespace Estacionamento
{
    partial class CadastroFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFunc));
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            lblPerm = new Label();
            cbCondicao = new ComboBox();
            btCadastro = new Button();
            btAtualizar = new Button();
            lblErro = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            resources.ApplyResources(txtLogin, "txtLogin");
            txtLogin.Name = "txtLogin";
            // 
            // txtSenha
            // 
            resources.ApplyResources(txtSenha, "txtSenha");
            txtSenha.Name = "txtSenha";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.Name = "txtNome";
            // 
            // txtTelefone
            // 
            resources.ApplyResources(txtTelefone, "txtTelefone");
            txtTelefone.Name = "txtTelefone";
            // 
            // lblPerm
            // 
            resources.ApplyResources(lblPerm, "lblPerm");
            lblPerm.Name = "lblPerm";
            // 
            // cbCondicao
            // 
            cbCondicao.FormattingEnabled = true;
            cbCondicao.Items.AddRange(new object[] { resources.GetString("cbCondicao.Items"), resources.GetString("cbCondicao.Items1"), resources.GetString("cbCondicao.Items2") });
            resources.ApplyResources(cbCondicao, "cbCondicao");
            cbCondicao.Name = "cbCondicao";
            // 
            // btCadastro
            // 
            resources.ApplyResources(btCadastro, "btCadastro");
            btCadastro.Name = "btCadastro";
            btCadastro.UseVisualStyleBackColor = true;
            btCadastro.Click += btCadastro_Click;
            // 
            // btAtualizar
            // 
            resources.ApplyResources(btAtualizar, "btAtualizar");
            btAtualizar.Name = "btAtualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += btAtualizar_Click;
            // 
            // lblErro
            // 
            resources.ApplyResources(lblErro, "lblErro");
            lblErro.Name = "lblErro";
            // 
            // CadastroFunc
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(lblErro);
            Controls.Add(btAtualizar);
            Controls.Add(btCadastro);
            Controls.Add(cbCondicao);
            Controls.Add(lblPerm);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Name = "CadastroFunc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btCadastro;
        public Button btAtualizar;
        public TextBox txtLogin;
        public ComboBox cbCondicao;
        public Label lblPerm;
        public TextBox txtSenha;
        public TextBox txtNome;
        public TextBox txtTelefone;
        private Label lblErro;
    }
}