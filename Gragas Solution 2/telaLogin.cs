using Gragas_Solution_2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gragas_Solution_2
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }




        /* MÉTODO QUE É EXECUTADO ASSIM QUE O PROGRAMA É INSTANCIADO, ELE É RESPONSÁVEL POR CRIAR O BANCO DE DADOS ,
         E CRIAR AS TABELAS "usuarios" E "itens".*/
        private void telaLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            InitializeDatabase();            
        }









        /* ESSE MÉTODO É RESPONSÁVEL POR VERIFICAR SE AS TABELAS "usuarios" E "itens" JÁ EXISTEM, E CASO NÃO EXISTIREM ELE AS CRIA
            AUTOMATICAMENTE, JÁ INSERINDO AS QUANTIDADES NOS ITENS.  */
        public static void InitializeDatabase()
        {
            string serverConnectionString = "server=localhost;uid=root;pwd=123456789";
            string databaseName = "gragas_solutions";

            using (var serverConnection = new MySqlConnection(serverConnectionString))
            {
                try
                {
                    serverConnection.Open();

                    // Verificar se o banco de dados existe
                    string checkDatabaseQuery = $"SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{databaseName}'";
                    using (var cmdCheckDatabase = new MySqlCommand(checkDatabaseQuery, serverConnection))
                    {
                        var result = cmdCheckDatabase.ExecuteScalar();
                        if (result == null)
                        {
                            // Criar o banco de dados
                            string createDatabaseQuery = $"CREATE DATABASE {databaseName}";
                            using (var cmdCreateDatabase = new MySqlCommand(createDatabaseQuery, serverConnection))
                            {
                                cmdCreateDatabase.ExecuteNonQuery();
                            }
                        }
                    }

                    // Conectar ao banco de dados específico
                    string dbConnectionString = $"server=localhost;uid=root;pwd=123456789;database={databaseName}";
                    using (var dbConnection = new MySqlConnection(dbConnectionString))
                    {
                        dbConnection.Open();

                        // Verificar se a tabela "usuarios" existe e criá-la se não existir
                        string checkUsersTableQuery = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{databaseName}' AND TABLE_NAME = 'usuarios'";
                        using (var cmdCheckUsersTable = new MySqlCommand(checkUsersTableQuery, dbConnection))
                        {
                            var usersTableExists = Convert.ToInt32(cmdCheckUsersTable.ExecuteScalar()) > 0;
                            if (!usersTableExists)
                            {
                                string createUsersTableQuery = @"
                            CREATE TABLE usuarios (
                                id INT AUTO_INCREMENT PRIMARY KEY,
                                login VARCHAR(50) NOT NULL,
                                nome VARCHAR(100) NOT NULL,
                                senha VARCHAR(50) NOT NULL
                            )";
                                using (var cmdCreateUsersTable = new MySqlCommand(createUsersTableQuery, dbConnection))
                                {
                                    cmdCreateUsersTable.ExecuteNonQuery();
                                }
                            }
                        }

                        // Verificar se a tabela "itens" existe e criá-la se não existir
                        string checkItemsTableQuery = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{databaseName}' AND TABLE_NAME = 'itens'";
                        using (var cmdCheckItemsTable = new MySqlCommand(checkItemsTableQuery, dbConnection))
                        {
                            var itemsTableExists = Convert.ToInt32(cmdCheckItemsTable.ExecuteScalar()) > 0;
                            if (!itemsTableExists)
                            {
                                string createItemsTableQuery = @"
                            CREATE TABLE itens (
                                id INT AUTO_INCREMENT PRIMARY KEY,
                                processador INT NOT NULL,
                                memorias_flash INT NOT NULL,
                                cristais_de_clock INT NOT NULL,
                                display_para_IHM INT NOT NULL,
                                soquetes_de_processador INT NOT NULL,
                                dissipador_de_calor INT NOT NULL,
                                fonte_de_alimentacao INT NOT NULL
                                
                            )";
                                using (var cmdCreateItemsTable = new MySqlCommand(createItemsTableQuery, dbConnection))
                                {
                                    cmdCreateItemsTable.ExecuteNonQuery();
                                }

                                // Inserir quantidades iniciais de 300 para cada item
                                string insertInitialItemsQuery = @"
                            INSERT INTO itens (processador, memorias_flash, cristais_de_clock, display_para_IHM, soquetes_de_processador, dissipador_de_calor, fonte_de_alimentacao)
                            VALUES (300, 600, 300, 300, 300, 300, 300)";
                                using (var cmdInsertInitialItems = new MySqlCommand(insertInitialItemsQuery, dbConnection))
                                {
                                    cmdInsertInitialItems.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro de MySQL: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }










        // MÉTODO QUE ABRE A TELA PRINCIPAL DO PROGRAMA.   OBS: ESSE MÉTODO TAMBÉM TEM UMA LÓGICA DE AUTENTICAR LOGIN E SENHA !!
        private async void botaoLogin_Click(object sender, EventArgs e)

        {
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
                string query = "SELECT COUNT(*) FROM usuarios WHERE login=@login AND senha=@senha";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {

                        MessageBox.Show("Login realizado com sucesso!");
                        // Lógica para liberar o acesso

                        // Exibe a Tela Adicionar
                        telaPrincipal mostrarTela = new telaPrincipal();
                        mostrarTela.Show();

                        // Esconde a Tela Atual
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Login ou senha incorretos.");
                    }
                }
            }
      
        }









        // MÉTODO QUE ABRE A TELA DE REGISTRO
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaRegistro secondForm = new telaRegistro();
            secondForm.Show();

            // Esconde a LoginForm
            this.Hide();
        }



  





        // MÉTODOS INUTILIZADOS

        private void textoAdicionar_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        




    }
}

    




        