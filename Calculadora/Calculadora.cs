using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            if(textBoxPainel.Text != "0")
    {
                textBoxPainel.Text += "0";
            }

        }
        private void botaoNumero1_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "1";
            }
            else
            {
                textBoxPainel.Text += "1";
            }
        }

        private void botaoNumero2_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "2";
            }
            else
            {
                textBoxPainel.Text += "2";
            }
        }

        private void botaoNumero3_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "3";
            }
            else
            {
                textBoxPainel.Text += "3";
            }
        }

        private void botaoNumero4_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "4";
            }
            else
            {
                textBoxPainel.Text += "4";
            }
        }

        private void botaoNumero5_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "5";
            }
            else
            {
                textBoxPainel.Text += "5";
            }
        }

        private void botaoNumero6_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "6";
            }
            else
            {
                textBoxPainel.Text += "6";
            }
        }

        private void botaoNumero7_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "7";
            }
            else
            {
                textBoxPainel.Text += "7";
            }
        }

        private void botaoNumero8_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "8";
            }
            else
            {
                textBoxPainel.Text += "8";
            }
        }

        private void botaoNumero9_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")
            {
                textBoxPainel.Text = "9";
            }
            else
            {
                textBoxPainel.Text += "9";
            }
        }

        private void botaoVirgula_Click(object sender, EventArgs e)
        {
            if(textBoxPainel.Text == "") // Verifica se o painel de texto está vazio
            {
                textBoxPainel.Text = "0,"; // Se estiver vazio, adiciona "0," para iniciar um número decimal
            }
            
            if (!textBoxPainel.Text.Contains(",")) // Verifica se o painel de texto já contém uma vírgula
            {
                textBoxPainel.Text += ",";
            }
            
        }
    }
}
