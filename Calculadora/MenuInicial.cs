using System;
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
    }
}
