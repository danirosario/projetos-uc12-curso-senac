using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar,
            Perder,
            Empatar
        }

        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png")
        };

        // Método para determinar o resultado do jogo com base na escolha do jogador e do computador
        public Image ImgPc { get; set; }
        public Image ImgJogador { get; set; }

        public Resultado Jogar(int escolhaJogador)
        {
            Random random = new Random();
            int escolhaPc = random.Next(0, 3); // Gera um número aleatório entre 0 e 2 para a escolha do computador
            ImgPc = imagens[escolhaPc]; // Define a imagem do computador com base na escolha aleatória
            ImgJogador = imagens[escolhaJogador]; // Define a imagem do jogador com base na escolha do jogador
            if (escolhaJogador == escolhaPc)
            {
                return Resultado.Empatar; // Empate se as escolhas forem iguais
            }
            else if ((escolhaJogador == 0 && escolhaPc == 2) || // Pedra ganha de Tesoura
                     (escolhaJogador == 1 && escolhaPc == 0) || // Papel ganha de Pedra
                     (escolhaJogador == 2 && escolhaPc == 1))   // Tesoura ganha de Papel
            {
                return Resultado.Ganhar; // Jogador ganha
            }
            else
            {
                return Resultado.Perder; // Jogador perde
            }
        }
    }
}
