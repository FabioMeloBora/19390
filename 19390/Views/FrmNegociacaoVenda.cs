using _19390.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19390.Views
{
    public partial class FrmNegociacaoVenda : Form
    {
        double total, entrada = 0, parcela;

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            calcularParcela();
        }

        public FrmNegociacaoVenda(int idVenda, int idCliente, double total, string nome)
        {
            InitializeComponent();
            txtIdVenda.Text = idVenda.ToString();
            txtIdCliente.Text = idCliente.ToString();
            txtNome.Text = nome;
            txtTotal.Text = total.ToString("C");
            txtData.Text = DateTime.Now.ToShortDateString();
            dtpVencto.Value = DateTime.Now.AddMonths(1);
            this.total = total;

            calcularParcela();
        }

        private void nudQtdeParcela_ValueChanged(object sender, EventArgs e)
        {
            calcularParcela();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            for(byte NumPar = 0; NumPar < nudQtdeParcela.Value; NumPar++)
            {
                NegociacaoVenda n = new NegociacaoVenda()
                {
                  idVenda = Convert.ToInt16(txtIdVenda.Text),
                    parcela = Convert.ToByte(NumPar + 1),
                      data_vencto = dtpVencto.Value.AddMonths(NumPar),
                       vlr_parcela = parcela,
                        status = false
                };

               n.Incluir();
            }

            Close();
        }

        void calcularParcela()
        {
            double saldo = total - entrada;
            if (txtEntrada.Text != "") entrada = double.Parse(txtEntrada.Text);
            parcela = saldo / Convert.ToByte(nudQtdeParcela.Value);
            lblSaldo.Text = saldo.ToString("C");
            lblVlrParcela.Text = parcela.ToString("C");
        }
        private void FrmNegociacaoVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
