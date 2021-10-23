using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace LunarCrush_Project
{
    public static class ConnexionClass
    {

        public static JObject Connexion(string URL, [Optional] string options, [Optional] string symbol)
        {
            var APIKey = "&key=06l2izqhxzk6gzhjdl1hmd";
            var parameters = APIKey + options + symbol;

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(URL + parameters).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                JObject data = (JObject)JsonConvert.DeserializeObject(dataObjects);
                client.Dispose();
                return data;
            }
            else
            {
                Trace.WriteLine((int)response.StatusCode + response.ReasonPhrase);
                return null;
            }
        }
    }
}