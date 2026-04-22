using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19390
{
    public class Banco
    {
        public static MySqlConnection conexao; //variavel para conexão com o banco de dados

        public static MySqlCommand comando; // variavel para comandos SQL

        public static MySqlDataAdapter adaptador; // variavel para adaptar os dados do banco para o DataTable

        public static DataTable datTabela; //  variavel para armazenar os dados em forma de tabela
        internal static object conexão;

        public static object Conexao { get; private set; }

        public static void AbrirConexao() //método para abrir a conexão com o banco de dados
        {
            try
            {
                conexao = new MySqlConnection("server=localhost; port=3307; uid=root; pwd=etecjau; ");

                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao conectar com o banco de dados. \n\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void FecharConexao() //método para fechar a conexão com o banco de dados
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao desconectar com o banco de dados. \n\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {

            try
                {
                AbrirConexao(); //chama o método para abrir a conexão com o banco de dados

                comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS VENDAS; USE VENDAS", conexao); //cria o banco de dados VENDAS se ele não existir
                comando.ExecuteNonQuery();//executa o comando SQL

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS CIDADES " +
                    "(ID INTEGER AUTO_INCREMENT PRIMARY KEY," +
                    " NOME VARCHAR(40)," +
                    " UF CHAR(02)) ", conexao); // cria a tabela CIDADES se ela não existir e define suas colunas
                comando.ExecuteNonQuery();//executa o comando SQL

                FecharConexao(); //chama o método para fechar a conexão com o banco de dados
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao criar o banco de dados. \n\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                AbrirConexao(); //chama o método para abrir a conexão com o banco de dados
                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS USUARIOS " +
                    "(ID INTEGER AUTO_INCREMENT PRIMARY KEY, "+
                    "NOME VARCHAR(50), " +
                    "LOGIN VARCHAR(30), " +
                    "SENHA VARCHAR(20), " +
                    "FUNCAO VARCHAR(50)) ", conexao);
                comando.ExecuteNonQuery();
             

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categorias " +
                    "(id integer auto_increment primary key, " +
                    "categoria char(20))", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS CLIENTES " +
                    "(id integer auto_increment primary key, " +
                    "nome char(40), " +
                    "idCidade integer,  " +
                    "dataNasc date, " +
                    "renda decimal(10,2), " +
                    "cpf char(14), " +
                    "foto varchar(100), " +
                    "venda boolean)", conexao);

                comando.ExecuteNonQuery();


                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Produtos " +
                    "(Id integer auto_increment primary key," +
                    "descricao char(40), " +
                    "idCategoria integer," +
                    "idMarca integer," +
                    "estoque decimal(10,3), " +
                    "foto varchar(100))", conexao);
                comando.ExecuteNonQuery();

                FecharConexao();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao criar o TABELA USUARIOS. \n\n", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            try
            {
                AbrirConexao(); //chama o método para abrir a conexão com o banco de dados
                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VENDAS_CAB " +
                    "(id integer auto_increment primary key, " +
                       "id_cliente integer, " +
                       "data date, " +
                       "total decimal(10,2))", conexao);

                comando.ExecuteNonQuery();
                FecharConexao();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao criar tabela vendas_CAB");
            }

            try
            {
                AbrirConexao(); //chama o método para abrir a conexão com o banco de dados
                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VENDAS_DET " +
                    "(id integer auto_increment primary key, " +
                       "id_vendas integer, " +
                       "id_produto integer," +
                       "qtde decimal(10,3), " +
                       "vlr_unit decimal(10,2))", conexao);

                comando.ExecuteNonQuery();
                FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao criar tabela vendas_DET");
            }




        }


    }//class Banco
}//namespace _19390
 