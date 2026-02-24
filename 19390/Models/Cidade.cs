using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace _19390.Models
{
    public class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }


        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("INSERT INTO CIDADES (NOME, UF)" +
                                                "VALUES " +
                                                "(@NOME, @UF)", Banco.conexao);


                Banco.comando.Parameters.AddWithValue("@NOME", nome);
                Banco.comando.Parameters.AddWithValue("@UF", uf);
                Banco.comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao incluir cidade. \n\n" + ex.Message);
            }

        }

        public DataTable Consultar()
        {

            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("SELECT * FROM CIDADES " +
                                                "WHERE NOME LIKE @NOME " +
                                                "ORDER BY NOME", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@NOME", nome + "%" );

                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datTabela = new DataTable();
                Banco.adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar cidade. \n\n" + ex.Message);
            }


            return Banco.datTabela;
        }

        public void Alterar()
        {
            try
            {
                //abre conexão
                Banco.AbrirConexao();
                //alimenta metodo comando
                Banco.comando = new MySqlCommand("UPDATE CIDADES SET NOME=@NOME, UF=@UF " +
                                                "WHERE ID=@ID", Banco.conexao);
                //cria os parametros utilizados no comando sql
                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("@uf", uf);
                Banco.comando.Parameters.AddWithValue("@id", id);
                //executa o comando sql
                Banco.comando.ExecuteNonQuery();
                //fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
              MessageBox.Show("Erro ao alterar cidade. \n\n" + ex.Message);
            }
        }

        public void Excluir()
        {
            try
            {
                //abre conexão com o banco de dados
                Banco.AbrirConexao();
                //alimenta o método comando com o comando sql com as instruções para excluir um registro
                Banco.comando = new MySqlCommand("delete from cidades where id = @id", Banco.conexao);
                //cria os parametros utilizados na instrução sql com seu respectivos cnteudo
                Banco.comando.Parameters.AddWithValue("@id", id);
                //executa o comando, no mysql, tem a função do raio do workbench
                Banco.comando.ExecuteNonQuery();
                //fecha conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

    }//fim class




}//fim namespace
