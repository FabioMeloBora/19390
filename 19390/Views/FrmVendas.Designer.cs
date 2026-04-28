namespace _19390.Views
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbClientes = new System.Windows.Forms.GroupBox();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.bntConfirmar = new System.Windows.Forms.Button();
            this.txtRenda = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbClientes
            // 
            this.grbClientes.Controls.Add(this.chkVenda);
            this.grbClientes.Controls.Add(this.bntConfirmar);
            this.grbClientes.Controls.Add(this.txtRenda);
            this.grbClientes.Controls.Add(this.label6);
            this.grbClientes.Controls.Add(this.mskCPF);
            this.grbClientes.Controls.Add(this.label5);
            this.grbClientes.Controls.Add(this.mskDataNascimento);
            this.grbClientes.Controls.Add(this.picCliente);
            this.grbClientes.Controls.Add(this.txtUF);
            this.grbClientes.Controls.Add(this.txtCidade);
            this.grbClientes.Controls.Add(this.txtEndereco);
            this.grbClientes.Controls.Add(this.cboCliente);
            this.grbClientes.Controls.Add(this.label4);
            this.grbClientes.Controls.Add(this.label3);
            this.grbClientes.Controls.Add(this.label2);
            this.grbClientes.Controls.Add(this.label1);
            this.grbClientes.Location = new System.Drawing.Point(10, 11);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Size = new System.Drawing.Size(771, 188);
            this.grbClientes.TabIndex = 0;
            this.grbClientes.TabStop = false;
            this.grbClientes.Text = "grbClientes";
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(98, 162);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(124, 20);
            this.chkVenda.TabIndex = 15;
            this.chkVenda.Text = "Bloqueia venda";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // bntConfirmar
            // 
            this.bntConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConfirmar.Location = new System.Drawing.Point(563, 119);
            this.bntConfirmar.Name = "bntConfirmar";
            this.bntConfirmar.Size = new System.Drawing.Size(74, 63);
            this.bntConfirmar.TabIndex = 14;
            this.bntConfirmar.Text = "Confirmar";
            this.bntConfirmar.UseVisualStyleBackColor = false;
            this.bntConfirmar.Click += new System.EventHandler(this.bntConfirmar_Click);
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(429, 123);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(128, 22);
            this.txtRenda.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "RENDA:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(253, 123);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(115, 22);
            this.mskCPF.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF:";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(91, 123);
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(115, 22);
            this.mskDataNascimento.TabIndex = 9;
            // 
            // picCliente
            // 
            this.picCliente.Location = new System.Drawing.Point(643, 18);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(115, 150);
            this.picCliente.TabIndex = 8;
            this.picCliente.TabStop = false;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(556, 86);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(65, 22);
            this.txtUF.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(92, 86);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(455, 22);
            this.txtCidade.TabIndex = 6;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(92, 57);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(526, 22);
            this.txtEndereco.TabIndex = 5;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(92, 24);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(526, 24);
            this.cboCliente.TabIndex = 4;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.txtCategoria);
            this.grbProdutos.Controls.Add(this.txtMarca);
            this.grbProdutos.Controls.Add(this.label13);
            this.grbProdutos.Controls.Add(this.label12);
            this.grbProdutos.Controls.Add(this.picProduto);
            this.grbProdutos.Controls.Add(this.btnInserir);
            this.grbProdutos.Controls.Add(this.btnRemover);
            this.grbProdutos.Controls.Add(this.txtEstoque);
            this.grbProdutos.Controls.Add(this.txtPreco);
            this.grbProdutos.Controls.Add(this.txtQuantidade);
            this.grbProdutos.Controls.Add(this.cboProdutos);
            this.grbProdutos.Controls.Add(this.label10);
            this.grbProdutos.Controls.Add(this.label9);
            this.grbProdutos.Controls.Add(this.label8);
            this.grbProdutos.Controls.Add(this.label7);
            this.grbProdutos.Location = new System.Drawing.Point(12, 211);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(768, 152);
            this.grbProdutos.TabIndex = 1;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "gbrProdutos";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(96, 88);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(348, 22);
            this.txtCategoria.TabIndex = 14;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(96, 57);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(510, 22);
            this.txtMarca.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Marca:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Categoria:";
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(635, 21);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(120, 115);
            this.picProduto.TabIndex = 10;
            this.picProduto.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInserir.Location = new System.Drawing.Point(544, 88);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(84, 49);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRemover.Location = new System.Drawing.Point(450, 88);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(91, 49);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(348, 120);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(96, 22);
            this.txtEstoque.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(216, 120);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(67, 22);
            this.txtPreco.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(81, 120);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(82, 22);
            this.txtQuantidade.TabIndex = 5;
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(96, 23);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(510, 24);
            this.cboProdutos.TabIndex = 4;
            this.cboProdutos.SelectedIndexChanged += new System.EventHandler(this.cboProdutos_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Estoque:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Preço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Produtos:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(11, 385);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.Size = new System.Drawing.Size(768, 132);
            this.dgvProdutos.TabIndex = 2;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGravar.Location = new System.Drawing.Point(474, 541);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(93, 30);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(573, 541);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFechar.Location = new System.Drawing.Point(672, 541);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(93, 30);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotal.Location = new System.Drawing.Point(84, 549);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 22);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 554);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Total:";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 587);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbProdutos);
            this.Controls.Add(this.grbClientes);
            this.Name = "FrmVendas";
            this.Text = "FORMULÁRIO DE VENDAS";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.grbClientes.ResumeLayout(false);
            this.grbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.grbProdutos.ResumeLayout(false);
            this.grbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox txtRenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Button bntConfirmar;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.CheckBox chkVenda;
    }
}