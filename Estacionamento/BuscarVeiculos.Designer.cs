namespace Estacionamento
{
    partial class BuscarVeiculos
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
            btEEstadia = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btEEstadia
            // 
            btEEstadia.Location = new Point(273, 28);
            btEEstadia.Name = "btEEstadia";
            btEEstadia.Size = new Size(188, 23);
            btEEstadia.TabIndex = 0;
            btEEstadia.Text = "Encerrar estadia";
            btEEstadia.UseVisualStyleBackColor = true;
            btEEstadia.Visible = false;
            btEEstadia.Click += btEEstadia_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(722, 251);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 83);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do Cliente Selecionado";
            // 
            // BuscarVeiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btEEstadia);
            Name = "BuscarVeiculos";
            Text = "BuscarVeiculos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEEstadia;
        private DataGridView dataGridView1;
        private Label label1;
    }
}