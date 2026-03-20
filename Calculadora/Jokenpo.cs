using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Jokenpo : Form
    {
        Game game = new Game();
        public Jokenpo() 
        {
            InitializeComponent();

            pictureBoxJogador.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPC.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void botaoPedra_Click(object sender, EventArgs e)
        {
            var resultado = game.Jogar(0);

            pictureBoxJogador.Image = game.ImgJogador;
            pictureBoxPC.Image = game.ImgPc;

        }

        private void botaoPapel_Click(object sender, EventArgs e)
        {
            var resultado = game.Jogar(1);

            pictureBoxJogador.Image = game.ImgJogador;
            pictureBoxPC.Image = game.ImgPc;
        }

        private void botaoTesoura_Click(object sender, EventArgs e)
        {
            var resultado = game.Jogar(2);

            pictureBoxJogador.Image = game.ImgJogador;
            pictureBoxPC.Image = game.ImgPc;
        }

        private void pictureBoxResultado_Click(object sender, EventArgs e)
        {
            
        }
    }

}

