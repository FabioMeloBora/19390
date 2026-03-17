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
using _19390.Views;

namespace _19390
{
    public partial class FrmMenu: Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco(); //chama a classe Banco e o método CriarBanco ao carregar o formulário
        }

       

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios form = new FrmUsuarios();
            form.Show();
        }

        private void CidadeStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmCidades form = new FrmCidades();
            form.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClientes form = new FrmClientes();
            form.Show();
        }
    }
}
