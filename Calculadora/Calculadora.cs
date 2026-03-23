using System;
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
            Divisao
        }

        private Operacao operacaoSelecionada { get; set; }// Variável para armazenar a operação selecionada
        public double Resultado { get; set; } // Variável para armazenar o resultado da operação
        public double Valor { get; set; }

        private void botaoOperadorSoma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxPainel.Text, out double valorDigitado))
            {
                operacaoSelecionada = Operacao.Soma;
                Valor = valorDigitado; // Armazena o primeiro número
                textBoxPainel.Clear();
                labelOperacaoAritmetica.Text = "+";
            }
        }

        private void botaoOperadorSubtracao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDouble(textBoxPainel.Text);
            textBoxPainel.Clear();
            labelOperacaoAritmetica.Text = "-";
        }

        private void botaoOperadorMultiplicacao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDouble(textBoxPainel.Text);
            textBoxPainel.Clear();
            labelOperacaoAritmetica.Text = "x";
        }

        private void botaoOperadorDivisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDouble(textBoxPainel.Text);
            textBoxPainel.Clear();
            labelOperacaoAritmetica.Text = "/";

        }

        private void botaoSqrt_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDouble(textBoxPainel.Text);  // Converte o valor do painel de texto para um número do tipo double e armazena na variável Valor

            labelOperacaoAritmetica.Text = "√"; // Atualiza o rótulo de operação aritmética para indicar que a operação selecionada é a raiz quadrada

            Resultado = Math.Sqrt(Valor);
            textBoxPainel.Text = Resultado.ToString("G10"); // Exibe o resultado da raiz quadrada no painel de texto, formatado para evitar notação científica desnecessária

            Valor = Resultado;  // Atualiza o valor armazenado com o resultado da raiz quadrada, permitindo que o usuário continue realizando operações a partir desse resultado
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

        private void botaoCE_Click(object sender, EventArgs e)
        {
            if(textBoxPainel.Text.Length > 0) // Verifica se o painel de texto tem algum conteúdo
            {
                textBoxPainel.Text = string.Empty; ; 
            }
        }

        private void botaoC_Click(object sender, EventArgs e)
        {
            
            textBoxPainel.Text = string.Empty; 
            labelOperacaoAritmetica.Text = string.Empty; // Limpa o rótulo de operação aritmética
            
        }

        private void botaoOperadorIgual_Click(object sender, EventArgs e)
        {
            Operacao operacao = operacaoSelecionada; // Armazena a operação selecionada em uma variável local
            if (double.TryParse(textBoxPainel.Text, out double valorDigitado)) // Tenta converter o texto do painel para um número do tipo double
            {
                switch (operacao) // Verifica qual operação foi selecionada
                {
                    case Operacao.Soma:
                        Resultado = Valor + valorDigitado; // Realiza a soma e armazena o resultado
                        break;
                    case Operacao.Subtracao:
                        Resultado = Valor - valorDigitado; // Realiza a subtração e armazena o resultado
                        break;
                    case Operacao.Multiplicacao:
                        Resultado = Valor * valorDigitado; // Realiza a multiplicação e armazena o resultado
                        break;
                    case Operacao.Divisao:
                        if (valorDigitado != 0) // Verifica se o divisor não é zero para evitar divisão por zero
                        {
                            Resultado = Valor / valorDigitado; // Realiza a divisão e armazena o resultado
                        }
                        else
                        {
                            MessageBox.Show("Não é possível dividir por zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // Exibe uma mensagem de erro se o divisor for zero
                            return; // Encerra a execução do método para evitar continuar com a divisão por zero
                        }
                        break;
                }
                labelOperacaoAritmetica.Text = "="; 
                textBoxPainel.Text = Resultado.ToString("G2");
            }
        }
    }
}
