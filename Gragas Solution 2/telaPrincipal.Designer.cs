namespace Gragas_Solution_2
{
    partial class telaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.tabelaItens = new System.Windows.Forms.DataGridView();
            this.pictureBoxProcessador = new System.Windows.Forms.PictureBox();
            this.pictureBoxMemoriasFlash = new System.Windows.Forms.PictureBox();
            this.pictureBoxCristaisDeClock = new System.Windows.Forms.PictureBox();
            this.pictureBoxDisplayParaIHM = new System.Windows.Forms.PictureBox();
            this.pictureBoxSoquetesDeProcessador = new System.Windows.Forms.PictureBox();
            this.pictureBoxDissipadorDeCalor = new System.Windows.Forms.PictureBox();
            this.pictureBoxFonteDeAlimentacao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemoriasFlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCristaisDeClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayParaIHM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoquetesDeProcessador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDissipadorDeCalor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFonteDeAlimentacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo(a) ao Estoque";
            // 
            // botaoRemover
            // 
            this.botaoRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoRemover.BackColor = System.Drawing.Color.RoyalBlue;
            this.botaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemover.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.botaoRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoRemover.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRemover.ForeColor = System.Drawing.Color.White;
            this.botaoRemover.Location = new System.Drawing.Point(690, 526);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(264, 65);
            this.botaoRemover.TabIndex = 1;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.UseVisualStyleBackColor = false;
            this.botaoRemover.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoAdicionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.botaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoAdicionar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdicionar.ForeColor = System.Drawing.Color.White;
            this.botaoAdicionar.Location = new System.Drawing.Point(198, 526);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(264, 65);
            this.botaoAdicionar.TabIndex = 2;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = false;
            this.botaoAdicionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabelaItens
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelaItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaItens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabelaItens.BackgroundColor = System.Drawing.Color.Silver;
            this.tabelaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaItens.Location = new System.Drawing.Point(203, 266);
            this.tabelaItens.Name = "tabelaItens";
            this.tabelaItens.Size = new System.Drawing.Size(760, 127);
            this.tabelaItens.TabIndex = 3;
            this.tabelaItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaItens_CellContentClick);
            // 
            // pictureBoxProcessador
            // 
            this.pictureBoxProcessador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxProcessador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProcessador.BackgroundImage")));
            this.pictureBoxProcessador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProcessador.Location = new System.Drawing.Point(259, 195);
            this.pictureBoxProcessador.Name = "pictureBoxProcessador";
            this.pictureBoxProcessador.Size = new System.Drawing.Size(70, 49);
            this.pictureBoxProcessador.TabIndex = 4;
            this.pictureBoxProcessador.TabStop = false;
            this.pictureBoxProcessador.Visible = false;
            this.pictureBoxProcessador.Click += new System.EventHandler(this.pictureBoxProcessador_Click);
            // 
            // pictureBoxMemoriasFlash
            // 
            this.pictureBoxMemoriasFlash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMemoriasFlash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMemoriasFlash.BackgroundImage")));
            this.pictureBoxMemoriasFlash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMemoriasFlash.Location = new System.Drawing.Point(368, 195);
            this.pictureBoxMemoriasFlash.Name = "pictureBoxMemoriasFlash";
            this.pictureBoxMemoriasFlash.Size = new System.Drawing.Size(70, 49);
            this.pictureBoxMemoriasFlash.TabIndex = 5;
            this.pictureBoxMemoriasFlash.TabStop = false;
            this.pictureBoxMemoriasFlash.Visible = false;
            // 
            // pictureBoxCristaisDeClock
            // 
            this.pictureBoxCristaisDeClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCristaisDeClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCristaisDeClock.BackgroundImage")));
            this.pictureBoxCristaisDeClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCristaisDeClock.Location = new System.Drawing.Point(462, 195);
            this.pictureBoxCristaisDeClock.Name = "pictureBoxCristaisDeClock";
            this.pictureBoxCristaisDeClock.Size = new System.Drawing.Size(70, 49);
            this.pictureBoxCristaisDeClock.TabIndex = 6;
            this.pictureBoxCristaisDeClock.TabStop = false;
            this.pictureBoxCristaisDeClock.Visible = false;
            // 
            // pictureBoxDisplayParaIHM
            // 
            this.pictureBoxDisplayParaIHM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDisplayParaIHM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDisplayParaIHM.BackgroundImage")));
            this.pictureBoxDisplayParaIHM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDisplayParaIHM.Location = new System.Drawing.Point(555, 195);
            this.pictureBoxDisplayParaIHM.Name = "pictureBoxDisplayParaIHM";
            this.pictureBoxDisplayParaIHM.Size = new System.Drawing.Size(70, 49);
            this.pictureBoxDisplayParaIHM.TabIndex = 7;
            this.pictureBoxDisplayParaIHM.TabStop = false;
            this.pictureBoxDisplayParaIHM.Visible = false;
            // 
            // pictureBoxSoquetesDeProcessador
            // 
            this.pictureBoxSoquetesDeProcessador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSoquetesDeProcessador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSoquetesDeProcessador.BackgroundImage")));
            this.pictureBoxSoquetesDeProcessador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSoquetesDeProcessador.Location = new System.Drawing.Point(656, 195);
            this.pictureBoxSoquetesDeProcessador.Name = "pictureBoxSoquetesDeProcessador";
            this.pictureBoxSoquetesDeProcessador.Size = new System.Drawing.Size(70, 49);
            this.pictureBoxSoquetesDeProcessador.TabIndex = 8;
            this.pictureBoxSoquetesDeProcessador.TabStop = false;
            this.pictureBoxSoquetesDeProcessador.Visible = false;
            // 
            // pictureBoxDissipadorDeCalor
            // 
            this.pictureBoxDissipadorDeCalor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDissipadorDeCalor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDissipadorDeCalor.BackgroundImage")));
            this.pictureBoxDissipadorDeCalor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDissipadorDeCalor.Location = new System.Drawing.Point(757, 195);
            this.pictureBoxDissipadorDeCalor.Name = "pictureBoxDissipadorDeCalor";
            this.pictureBoxDissipadorDeCalor.Size = new System.Drawing.Size(70, 49);
            this.pictureBoxDissipadorDeCalor.TabIndex = 9;
            this.pictureBoxDissipadorDeCalor.TabStop = false;
            this.pictureBoxDissipadorDeCalor.Visible = false;
            // 
            // pictureBoxFonteDeAlimentacao
            // 
            this.pictureBoxFonteDeAlimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxFonteDeAlimentacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFonteDeAlimentacao.BackgroundImage")));
            this.pictureBoxFonteDeAlimentacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFonteDeAlimentacao.Location = new System.Drawing.Point(863, 195);
            this.pictureBoxFonteDeAlimentacao.Name = "pictureBoxFonteDeAlimentacao";
            this.pictureBoxFonteDeAlimentacao.Size = new System.Drawing.Size(70, 49);
            this.pictureBoxFonteDeAlimentacao.TabIndex = 10;
            this.pictureBoxFonteDeAlimentacao.TabStop = false;
            this.pictureBoxFonteDeAlimentacao.Visible = false;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 648);
            this.Controls.Add(this.pictureBoxFonteDeAlimentacao);
            this.Controls.Add(this.pictureBoxDissipadorDeCalor);
            this.Controls.Add(this.pictureBoxSoquetesDeProcessador);
            this.Controls.Add(this.pictureBoxDisplayParaIHM);
            this.Controls.Add(this.pictureBoxCristaisDeClock);
            this.Controls.Add(this.pictureBoxMemoriasFlash);
            this.Controls.Add(this.pictureBoxProcessador);
            this.Controls.Add(this.tabelaItens);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.label1);
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemoriasFlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCristaisDeClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayParaIHM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoquetesDeProcessador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDissipadorDeCalor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFonteDeAlimentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoRemover;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.DataGridView tabelaItens;
        private System.Windows.Forms.PictureBox pictureBoxProcessador;
        private System.Windows.Forms.PictureBox pictureBoxMemoriasFlash;
        private System.Windows.Forms.PictureBox pictureBoxCristaisDeClock;
        private System.Windows.Forms.PictureBox pictureBoxDisplayParaIHM;
        private System.Windows.Forms.PictureBox pictureBoxSoquetesDeProcessador;
        private System.Windows.Forms.PictureBox pictureBoxDissipadorDeCalor;
        private System.Windows.Forms.PictureBox pictureBoxFonteDeAlimentacao;
    }
}