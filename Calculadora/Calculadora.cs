using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void botaoNumero0_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "0"; // quando clicar no botão 0, o painel de texto exibirá "0"
        }
        private void botaoNumero1_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "1"; 
        }

        private void botaoNumero2_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "2";
        }

        private void botaoNumero3_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "3";
        }

        private void botaoNumero4_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "4";
        }

        private void botaoNumero5_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "5";
        }

        private void botaoNumero6_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "6";
        }

        private void botaoNumero7_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "7";
        }

        private void botaoNumero8_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "8";
        }

        private void botaoNumero9_Click(object sender, EventArgs e)
        {
            textBoxPainel.Text += "9";
        }
    }
}
