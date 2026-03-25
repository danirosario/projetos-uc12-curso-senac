using System;
using System.Threading;
using System.Windows.Forms;

namespace Projetos
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void ButtonCalcularIMC_Click(object sender, EventArgs e)
        {
            CalcularIMC();
            Limpar();

        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void ButtonMenuInicial_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread abrirMenuInicial = new Thread(() => Application.Run(new MenuInicial()));
            abrirMenuInicial.Start();
        }
    

        public void Limpar()
        {
            TextBoxNome.Clear();
            TextBoxPeso.Clear();
            TextBoxAltura.Clear();
        }

        public void CalcularIMC()
        {
            string status;

            double.TryParse(TextBoxPeso.Text , out double peso);
            double.TryParse(TextBoxAltura.Text , out double altura);

            double imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                status = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                status = "Peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                status = "Sobrepeso";
            }
            else
            {
                status = "Obesidade";
            }

            var linha = new string[] 
            {
                TextBoxNome.Text,
                peso.ToString("F2"),
                altura.ToString("F2"),
                imc.ToString("F2"),
                status
            };

            listViewResultados.Items.Add(new ListViewItem(linha));
        }
    }
}
