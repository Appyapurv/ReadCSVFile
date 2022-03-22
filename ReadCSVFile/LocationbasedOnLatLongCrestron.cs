using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReadCSVFile
{
    public class LocationbasedOnLatLongCrestron
    {
        public void Main(string[] args)
        {
            string Key = "aaaa75f33b714b2ab74d30bdc4169337";
            var lat = new List<string>();
            var longitute = new List<string>();
            using (var reader = new StreamReader(@"C:\Users\aupadhyay\Desktop\Device-Request-Details.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',', ';');

                    lat.Add(values[1]);
                    longitute.Add(values[2]);
                }
            }
            for (int i = 1; i < lat.Count; i++)
            {
                string query = $"https://api.opencagedata.com/geocode/v1/json?q={lat[i]}+{longitute[i]}&key={Key}";
                JObject jObject;
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.BaseAddress = new Uri(query);
                    var response = client.GetAsync(client.BaseAddress).Result;
                    var getObjectString = response.Content.ReadAsStringAsync().Result;
                    jObject = JsonConvert.DeserializeObject<JObject>(getObjectString);
                    var result = jObject["results"];
                    var item = result[0];
                    var components = item["components"].Value<object>();
                    var items = JsonConvert.DeserializeObject<Components>(components.ToString());
                    items.Countrycode = (string)item["components"]["ISO_3166-1_alpha-2"];
                }
            }

            // object ss =  GetApiResponse(query).Result;
        }

        private async Task<Object> GetApiResponse(string endpoint)
        {
            JObject jObject;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.BaseAddress = new Uri(endpoint);
                var response = await client.GetAsync(client.BaseAddress);
                var getObjectString = response.Content.ReadAsStringAsync().Result;
                jObject = JsonConvert.DeserializeObject<JObject>(getObjectString);
            }
            return jObject;
        }
    }

    public class Components
    {
        public string Countrycode { get; set; }
        public string ISO_31661_alpha3 { get; set; }
        public string _category { get; set; }
        public string _type { get; set; }
        public string city { get; set; }
        public string city_district { get; set; }
        public string continent { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string county { get; set; }
        public string neighbourhood { get; set; }
        public string postcode { get; set; }
        public string road { get; set; }
        public string road_type { get; set; }
        public string state { get; set; }
        public string state_code { get; set; }
        public string state_district { get; set; }
        public string suburb { get; set; }

    }
}