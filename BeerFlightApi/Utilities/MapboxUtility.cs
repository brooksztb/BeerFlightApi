using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BeerFlightApi.Utilities
{
    public class MapboxUtility
    {
        private static string apiKey = "pk.eyJ1IjoiYnJvb2tzenRiIiwiYSI6ImNqazFrb2d1ZTBpbzAzcHFsY3JqdThqdmUifQ.JeVbFdP5Fc_DZrT8PxPp1w";
        private static string mapboxApiUrl = "https://api.mapbox.com";

        public static async Task<IEnumerable<string>> GetAddress(string address, string country)
        {
            string formattedLocation = address.Replace(" ", "+");
            string type = "address";
            var result = await GetLocationResponse("mapbox.places", formattedLocation, country, type);

            return new string[] { result };
        }

        private static async Task<string> GetLocationResponse(string mode, string formattedLocation, string country, string type)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(string.Format("/geocoding/v5/{0}/{1}.json?access_token={2}&country={3}&type={4}", mode, mapboxApiUrl, formattedLocation, country, type));
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            var JSONObj = JsonConvert.DeserializeObject(result);
            return result;
        }
    }
}
