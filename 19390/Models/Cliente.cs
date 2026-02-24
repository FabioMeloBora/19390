using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19390.Models
{
    internal class Cliente
    {

        public int id { get; set; }
        public string nome { get; set; }
         public int idCidade { get; set; }
        public DateTime dataNasc { get; set; }
        public double renda { get; set; }
        public string cpf { get; set; }

        public string foto { get; set; }

        public bool venda { get; set; }

        public DataTable Consultar()
        {
            try
            {
                Banco.comando = new MySqlCommand("SELECT cl.*, ci.nome cidade, " +
                    "ci.uf FROM Clientes cl inner join Cidades ci on (ci.id = cl.idCidade) " +
                    "where cl.nome like ?Nome order by cl.nome", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@Nome", nome + "%");
                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datTabela = new DataTable();
                Banco.adaptador.Fill(Banco.datTabela);
                return Banco.datTabela;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Incluir()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand
                    ("INSERT INTO clientes (nome, idCidade, dataNasc, renda, cpf, foto, venda) " +
                    "VALUES (@nome,  @idCidade, @dataNasc, @renda, @cpf, @foto, @venda)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("idCidade", idCidade);
                Banco.comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.comando.Parameters.AddWithValue("@renda", renda);
                Banco.comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.comando.Parameters.AddWithValue("@foto", foto);
                Banco.comando.Parameters.AddWithValue("venda", venda);
                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand
                    ("UPDATE cliente SET nome = @nome, idCidae = @idCidade, dataNasc = @dataNasc, " +
                    "renda = @renda, cpf = @cpf, foto = @foto, venda = @venda where id = @id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("idCidade", idCidade);
                Banco.comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.comando.Parameters.AddWithValue("@renda", renda);
                Banco.comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.comando.Parameters.AddWithValue("@foto", foto);
                Banco.comando.Parameters.AddWithValue("venda", venda);
                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
