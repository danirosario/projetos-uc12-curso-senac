using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Projetos
{
    public partial class Jokenpo : Form
    {
        Game game = new Game();
        public Jokenpo()
        {
            InitializeComponent();

            pictureBoxJogador.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPC.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxResultado.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void IniciarJogo(int opcao)
        {
            //Game jogo = new Game();
            switch (game.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    pictureBoxResultado.Image = Image.FromFile(Path.Combine(Application.StartupPath, "imagens/Ganhar.png"));
                    goto default;
                case Game.Resultado.Perder:
                    pictureBoxResultado.Image = Image.FromFile(Path.Combine(Application.StartupPath, "imagens/Perder.png"));
                    goto default;
                case Game.Resultado.Empatar:
                    pictureBoxResultado.Image = Image.FromFile(Path.Combine(Application.StartupPath, "imagens/Empatar.png"));
                    goto default;
                default:
                    pictureBoxJogador.BackgroundImage = game.ImgJogador;
                    pictureBoxPC.BackgroundImage = game.ImgPc;
                    break;
            }
        }

        private void botaoPedra_Click(object sender, EventArgs e)
        {
            IniciarJogo(0); // O método IniciarJogo já atualizará as imagens e o resultado
        }

        private void botaoPapel_Click(object sender, EventArgs e)
        {
            IniciarJogo(1);
        }

        private void botaoTesoura_Click(object sender, EventArgs e)
        {
            IniciarJogo(2);
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread abrirMenuInicial = new Thread(() => Application.Run(new MenuInicial())); // criar um novo processamento para abrir novamente o menu que foi finalizado
            abrirMenuInicial.Start(); // iniciar thread abrirMenuInicial
        }
    }

}

