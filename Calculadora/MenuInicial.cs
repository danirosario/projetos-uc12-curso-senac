using System;
using System.Threading;
using System.Windows.Forms;

namespace Projetos
{
    public partial class MenuInicial: Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void buttonIrParaCalculadora_Click(object sender, EventArgs e)
        {
           Calculadora calc = new Calculadora();
           this.Hide();
           calc.ShowDialog();
           this.Show();
        }

        private void buttonIrParaJokenpo_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread abrirJokenpo = new Thread(() => Application.Run(new Jokenpo()));
            abrirJokenpo.Start();

            //Jokenpo jokenpo = new Jokenpo();
            //this.Hide();
            //jokenpo.ShowDialog();
            //this.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calc2 = new Calculadora();

            calc2.TopLevel = false;
            //calc2.FormBorderStyle = FormBorderStyle.None;
            calc2.Dock = DockStyle.Fill;

            PanelConteudo.Controls.Clear();
            PanelConteudo.Controls.Add(calc2);

            calc2.Show();
        }

        private void buttonFecharMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
