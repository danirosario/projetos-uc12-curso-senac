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


    }
}
