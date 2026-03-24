namespace Projetos
{
    partial class IMC
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
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelPeso = new System.Windows.Forms.Label();
            this.LabelAltura = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.TextBoxAltura = new System.Windows.Forms.TextBox();
            this.TextBoxPeso = new System.Windows.Forms.TextBox();
            this.ButtonLimpar = new System.Windows.Forms.Button();
            this.ButtonCalcularIMC = new System.Windows.Forms.Button();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.listViewResultados = new System.Windows.Forms.ListView();
            this.ButtonMenuInicial = new System.Windows.Forms.Button();
            this.ColumnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderPeso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderAltura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderIMC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(53, 50);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(38, 13);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome:";
            // 
            // LabelPeso
            // 
            this.LabelPeso.AutoSize = true;
            this.LabelPeso.Location = new System.Drawing.Point(53, 87);
            this.LabelPeso.Name = "LabelPeso";
            this.LabelPeso.Size = new System.Drawing.Size(34, 13);
            this.LabelPeso.TabIndex = 1;
            this.LabelPeso.Text = "Peso:";
            // 
            // LabelAltura
            // 
            this.LabelAltura.AutoSize = true;
            this.LabelAltura.Location = new System.Drawing.Point(53, 123);
            this.LabelAltura.Name = "LabelAltura";
            this.LabelAltura.Size = new System.Drawing.Size(37, 13);
            this.LabelAltura.TabIndex = 2;
            this.LabelAltura.Text = "Altura:";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(141, 47);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(352, 20);
            this.TextBoxNome.TabIndex = 3;
            // 
            // TextBoxAltura
            // 
            this.TextBoxAltura.Location = new System.Drawing.Point(141, 120);
            this.TextBoxAltura.Name = "TextBoxAltura";
            this.TextBoxAltura.Size = new System.Drawing.Size(183, 20);
            this.TextBoxAltura.TabIndex = 4;
            // 
            // TextBoxPeso
            // 
            this.TextBoxPeso.Location = new System.Drawing.Point(141, 84);
            this.TextBoxPeso.Name = "TextBoxPeso";
            this.TextBoxPeso.Size = new System.Drawing.Size(183, 20);
            this.TextBoxPeso.TabIndex = 5;
            // 
            // ButtonLimpar
            // 
            this.ButtonLimpar.Location = new System.Drawing.Point(418, 118);
            this.ButtonLimpar.Name = "ButtonLimpar";
            this.ButtonLimpar.Size = new System.Drawing.Size(75, 23);
            this.ButtonLimpar.TabIndex = 6;
            this.ButtonLimpar.Text = "Limpar";
            this.ButtonLimpar.UseVisualStyleBackColor = true;
            this.ButtonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // ButtonCalcularIMC
            // 
            this.ButtonCalcularIMC.Location = new System.Drawing.Point(43, 186);
            this.ButtonCalcularIMC.Name = "ButtonCalcularIMC";
            this.ButtonCalcularIMC.Size = new System.Drawing.Size(75, 25);
            this.ButtonCalcularIMC.TabIndex = 7;
            this.ButtonCalcularIMC.Text = "Calcular IMC";
            this.ButtonCalcularIMC.UseVisualStyleBackColor = true;
            this.ButtonCalcularIMC.Click += new System.EventHandler(this.ButtonCalcularIMC_Click);
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.Location = new System.Drawing.Point(43, 229);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(75, 23);
            this.ButtonExcluir.TabIndex = 8;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.UseVisualStyleBackColor = true;
            // 
            // listViewResultados
            // 
            this.listViewResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderNome,
            this.ColumnHeaderPeso,
            this.ColumnHeaderAltura,
            this.ColumnHeaderIMC,
            this.ColumnHeaderStatus});
            this.listViewResultados.HideSelection = false;
            this.listViewResultados.Location = new System.Drawing.Point(141, 186);
            this.listViewResultados.Name = "listViewResultados";
            this.listViewResultados.Size = new System.Drawing.Size(352, 268);
            this.listViewResultados.TabIndex = 9;
            this.listViewResultados.UseCompatibleStateImageBehavior = false;
            this.listViewResultados.View = System.Windows.Forms.View.Details;
            // 
            // ButtonMenuInicial
            // 
            this.ButtonMenuInicial.Location = new System.Drawing.Point(43, 431);
            this.ButtonMenuInicial.Name = "ButtonMenuInicial";
            this.ButtonMenuInicial.Size = new System.Drawing.Size(75, 23);
            this.ButtonMenuInicial.TabIndex = 10;
            this.ButtonMenuInicial.Text = "Voltar";
            this.ButtonMenuInicial.UseVisualStyleBackColor = true;
            // 
            // ColumnHeaderNome
            // 
            this.ColumnHeaderNome.Text = "Nome";
            this.ColumnHeaderNome.Width = 90;
            // 
            // ColumnHeaderPeso
            // 
            this.ColumnHeaderPeso.Text = "Peso";
            // 
            // ColumnHeaderAltura
            // 
            this.ColumnHeaderAltura.Text = "Altura";
            // 
            // ColumnHeaderIMC
            // 
            this.ColumnHeaderIMC.Text = "IMC";
            // 
            // ColumnHeaderStatus
            // 
            this.ColumnHeaderStatus.Text = "Status";
            this.ColumnHeaderStatus.Width = 70;
            // 
            // IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 483);
            this.Controls.Add(this.ButtonMenuInicial);
            this.Controls.Add(this.listViewResultados);
            this.Controls.Add(this.ButtonExcluir);
            this.Controls.Add(this.ButtonCalcularIMC);
            this.Controls.Add(this.ButtonLimpar);
            this.Controls.Add(this.TextBoxPeso);
            this.Controls.Add(this.TextBoxAltura);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.LabelAltura);
            this.Controls.Add(this.LabelPeso);
            this.Controls.Add(this.LabelNome);
            this.Name = "IMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label LabelPeso;
        private System.Windows.Forms.Label LabelAltura;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.TextBox TextBoxAltura;
        private System.Windows.Forms.TextBox TextBoxPeso;
        private System.Windows.Forms.Button ButtonLimpar;
        private System.Windows.Forms.Button ButtonCalcularIMC;
        private System.Windows.Forms.Button ButtonExcluir;
        private System.Windows.Forms.ListView listViewResultados;
        private System.Windows.Forms.Button ButtonMenuInicial;
        private System.Windows.Forms.ColumnHeader ColumnHeaderNome;
        private System.Windows.Forms.ColumnHeader ColumnHeaderPeso;
        private System.Windows.Forms.ColumnHeader ColumnHeaderAltura;
        private System.Windows.Forms.ColumnHeader ColumnHeaderIMC;
        private System.Windows.Forms.ColumnHeader ColumnHeaderStatus;
    }
}