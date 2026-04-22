using Org.BouncyCastle.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _19390.Models
{
        public class VendaDet
        {
            public int Id { get; set; }
            public int idVendaCab { get; set; }
            public int idProduto { get; set; }
            public double qtde { get; set; }
            public double valorUnitario { get; set; }  
        
            public void Incluir()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand(
                "INSERT INTO vendaDet (idVendaCab, idProduto, qtde, valorUnitario)" +
                "VALUES (@idVendaCab, @idProduto, @qtde, @valorUnitario)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@idVendaCab", idVendaCab);
                Banco.comando.Parameters.AddWithValue("@idProduto", idProduto);
                Banco.comando.Parameters.AddWithValue("@qtde", qtde);
                Banco.comando.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                Banco.comando.ExecuteNonQuery();
                    Banco.conexao.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }



}
