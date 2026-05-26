using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _19390.Models
{
    internal class NegociacaoVenda
    {
        public int id { get; set; }

        public int idVenda { get; set; }

        public byte parcela { get; set; }

        public DateTime data_vencto { get; set; }

        public DateTime data_pagto { get; set; }

        public double vlr_parcela { get; set; }

        public Boolean status { get; set; } 

        public void Incluir()
        {
            try
            {
                //abre conexao com banco
                Banco.AbrirConexao();
                //alimenta metodo command com a instrução desejada e indicada 
                Banco.comando = new MySqlCommand("INSERT INTO contas_receber (idVenda, parcela, data_vencto, " +
                    "vlr_parcela, status) " +
                    "VALUES (@idVenda, @parcela, @data_vencto, @vlr_parcela, @status)", Banco.conexao);
                //cria os parametros necessários para a execução do comando
                Banco.comando.Parameters.AddWithValue("@idVenda", idVenda);
                Banco.comando.Parameters.AddWithValue("@parcela", parcela);
                Banco.comando.Parameters.AddWithValue("@data_vencto", data_vencto);
                Banco.comando.Parameters.AddWithValue("@vlr_parcela", vlr_parcela);
                Banco.comando.Parameters.AddWithValue("@status", status);
                //executa o comando no sql, tem a função do raio do workbench
                Banco.comando.ExecuteNonQuery();
                //fecha a conexao com o banco
                Banco.FecharConexao();
            }

            catch(Exception e)
            {
                MessageBox.Show( e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
