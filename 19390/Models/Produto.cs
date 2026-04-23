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

   


    public class Produto
    {
       
            public int id { get; set; }
            public string descricao { get; set; }
            public int idCategoria { get; set; }
            public int idMarca { get; set; }
            public double estoque { get; set; }
            public double valorVenda { get; set; }
            public string foto { get; set; }

        

        public DataTable Consultar()
        {
            try
            {
                Banco.comando = new MySqlCommand("SELECT p.*, m.marca, c.categoria FROM Produtos p " +
                    "INNER JOIN Marcas m ON m.id = p.idMarca " +
                    "INNER JOIN Categorias c ON c.id = p.idCategoria " +
                    "WHERE p.descricao LIKE @Descricao ORDER BY p.descricao", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@Descricao", descricao + "%");
                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datTabela = new DataTable();
                Banco.adaptador.Fill(Banco.datTabela);

                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void atualizarEstoque(double qtde)
        {
            try
            {
                Banco.AbrirConexao();

                Banco.comando = new MySqlCommand(
                    "UPDATE produtos SET Estoque = Estoque - @qtde WHERE id = @id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@qtde", qtde);
                Banco.comando.Parameters.AddWithValue("@id", id);

                Banco.comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
