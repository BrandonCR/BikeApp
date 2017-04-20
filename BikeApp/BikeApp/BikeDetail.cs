using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeApp
{
    public class PublicImage
    {
        public string name { get; set; }
        public string full { get; set; }
        public string large { get; set; }
        public string medium { get; set; }
        public string thumb { get; set; }
    }

    public class BikeDetail
    {
        public int id { get; set; }
        public string title { get; set; }
        public string serial { get; set; }
        public string manufacturer_name { get; set; }
        public string frame_model { get; set; }
        public object year { get; set; }
        public List<string> frame_colors { get; set; }
        public string thumb { get; set; }
        public string large_img { get; set; }
        public bool is_stock_img { get; set; }
        public bool stolen { get; set; }
        public object stolen_location { get; set; }
        public object date_stolen { get; set; }
        public int registration_created_at { get; set; }
        public int registration_updated_at { get; set; }
        public string url { get; set; }
        public string api_url { get; set; }
        public int manufacturer_id { get; set; }
        public object paint_description { get; set; }
        public string name { get; set; }
        public string frame_size { get; set; }
        public string description { get; set; }
        public bool rear_tire_narrow { get; set; }
        public bool front_tire_narrow { get; set; }
        public string type_of_cycle { get; set; }
        public bool test_bike { get; set; }
        public int rear_wheel_size_iso_bsd { get; set; }
        public int front_wheel_size_iso_bsd { get; set; }
        public string handlebar_type_slug { get; set; }
        public string frame_material_slug { get; set; }
        public object front_gear_type_slug { get; set; }
        public object rear_gear_type_slug { get; set; }
        public object stolen_record { get; set; }
        public List<PublicImage> public_images { get; set; }
        public List<object> components { get; set; }
    }

    public class RootObject1
    {
        public BikeDetail bikeDetail { get; set; }
    }
}
