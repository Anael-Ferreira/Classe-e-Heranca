namespace Portas_e_Moradores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.btnPorta = new System.Windows.Forms.Button();
            this.btnhabitacao = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.btnTudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(139, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(77, 104);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(139, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(23, 148);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base:";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(77, 141);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(139, 20);
            this.txtBase.TabIndex = 7;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(23, 111);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(77, 181);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(139, 20);
            this.txtCor.TabIndex = 9;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(23, 188);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 13);
            this.lblCor.TabIndex = 8;
            this.lblCor.Text = "Cor:";
            // 
            // btnPorta
            // 
            this.btnPorta.Location = new System.Drawing.Point(319, 64);
            this.btnPorta.Name = "btnPorta";
            this.btnPorta.Size = new System.Drawing.Size(113, 23);
            this.btnPorta.TabIndex = 10;
            this.btnPorta.Text = "Mostrar Porta";
            this.btnPorta.UseVisualStyleBackColor = true;
            this.btnPorta.Click += new System.EventHandler(this.btnPorta_Click);
            // 
            // btnhabitacao
            // 
            this.btnhabitacao.Location = new System.Drawing.Point(319, 106);
            this.btnhabitacao.Name = "btnhabitacao";
            this.btnhabitacao.Size = new System.Drawing.Size(113, 23);
            this.btnhabitacao.TabIndex = 11;
            this.btnhabitacao.Text = "Mostrar habitação";
            this.btnhabitacao.UseVisualStyleBackColor = true;
            this.btnhabitacao.Click += new System.EventHandler(this.btnhabitacao_Click);
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(319, 143);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(113, 23);
            this.btnPessoa.TabIndex = 12;
            this.btnPessoa.Text = "Mostrar Pessoa";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // btnTudo
            // 
            this.btnTudo.Location = new System.Drawing.Point(319, 179);
            this.btnTudo.Name = "btnTudo";
            this.btnTudo.Size = new System.Drawing.Size(113, 23);
            this.btnTudo.TabIndex = 13;
            this.btnTudo.Text = "Mostrar Tudo";
            this.btnTudo.UseVisualStyleBackColor = true;
            this.btnTudo.Click += new System.EventHandler(this.btnTudo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTudo);
            this.Controls.Add(this.btnPessoa);
            this.Controls.Add(this.btnhabitacao);
            this.Controls.Add(this.btnPorta);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnPorta;
        private System.Windows.Forms.Button btnhabitacao;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.Button btnTudo;
    }
}

