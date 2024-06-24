using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gragas_Solution_2
{
    public partial class telaRegistro : Form
    {
        public telaRegistro()
        {
            InitializeComponent();
        }
        private void telaRegistro_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }






        /* BOTÃO DE REGISTRAR ,ELE TEM UMA LÓGICA QUE GRAVA OS DADOS DIGITADOS NO BANCO DE DADOS , SOMENTE DEPOIS
        O USUÁRIO SE CADASTRAR AQUI , SERÁ POSSÍVEL ACESSAR O SISTEMA */
        private void botaoRegistrar_Click(object sender, EventArgs e)
        {
            string nome = textoNome.Text;
            string login = textoLogin.Text;
            string senha = textoSenha.Text;


            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string connectionString = "server=localhost;database=gragas_solutions;user=root;password=123456789";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO usuarios (nome,login, senha) VALUES (@nome,@login, @senha)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cadastro realizado com sucesso!");
        }
        








        // BOTAO PARA ACESSAR A TELA "login"
        private void button1_Click(object sender, EventArgs e)

        {
            // Exibe a Tela Adicionar
            telaLogin mostrarTela = new telaLogin();
            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }







        // MÉTODOS INUTILIZADOS
        private void textoAdicionar_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

        
    

