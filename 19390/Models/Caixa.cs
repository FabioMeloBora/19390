using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19390.Models
{
    internal class Caixa
    {
        public int idCliente { get; set; }
        public string nomeCliente { get; set; }
        public int idVenda { get; set; }
        public double valor { get; set; }
        public double valorDinheiro { get; set; }
        public double valorCheque { get; set; }
        public double valorCartao { get; set; }
        public double valorPix { get; set; }
        public double valorBoleto { get; set; }
        public double troco { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySql.Data.MySqlClient.MySqlCommand(
                    "INSERT INTO caixa (idCliente, nomeCliente, idVenda, valor, valorDinheiro, valorCheque, valorCartao, valorPix, valorBoleto, troco) " +
                    "VALUES (@idCliente, @nomeCliente, @idVenda, @valor, @valorDinheiro, @valorCheque, @valorCartao, @valorPix, @valorBoleto, @troco)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@idCliente", idCliente);
                Banco.comando.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                Banco.comando.Parameters.AddWithValue("@idVenda", idVenda);
                Banco.comando.Parameters.AddWithValue("@valor", valor);
                Banco.comando.Parameters.AddWithValue("@valorDinheiro", valorDinheiro);
                Banco.comando.Parameters.AddWithValue("@valorCheque", valorCheque);
                Banco.comando.Parameters.AddWithValue("@valorCartao", valorCartao);
                Banco.comando.Parameters.AddWithValue("@valorPix", valorPix);
                Banco.comando.Parameters.AddWithValue("@valorBoleto", valorBoleto);
                Banco.comando.Parameters.AddWithValue("@troco", troco);
                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
