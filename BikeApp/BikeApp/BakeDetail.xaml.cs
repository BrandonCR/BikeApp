using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BakeDetail : ContentPage
    {
        public ObservableCollection<Bike> ListaGeneral1 = new ObservableCollection<Bike>();

        private List<Bike> bikes;

        public BakeDetail()
        {
            InitializeComponent();
        }

        public BakeDetail(List<Bike> bikes)
        {
            this.bikes = bikes;
            InitializeComponent();
            ListaGeneral1 = new ObservableCollection<Bike>();
            listadoDatos1.ItemsSource = ListaGeneral1;
            ListaGeneral1.Clear();
            for (int i = 0; i < bikes.Count; i++)
            {
                ListaGeneral1.Add(bikes[i]);
            }
            //ListaGeneral1.Add(bikes);
        }
    }
}
