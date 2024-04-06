namespace Estacionamento
{
    partial class BuscaFuncionario
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
            btAtualizar = new Button();
            dgvDadosFunc = new DataGridView();
            btBuscar = new Button();
            txtBusca = new TextBox();
            cbCondicao = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDadosFunc).BeginInit();
            SuspendLayout();
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(613, 12);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Size = new Size(75, 23);
            btAtualizar.TabIndex = 8;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += btAtualizar_Click;
            // 
            // dgvDadosFunc
            // 
            dgvDadosFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosFunc.Location = new Point(71, 132);
            dgvDadosFunc.Name = "dgvDadosFunc";
            dgvDadosFunc.RowTemplate.Height = 25;
            dgvDadosFunc.Size = new Size(564, 150);
            dgvDadosFunc.TabIndex = 7;
            dgvDadosFunc.CellClick += dgvDadosFunc_CellClick;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(532, 12);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 6;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(179, 12);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Nome ou Telefone";
            txtBusca.ShortcutsEnabled = false;
            txtBusca.Size = new Size(213, 23);
            txtBusca.TabIndex = 0;
            txtBusca.TextAlign = HorizontalAlignment.Center;
            // 
            // cbCondicao
            // 
            cbCondicao.FormattingEnabled = true;
            cbCondicao.Items.AddRange(new object[] { "adm", "func", "inativo" });
            cbCondicao.Location = new Point(405, 13);
            cbCondicao.Name = "cbCondicao";
            cbCondicao.Size = new Size(121, 23);
            cbCondicao.TabIndex = 9;
            // 
            // BuscaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(cbCondicao);
            Controls.Add(btAtualizar);
            Controls.Add(dgvDadosFunc);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Name = "BuscaFuncionario";
            Text = "BuscaFuncionario";
            ((System.ComponentModel.ISupportInitialize)dgvDadosFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAtualizar;
        private DataGridView dgvDadosFunc;
        private Button btBuscar;
        private TextBox txtBusca;
        private ComboBox cbCondicao;
    }
}