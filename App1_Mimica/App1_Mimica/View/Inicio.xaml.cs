using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Mimica.ViewModel;

namespace App1_Mimica.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            this.BindingContext = new InicioViewModel();
        }

        //Daqui pra frente fará parte da ViewModel:

        //public class Grupo1 : INotifyPropertyChanged
        //{
        //    //Usando aqui o snippet "propfull"
        //    private string _NomeGrupo1;
            
        //    public string NomeGrupo1
        //    {
        //        get { return _NomeGrupo1; }
        //        set { _NomeGrupo1 = value;
        //            PropriedadeMudada("NomeGrupo1");               
        //        }
        //    }

        //    public Grupo1()
        //    {
        //        NomeGrupo1 = "Os machos";
        //    }

        //    public event PropertyChangedEventHandler PropertyChanged;

        //    private void PropriedadeMudada(string NomePropriedade)
        //    {
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs(NomePropriedade));
        //        }
        //    }
        //}
    }
}
           






    

        