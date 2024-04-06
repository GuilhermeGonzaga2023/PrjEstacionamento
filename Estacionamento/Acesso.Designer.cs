namespace Estacionamento
{
    partial class Acesso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btAcesso = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(101, 114);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(164, 23);
            this.txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(101, 173);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(164, 23);
            this.txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(142, 40);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 15);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Acesso";
            // 
            // btAcesso
            // 
            this.btAcesso.Location = new System.Drawing.Point(128, 260);
            this.btAcesso.Name = "btAcesso";
            this.btAcesso.Size = new System.Drawing.Size(75, 23);
            this.btAcesso.TabIndex = 5;
            this.btAcesso.Text = "Logar";
            this.btAcesso.UseVisualStyleBackColor = true;
            this.btAcesso.Click += new System.EventHandler(this.btAcesso_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(127, 314);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(106, 15);
            this.lblErro.TabIndex = 6;
            this.lblErro.Text = "mensagem de erro";
            // 
            // Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(337, 413);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btAcesso);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Name = "Acesso";
            this.Text = "Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label2;
        private Label lblLogin;
        private Button btAcesso;
        private Label lblErro;
    }
}