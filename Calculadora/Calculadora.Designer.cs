namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.painel = new System.Windows.Forms.TextBox();
            this.botaoVirgula = new System.Windows.Forms.Button();
            this.botaoNumero0 = new System.Windows.Forms.Button();
            this.botaoOperadorIgual = new System.Windows.Forms.Button();
            this.botaoOperadorSoma = new System.Windows.Forms.Button();
            this.botaoOperadorSubtracao = new System.Windows.Forms.Button();
            this.botaoNumero3 = new System.Windows.Forms.Button();
            this.botaoNumero2 = new System.Windows.Forms.Button();
            this.botaoNumero1 = new System.Windows.Forms.Button();
            this.botaoOperadorMultiplicacao = new System.Windows.Forms.Button();
            this.botaoNumero6 = new System.Windows.Forms.Button();
            this.botaoNumero5 = new System.Windows.Forms.Button();
            this.botaoNumero4 = new System.Windows.Forms.Button();
            this.botaoOperadorDivisao = new System.Windows.Forms.Button();
            this.botaoNumero9 = new System.Windows.Forms.Button();
            this.botaoNumero8 = new System.Windows.Forms.Button();
            this.botaoNumero7 = new System.Windows.Forms.Button();
            this.botaoCE = new System.Windows.Forms.Button();
            this.botaoC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel.Location = new System.Drawing.Point(12, 12);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(278, 62);
            this.painel.TabIndex = 0;
            this.painel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.painel.TextChanged += new System.EventHandler(this.painel_TextChanged);
            // 
            // botaoVirgula
            // 
            this.botaoVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVirgula.Location = new System.Drawing.Point(12, 332);
            this.botaoVirgula.Name = "botaoVirgula";
            this.botaoVirgula.Size = new System.Drawing.Size(59, 49);
            this.botaoVirgula.TabIndex = 1;
            this.botaoVirgula.Text = ",";
            this.botaoVirgula.UseVisualStyleBackColor = true;
            this.botaoVirgula.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoNumero0
            // 
            this.botaoNumero0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero0.Location = new System.Drawing.Point(85, 332);
            this.botaoNumero0.Name = "botaoNumero0";
            this.botaoNumero0.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero0.TabIndex = 2;
            this.botaoNumero0.Text = "0";
            this.botaoNumero0.UseVisualStyleBackColor = true;
            // 
            // botaoOperadorIgual
            // 
            this.botaoOperadorIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOperadorIgual.Location = new System.Drawing.Point(158, 332);
            this.botaoOperadorIgual.Name = "botaoOperadorIgual";
            this.botaoOperadorIgual.Size = new System.Drawing.Size(59, 49);
            this.botaoOperadorIgual.TabIndex = 3;
            this.botaoOperadorIgual.Text = "=";
            this.botaoOperadorIgual.UseVisualStyleBackColor = true;
            // 
            // botaoOperadorSoma
            // 
            this.botaoOperadorSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOperadorSoma.Location = new System.Drawing.Point(231, 332);
            this.botaoOperadorSoma.Name = "botaoOperadorSoma";
            this.botaoOperadorSoma.Size = new System.Drawing.Size(59, 49);
            this.botaoOperadorSoma.TabIndex = 4;
            this.botaoOperadorSoma.Text = "+";
            this.botaoOperadorSoma.UseVisualStyleBackColor = true;
            this.botaoOperadorSoma.Click += new System.EventHandler(this.button4_Click);
            // 
            // botaoOperadorSubtracao
            // 
            this.botaoOperadorSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOperadorSubtracao.Location = new System.Drawing.Point(231, 268);
            this.botaoOperadorSubtracao.Name = "botaoOperadorSubtracao";
            this.botaoOperadorSubtracao.Size = new System.Drawing.Size(59, 49);
            this.botaoOperadorSubtracao.TabIndex = 8;
            this.botaoOperadorSubtracao.Text = "-";
            this.botaoOperadorSubtracao.UseVisualStyleBackColor = true;
            this.botaoOperadorSubtracao.Click += new System.EventHandler(this.button5_Click);
            // 
            // botaoNumero3
            // 
            this.botaoNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero3.Location = new System.Drawing.Point(158, 268);
            this.botaoNumero3.Name = "botaoNumero3";
            this.botaoNumero3.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero3.TabIndex = 7;
            this.botaoNumero3.Text = "3";
            this.botaoNumero3.UseVisualStyleBackColor = true;
            // 
            // botaoNumero2
            // 
            this.botaoNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero2.Location = new System.Drawing.Point(85, 268);
            this.botaoNumero2.Name = "botaoNumero2";
            this.botaoNumero2.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero2.TabIndex = 6;
            this.botaoNumero2.Text = "2";
            this.botaoNumero2.UseVisualStyleBackColor = true;
            // 
            // botaoNumero1
            // 
            this.botaoNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero1.Location = new System.Drawing.Point(12, 268);
            this.botaoNumero1.Name = "botaoNumero1";
            this.botaoNumero1.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero1.TabIndex = 5;
            this.botaoNumero1.Text = "1";
            this.botaoNumero1.UseVisualStyleBackColor = true;
            // 
            // botaoOperadorMultiplicacao
            // 
            this.botaoOperadorMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOperadorMultiplicacao.Location = new System.Drawing.Point(231, 203);
            this.botaoOperadorMultiplicacao.Name = "botaoOperadorMultiplicacao";
            this.botaoOperadorMultiplicacao.Size = new System.Drawing.Size(59, 49);
            this.botaoOperadorMultiplicacao.TabIndex = 12;
            this.botaoOperadorMultiplicacao.Text = "x";
            this.botaoOperadorMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // botaoNumero6
            // 
            this.botaoNumero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero6.Location = new System.Drawing.Point(158, 203);
            this.botaoNumero6.Name = "botaoNumero6";
            this.botaoNumero6.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero6.TabIndex = 11;
            this.botaoNumero6.Text = "6";
            this.botaoNumero6.UseVisualStyleBackColor = true;
            // 
            // botaoNumero5
            // 
            this.botaoNumero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero5.Location = new System.Drawing.Point(85, 203);
            this.botaoNumero5.Name = "botaoNumero5";
            this.botaoNumero5.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero5.TabIndex = 10;
            this.botaoNumero5.Text = "5";
            this.botaoNumero5.UseVisualStyleBackColor = true;
            // 
            // botaoNumero4
            // 
            this.botaoNumero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero4.Location = new System.Drawing.Point(12, 203);
            this.botaoNumero4.Name = "botaoNumero4";
            this.botaoNumero4.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero4.TabIndex = 9;
            this.botaoNumero4.Text = "4";
            this.botaoNumero4.UseVisualStyleBackColor = true;
            this.botaoNumero4.Click += new System.EventHandler(this.button12_Click);
            // 
            // botaoOperadorDivisao
            // 
            this.botaoOperadorDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOperadorDivisao.Location = new System.Drawing.Point(231, 139);
            this.botaoOperadorDivisao.Name = "botaoOperadorDivisao";
            this.botaoOperadorDivisao.Size = new System.Drawing.Size(59, 49);
            this.botaoOperadorDivisao.TabIndex = 16;
            this.botaoOperadorDivisao.Text = "/";
            this.botaoOperadorDivisao.UseVisualStyleBackColor = true;
            this.botaoOperadorDivisao.Click += new System.EventHandler(this.button13_Click);
            // 
            // botaoNumero9
            // 
            this.botaoNumero9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero9.Location = new System.Drawing.Point(158, 139);
            this.botaoNumero9.Name = "botaoNumero9";
            this.botaoNumero9.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero9.TabIndex = 15;
            this.botaoNumero9.Text = "9";
            this.botaoNumero9.UseVisualStyleBackColor = true;
            this.botaoNumero9.Click += new System.EventHandler(this.button14_Click);
            // 
            // botaoNumero8
            // 
            this.botaoNumero8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero8.Location = new System.Drawing.Point(85, 139);
            this.botaoNumero8.Name = "botaoNumero8";
            this.botaoNumero8.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero8.TabIndex = 14;
            this.botaoNumero8.Text = "8";
            this.botaoNumero8.UseVisualStyleBackColor = true;
            this.botaoNumero8.Click += new System.EventHandler(this.button15_Click);
            // 
            // botaoNumero7
            // 
            this.botaoNumero7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNumero7.Location = new System.Drawing.Point(12, 139);
            this.botaoNumero7.Name = "botaoNumero7";
            this.botaoNumero7.Size = new System.Drawing.Size(59, 49);
            this.botaoNumero7.TabIndex = 13;
            this.botaoNumero7.Text = "7";
            this.botaoNumero7.UseVisualStyleBackColor = true;
            this.botaoNumero7.Click += new System.EventHandler(this.button16_Click);
            // 
            // botaoCE
            // 
            this.botaoCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCE.Location = new System.Drawing.Point(12, 93);
            this.botaoCE.Name = "botaoCE";
            this.botaoCE.Size = new System.Drawing.Size(132, 39);
            this.botaoCE.TabIndex = 17;
            this.botaoCE.Text = "CE";
            this.botaoCE.UseVisualStyleBackColor = true;
            // 
            // botaoC
            // 
            this.botaoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoC.Location = new System.Drawing.Point(158, 93);
            this.botaoC.Name = "botaoC";
            this.botaoC.Size = new System.Drawing.Size(132, 39);
            this.botaoC.TabIndex = 18;
            this.botaoC.Text = "C";
            this.botaoC.UseVisualStyleBackColor = true;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 436);
            this.Controls.Add(this.botaoC);
            this.Controls.Add(this.botaoCE);
            this.Controls.Add(this.botaoOperadorDivisao);
            this.Controls.Add(this.botaoNumero9);
            this.Controls.Add(this.botaoNumero8);
            this.Controls.Add(this.botaoNumero7);
            this.Controls.Add(this.botaoOperadorMultiplicacao);
            this.Controls.Add(this.botaoNumero6);
            this.Controls.Add(this.botaoNumero5);
            this.Controls.Add(this.botaoNumero4);
            this.Controls.Add(this.botaoOperadorSubtracao);
            this.Controls.Add(this.botaoNumero3);
            this.Controls.Add(this.botaoNumero2);
            this.Controls.Add(this.botaoNumero1);
            this.Controls.Add(this.botaoOperadorSoma);
            this.Controls.Add(this.botaoOperadorIgual);
            this.Controls.Add(this.botaoNumero0);
            this.Controls.Add(this.botaoVirgula);
            this.Controls.Add(this.painel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox painel;
        private System.Windows.Forms.Button botaoVirgula;
        private System.Windows.Forms.Button botaoNumero0;
        private System.Windows.Forms.Button botaoOperadorIgual;
        private System.Windows.Forms.Button botaoOperadorSoma;
        private System.Windows.Forms.Button botaoOperadorSubtracao;
        private System.Windows.Forms.Button botaoNumero3;
        private System.Windows.Forms.Button botaoNumero2;
        private System.Windows.Forms.Button botaoNumero1;
        private System.Windows.Forms.Button botaoOperadorMultiplicacao;
        private System.Windows.Forms.Button botaoNumero6;
        private System.Windows.Forms.Button botaoNumero5;
        private System.Windows.Forms.Button botaoNumero4;
        private System.Windows.Forms.Button botaoOperadorDivisao;
        private System.Windows.Forms.Button botaoNumero9;
        private System.Windows.Forms.Button botaoNumero8;
        private System.Windows.Forms.Button botaoNumero7;
        private System.Windows.Forms.Button botaoCE;
        private System.Windows.Forms.Button botaoC;
    }
}

