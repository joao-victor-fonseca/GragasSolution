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
    public partial class telaRemover : Form
    {

        /* ISSO AQUI É UM EVENTO QUE FAZ UMA CONEXÃO COM A TELA "telaPrincipal" ,  A FUNÇÃO DISSO É ATUALIZAR 
         O ESTOQUE EM TEMPO REAL PARA QUE O ALERTA SEJA EMITIDO*/
        public static event Action EstoqueAtualizado;
      
        
        public telaRemover()
        {
            InitializeComponent();
        }
        private void telaRemover_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        
        
        
        



        
        /* NESSE MÉTODO TEM UMA LOGICA EXTREMAMENTE COMPLEXA DE REMOÇÃO DOS ITENS , NÃO DEIXA REMOVER UMA QUANTIDADE
         MAIOR DE ITENS DO QUE A QUE VOCÊ POSSUI NO ESTOQUE, E ALÉM DISSO TAMBÉM ATIVA O ALERTA , ATUALIZANDO EM TEMPO
        REAL A QUANTIDADE DE ITENS NA TABELA */
        private void botaoAdicionarEstoque_Click(object sender, EventArgs e)
        {
            // Verifica se nenhum item está selecionado
            if (listaRemover.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione um item");
                return; // Sai do método se nenhum item estiver selecionado
            }

            int ValorRemover = int.Parse(textoQuantidade.Text); // Valor inserido na caixa transformado em int e depois na variavel
            string selectedItem = listaRemover.SelectedItem.ToString();

            string connectionString = "server=localhost;uid=root;pwd=123456789;database=gragas_solutions";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string querySelect = "";
                string queryUpdate = "";
                string columnName = "";

                // Determina a query de seleção e a coluna com base no item selecionado
                switch (selectedItem)
                {
                    case "Processadores":
                        columnName = "processador";
                        break;
                    case "Memorias Flash":
                        columnName = "memorias_flash";
                        break;
                    case "Cristais de Clock":
                        columnName = "cristais_de_clock";
                        break;
                    case "Display para IHM":
                        columnName = "display_para_IHM";
                        break;
                    case "Soquetes de Processador":
                        columnName = "soquetes_de_processador";
                        break;
                    case "Dissipador de Calor":
                        columnName = "dissipador_de_calor";
                        break;
                    case "Fonte de Alimentação":
                        columnName = "fonte_de_alimentacao";
                        break;
                    default:
                        MessageBox.Show("Item desconhecido");
                        return; // Sai do método se o item não for reconhecido
                }

                // Query para obter a quantidade atual
                querySelect = $"SELECT {columnName} FROM itens WHERE id = 1;";
                queryUpdate = $"UPDATE itens SET {columnName} = {columnName} - @ValorRemover WHERE id = 1;";

                using (MySqlCommand comandoSelect = new MySqlCommand(querySelect, conexao))
                {
                    int quantidadeAtual = Convert.ToInt32(comandoSelect.ExecuteScalar());

                    if (ValorRemover > quantidadeAtual)
                    {
                        MessageBox.Show($"Você só pode remover {quantidadeAtual} desse item.");
                        return; // Sai do método se a quantidade a ser removida for maior do que a disponível
                    }
                }

                using (MySqlCommand comandoUpdate = new MySqlCommand(queryUpdate, conexao))
                {
                    comandoUpdate.Parameters.AddWithValue("@ValorRemover", ValorRemover);
                    comandoUpdate.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Itens removidos do estoque");
            EstoqueAtualizado?.Invoke();
        }








        //BOTAO DE VOLTAR PARA A TELA PRINCIPAL
        private void button1_Click(object sender, EventArgs e)
        {
            telaPrincipal mostrarTela = new telaPrincipal();
            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listaRemover_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textoQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
