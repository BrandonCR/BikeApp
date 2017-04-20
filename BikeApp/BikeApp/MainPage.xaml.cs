using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BikeApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Bike> ListaGeneral = new ObservableCollection<Bike>();
        /*{
            get;
            set;
        }*/

        public MainPage()
        {
            InitializeComponent();
            ListaGeneral = new ObservableCollection<Bike>();
            listadoDatos.ItemsSource = ListaGeneral;

            //boton.Clicked += async (s, e) => {
            //    //await Navigation.PushModalAsync(new DetallePersona());
            //    var servicio = new ServicioRest();

            //    //servicio.Conectar();

            //    List<Bike> Bikes = await servicio.GetJson();
            //    ListaGeneral = new ObservableCollection<Bike>(Bikes);
            //};
        }

        private async void boton_Clicked(object sender, EventArgs e)
        {
            if (texto.Text == null || texto.Text == " ")
            {
                boton.IsEnabled = false;
                var servicio = new ServicioRest();

                List<Bike> Bikes = await servicio.GetJson();
                ListaGeneral.Clear();
                for (int i = 0; i < Bikes.Count; i++)
                {
                    ListaGeneral.Add(Bikes[i]);
                }
                boton.IsEnabled = true;
            }
            else
            {
                int numeros = 123456789;
                bool aux = int.TryParse(texto.Text, out numeros);
                if (aux)
                {
                    //texto.Text = "El ID es INT";
                    boton.IsEnabled = false;
                    var servicio = new ServicioRest();

                    List<Bike> Bikes = await servicio.GetJson(texto.Text);
                    //Bike Bikes = await servicio.GetJson(texto.Text);
                    ListaGeneral.Clear();
                    boton.IsEnabled = true;
                    await Navigation.PushModalAsync(new BakeDetail(Bikes));
                }
                else
                {
                    texto.Text = "El ID debe de ser tipo INT";
                }
            }
        }
    }
}
