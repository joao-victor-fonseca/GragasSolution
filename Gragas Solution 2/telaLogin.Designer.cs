namespace Gragas_Solution_2
{
    partial class telaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            this.textoLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoSenha = new System.Windows.Forms.TextBox();
            this.botaoLogin = new System.Windows.Forms.Button();
            this.linkRegistro = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoLogin
            // 
            this.textoLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLogin.Location = new System.Drawing.Point(140, 78);
            this.textoLogin.Multiline = true;
            this.textoLogin.Name = "textoLogin";
            this.textoLogin.Size = new System.Drawing.Size(182, 26);
            this.textoLogin.TabIndex = 0;
            this.textoLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoLogin.TextChanged += new System.EventHandler(this.textoAdicionar_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textoSenha
            // 
            this.textoSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.Location = new System.Drawing.Point(140, 113);
            this.textoSenha.Multiline = true;
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.PasswordChar = '*';
            this.textoSenha.Size = new System.Drawing.Size(182, 26);
            this.textoSenha.TabIndex = 4;
            this.textoSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // botaoLogin
            // 
            this.botaoLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.botaoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLogin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.botaoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoLogin.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLogin.ForeColor = System.Drawing.Color.White;
            this.botaoLogin.Location = new System.Drawing.Point(75, 181);
            this.botaoLogin.Name = "botaoLogin";
            this.botaoLogin.Size = new System.Drawing.Size(247, 69);
            this.botaoLogin.TabIndex = 5;
            this.botaoLogin.Text = "Acessar Estoque";
            this.botaoLogin.UseVisualStyleBackColor = false;
            this.botaoLogin.Click += new System.EventHandler(this.botaoLogin_Click);
            // 
            // linkRegistro
            // 
            this.linkRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkRegistro.AutoSize = true;
            this.linkRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistro.Location = new System.Drawing.Point(53, 266);
            this.linkRegistro.Name = "linkRegistro";
            this.linkRegistro.Size = new System.Drawing.Size(285, 20);
            this.linkRegistro.TabIndex = 8;
            this.linkRegistro.TabStop = true;
            this.linkRegistro.Text = "Não Possui uma Conta ? Clique Aqui";
            this.linkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(309, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 141);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Faça seu Login ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkRegistro);
            this.panel1.Controls.Add(this.botaoLogin);
            this.panel1.Controls.Add(this.textoSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textoLogin);
            this.panel1.Location = new System.Drawing.Point(396, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 338);
            this.panel1.TabIndex = 11;
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "telaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.telaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoSenha;
        private System.Windows.Forms.Button botaoLogin;
        private System.Windows.Forms.LinkLabel linkRegistro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

