namespace _19390.Views
{
    partial class FrmCaixa
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
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.txtPIX = new System.Windows.Forms.TextBox();
            this.txtBoleto = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(118, 22);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(102, 22);
            this.txtIdCliente.TabIndex = 0;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(252, 22);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(370, 22);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(118, 64);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(102, 22);
            this.txtVenda.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(310, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(102, 22);
            this.txtValor.TabIndex = 3;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(252, 125);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(233, 22);
            this.txtDinheiro.TabIndex = 4;
            // 
            // txtCheque
            // 
            this.txtCheque.Location = new System.Drawing.Point(252, 166);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(233, 22);
            this.txtCheque.TabIndex = 5;
            // 
            // txtCartao
            // 
            this.txtCartao.Location = new System.Drawing.Point(252, 214);
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(233, 22);
            this.txtCartao.TabIndex = 6;
            // 
            // txtPIX
            // 
            this.txtPIX.Location = new System.Drawing.Point(252, 258);
            this.txtPIX.Name = "txtPIX";
            this.txtPIX.Size = new System.Drawing.Size(233, 22);
            this.txtPIX.TabIndex = 7;
            // 
            // txtBoleto
            // 
            this.txtBoleto.Location = new System.Drawing.Point(252, 304);
            this.txtBoleto.Name = "txtBoleto";
            this.txtBoleto.Size = new System.Drawing.Size(233, 22);
            this.txtBoleto.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(252, 356);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(233, 22);
            this.textBox10.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "TROCO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "CLIENTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "VENDA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "VALOR:";
            // 
            // btnCaixa
            // 
            this.btnCaixa.Image = global::_19390.Properties.Resources.pngwing;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaixa.Location = new System.Drawing.Point(461, 384);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(186, 54);
            this.btnCaixa.TabIndex = 10;
            this.btnCaixa.Text = "Realizar Pagamento";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::_19390.Properties.Resources.PagtoDinheiro;
            this.button1.Location = new System.Drawing.Point(171, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.txtBoleto);
            this.Controls.Add(this.txtPIX);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.txtCheque);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Name = "FrmCaixa";
            this.Text = "Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.TextBox txtPIX;
        private System.Windows.Forms.TextBox txtBoleto;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}