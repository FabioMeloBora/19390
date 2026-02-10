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
    public partial class FrmCidades: Form
    {
        Cidade c;

        public FrmCidades()
        {
            InitializeComponent();
        }

        void limpacontroles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtUF.Clear();
            txtNome.Focus();
        }

        void carregaGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.Consultar();
        }


        private void FrmCidades_Load(object sender, EventArgs e)
        {
           limpacontroles();
              carregaGrid("");  
        }
    }
}
