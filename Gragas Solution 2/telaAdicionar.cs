using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gragas_Solution_2
{
    public partial class telaAdicionar : Form
    {
        public telaAdicionar()
        {
            InitializeComponent();
        }
        private void telaAdicionar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }







        /* ESTE É O BOTAO DE ADICIONAR ITEM, ELE TEM VÁRIAS CONDIÇÕES INTELIGENTES DENTRO DELE, PARA EVITAR QUE O USUÁRIO
        CAUSE BUGS USANDO O PROGRAMA */
        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            // Verifica se nenhum item está selecionado
            if (listaAdicionar.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione um item");
                return; // Sai do método se nenhum item estiver selecionado
            }

            int ValorAdd = int.Parse(textoQuantidade.Text); // Valor inserido na caixa transformado em int e depois na variavel
            string selectedItem = listaAdicionar.SelectedItem.ToString();

            string connectionString = "server=localhost;uid=root;pwd=123456789;database=gragas_solutions";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string query = "";

                // Determina a query a ser usada com base no item selecionado
                switch (selectedItem)
                {
                    case "Processadores":
                        query = "UPDATE itens SET processador = processador + @ValorAdd WHERE id = 1;";
                        break;
                    case "Memorias Flash":
                        query = "UPDATE itens SET memorias_flash = memorias_flash + @ValorAdd WHERE id = 1;";
                        break;
                    case "Cristais de Clock":
                        query = "UPDATE itens SET cristais_de_clock = cristais_de_clock + @ValorAdd WHERE id = 1;";
                        break;
                    case "Display para IHM":
                        query = "UPDATE itens SET display_para_IHM = display_para_IHM + @ValorAdd WHERE id = 1;";
                        break;
                    case "Soquetes de Processador":
                        query = "UPDATE itens SET soquetes_de_processador = soquetes_de_processador + @ValorAdd WHERE id = 1;";
                        break;
                    case "Dissipador de Calor":
                        query = "UPDATE itens SET dissipador_de_calor = dissipador_de_calor + @ValorAdd WHERE id = 1;";
                        break;
                    case "Fonte de Alimentação":
                        query = "UPDATE itens SET fonte_de_alimentacao = fonte_de_alimentacao + @ValorAdd WHERE id = 1;";
                        break;
                    default:
                        MessageBox.Show("Item desconhecido");
                        return; // Sai do método se o item não for reconhecido
                }

                using (MySqlCommand comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@ValorAdd", ValorAdd);
                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Itens adicionados ao estoque");
        }










        // IMPOSSIBILITA O USUÁRIO DE DIGITAR QUALQUER CARACTERE
        private void textoAdicionar_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verifica se a tecla pressionada não é um dígito (número) nem o backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Se a tecla pressionada não for um dígito, cancela o evento
                e.Handled = true;
            }

        }









        // BOTÃO DE VOLTAR PARA A TELA PRINCIPAL
        private void button1_Click(object sender, EventArgs e)
        {
            // Exibe a Tela Adicionar
            telaPrincipal mostrarTela = new telaPrincipal();
            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }






        

        

        

        
        // MÉTODOS INUTILIZADOS 

        private void listaAdicionar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textoAdicionar_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
