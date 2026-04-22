using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19390.Models
{
    internal class VendaCab
    {
        public int Id { get; set; }
        public int idCliente { get; set; }
        public DateTime data { get; set; }
        public double total { get; set; }

        public int Incluir()
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand(
                    "INSERT INTO vendaCab (idCliente, data, total)" +
                    "VALUES (@idCLiente, @data, @total)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@idCliente", idCliente);
                Banco.comando.Parameters.AddWithValue("@data", data);
                Banco.comando.Parameters.AddWithValue("@total", total);
                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
                return (int)Banco.comando.LastInsertedId;
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
