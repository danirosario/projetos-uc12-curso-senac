using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projetos
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar,
            Perder,
            Empatar
        }

        private static Random random = new Random();

        private static Image[] imagens =
        {
            Image.FromFile(Path.Combine(Application.StartupPath, "imagens/Pedra.png")),
            Image.FromFile(Path.Combine(Application.StartupPath, "imagens/Papel.png")),
            Image.FromFile(Path.Combine(Application.StartupPath, "imagens/Tesoura.png")),
        };

        public Image ImgPc { get; set; }
        public Image ImgJogador { get; set; }

        public Resultado Jogar(int escolhaJogador)
        {
            int escolhaPc = random.Next(0, 3);

            ImgPc = imagens[escolhaPc];
            ImgJogador = imagens[escolhaJogador];


            if (escolhaJogador == escolhaPc)
            {
                return Resultado.Empatar;
            }

            if ((escolhaJogador == 0 && escolhaPc == 2) ||
                (escolhaJogador == 1 && escolhaPc == 0) ||
                (escolhaJogador == 2 && escolhaPc == 1))
            {
               return Resultado.Ganhar;
            }
            else 
            {
                return Resultado.Perder;
            }
        }
    }
}