using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeApp
{
    public class Bike
    {
        public int id { get; set; }
        public string title { get; set; }
        public string serial { get; set; }
        public string manufacturer_name { get; set; }
        public string frame_model { get; set; }
        public int? year { get; set; }
        public List<string> frame_colors = new List<string>(); //{ get; set; }
        public string thumb { get; set; } = String.Empty;
        public string large_img { get; set; } = String.Empty;
        public bool is_stock_img { get; set; }
        public bool stolen { get; set; }
        public string stolen_location { get; set; }
        public long date_stolen { get; set; }
    }

    public class RootObject
    {
        public List<Bike> bikes { get; set; }
    }
}
