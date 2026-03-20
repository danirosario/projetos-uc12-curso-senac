namespace Calculadora
{
    partial class Jokenpo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jokenpo));
            this.botaoTesoura = new System.Windows.Forms.Button();
            this.botaoPapel = new System.Windows.Forms.Button();
            this.botaoPedra = new System.Windows.Forms.Button();
            this.pictureBoxJogador = new System.Windows.Forms.PictureBox();
            this.pictureBoxPC = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoTesoura
            // 
            this.botaoTesoura.BackgroundImage = global::Projetos.Properties.Resources.Tesoura;
            this.botaoTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoTesoura.Location = new System.Drawing.Point(476, 299);
            this.botaoTesoura.Name = "botaoTesoura";
            this.botaoTesoura.Size = new System.Drawing.Size(187, 183);
            this.botaoTesoura.TabIndex = 2;
            this.botaoTesoura.UseVisualStyleBackColor = true;
            this.botaoTesoura.Click += new System.EventHandler(this.botaoTesoura_Click);
            // 
            // botaoPapel
            // 
            this.botaoPapel.BackgroundImage = global::Projetos.Properties.Resources.Papel;
            this.botaoPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPapel.Location = new System.Drawing.Point(258, 299);
            this.botaoPapel.Name = "botaoPapel";
            this.botaoPapel.Size = new System.Drawing.Size(187, 183);
            this.botaoPapel.TabIndex = 1;
            this.botaoPapel.UseVisualStyleBackColor = true;
            this.botaoPapel.Click += new System.EventHandler(this.botaoPapel_Click);
            // 
            // botaoPedra
            // 
            this.botaoPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPedra.BackgroundImage")));
            this.botaoPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPedra.Location = new System.Drawing.Point(36, 299);
            this.botaoPedra.Name = "botaoPedra";
            this.botaoPedra.Size = new System.Drawing.Size(187, 183);
            this.botaoPedra.TabIndex = 0;
            this.botaoPedra.UseVisualStyleBackColor = true;
            this.botaoPedra.Click += new System.EventHandler(this.botaoPedra_Click);
            // 
            // pictureBoxJogador
            // 
            this.pictureBoxJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxJogador.Location = new System.Drawing.Point(36, 61);
            this.pictureBoxJogador.Name = "pictureBoxJogador";
            this.pictureBoxJogador.Size = new System.Drawing.Size(187, 183);
            this.pictureBoxJogador.TabIndex = 3;
            this.pictureBoxJogador.TabStop = false;
            // 
            // pictureBoxPC
            // 
            this.pictureBoxPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPC.Location = new System.Drawing.Point(258, 61);
            this.pictureBoxPC.Name = "pictureBoxPC";
            this.pictureBoxPC.Size = new System.Drawing.Size(187, 183);
            this.pictureBoxPC.TabIndex = 4;
            this.pictureBoxPC.TabStop = false;
            // 
            // pictureBoxResultado
            // 
            this.pictureBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResultado.Location = new System.Drawing.Point(476, 61);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(187, 183);
            this.pictureBoxResultado.TabIndex = 5;
            this.pictureBoxResultado.TabStop = false;
            this.pictureBoxResultado.Click += new System.EventHandler(this.pictureBoxResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "PC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jokenpô";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            // 
            // Jokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxResultado);
            this.Controls.Add(this.pictureBoxPC);
            this.Controls.Add(this.pictureBoxJogador);
            this.Controls.Add(this.botaoTesoura);
            this.Controls.Add(this.botaoPapel);
            this.Controls.Add(this.botaoPedra);
            this.Name = "Jokenpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoPedra;
        private System.Windows.Forms.Button botaoPapel;
        private System.Windows.Forms.Button botaoTesoura;
        private System.Windows.Forms.PictureBox pictureBoxJogador;
        private System.Windows.Forms.PictureBox pictureBoxPC;
        private System.Windows.Forms.PictureBox pictureBoxResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}