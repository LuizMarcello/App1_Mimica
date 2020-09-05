using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1_Mimica.ViewModel
{
    public class JogoViewModel
    {
        public Command MostrarPalavra { get; set; }
        public Command Acertou { get; set; }
        public Command Errou { get; set; }
        public Command Iniciar { get; set; }

        public byte PalavraPontuacao { get; set; }
        public string Palavra { get; set; }
        public string TextoContagem { get; set; }

        public bool ContainerContagem { get; set; }
        public bool ContainerIniciar { get; set; }

        public JogoViewModel()
        {
            ContainerContagem = false;

            ContainerIniciar = true;

            //MostrarPalavra = new Command(NomeDoMetodoASerConstruido);
            //Acertou = new Command(NomeDoMetodoASerConstruido);
            //Errou = new Command(NomeDoMetodoASerConstruido);
            //Iniciar = new Command(NomeDoMetodoASerConstruido);
        }
    }
}





