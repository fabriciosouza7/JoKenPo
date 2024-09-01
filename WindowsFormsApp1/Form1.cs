using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Image[] imgComputador = new Image[]
        {
            Properties.Resources.jo,
            Properties.Resources.ken,
            Properties.Resources.po
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            PicJogador.Image = bt.BackgroundImage;
            Jogada jogadaJogador = RetornaJogadaDoJogador(Convert.ToInt32(bt.Tag));
            Jogada jogadaAdversario = RetornaJogadaDoAdversario();
            Resultado resultado = RetornaGanhador(jogadaJogador, jogadaAdversario);

            if (resultado == Resultado.VitoriaComputador)
            {
                LbPtComputador.Text = (int.Parse(LbPtComputador.Text) + 1).ToString();
            }
            else if (resultado == Resultado.VitoriaJogador){
                LbPtJogador.Text = (int.Parse(LbPtJogador.Text) + 1).ToString();
            }
            else if (resultado == Resultado.Empate)
            {
                LbEmpate.Text = (int.Parse(LbEmpate.Text) + 1).ToString();
            }
        }

        private Resultado RetornaGanhador(Jogada jogador, Jogada adversario)
        {
            if (jogador == Jogada.Jo) // pedra
            {
                if (adversario == Jogada.Ken) // papel
                {
                    return Resultado.VitoriaComputador;
                }
                else if (adversario == Jogada.Po) // tesoura
                {
                    return Resultado.VitoriaJogador;
                }
            }else if (jogador == Jogada.Ken) // papel
            {
                if (adversario == Jogada.Jo) // pedra
                {
                    return Resultado.VitoriaJogador;
                }
                else if (adversario == Jogada.Po) // tesoura
                {
                    return Resultado.VitoriaComputador;
                }
            }
            else
            {
                if(adversario == Jogada.Jo) // pedra
                {
                    return Resultado.VitoriaComputador;
                }
                else if (adversario == Jogada.Ken) // papel
                {
                    return Resultado.VitoriaJogador;
                }
            }

            return Resultado.Empate;
        }

        private Jogada RetornaJogadaDoJogador(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadaDoAdversario()
        {
            Random rnd = new Random();
            int escolha = rnd.Next(3);
            PIcComputador.Image = imgComputador[escolha];
            return (Jogada)escolha;
        }

        enum Jogada
        {
            Jo = 0,  // pedra
            Ken = 1, // papel
            Po = 2 // tesoura
        }

        enum Resultado
        {
            VitoriaJogador,
            VitoriaComputador,
            Empate
        }
    }
}
