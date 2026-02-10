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
    public partial class FrmUsuarios : Form
    {
        Usuario u;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        void limpacontroles()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtFuncao.Clear();
            txtNome.Focus();
        }

        void carregaGrid(string pesquisa)
        {
            u = new Usuario()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = u.Consultar();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            limpacontroles();
            carregaGrid("");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
