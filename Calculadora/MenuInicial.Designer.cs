namespace Projetos
{
    partial class MenuInicial
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jokenpoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIrParaJokenpo = new System.Windows.Forms.Button();
            this.buttonIrParaCalculadora = new System.Windows.Forms.Button();
            this.PanelConteudo = new System.Windows.Forms.Panel();
            this.buttonFecharMenu = new System.Windows.Forms.Button();
            this.buttonIMC = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.jokenpoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // jokenpoToolStripMenuItem
            // 
            this.jokenpoToolStripMenuItem.Name = "jokenpoToolStripMenuItem";
            this.jokenpoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.jokenpoToolStripMenuItem.Text = "Jokenpo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha uma ação:";
            // 
            // buttonIrParaJokenpo
            // 
            this.buttonIrParaJokenpo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIrParaJokenpo.Location = new System.Drawing.Point(127, 282);
            this.buttonIrParaJokenpo.Name = "buttonIrParaJokenpo";
            this.buttonIrParaJokenpo.Size = new System.Drawing.Size(218, 86);
            this.buttonIrParaJokenpo.TabIndex = 2;
            this.buttonIrParaJokenpo.Text = "JoKenPo";
            this.buttonIrParaJokenpo.UseVisualStyleBackColor = true;
            this.buttonIrParaJokenpo.Click += new System.EventHandler(this.buttonIrParaJokenpo_Click);
            // 
            // buttonIrParaCalculadora
            // 
            this.buttonIrParaCalculadora.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIrParaCalculadora.Location = new System.Drawing.Point(127, 167);
            this.buttonIrParaCalculadora.Name = "buttonIrParaCalculadora";
            this.buttonIrParaCalculadora.Size = new System.Drawing.Size(218, 86);
            this.buttonIrParaCalculadora.TabIndex = 1;
            this.buttonIrParaCalculadora.Text = "Calculadora";
            this.buttonIrParaCalculadora.UseVisualStyleBackColor = true;
            this.buttonIrParaCalculadora.Click += new System.EventHandler(this.buttonIrParaCalculadora_Click);
            // 
            // PanelConteudo
            // 
            this.PanelConteudo.Location = new System.Drawing.Point(453, 92);
            this.PanelConteudo.Name = "PanelConteudo";
            this.PanelConteudo.Size = new System.Drawing.Size(291, 411);
            this.PanelConteudo.TabIndex = 4;
            // 
            // buttonFecharMenu
            // 
            this.buttonFecharMenu.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharMenu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonFecharMenu.Location = new System.Drawing.Point(647, 47);
            this.buttonFecharMenu.Name = "buttonFecharMenu";
            this.buttonFecharMenu.Size = new System.Drawing.Size(97, 29);
            this.buttonFecharMenu.TabIndex = 5;
            this.buttonFecharMenu.Text = "Fechar";
            this.buttonFecharMenu.UseVisualStyleBackColor = true;
            this.buttonFecharMenu.Click += new System.EventHandler(this.buttonFecharMenu_Click);
            // 
            // buttonIMC
            // 
            this.buttonIMC.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIMC.Location = new System.Drawing.Point(127, 398);
            this.buttonIMC.Name = "buttonIMC";
            this.buttonIMC.Size = new System.Drawing.Size(218, 86);
            this.buttonIMC.TabIndex = 6;
            this.buttonIMC.Text = "IMC";
            this.buttonIMC.UseVisualStyleBackColor = true;
            this.buttonIMC.Click += new System.EventHandler(this.buttonIMC_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 652);
            this.Controls.Add(this.buttonIMC);
            this.Controls.Add(this.buttonFecharMenu);
            this.Controls.Add(this.PanelConteudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIrParaJokenpo);
            this.Controls.Add(this.buttonIrParaCalculadora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jokenpoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIrParaJokenpo;
        private System.Windows.Forms.Button buttonIrParaCalculadora;
        private System.Windows.Forms.Panel PanelConteudo;
        private System.Windows.Forms.Button buttonFecharMenu;
        private System.Windows.Forms.Button buttonIMC;
    }
}