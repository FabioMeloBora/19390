using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _19390.Models;

namespace _19390.Views
{
    public partial class FrmVendas : Form
    {
        double total;

        Cliente c;
        Produto p;
        VendaCab vc;
        VendaDet vd;
   
        public FrmVendas()
        {
            InitializeComponent();
        }

        void LimpaProduto()
        {
            cboProdutos.SelectedIndex = -1;
            txtEstoque.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtMarca.Clear();
            txtCategoria.Clear();
            picProduto.ImageLocation = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvProdutos.RowCount = 0;
            cboCliente.SelectedIndex = -1;
            txtCidade.Clear();
            txtUF.Clear();
            txtRenda.Clear();
            mskCPF.Clear();
            mskDataNascimento.Clear();
            chkVenda.Checked = false;
            picCliente.ImageLocation = "";
            total = 0;
            lblTotal.Text = total.ToString("C");
            grbClientes.Enabled = true;
            grbProdutos.Enabled = false;
                LimpaProduto();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            c = new Cliente();
            cboCliente.DataSource = c.Consultar();
            cboCliente.DisplayMember = "nome";
            cboCliente.ValueMember = "id";

            p = new Produto();
            cboProdutos.DataSource = p.Consultar();
            cboProdutos.DisplayMember = "descricao";
            cboProdutos.ValueMember = "id";

            btnCancelar.PerformClick();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCliente.SelectedItem;
                txtCidade.Text = reg["CIDADE"].ToString();
                txtUF.Text = reg["UF"].ToString();
                txtRenda.Text = reg["RENDA"].ToString();
                mskCPF.Text = reg["CPF"].ToString();
                mskDataNascimento.Text = reg["DATANASC"].ToString();
                picCliente.ImageLocation = reg["FOTO"].ToString();
                chkVenda.Checked = (bool)reg["VENDA"];
            }
        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                if (chkVenda.Checked)
                {
                    MessageBox.Show("Cliente Bloqueado para Venda!", "Vendas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCancelar.PerformClick();
                    return;
                }
                grbClientes.Enabled = false;
                grbProdutos.Enabled = false;
            }
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProdutos.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboProdutos.SelectedItem;
                txtEstoque.Text = reg["estoque"].ToString();
                txtPreco.Text = reg["valorVenda"].ToString();
                txtMarca.Text = reg["Marca"].ToString();
                txtCategoria.Text = reg["Categoria"].ToString();
                picProduto.ImageLocation = reg["foto"].ToString();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(txtQuantidade.Text);
            double estoque = double.Parse(txtEstoque.Text);

            if(quantidade > estoque)
            {
                MessageBox.Show("Estoque insuficiente", "Vendas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.SelectAll();
                return;
            }
            dgvProdutos.Rows.Add(cboProdutos.SelectedValue, cboProdutos.Text,
                txtQuantidade.Text, txtPreco.Text);

            double preco = double.Parse(txtPreco.Text);
            total += quantidade * preco;
            lblTotal.Text = total.ToString();
            LimpaProduto();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.RowCount > 0)
            {
                double Quantidade = double.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());
                double preco = double.Parse(dgvProdutos.CurrentRow.Cells[3].Value.ToString());

                total -= Quantidade * preco;
                lblTotal.Text = total.ToString("C");

                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
            }
        }
    }
}
;