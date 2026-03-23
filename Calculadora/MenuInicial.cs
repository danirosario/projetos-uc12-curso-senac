using System;
using Calculadora;
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
            global::Calculadora.Calculadora calc = new global::Calculadora.Calculadora();
            this.Hide();
            calc.ShowDialog();
            this.Show();
        }
    }
}
