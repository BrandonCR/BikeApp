using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BikeApp
{
    public class ServicioRest
    {
        public async void Conectar()
        {
            // https://bikeindex.org/api/v3

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var llamada = await httpClient.GetAsync("https://bikeindex.org/api/v3/search").ConfigureAwait(false);

                    var BikeTest = new Bike() { title = "big nine 500" };
                    string parseo = JsonConvert.SerializeObject(BikeTest);
                    //await httpClient.PostAsync("/inventario", new StringContent(parseo, Encoding.UTF8, "application/json")).ConfigureAwait(false);

                    Debug.WriteLine(parseo);

                    if (llamada.IsSuccessStatusCode)
                    {
                        var json = await llamada.Content.ReadAsStringAsync().ConfigureAwait(false);

                        var resultado = JsonConvert.DeserializeObject<Bike[]>(json);
                        Debug.WriteLine(resultado[0].title);

                    }
                    //var resultado = await httpClient.GetAsync("/").ConfigureAwait(false);

                    //var codigo = resultado.StatusCode;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("El Error fue: " + ex);
            }

        }



        public async Task<List<Bike>> GetJson()
        {
            // https://bikeindex.org/api/v3

            try
            {

                using (var httpClient = new HttpClient())
                {
                    var llamada = await httpClient.GetAsync("https://bikeindex.org/api/v3/search").ConfigureAwait(false);

                    if (llamada.IsSuccessStatusCode)
                    {
                        var json = await llamada.Content.ReadAsStringAsync().ConfigureAwait(false);

                        var resultado = JsonConvert.DeserializeObject<RootObject>(json);
                        //var resultado = JsonConvert.DeserializeObject(json);
                        //List<Bike> Bikes = (List<Bike>)resultado;
                        //Debug.WriteLine(Bikes[0].title);
                        //Debug.WriteLine(resultado.bikes[0].title);
                        return resultado.bikes;
                    }
                    //var resultado = await httpClient.GetAsync("/").ConfigureAwait(false);

                    //var codigo = resultado.StatusCode;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("El Error fue: " + ex);
            }

            return new List<Bike>();

        }



        public async Task<List<Bike>> GetJson(string aux)
        {
            // https://bikeindex.org/api/v3

            try
            {

                using (var httpClient = new HttpClient())
                {
                    var llamada = await httpClient.GetAsync("https://bikeindex.org/api/v3/bikes/" + aux).ConfigureAwait(false);

                    if (llamada.IsSuccessStatusCode)
                    {
                        var json = await llamada.Content.ReadAsStringAsync().ConfigureAwait(false);

                        var resultado1 = JsonConvert.DeserializeObject<BikeDetail>(json);
                        var id = resultado1.id;
                        var resultado = JsonConvert.DeserializeObject<RootObject>(json);
                        //var resultado = JsonConvert.DeserializeObject<Bike[]>(json);

                        return resultado.bikes;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("El Error fue: " + ex);
            }

            return new List<Bike>();

        }
    }
}
