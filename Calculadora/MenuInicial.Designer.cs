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
            this.buttonJokenpo = new System.Windows.Forms.Button();
            this.buttonIrParaCalculadora = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
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
            this.label1.Location = new System.Drawing.Point(138, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha uma ação:";
            // 
            // buttonJokenpo
            // 
            this.buttonJokenpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJokenpo.Location = new System.Drawing.Point(144, 348);
            this.buttonJokenpo.Name = "buttonJokenpo";
            this.buttonJokenpo.Size = new System.Drawing.Size(218, 86);
            this.buttonJokenpo.TabIndex = 2;
            this.buttonJokenpo.Text = "JoKenPo";
            this.buttonJokenpo.UseVisualStyleBackColor = true;
            // 
            // buttonIrParaCalculadora
            // 
            this.buttonIrParaCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIrParaCalculadora.Location = new System.Drawing.Point(144, 227);
            this.buttonIrParaCalculadora.Name = "buttonIrParaCalculadora";
            this.buttonIrParaCalculadora.Size = new System.Drawing.Size(218, 86);
            this.buttonIrParaCalculadora.TabIndex = 1;
            this.buttonIrParaCalculadora.Text = "Calculadora";
            this.buttonIrParaCalculadora.UseVisualStyleBackColor = true;
            this.buttonIrParaCalculadora.Click += new System.EventHandler(this.buttonIrParaCalculadora_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonJokenpo);
            this.Controls.Add(this.buttonIrParaCalculadora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuInicial";
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
        private System.Windows.Forms.Button buttonJokenpo;
        private System.Windows.Forms.Button buttonIrParaCalculadora;
    }
}