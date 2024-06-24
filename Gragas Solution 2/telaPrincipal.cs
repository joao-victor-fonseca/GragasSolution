using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gragas_Solution_2
{
    public partial class telaPrincipal : Form
    {


        /* NESSE MÉTODO, COLOQUEI UMA RESTRIÇÃO QUE FAZ COM QUE AS PICTURE BOXES DOS ITENS SEMPRE COMECEM INVISIVEIS,
        E ELAS SÓ SE TORNARÃO VISIVEIS DEPOIS QUE A CONDIÇÃO FOR ATINGIDA */
        public telaPrincipal()
        {
            InitializeComponent();
            pictureBoxProcessador.Visible = false;
            pictureBoxMemoriasFlash.Visible = false;
            pictureBoxCristaisDeClock.Visible = false;
            pictureBoxDisplayParaIHM.Visible = false;
            pictureBoxSoquetesDeProcessador.Visible = false;
            pictureBoxDissipadorDeCalor.Visible = false;
            pictureBoxFonteDeAlimentacao.Visible = false;
        }

       





        // ASSIM QUE O PROGRAMA É EXECUTADO , ESSE MÉTODO JÁ PUXA O "LoadItens" FAZENDO COM QUE OS ITENS SEJAM EXIBIDOS NA TELA
        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            
            this.CenterToScreen();
            pictureBoxProcessador.Visible = false;
            pictureBoxMemoriasFlash.Visible = false;
            pictureBoxCristaisDeClock.Visible = false;
            pictureBoxDisplayParaIHM.Visible = false;
            pictureBoxSoquetesDeProcessador.Visible = false;
            pictureBoxDissipadorDeCalor.Visible = false;
            pictureBoxFonteDeAlimentacao.Visible = false;
            LoadItens();
            AtualizarAlertas();
            AtualizarAlertaMemoriaFlash();
            telaRemover.EstoqueAtualizado += AtualizarAlertas;
        }

      
        // MÉTODO QUE FAZ A CONEXÃO COM O BANCO DE DADOS E PUXA OS ELEMENTOS DA TABELA "itens" E EXIBE NA TELA PARA O USUARIO
        private void LoadItens()
        {
            string dbConnectionString = "server=localhost;uid=root;pwd=123456789;database=gragas_solutions";
            using (var dbConnection = new MySqlConnection(dbConnectionString))
            {
                try
                {
                    dbConnection.Open();
                    string query = "SELECT * FROM itens";
                    using (var cmd = new MySqlCommand(query, dbConnection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            tabelaItens.DataSource = dataTable;

                            // Torna a coluna "id" invisível
                            if (tabelaItens.Columns["id"] != null)
                            {
                                tabelaItens.Columns["id"].Visible = false;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }



        /* ESSE MÉTODO É O SISTEMA DE ALERTA , ELE TEM UMA CONDICAO QUE SE A QUANTIDADE DO ITEM FICAR EM MENOS DE 30 ,
         EXIBE UMA PICTURE BOX DE ALERTA NA TELA */
        public void AtualizarAlertas()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456789;database=gragas_solutions";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string[] itens = { "processador", "cristais_de_clock", "display_para_IHM", "soquetes_de_processador", "dissipador_de_calor", "fonte_de_alimentacao" };
                PictureBox[] pictureBoxes = { pictureBoxProcessador,pictureBoxCristaisDeClock, pictureBoxDisplayParaIHM, pictureBoxSoquetesDeProcessador, pictureBoxDissipadorDeCalor, pictureBoxFonteDeAlimentacao };

                for (int i = 0; i < itens.Length; i++)
                {
                    string query = $"SELECT {itens[i]} FROM itens WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        int quantidadeAtual = Convert.ToInt32(comando.ExecuteScalar());
                        pictureBoxes[i].Visible = quantidadeAtual <= 30;
                    }
                }
            }
        }








        // MESMA FUNÇÃO DO ALERTA DO CIMA , PORÉM ESSE É PROPRIO PRA MEMORIA FLASH, POIS O LIMITE DELA É 60
        public void AtualizarAlertaMemoriaFlash()
        {
            string connectionString = "server=localhost;uid=root;pwd=123456789;database=gragas_solutions";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string[] itens = { "memorias_flash" };
                PictureBox[] pictureBoxes = { pictureBoxMemoriasFlash };

                for (int i = 0; i < itens.Length; i++)
                {
                    string query = $"SELECT {itens[i]} FROM itens WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        int quantidadeAtual = Convert.ToInt32(comando.ExecuteScalar());
                        pictureBoxes[i].Visible = quantidadeAtual <= 60;
                    }
                }
            }
        }



       




        // MÉTODO QUE ACESSA A TELA DE ADICIONAR ITENS
        private void button2_Click(object sender, EventArgs e)
        {
            // Exibe a Tela Adicionar
            telaAdicionar mostrarTela = new telaAdicionar();
            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }









        // MÉTODO QUE ACESSA A TELA DE REMOVER ITENS 
        private void button1_Click(object sender, EventArgs e)
        {
            telaRemover mostrarTela = new telaRemover();
            mostrarTela.Show();          
            this.Hide();
        }





      



        // A TABELA DATAGRIDVIEW
        private void tabelaItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }










        // MÉTODOS INUTILIZADOS
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxProcessador_Click(object sender, EventArgs e)
        {

        }
    }
}
