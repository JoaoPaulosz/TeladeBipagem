namespace TeladeBipagem
{
    partial class TelaInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoParada = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encerrar = new System.Windows.Forms.Button();
            this.finalizarParada = new System.Windows.Forms.Button();
            this.qtdeProduzir = new System.Windows.Forms.Label();
            this.totalProduzir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.etiqSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codOrdem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Operador = new System.Windows.Forms.Label();
            this.codOperador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeOperador = new System.Windows.Forms.Label();
            this.descProd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoParada
            // 
            this.botaoParada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoParada.Location = new System.Drawing.Point(13, 144);
            this.botaoParada.Name = "botaoParada";
            this.botaoParada.Size = new System.Drawing.Size(144, 32);
            this.botaoParada.TabIndex = 0;
            this.botaoParada.Text = "Informar Parada";
            this.botaoParada.UseVisualStyleBackColor = true;
            this.botaoParada.Click += new System.EventHandler(this.AbrirTelaMotivo);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.encerrar);
            this.groupBox1.Controls.Add(this.finalizarParada);
            this.groupBox1.Controls.Add(this.qtdeProduzir);
            this.groupBox1.Controls.Add(this.totalProduzir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.etiqSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.botaoParada);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(198, 67);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(17, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "/";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(361, 67);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "XXX";
            // 
            // encerrar
            // 
            this.encerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encerrar.Location = new System.Drawing.Point(454, 144);
            this.encerrar.Name = "encerrar";
            this.encerrar.Size = new System.Drawing.Size(123, 32);
            this.encerrar.TabIndex = 7;
            this.encerrar.Text = "Encerrar";
            this.encerrar.UseVisualStyleBackColor = true;
            // 
            // finalizarParada
            // 
            this.finalizarParada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finalizarParada.Location = new System.Drawing.Point(163, 144);
            this.finalizarParada.Name = "finalizarParada";
            this.finalizarParada.Size = new System.Drawing.Size(145, 32);
            this.finalizarParada.TabIndex = 6;
            this.finalizarParada.Text = "Finalizar Parada";
            this.finalizarParada.UseVisualStyleBackColor = true;
            this.finalizarParada.Click += new System.EventHandler(this.finalizarParada_Click);
            // 
            // qtdeProduzir
            // 
            this.qtdeProduzir.AutoSize = true;
            this.qtdeProduzir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qtdeProduzir.Location = new System.Drawing.Point(152, 67);
            this.qtdeProduzir.Name = "qtdeProduzir";
            this.qtdeProduzir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qtdeProduzir.Size = new System.Drawing.Size(40, 21);
            this.qtdeProduzir.TabIndex = 5;
            this.qtdeProduzir.Text = "XXX";
            // 
            // totalProduzir
            // 
            this.totalProduzir.AutoSize = true;
            this.totalProduzir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalProduzir.Location = new System.Drawing.Point(221, 67);
            this.totalProduzir.Name = "totalProduzir";
            this.totalProduzir.Size = new System.Drawing.Size(134, 21);
            this.totalProduzir.TabIndex = 4;
            this.totalProduzir.Text = "Qtde a Produzir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Qtde Produzida:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // etiqSearch
            // 
            this.etiqSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.etiqSearch.Location = new System.Drawing.Point(88, 24);
            this.etiqSearch.Name = "etiqSearch";
            this.etiqSearch.Size = new System.Drawing.Size(169, 29);
            this.etiqSearch.TabIndex = 1;
            this.etiqSearch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Etiqueta:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // codOrdem
            // 
            this.codOrdem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codOrdem.Location = new System.Drawing.Point(100, 12);
            this.codOrdem.Name = "codOrdem";
            this.codOrdem.Size = new System.Drawing.Size(113, 29);
            this.codOrdem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "OP:";
            // 
            // Operador
            // 
            this.Operador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Operador.Location = new System.Drawing.Point(11, 46);
            this.Operador.Name = "Operador";
            this.Operador.Size = new System.Drawing.Size(83, 20);
            this.Operador.TabIndex = 4;
            this.Operador.Text = "Operador:";
            // 
            // codOperador
            // 
            this.codOperador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codOperador.Location = new System.Drawing.Point(100, 43);
            this.codOperador.Name = "codOperador";
            this.codOperador.Size = new System.Drawing.Size(113, 29);
            this.codOperador.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pruduto:";
            // 
            // nomeOperador
            // 
            this.nomeOperador.AutoSize = true;
            this.nomeOperador.BackColor = System.Drawing.SystemColors.Control;
            this.nomeOperador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeOperador.ForeColor = System.Drawing.Color.Blue;
            this.nomeOperador.Location = new System.Drawing.Point(219, 46);
            this.nomeOperador.Name = "nomeOperador";
            this.nomeOperador.Size = new System.Drawing.Size(146, 21);
            this.nomeOperador.TabIndex = 9;
            this.nomeOperador.Text = "Nome do Operador";
            this.nomeOperador.Click += new System.EventHandler(this.DescMotivo_Click);
            // 
            // descProd
            // 
            this.descProd.AutoSize = true;
            this.descProd.BackColor = System.Drawing.SystemColors.Control;
            this.descProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descProd.ForeColor = System.Drawing.Color.Blue;
            this.descProd.Location = new System.Drawing.Point(100, 80);
            this.descProd.Name = "descProd";
            this.descProd.Size = new System.Drawing.Size(135, 21);
            this.descProd.TabIndex = 10;
            this.descProd.Text = "Nome do Produto";
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 304);
            this.Controls.Add(this.descProd);
            this.Controls.Add(this.nomeOperador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codOperador);
            this.Controls.Add(this.Operador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codOrdem);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaInicio";
            this.Text = "Produção por Bipagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoParada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox codOrdem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Operador;
        private System.Windows.Forms.TextBox codOperador;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label qtdeProduzir;
        private System.Windows.Forms.Label totalProduzir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox etiqSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encerrar;
        private System.Windows.Forms.Button finalizarParada;
        private System.Windows.Forms.Label nomeOperador;
        private System.Windows.Forms.Label descProd;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
    }
}
