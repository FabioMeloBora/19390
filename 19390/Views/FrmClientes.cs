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
    public partial class FrmClientes : Form
    {

        Cidade ci;
        Cliente cl;

        void carregaGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            dgvClientes.DataSource = cl.Consultar();
        }
        void LimpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;

        }


        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //cria um objeto de tipo cidade
            //e alimenta o comboBox

            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            LimpaControles();
            carregaGrid("");

            //deixa invisivel colunas do grid
            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible = false;

        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "C:/fotos/clientes";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;

            cl = new Cliente()
            {
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked
            };
            cl.Incluir();

            LimpaControles();
            carregaGrid("");
        }
    }
}
