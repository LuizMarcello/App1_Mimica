using System;
using System.Collections.Generic;
using System.Text;
using App1_Mimica.Model;

namespace App1_Mimica.Armazenamento
{
    public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        //public static string[indice de qual array][indice da palavra dentro do array] Palavras = { };
        public static string[][] Palavras = { 
            //Fáceis pontuação 1
            new string[]{"Olho", "Lingua", "Chinelo", "Milho", "Penalti", "Bola", "Ping-Pong"},

            //Médias pontuação 3
            new string[]{"Carpinteiro", "Amarelo", "Limão", "Abelha"},

            //Difíceis pontuação 5
            new string[]{"Cisterna", "Lanterna", "Batman vs Superman", "Notebook"},
        };
    }
}
