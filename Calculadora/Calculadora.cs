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

        enum Operacao
        {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao,
            Sqrt
        }

        private Operacao operacaoSelecionada { get; set; }// Variável para armazenar a operação selecionada
        public double resultado { get; set; } // Variável para armazenar o resultado da operação
        public double valor { get; set; }

        private void botaoOperadorSoma_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Soma; // Define a operação como soma
            valor = Convert.ToDouble(textBoxPainel.Text); // Converte o texto do painel para um número e armazena na variável valor
            textBoxPainel.Clear(); // Limpa o painel de texto para permitir a entrada do próximo número
            labelOperacaoAritmetica.Text = "+"; // Exibe o símbolo da operação selecionada no rótulo de operação aritmética
        }

        private void botaoOperadorSubtracao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Subtracao; 
            valor = Convert.ToDouble(textBoxPainel.Text); 
            textBoxPainel.Clear(); 
            labelOperacaoAritmetica.Text = "-"; 
        }

        private void botaoOperadorMultiplicacao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Multiplicacao;
            valor = Convert.ToDouble(textBoxPainel.Text);
            textBoxPainel.Clear();
            labelOperacaoAritmetica.Text = "x";
        }

        private void botaoOperadorDivisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Divisao;
            valor = Convert.ToDouble(textBoxPainel.Text);
            textBoxPainel.Clear();
            labelOperacaoAritmetica.Text = "/";

        }

        private void botaoSqrt_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Sqrt;
            valor = Convert.ToDouble(textBoxPainel.Text);
            textBoxPainel.Clear();
            labelOperacaoAritmetica.Text = "√";
        } 

        private void botaoNumero0_Click(object sender, EventArgs e)
        {
            if(textBoxPainel.Text != "0") // Verifica se o painel de texto não é igual a "0"
            {
                textBoxPainel.Text += "0"; // Se não for "0", adiciona "0" ao final do texto existente no painel de texto
            }

        }
        private void botaoNumero1_Click(object sender, EventArgs e)
        {
            if (textBoxPainel.Text == "0")  // Verifica se o painel de texto é igual a "0"
            {
                textBoxPainel.Text = "1";  // Se for "0", substitui o texto do painel de texto por "1"
            }
            else
            {
                textBoxPainel.Text += "1";  // Se não for "0", adiciona "1" ao final do texto existente no painel de texto
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
