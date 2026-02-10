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
    internal class Usuario
    {
        public int Id { get; set; }

        public string nome { get; set; }
        public string senha { get; set; }

        public string login { get; set; }

        public string funcao { get; set; }


        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("INSERT INTO USUARIOS (NOME, LOGIN, SENHA, FUNCAO )" +
                                                "VALUES " +
                                                "(@NOME, @LOGIN, @SENHA, @FUNCAO)", Banco.conexao);


                Banco.comando.Parameters.AddWithValue("@NOME", nome);
                Banco.comando.Parameters.AddWithValue("@UF", login);
                Banco.comando.Parameters.AddWithValue("@SENHA", senha);
                Banco.comando.Parameters.AddWithValue("@FUNCAO", funcao);
                Banco.comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao incluir usuario. \n\n" + ex.Message);
            }
        }


        public DataTable Consultar()
        {

            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("SELECT * FROM USUARIOS " +
                                                "WHERE NOME LIKE @NOME " +
                                                "ORDER BY NOME", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@NOME", nome);

                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datTabela = new DataTable();
                Banco.adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar Usuário. \n\n" + ex.Message);
            }
            return Banco.datTabela;

        }
    }
}
