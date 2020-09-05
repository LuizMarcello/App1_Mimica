using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using App1_Mimica.Model;
using Xamarin.Forms;
using App1_Mimica.Armazenamento;

namespace App1_Mimica.ViewModel
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        public Jogo Jogo { get; set; }
        public Command IniciarCommand { get; set; }

        public InicioViewModel()
        {
            Armazenamento.Armazenamento.Jogo = this.Jogo;
            Armazenamento.Armazenamento.RodadaAtual = 1;
            IniciarCommand = new Command(IniciarJogo);
        }

        private void IniciarJogo()
        {
            App.Current.MainPage = new View.Jogo();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}

        

