using System;

namespace Projetos
{
    internal class PessoaImc
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public PessoaImc()
        {
        }
        public PessoaImc(string nome, double peso, double altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }
        public double CalcularIMC()
        {
            return Peso / Math.Pow(Altura, 2);
        }

        public enum StatusIMCEnum
        {
            AbaixoDoPeso = 1,
            PesoNormal = 2,
            Sobrepeso = 3,
            Obesidade = 4
        }

        public StatusIMCEnum StatusIMC()
        {
            double imc = CalcularIMC();
            if (imc < 18.5)
            {
                return StatusIMCEnum.AbaixoDoPeso; // Abaixo do peso
            }
            else if (imc >= 18.5 && imc < 25)
            {
                return StatusIMCEnum.PesoNormal; // Peso normal
            }
            else if (imc >= 25 && imc < 30)
            {
                return StatusIMCEnum.Sobrepeso; // Sobrepeso
            }
            else
            {
                return StatusIMCEnum.Obesidade; // Obesidade
            }
        }

    }
}
