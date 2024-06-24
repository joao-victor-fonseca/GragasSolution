namespace Gragas_Solution_2
{
    partial class telaAdicionar
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
            this.label2 = new System.Windows.Forms.Label();
            this.textoQuantidade = new System.Windows.Forms.TextBox();
            this.botaoAdicionarEstoque = new System.Windows.Forms.Button();
            this.listaAdicionar = new System.Windows.Forms.ListBox();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textoQuantidade
            // 
            this.textoQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoQuantidade.Location = new System.Drawing.Point(683, 336);
            this.textoQuantidade.Multiline = true;
            this.textoQuantidade.Name = "textoQuantidade";
            this.textoQuantidade.Size = new System.Drawing.Size(145, 28);
            this.textoQuantidade.TabIndex = 4;
            this.textoQuantidade.TextChanged += new System.EventHandler(this.textoAdicionar_TextChanged);
            this.textoQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoAdicionar_KeyPress);
            // 
            // botaoAdicionarEstoque
            // 
            this.botaoAdicionarEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoAdicionarEstoque.BackColor = System.Drawing.Color.RoyalBlue;
            this.botaoAdicionarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionarEstoque.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.botaoAdicionarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoAdicionarEstoque.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdicionarEstoque.ForeColor = System.Drawing.Color.White;
            this.botaoAdicionarEstoque.Location = new System.Drawing.Point(470, 420);
            this.botaoAdicionarEstoque.Name = "botaoAdicionarEstoque";
            this.botaoAdicionarEstoque.Size = new System.Drawing.Size(317, 76);
            this.botaoAdicionarEstoque.TabIndex = 6;
            this.botaoAdicionarEstoque.Text = "Adicionar ao Estoque";
            this.botaoAdicionarEstoque.UseVisualStyleBackColor = false;
            this.botaoAdicionarEstoque.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // listaAdicionar
            // 
            this.listaAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAdicionar.FormattingEnabled = true;
            this.listaAdicionar.ItemHeight = 24;
            this.listaAdicionar.Items.AddRange(new object[] {
            "Processadores",
            "Memorias Flash",
            "Cristais de Clock",
            "Display para IHM",
            "Soquetes de Processador",
            "Dissipador de Calor",
            "Fonte de Alimentação"});
            this.listaAdicionar.Location = new System.Drawing.Point(683, 271);
            this.listaAdicionar.Name = "listaAdicionar";
            this.listaAdicionar.Size = new System.Drawing.Size(227, 28);
            this.listaAdicionar.TabIndex = 7;
            this.listaAdicionar.SelectedIndexChanged += new System.EventHandler(this.listaAdicionar_SelectedIndexChanged);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(12, 12);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(136, 36);
            this.botaoVoltar.TabIndex = 8;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adicione aqui o produto";
            // 
            // telaAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.listaAdicionar);
            this.Controls.Add(this.botaoAdicionarEstoque);
            this.Controls.Add(this.textoQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "telaAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaAdicionar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaAdicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoQuantidade;
        private System.Windows.Forms.Button botaoAdicionarEstoque;
        private System.Windows.Forms.ListBox listaAdicionar;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Label label3;
    }
}