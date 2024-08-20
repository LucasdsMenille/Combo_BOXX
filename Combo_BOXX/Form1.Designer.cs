namespace Combo_BOXX
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(138, 24);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(457, 20);
            this.txtTexto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Índice do combo:";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(138, 479);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(457, 20);
            this.txtIndice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto do Combo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(138, 518);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(457, 20);
            this.txtConteudo.TabIndex = 4;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(252, 415);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(147, 42);
            this.btnExibir.TabIndex = 6;
            this.btnExibir.Text = "Exibir Dados do Combo";
            this.btnExibir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade de itens:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(334, 334);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(13, 13);
            this.lblQtde.TabIndex = 8;
            this.lblQtde.Text = "0";
            // 
            // cboLista
            // 
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(110, 204);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(433, 21);
            this.cboLista.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lista: ";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(252, 271);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(147, 42);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover do Combo";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(337, 105);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(147, 42);
            this.btnOrdenar.TabIndex = 12;
            this.btnOrdenar.Text = "Ordenar o Combo";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(149, 105);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(147, 42);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir o Combo";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 572);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnInserir;
    }
}

