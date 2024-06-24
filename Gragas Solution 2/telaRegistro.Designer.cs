namespace Gragas_Solution_2
{
    partial class telaRegistro
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
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.textoSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textConfirmarSenha = new System.Windows.Forms.TextBox();
            this.textoData = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textoLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(12, 12);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(136, 36);
            this.botaoVoltar.TabIndex = 9;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoNome
            // 
            this.textoNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNome.Location = new System.Drawing.Point(112, 67);
            this.textoNome.Multiline = true;
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(279, 29);
            this.textoNome.TabIndex = 10;
            this.textoNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoNome.TextChanged += new System.EventHandler(this.textoAdicionar_TextChanged);
            // 
            // textoSenha
            // 
            this.textoSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.Location = new System.Drawing.Point(175, 330);
            this.textoSenha.Multiline = true;
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.PasswordChar = '*';
            this.textoSenha.Size = new System.Drawing.Size(125, 29);
            this.textoSenha.TabIndex = 13;
            this.textoSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Confirme a Senha:";
            // 
            // textConfirmarSenha
            // 
            this.textConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmarSenha.Location = new System.Drawing.Point(175, 420);
            this.textConfirmarSenha.Multiline = true;
            this.textConfirmarSenha.Name = "textConfirmarSenha";
            this.textConfirmarSenha.PasswordChar = '*';
            this.textConfirmarSenha.Size = new System.Drawing.Size(125, 29);
            this.textConfirmarSenha.TabIndex = 17;
            this.textConfirmarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoData
            // 
            this.textoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoData.Location = new System.Drawing.Point(91, 155);
            this.textoData.Name = "textoData";
            this.textoData.Size = new System.Drawing.Size(322, 26);
            this.textoData.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(112, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 69);
            this.button2.TabIndex = 19;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.botaoRegistrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome Completo:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Login:";
            // 
            // textoLogin
            // 
            this.textoLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLogin.Location = new System.Drawing.Point(102, 242);
            this.textoLogin.Multiline = true;
            this.textoLogin.Name = "textoLogin";
            this.textoLogin.Size = new System.Drawing.Size(279, 29);
            this.textoLogin.TabIndex = 22;
            this.textoLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(432, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(382, 60);
            this.label7.TabIndex = 23;
            this.label7.Text = "Faça seu cadastro";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textoLogin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textoData);
            this.panel1.Controls.Add(this.textConfirmarSenha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textoSenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textoNome);
            this.panel1.Location = new System.Drawing.Point(360, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 572);
            this.panel1.TabIndex = 24;
            // 
            // telaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.botaoVoltar);
            this.Name = "telaRegistro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaRegistro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaRegistro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.TextBox textoSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textConfirmarSenha;
        private System.Windows.Forms.DateTimePicker textoData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textoLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}