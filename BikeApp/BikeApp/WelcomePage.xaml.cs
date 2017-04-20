using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();

            botonBienvenidos.Clicked += async (s, e) =>
            {
                //await DisplayAlert("Mensaje", "mensaje", "Cancelar");
                await Navigation.PushModalAsync(new MainPage()
                {
                    //  Nombre = texto.Text
                });
                //await Navigation.PushAsync(new MainPage());

            };
    }
    }
}